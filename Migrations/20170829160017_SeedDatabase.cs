using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Honda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Tesla')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('GM Motors')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('CRV',(SELECT ID FROM Makes WHERE Name = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('HRV',(SELECT ID FROM Makes WHERE Name = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Accord',(SELECT ID FROM Makes WHERE Name = 'Honda'))");


            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('RAV4',(SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('HighLender',(SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Corolla',(SELECT ID FROM Makes WHERE Name = 'Toyota'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Model X300',(SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Model X500',(SELECT ID FROM Makes WHERE Name = 'Tesla'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('Model X700',(SELECT ID FROM Makes WHERE Name = 'Tesla'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('S300',(SELECT ID FROM Makes WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('S500',(SELECT ID FROM Makes WHERE Name = 'BMW'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('S700',(SELECT ID FROM Makes WHERE Name = 'BMW'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('GM900',(SELECT ID FROM Makes WHERE Name = 'GM Motors'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('GM1900',(SELECT ID FROM Makes WHERE Name = 'GM Motors'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeId) VALUES ('GM3900',(SELECT ID FROM Makes WHERE Name = 'GM Motors'))");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
