using FluentMigrator;

namespace Optimal.Com.Web.Migrations
{
    [Migration(123)]
    public class TestMigrationUser : Migration
    {
        public override void Down()
        {
        }

        public override void Up()
        {
            Create.Table("User")
                .WithColumn("ID").AsInt32().Identity()
                .WithColumn("Name").AsString(50);
        }
    }
}
