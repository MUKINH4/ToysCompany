﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToysCompany.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TDS_TB_Brinquedos",
                columns: table => new
                {
                    Id_Brinquedo = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome_brinquedo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Tipo_brinquedo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Classificacao = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Tamanho = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Preco = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDS_TB_Brinquedos", x => x.Id_Brinquedo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TDS_TB_Brinquedos");
        }
    }
}
