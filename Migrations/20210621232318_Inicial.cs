using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_Detalle2_Ap2.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SuplidorID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.OrdenID);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    Existencia = table.Column<double>(type: "REAL", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValorInventario = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Suplidores",
                columns: table => new
                {
                    SuplidorID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suplidores", x => x.SuplidorID);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesDetalle",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrdenID = table.Column<int>(type: "INTEGER", nullable: false),
                    Suplidor = table.Column<string>(type: "TEXT", nullable: true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Costo = table.Column<decimal>(type: "TEXT", nullable: false),
                    SuplidorID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesDetalle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrdenesDetalle_Ordenes_OrdenID",
                        column: x => x.OrdenID,
                        principalTable: "Ordenes",
                        principalColumn: "OrdenID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenesDetalle_Suplidores_SuplidorID",
                        column: x => x.SuplidorID,
                        principalTable: "Suplidores",
                        principalColumn: "SuplidorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Concepto", "Costo", "Existencia", "ValorInventario" },
                values: new object[] { 1, "Arroz", 22m, 0.0, 10m });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Concepto", "Costo", "Existencia", "ValorInventario" },
                values: new object[] { 2, "Azucar", 50m, 0.0, 6m });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Concepto", "Costo", "Existencia", "ValorInventario" },
                values: new object[] { 3, "Chocolate", 25m, 0.0, 20m });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorID", "Nombres", "ProductoId" },
                values: new object[] { 1, "Ramon", 0 });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorID", "Nombres", "ProductoId" },
                values: new object[] { 2, "Pablo", 0 });

            migrationBuilder.InsertData(
                table: "Suplidores",
                columns: new[] { "SuplidorID", "Nombres", "ProductoId" },
                values: new object[] { 3, "Cristian", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDetalle_OrdenID",
                table: "OrdenesDetalle",
                column: "OrdenID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDetalle_SuplidorID",
                table: "OrdenesDetalle",
                column: "SuplidorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenesDetalle");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Suplidores");
        }
    }
}
