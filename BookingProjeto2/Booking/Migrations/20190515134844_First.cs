using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IDCliente = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 60, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Contacto = table.Column<string>(maxLength: 15, nullable: false),
                    Morada = table.Column<string>(maxLength: 100, nullable: false),
                    Localidade = table.Column<string>(maxLength: 70, nullable: false),
                    CodPostal = table.Column<string>(maxLength: 15, nullable: true),
                    CC = table.Column<string>(maxLength: 15, nullable: false),
                    DataNasc = table.Column<string>(maxLength: 10, nullable: false),
                    Imagem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IDCliente);
                });

            migrationBuilder.CreateTable(
                name: "Hoteis",
                columns: table => new
                {
                    IDHotel = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeHotel = table.Column<string>(maxLength: 80, nullable: false),
                    NumEstrelas = table.Column<string>(maxLength: 1, nullable: false),
                    Morada = table.Column<string>(maxLength: 60, nullable: false),
                    Localidade = table.Column<string>(maxLength: 60, nullable: false),
                    CodPostal = table.Column<string>(maxLength: 15, nullable: false),
                    Pais = table.Column<string>(maxLength: 50, nullable: false),
                    QuantidadeQuartos = table.Column<short>(nullable: false),
                    Descricao = table.Column<string>(type: "ntext", nullable: false),
                    Imagem = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hoteis", x => x.IDHotel);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamento",
                columns: table => new
                {
                    IDTipoPagamento = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Designacao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamento", x => x.IDTipoPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Utilizador = table.Column<string>(maxLength: 150, nullable: false),
                    Pass = table.Column<string>(maxLength: 50, nullable: false),
                    TipoUtilizador = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Utilizador);
                });

            migrationBuilder.CreateTable(
                name: "Regimes",
                columns: table => new
                {
                    IDRegime = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDHotel = table.Column<long>(nullable: false),
                    TipoRegime = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regimes", x => x.IDRegime);
                    table.ForeignKey(
                        name: "FK_Regimes_Hoteis",
                        column: x => x.IDHotel,
                        principalTable: "Hoteis",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicosHotel",
                columns: table => new
                {
                    IDServicos = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDHotel = table.Column<long>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosHotel", x => x.IDServicos);
                    table.ForeignKey(
                        name: "FK_ServicosHotel_Hoteis",
                        column: x => x.IDHotel,
                        principalTable: "Hoteis",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoQuarto",
                columns: table => new
                {
                    IDTipoQuarto = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDHotel = table.Column<long>(nullable: false),
                    Capacidade = table.Column<byte>(nullable: false),
                    Inventario = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false),
                    Imagem = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoQuarto", x => x.IDTipoQuarto);
                    table.ForeignKey(
                        name: "FK_TipoQuarto_Hoteis",
                        column: x => x.IDHotel,
                        principalTable: "Hoteis",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    CodPagamento = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDTipoPagamento = table.Column<short>(nullable: false),
                    NomeTitular = table.Column<string>(maxLength: 120, nullable: false),
                    NumCartao = table.Column<string>(maxLength: 20, nullable: false),
                    DataValidadeCartao = table.Column<string>(maxLength: 10, nullable: false),
                    CVV = table.Column<string>(maxLength: 5, nullable: true),
                    Descricao = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.CodPagamento);
                    table.ForeignKey(
                        name: "FK_Pagamento_TipoPagamento",
                        column: x => x.IDTipoPagamento,
                        principalTable: "TipoPagamento",
                        principalColumn: "IDTipoPagamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EspecificacoesQuarto",
                columns: table => new
                {
                    IDEspecificacao = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDTipoQuarto = table.Column<long>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecificacoesQuarto", x => x.IDEspecificacao);
                    table.ForeignKey(
                        name: "FK_EspecificacoesQuarto_TipoQuarto",
                        column: x => x.IDTipoQuarto,
                        principalTable: "TipoQuarto",
                        principalColumn: "IDTipoQuarto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Precario",
                columns: table => new
                {
                    IDRegime = table.Column<byte>(nullable: false),
                    IDTipoQuarto = table.Column<long>(nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(6, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Precario", x => new { x.IDRegime, x.IDTipoQuarto });
                    table.ForeignKey(
                        name: "FK_Precario_Regimes",
                        column: x => x.IDRegime,
                        principalTable: "Regimes",
                        principalColumn: "IDRegime",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Precario_TipoQuarto",
                        column: x => x.IDTipoQuarto,
                        principalTable: "TipoQuarto",
                        principalColumn: "IDTipoQuarto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    IDReserva = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDHotel = table.Column<long>(nullable: false),
                    IDCliente = table.Column<long>(nullable: false),
                    IDRegime = table.Column<byte>(nullable: false),
                    IDTipoQuarto = table.Column<long>(nullable: false),
                    CodPagamento = table.Column<long>(nullable: false),
                    QuantAdultos = table.Column<short>(nullable: false),
                    QuantCriancas = table.Column<short>(nullable: false),
                    CheckIn = table.Column<DateTime>(type: "date", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.IDReserva);
                    table.ForeignKey(
                        name: "FK_Reservas_Pagamento",
                        column: x => x.CodPagamento,
                        principalTable: "Pagamento",
                        principalColumn: "CodPagamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes",
                        column: x => x.IDCliente,
                        principalTable: "Clientes",
                        principalColumn: "IDCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Hoteis",
                        column: x => x.IDHotel,
                        principalTable: "Hoteis",
                        principalColumn: "IDHotel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Regimes",
                        column: x => x.IDRegime,
                        principalTable: "Regimes",
                        principalColumn: "IDRegime",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_TipoQuarto",
                        column: x => x.IDTipoQuarto,
                        principalTable: "TipoQuarto",
                        principalColumn: "IDTipoQuarto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecificacoesQuarto_IDTipoQuarto",
                table: "EspecificacoesQuarto",
                column: "IDTipoQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_IDTipoPagamento",
                table: "Pagamento",
                column: "IDTipoPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Precario_IDTipoQuarto",
                table: "Precario",
                column: "IDTipoQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_Regimes_IDHotel",
                table: "Regimes",
                column: "IDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CodPagamento",
                table: "Reservas",
                column: "CodPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IDCliente",
                table: "Reservas",
                column: "IDCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IDHotel",
                table: "Reservas",
                column: "IDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IDRegime",
                table: "Reservas",
                column: "IDRegime");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_IDTipoQuarto",
                table: "Reservas",
                column: "IDTipoQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_ServicosHotel_IDHotel",
                table: "ServicosHotel",
                column: "IDHotel");

            migrationBuilder.CreateIndex(
                name: "IX_TipoQuarto_IDHotel",
                table: "TipoQuarto",
                column: "IDHotel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EspecificacoesQuarto");

            migrationBuilder.DropTable(
                name: "Precario");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "ServicosHotel");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Regimes");

            migrationBuilder.DropTable(
                name: "TipoQuarto");

            migrationBuilder.DropTable(
                name: "TipoPagamento");

            migrationBuilder.DropTable(
                name: "Hoteis");
        }
    }
}
