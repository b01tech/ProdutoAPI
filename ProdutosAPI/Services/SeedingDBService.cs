using ProdutosAPI.Data;
using ProdutosAPI.Models;

namespace ProdutosAPI.Services;

public class SeedingDBService
{
    private readonly AppDbContext _context;

    public SeedingDBService(AppDbContext context)
    {
        _context = context;
    }

    public void SeedProdutos()
    {
        if (_context.produtos.Any())
        {
            return;
        }
        var p1 = new Produto { ProdutoId = 1 , Nome = "Produto_1", preco = 100.00m, Ativo = true};
        var p2 = new Produto { ProdutoId = 2 , Nome = "Produto_2", preco = 50.00m, Ativo = true};
        var p3 = new Produto { ProdutoId = 3 , Nome = "Produto_3", preco = 80.00m, Ativo = true};
        var p4 = new Produto { ProdutoId = 4 , Nome = "Produto_4", preco = 40.00m, Ativo = true};
        var p5 = new Produto { ProdutoId = 5 , Nome = "Produto_5", preco = 150.00m, Ativo = true};

        _context.produtos.AddRange(p1, p2, p3, p4, p5);
        _context.SaveChanges();
    }
}
