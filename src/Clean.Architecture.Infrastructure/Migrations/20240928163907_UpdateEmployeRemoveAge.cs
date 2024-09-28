﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeInfoApp.Infrastructure.Migrations;

/// <inheritdoc />
public partial class UpdateEmployeRemoveAge : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Age",
            table: "Employees");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "Age",
            table: "Employees",
            type: "int",
            nullable: false,
            defaultValue: 0);
    }
}
