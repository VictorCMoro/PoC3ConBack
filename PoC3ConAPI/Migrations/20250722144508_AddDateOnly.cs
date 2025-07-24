using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoC3ConAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                -- Atualizar dados existentes para garantir compatibilidade
                UPDATE Clientes 
                SET DataNascimento = CAST(DataNascimento AS DATE)
                WHERE DataNascimento IS NOT NULL;
                
                -- Alterar o tipo da coluna
                ALTER TABLE Clientes 
                ALTER COLUMN DataNascimento DATE NOT NULL

                ALTER TABLE Pedidos 
                ALTER COLUMN DataPedido DATE NOT NULL;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER TABLE Clientes 
                ALTER COLUMN DataNascimento DATETIME2 NOT NULL

                ALTER TABLE Pedidos 
                ALTER COLUMN DataPedido DATETIME2 NOT NULL;
            ");
        }
    }
}