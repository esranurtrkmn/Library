using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_DataAccess.Migrations
{
    public partial class AddCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Roman')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Öykü')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Şiir')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Psikoloji')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Felsefe')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
