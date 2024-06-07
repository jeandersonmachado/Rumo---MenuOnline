using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuOnline.Migrations
{
    public partial class PratoEBebida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
                 "VALUES('1','Risotto','25.50','risotto preparado com arroz arbório')");

            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
"VALUES('1','Bife à Parmegianao','20.50','coberto com molho de tomate caseiro')");

            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
                 "VALUES('1','Salada com Frango Grelhado','18.00','Clássica salada Caesar com alface romana crocante')");


            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
                 "VALUES('2','Limonada Sicilianao','10.50','Refrescante limonada feita com limões sicilianos frescos')");

            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
                 "VALUES('2','Suco de Maracujá','8.50','Suco natural de maracujá')");

            migrationBuilder.Sql("INSERT INTO Pratos(CategoriaId,Nome,Preco,Descricao)" +
                 "VALUES('2','Chá Gelado','6.30','Delicioso chá de hibisco gelado')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
