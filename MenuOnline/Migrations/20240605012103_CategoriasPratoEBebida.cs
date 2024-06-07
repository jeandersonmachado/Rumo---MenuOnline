using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuOnline.Migrations
{
    public partial class CategoriasPratoEBebida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                 "VALUES('Prato','Prato feito com os melhores ingredientes')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                 "VALUES('Bebida','Bebida originais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELTE FROM categorias");
        }
    }
}
