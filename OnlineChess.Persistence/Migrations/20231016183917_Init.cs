using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineChess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Player1Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Player2Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Board_Player_Player1Id",
                        column: x => x.Player1Id,
                        principalTable: "Player",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Board_Player_Player2Id",
                        column: x => x.Player2Id,
                        principalTable: "Player",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PieceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BlockColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCoordinate = table.Column<long>(type: "bigint", nullable: false),
                    YCoordinate = table.Column<long>(type: "bigint", nullable: false),
                    BoardId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Block_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Piece",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PieceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PieceColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCoordinate = table.Column<long>(type: "bigint", nullable: false),
                    YCoordinate = table.Column<long>(type: "bigint", nullable: false),
                    HasMovedSinceStart = table.Column<bool>(type: "bit", nullable: false),
                    BlockId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Piece_Block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Block",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Block_BoardId",
                table: "Block",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Block_PieceId",
                table: "Block",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Player1Id",
                table: "Board",
                column: "Player1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Player2Id",
                table: "Board",
                column: "Player2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_BlockId",
                table: "Piece",
                column: "BlockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Block_Piece_PieceId",
                table: "Block",
                column: "PieceId",
                principalTable: "Piece",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Block_Board_BoardId",
                table: "Block");

            migrationBuilder.DropForeignKey(
                name: "FK_Block_Piece_PieceId",
                table: "Block");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Piece");

            migrationBuilder.DropTable(
                name: "Block");
        }
    }
}
