using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPTransporteBack.Infrastruture.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Casetas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Convenio = table.Column<bool>(type: "bit", nullable: false),
                    Tramo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TasaIVA = table.Column<double>(type: "float", nullable: false),
                    Proveedor = table.Column<int>(type: "int", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCotizador = table.Column<int>(type: "int", nullable: false),
                    De1A3 = table.Column<double>(type: "float", nullable: false),
                    De2A2 = table.Column<double>(type: "float", nullable: false),
                    De2A3 = table.Column<double>(type: "float", nullable: false),
                    De2A4 = table.Column<double>(type: "float", nullable: false),
                    De2A5 = table.Column<double>(type: "float", nullable: false),
                    De2A6 = table.Column<double>(type: "float", nullable: false),
                    De2A9 = table.Column<double>(type: "float", nullable: false),
                    De3A3 = table.Column<double>(type: "float", nullable: false),
                    De3A4 = table.Column<double>(type: "float", nullable: false),
                    De3A5 = table.Column<double>(type: "float", nullable: false),
                    De3A6 = table.Column<double>(type: "float", nullable: false),
                    De3A7 = table.Column<double>(type: "float", nullable: false),
                    De3A9 = table.Column<double>(type: "float", nullable: false),
                    De3A12 = table.Column<double>(type: "float", nullable: false),
                    De4A6 = table.Column<double>(type: "float", nullable: false),
                    De5A6 = table.Column<double>(type: "float", nullable: false),
                    De5A7 = table.Column<double>(type: "float", nullable: false),
                    De5A9 = table.Column<double>(type: "float", nullable: false),
                    De6A6 = table.Column<double>(type: "float", nullable: false),
                    De6A7 = table.Column<double>(type: "float", nullable: false),
                    De6A8 = table.Column<double>(type: "float", nullable: false),
                    De6A9 = table.Column<double>(type: "float", nullable: false),
                    De7A9 = table.Column<double>(type: "float", nullable: false),
                    De8A9 = table.Column<double>(type: "float", nullable: false),
                    De9A9 = table.Column<double>(type: "float", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casetas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentosEntrega",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentosEntrega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Embalajes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leyenda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveUnidadMedidaSAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveEmbalajeSAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionEmbalajeSAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embalajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstatusContenedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstatusContenedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gasolineras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoExterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoValle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contabiliza = table.Column<bool>(type: "bit", nullable: false),
                    ContabilizaCargoOperador = table.Column<bool>(type: "bit", nullable: false),
                    TasaIVA = table.Column<double>(type: "float", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Proveedor = table.Column<int>(type: "int", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasolineras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Terminal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Grupo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autorizada = table.Column<bool>(type: "bit", nullable: false),
                    CodigoOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalidadOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalidadDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TramoFederal = table.Column<bool>(type: "bit", nullable: false),
                    TramoPatio = table.Column<bool>(type: "bit", nullable: false),
                    DistanciaKilometros = table.Column<double>(type: "float", nullable: false),
                    TiempoNormal1OP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoFull1OP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoNormal2OP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoFull2OP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RendimientoSenc = table.Column<double>(type: "float", nullable: false),
                    RendiemientoFull = table.Column<double>(type: "float", nullable: false),
                    EsRutaCritica = table.Column<bool>(type: "bit", nullable: false),
                    KilometrosRutaCritica = table.Column<double>(type: "float", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCarga",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Estatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveSAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clasificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoMaterialPeligroso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presentacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FraccionArancelaria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCarga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContenedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<int>(type: "int", nullable: false),
                    Abreviado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContenedores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casetas");

            migrationBuilder.DropTable(
                name: "DocumentosEntrega");

            migrationBuilder.DropTable(
                name: "Embalajes");

            migrationBuilder.DropTable(
                name: "EstatusContenedores");

            migrationBuilder.DropTable(
                name: "Gasolineras");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "TipoCarga");

            migrationBuilder.DropTable(
                name: "TipoContenedores");
        }
    }
}
