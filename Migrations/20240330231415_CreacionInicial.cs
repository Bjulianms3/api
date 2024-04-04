using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.PeliculaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriaPelicula",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    PeliculasPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPelicula", x => new { x.CategoriasCategoriaId, x.PeliculasPeliculaId });
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Pelicula_PeliculasPeliculaId",
                        column: x => x.PeliculasPeliculaId,
                        principalTable: "Pelicula",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Accion", true },
                    { 2, "Aventura", true },
                    { 3, "Animacion", true },
                    { 4, "Ciencia ficcion", true },
                    { 5, "Comedia", true },
                    { 6, "Crimen", true },
                    { 7, "Documental", true },
                    { 8, "Drama", true },
                    { 9, "Familiar", true },
                    { 10, "Fantasia", true },
                    { 11, "Historia", true },
                    { 12, "Horror", true },
                    { 13, "Musica", true },
                    { 14, "Misterio", true },
                    { 15, "Romance", true }
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "PeliculaId", "Anio", "Poster", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 1994, "N/A", "El banquero andy dufrense es arrestado por matar a su esposa", "Sueño de fuga" },
                    { 2, 1972, "N/A", "El patriarca de una organizacion criminal transfiere el cont", "El padrino" },
                    { 3, 2008, "N/A", "cunado el joker emerge causando caos y violencia en", "El caballero oscuro" },
                    { 4, 2003, "N/A", "Gandalf y aragon lideran el mundo de los hombre,", "El retorno del rey" },
                    { 5, 1974, "N/A", "Las vidas de dos mafiosos, un boxeador, la esposa de", "Tiempos violentos" },
                    { 6, 1994, "N/A", "Las predecidenciales de kennedy y Jonhson, los eventos de viet", "Forest Gump" },
                    { 7, 1999, "N/A", "Un hombre deprimido conoce a un fabricante de jabon", "El club de la pelea" },
                    { 8, 2010, "N/A", "A un ladron que roba secretos corporativos a traves de la tec", "Inception" },
                    { 9, 1970, "N/A", "Los rebeldes han vencido", "Star wars" },
                    { 10, 1999, "N/A", "Un hacker se da cuenta por medio de otros rebeldes de la natiraleza", "Matrix" },
                    { 11, 2014, "N/A", "Un grupo de exploradores prueban los saltos a traves de", "Interestelar" },
                    { 12, 2024, "N/A", "paul atreides se une a chani u los fremen mientras", "Dune: parte dos" },
                    { 13, 1991, "N/A", "Un cyborg, identico al que fracaso", "Terminator 2" },
                    { 14, 1985, "N/A", "Marty Mcfly, un estudiante de 17 años, es enviado", "Volver al futuro" },
                    { 15, 2023, "N/A", "Vivir en Barbie land es ser perfecto en un lugar perfecto", "Barbie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPelicula_PeliculasPeliculaId",
                table: "CategoriaPelicula",
                column: "PeliculasPeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaPelicula");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pelicula");
        }
    }
}
