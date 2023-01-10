using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleTrader.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class assetrtansaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShareAmmount",
                table: "AssetTransactions",
                newName: "Shares");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateProcessed",
                table: "AssetTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateProcessed",
                table: "AssetTransactions");

            migrationBuilder.RenameColumn(
                name: "Shares",
                table: "AssetTransactions",
                newName: "ShareAmmount");
        }
    }
}
