using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessAssignment3.Migrations
{
    public partial class NonNullables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Cinemas_CinemaID",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieID",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Screenings_ScreeningID",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Screenings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CinemaID",
                table: "Screenings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Cinemas_CinemaID",
                table: "Screenings",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieID",
                table: "Screenings",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Screenings_ScreeningID",
                table: "Tickets",
                column: "ScreeningID",
                principalTable: "Screenings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Cinemas_CinemaID",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Movies_MovieID",
                table: "Screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Screenings_ScreeningID",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "ScreeningID",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "Screenings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaID",
                table: "Screenings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Cinemas_CinemaID",
                table: "Screenings",
                column: "CinemaID",
                principalTable: "Cinemas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Movies_MovieID",
                table: "Screenings",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Screenings_ScreeningID",
                table: "Tickets",
                column: "ScreeningID",
                principalTable: "Screenings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
