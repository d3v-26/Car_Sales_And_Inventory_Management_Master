using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Sales_And_Inventory_Management_Master.Data.Migrations
{
    public partial class Car1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    dimesion_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    height = table.Column<float>(type: "real", nullable: false),
                    width = table.Column<float>(type: "real", nullable: false),
                    length = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.dimesion_id);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    engineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    performance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    efficiency = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.engineId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imageId);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    specification_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    average = table.Column<float>(type: "real", nullable: false),
                    max_speed = table.Column<float>(type: "real", nullable: false),
                    price = table.Column<long>(type: "bigint", nullable: false),
                    dimensionsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    no_of_seats = table.Column<int>(type: "int", nullable: false),
                    free_space = table.Column<int>(type: "int", nullable: false),
                    engineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    airbags = table.Column<int>(type: "int", nullable: false),
                    fuel_Consumption_Type = table.Column<int>(type: "int", nullable: false),
                    additional_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.specification_id);
                    table.ForeignKey(
                        name: "FK_Specifications_Dimensions_dimensionsId",
                        column: x => x.dimensionsId,
                        principalTable: "Dimensions",
                        principalColumn: "dimesion_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specifications_Engines_engineId",
                        column: x => x.engineId,
                        principalTable: "Engines",
                        principalColumn: "engineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    car_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    launch_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    no_of_images = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<float>(type: "real", nullable: false),
                    specificationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    imageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.car_id);
                    table.ForeignKey(
                        name: "FK_Cars_Images_imageId",
                        column: x => x.imageId,
                        principalTable: "Images",
                        principalColumn: "imageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Specifications_specificationId",
                        column: x => x.specificationId,
                        principalTable: "Specifications",
                        principalColumn: "specification_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_imageId",
                table: "Cars",
                column: "imageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_specificationId",
                table: "Cars",
                column: "specificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_dimensionsId",
                table: "Specifications",
                column: "dimensionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Specifications_engineId",
                table: "Specifications",
                column: "engineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Engines");
        }
    }
}
