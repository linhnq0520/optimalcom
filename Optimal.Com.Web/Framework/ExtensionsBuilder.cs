using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace Optimal.Com.Web.Framework
{
    public static class ExtensionsBuilder
    {
        public static PropertyBuilder<string> AsString(this PropertyBuilder<string> propertyBuilder, int maxLength)
        {
            propertyBuilder.HasColumnType($"nvarchar({maxLength})");
            return propertyBuilder;
        }
    }
    public static class MigrationBuilderExtensions
    {
        public static void InsertData<TEntity>(this MigrationBuilder migrationBuilder, List<TEntity> data)
            where TEntity : BaseEntity
        {
            var entityType = GetEntityType<TEntity>(migrationBuilder);
            var tableName = entityType.GetTableName();
            var columnNames = entityType.GetProperties().Where(p => !p.IsKey()).Select(p => p.GetColumnName()).ToArray();

            migrationBuilder.InsertData(
                table: tableName,
                columns: columnNames,
                values: data.Select(item => columnNames.Select(colName => GetColumnValue(item, colName)).ToArray()).ToArray()
            );
        }

        private static IModel? GetModel(MigrationBuilder migrationBuilder)
        {
            var property = migrationBuilder.GetType().GetProperty("ActiveModel", BindingFlags.NonPublic | BindingFlags.Instance);
            return (IModel)property.GetValue(migrationBuilder);
        }

        private static IEntityType? GetEntityType<TEntity>(MigrationBuilder migrationBuilder)
        {
            var model = GetModel(migrationBuilder);
            return model.FindEntityType(typeof(TEntity));
        }

        private static object? GetColumnValue(object item, string columnName)
        {
            var property = item.GetType().GetProperty(columnName);
            return property.GetValue(item);
        }
        public static ModelBuilder ApplyAllConfigurationsFromCurrentAssembly(this ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.GetInterfaces().Any(interfaceType =>
                    interfaceType.IsGenericType &&
                    interfaceType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
                .ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }

            return modelBuilder;
        }
    }
}
