using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessAssignment3.Migrations
{
    public partial class Structure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScreeningTicket");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScreeningID",
                table: "Tickets",
                column: "ScreeningID");

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
                name: "FK_Tickets_Screenings_ScreeningID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_ScreeningID",
                table: "Tickets");

            migrationBuilder.CreateTable(
                name: "ScreeningTicket",
                columns: table => new
                {
                    ScreeningsID = table.Column<int>(type: "int", nullable: false),
                    TicketsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningTicket", x => new { x.ScreeningsID, x.TicketsID });
                    table.ForeignKey(
                        name: "FK_ScreeningTicket_Screenings_ScreeningsID",
                        column: x => x.ScreeningsID,
                        principalTable: "Screenings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScreeningTicket_Tickets_TicketsID",
                        column: x => x.TicketsID,
                        principalTable: "Tickets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScreeningTicket_TicketsID",
                table: "ScreeningTicket",
                column: "TicketsID");
        }
    }
}
