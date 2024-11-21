using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp3.Migrations
{
    /// <inheritdoc />
    public partial class transicaoSolucaotransferenciaProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permissaoEnviarPara",
                columns: table => new
                {
                    EnviarParaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoEnviarPara", x => x.EnviarParaID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoFormaEnvios",
                columns: table => new
                {
                    FormaEnvioRmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoFormaEnvios", x => x.FormaEnvioRmID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoTipos",
                columns: table => new
                {
                    TipoEmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoTipos", x => x.TipoEmailID);
                });

            migrationBuilder.CreateTable(
                name: "permissaoClientes",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permitido = table.Column<bool>(type: "bit", nullable: false),
                    TipoEmailID1 = table.Column<int>(type: "int", nullable: false),
                    EnviarParaID1 = table.Column<int>(type: "int", nullable: false),
                    FormaEnvioRmID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissaoClientes", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_permissaoClientes_permissaoEnviarPara_EnviarParaID1",
                        column: x => x.EnviarParaID1,
                        principalTable: "permissaoEnviarPara",
                        principalColumn: "EnviarParaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_permissaoClientes_permissaoFormaEnvios_FormaEnvioRmID1",
                        column: x => x.FormaEnvioRmID1,
                        principalTable: "permissaoFormaEnvios",
                        principalColumn: "FormaEnvioRmID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_permissaoClientes_permissaoTipos_TipoEmailID1",
                        column: x => x.TipoEmailID1,
                        principalTable: "permissaoTipos",
                        principalColumn: "TipoEmailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_EnviarParaID1",
                table: "permissaoClientes",
                column: "EnviarParaID1");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_FormaEnvioRmID1",
                table: "permissaoClientes",
                column: "FormaEnvioRmID1");

            migrationBuilder.CreateIndex(
                name: "IX_permissaoClientes_TipoEmailID1",
                table: "permissaoClientes",
                column: "TipoEmailID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permissaoClientes");

            migrationBuilder.DropTable(
                name: "permissaoEnviarPara");

            migrationBuilder.DropTable(
                name: "permissaoFormaEnvios");

            migrationBuilder.DropTable(
                name: "permissaoTipos");
        }
    }
}
