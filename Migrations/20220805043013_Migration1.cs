using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProyecto1.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SitioWeb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Efec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombrePaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorreoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultadosEfectosAdversos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConservaSintomas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alergias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripAlergias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NuevasEnfermedades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtrasCondiciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cancer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sintomas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inyec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreInyec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAplicacion1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaAplicacion2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVencimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LugarAplicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TuvoCovid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sospecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CovidPostInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RazonDeInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstabaEmbarazada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reacciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionesReacciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicamentos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeidcamentosPostInyeccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inyec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Med",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    NombreComp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Med", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaPaciente = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumContacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distrito = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pac", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clinic");

            migrationBuilder.DropTable(
                name: "Efec");

            migrationBuilder.DropTable(
                name: "Inyec");

            migrationBuilder.DropTable(
                name: "Med");

            migrationBuilder.DropTable(
                name: "Pac");
        }
    }
}
