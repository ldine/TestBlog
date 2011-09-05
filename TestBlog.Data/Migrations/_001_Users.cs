using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator;
using System.Data;

namespace TestBlog.Data.Migrations
{
    [Migration(1)]
    public class _001_Users : Migration
    {
        public override void Up()
        {
            Create.Table("Users")
                .WithColumn("User_Id").AsInt32().NotNullable().PrimaryKey()
                .WithColumn("Username").AsString(100)
                .WithColumn("Password").AsString(100);
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}
