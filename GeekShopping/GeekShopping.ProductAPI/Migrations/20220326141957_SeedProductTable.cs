using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { new Guid("0b37575e-68f4-4ca7-b490-979f6f829fd4"), "T-shirt", "Camisa social P", "https://th.bing.com/th/id/R.2a89878829d77f092f240129da8b185b?rik=3eK%2b3Ekb18pHjA&pid=ImgRaw&r=0", "Camisa Social", 69.90m },
                    { new Guid("5aebe930-e94a-4190-a064-cf12ce470f26"), "T-shirt", "Camisa feminina manga longa", "https://th.bing.com/th/id/R.1db75a836a6023f811d21452a8cb93db?rik=SJW8sBtMBBREeg&riu=http%3a%2f%2fmaxdicas.com%2fwp-content%2fuploads%2f2016%2f07%2fcamisa-feminina-xadrez-da-moda.jpg&ehk=yz1Tn4oClJNlMtbf3YkrplbHFJTDhfoLgP9iwXo4m84%3d&risl=&pid=ImgRaw&r=0", "Camisa Social Feminina", 80.90m },
                    { new Guid("877a28c3-f665-4648-b9cb-fd8107054ce4"), "T-shirt", "Camisa adidas M", "https://th.bing.com/th/id/OIP.8gSxyAC3iGCbLdA726Y2TAHaHa?pid=ImgDet&rs=1", "Camisa Adidas", 35.90m },
                    { new Guid("aad1b00c-c23e-40fe-aecd-e0244cfd24a4"), "T-shirt", "Camisa do vasco", "https://th.bing.com/th/id/R.222559365766c1c20d5a484703a08de1?rik=NAt9lgVgbDm1UQ&pid=ImgRaw&r=0", "Camisa Time", 150.90m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: new Guid("0b37575e-68f4-4ca7-b490-979f6f829fd4"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: new Guid("5aebe930-e94a-4190-a064-cf12ce470f26"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: new Guid("877a28c3-f665-4648-b9cb-fd8107054ce4"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: new Guid("aad1b00c-c23e-40fe-aecd-e0244cfd24a4"));
        }
    }
}
