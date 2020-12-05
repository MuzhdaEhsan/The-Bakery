using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryWebsite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    clientsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderID = table.Column<int>(nullable: false),
                    clName = table.Column<string>(nullable: true),
                    clLastName = table.Column<string>(nullable: true),
                    clPhone = table.Column<string>(nullable: true),
                    clEmail = table.Column<string>(nullable: true),
                    clStreet = table.Column<string>(nullable: true),
                    clCity = table.Column<string>(nullable: true),
                    clPostalcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.clientsID);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ordersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(nullable: false),
                    ordQuantity = table.Column<string>(nullable: true),
                    ordDate = table.Column<string>(nullable: true),
                    ordDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ordersID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prdName = table.Column<string>(nullable: true),
                    prdPrice = table.Column<int>(nullable: false),
                    prdDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
