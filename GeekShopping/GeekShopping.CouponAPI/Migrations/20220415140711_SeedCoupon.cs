using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.CouponAPI.Migrations
{
    public partial class SeedCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { new Guid("1100c67e-b6f2-4d31-8f65-2f5c819d1930"), "EDU_10", 10m });

            migrationBuilder.InsertData(
                table: "coupon",
                columns: new[] { "id", "coupon_code", "discount_amount" },
                values: new object[] { new Guid("4269b36e-32c4-4274-b85c-c46edcef7020"), "EDU_20", 20m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: new Guid("1100c67e-b6f2-4d31-8f65-2f5c819d1930"));

            migrationBuilder.DeleteData(
                table: "coupon",
                keyColumn: "id",
                keyValue: new Guid("4269b36e-32c4-4274-b85c-c46edcef7020"));
        }
    }
}
