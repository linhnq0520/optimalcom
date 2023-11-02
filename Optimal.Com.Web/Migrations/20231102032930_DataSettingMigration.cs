using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Optimal.Com.Web.Migrations
{
    /// <inheritdoc />
    public partial class DataSettingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Name", "Value" },
                values: new object[] { "AuthSetting.SecretKey", "uevfqmvekswfzycptlhuhsazjzancgvz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Name",
                keyValue: "AuthSetting.SecretKey");
        }
    }
}
