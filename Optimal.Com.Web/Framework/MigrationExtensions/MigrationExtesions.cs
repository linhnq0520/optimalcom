
using FluentMigrator.Builders.Alter.Table;
using FluentMigrator.Builders.Create;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Expressions;
using FluentMigrator.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using Optimal.Com.Web.Framework.Commons;
using Optimal.Com.Web.Framework.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Optimal.Com.Web.Framework.MigrationExtensions
{
    public static class FluentMigratorExtensions
    {
        private const int DATE_TIME_PRECISION = 6;

        private static Dictionary<Type, Action<ICreateTableColumnAsTypeSyntax>> TypeMapping { get; } = new Dictionary<Type, Action<ICreateTableColumnAsTypeSyntax>>
        {
            [typeof(int)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsInt32();
            },
            [typeof(long)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsInt64();
            },
            [typeof(string)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsString(int.MaxValue).Nullable();
            },
            [typeof(bool)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsBoolean();
            },
            [typeof(decimal)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsDecimal(18, 8);
            },
            [typeof(DateTime)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsDateTime2();
            },
            [typeof(byte[])] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsBinary(int.MaxValue);
            },
            [typeof(Guid)] = delegate (ICreateTableColumnAsTypeSyntax c)
            {
                c.AsGuid();
            }
        };


        private static void DefineByOwnType(string columnName, Type propType, CreateTableExpressionBuilder create, bool canBeNullable = false)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentNullException("The column name cannot be empty");
            }

            if (propType == typeof(string) || propType.FindInterfaces((Type t, object? o) => t.FullName?.Equals(o!.ToString(), StringComparison.InvariantCultureIgnoreCase) ?? false, "System.Collections.IEnumerable").Length != 0)
            {
                canBeNullable = true;
            }

            ICreateTableColumnAsTypeSyntax obj = create.WithColumn(columnName);
            TypeMapping[propType](obj);
            if (propType == typeof(DateTime))
            {
                create.CurrentColumn.Precision = 6;
            }

            if (canBeNullable)
            {
                create.Nullable();
            }
        }

        //public static ICreateTableColumnOptionOrForeignKeyCascadeOrWithColumnSyntax ForeignKey<TPrimary>(this ICreateTableColumnOptionOrWithColumnSyntax column, string primaryTableName = null, string primaryColumnName = null, Rule onDelete = Rule.Cascade) where TPrimary : BaseEntity
        //{
        //    if (string.IsNullOrEmpty(primaryTableName))
        //    {
        //        primaryTableName = NameCompatibilityManager.GetTableName(typeof(TPrimary));
        //    }

        //    if (string.IsNullOrEmpty(primaryColumnName))
        //    {
        //        primaryColumnName = "Id";
        //    }

        //    return column.Indexed().ForeignKey(primaryTableName, primaryColumnName).OnDelete(onDelete);
        //}

        //public static IAlterTableColumnOptionOrAddColumnOrAlterColumnOrForeignKeyCascadeSyntax ForeignKey<TPrimary>(this IAlterTableColumnOptionOrAddColumnOrAlterColumnSyntax column, string primaryTableName = null, string primaryColumnName = null, Rule onDelete = Rule.Cascade) where TPrimary : BaseEntity
        //{
        //    if (string.IsNullOrEmpty(primaryTableName))
        //    {
        //        primaryTableName = NameCompatibilityManager.GetTableName(typeof(TPrimary));
        //    }

        //    if (string.IsNullOrEmpty(primaryColumnName))
        //    {
        //        primaryColumnName = "Id";
        //    }

        //    return column.Indexed().ForeignKey(primaryTableName, primaryColumnName).OnDelete(onDelete);
        //}

        public static void TableFor<TEntity>(this ICreateExpressionRoot expressionRoot) where TEntity : BaseEntity
        {
            
        }


        public static (Type propType, bool canBeNullable) GetTypeToMap(this Type type)
        {
            Type underlyingType = Nullable.GetUnderlyingType(type);
            if ((object)underlyingType != null)
            {
                return (underlyingType, true);
            }

            return (type, false);
        }
    }
}
