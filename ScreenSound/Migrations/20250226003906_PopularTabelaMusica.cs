using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Trem das 11", 1997 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Princesa", 2009 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Emoções", 2000 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musica");
        }
    }
}
