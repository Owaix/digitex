using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreSM.Migrations
{
    public partial class asssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    CNIC = table.Column<string>(nullable: true),
                    TaxPayerType = table.Column<string>(nullable: true),
                    SaleType = table.Column<string>(nullable: true),
                    SaleCategoryID = table.Column<int>(nullable: false),
                    TaxRate = table.Column<decimal>(nullable: false),
                    TaxWithheld = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    isCreated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
