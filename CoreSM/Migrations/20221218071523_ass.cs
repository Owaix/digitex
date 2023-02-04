using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreSM.Migrations
{
    public partial class ass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.CreateTable(
                name: "SalesCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    PayerType = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    TaxRate = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesCategory", x => x.ID);
                });

       
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.DropTable(
                name: "SalesCategory");

          
        }
    }
}
