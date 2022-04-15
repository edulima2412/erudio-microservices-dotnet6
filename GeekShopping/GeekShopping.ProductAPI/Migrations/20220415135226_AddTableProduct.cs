using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class AddTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "product",
                newName: "id");

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { new Guid("18661af9-5265-44dc-9494-25af9f860f78"), "T-shirt", "Camisa do star wars", "4_storm_tropper.jpg", "Camisa Star Wars", 150.90m },
                    { new Guid("34154b02-b59c-4004-973d-b900e453e70f"), "Caneca", "Linda caneca do mario", "1_super_mario.jpg", "Caneca Mario", 15.90m },
                    { new Guid("37da0635-2b87-4909-8744-faccb6ae015b"), "T-shirt", "Camisa spaceX M", "6_spacex.jpg", "Camisa SpaceX", 35.90m },
                    { new Guid("b1d7752e-07ad-45df-9d88-072a04c0be6c"), "T-shirt", "Camisa do dragon ball G", "13_dragon_ball.jpg", "Camisa Dragon Ball", 55.90m },
                    { new Guid("d460cf81-cb95-4726-ad5d-4152e587e7c2"), "Brinquedo", "Nave millenium falcon do star wars", "10_milennium_falcon.jpg", "Nave Millenium Falcon", 1500m },
                    { new Guid("e7ea6905-ca4a-4aa6-a03f-b65873aed73c"), "T-shirt", "Camisa social P", "2_no_internet.jpg", "Camisa Jurassic Park", 69.90m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("18661af9-5265-44dc-9494-25af9f860f78"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("34154b02-b59c-4004-973d-b900e453e70f"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("37da0635-2b87-4909-8744-faccb6ae015b"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("b1d7752e-07ad-45df-9d88-072a04c0be6c"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("d460cf81-cb95-4726-ad5d-4152e587e7c2"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("e7ea6905-ca4a-4aa6-a03f-b65873aed73c"));

            migrationBuilder.RenameColumn(
                name: "id",
                table: "product",
                newName: "Id");
        }
    }
}
