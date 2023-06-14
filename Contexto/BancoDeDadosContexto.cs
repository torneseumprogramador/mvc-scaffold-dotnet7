using Microsoft.EntityFrameworkCore;
using scaffold.Models;

namespace entity.Contexto;

public class BancoDeDadosContexto : DbContext
{
    // estratégia 3, passando a dependencia do banco de dados via construtor
    public BancoDeDadosContexto(DbContextOptions<BancoDeDadosContexto> options) : base(options)
    {
    }

    public BancoDeDadosContexto() { }

    // estratégia 1 = vc pode criar a instancia de onde estiver do seu contexto
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseMySql(configuration.GetConnectionString("conexao"), 
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }

    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Fornecedor> Fornecedores { get; set; } = default!;
    public DbSet<Pedido> Pedidos { get; set; } = default!;
    public DbSet<Produto> Produtos { get; set; } = default!;
    public DbSet<PedidoProduto> PedidosProdutos { get; set; } = default!;
}
