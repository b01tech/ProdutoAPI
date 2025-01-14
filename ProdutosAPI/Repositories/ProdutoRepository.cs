using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Data;
using ProdutosAPI.Models;

namespace ProdutosAPI.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Produto> GetAll()
    {
        return _context.produtos.AsNoTracking().ToList();  
    }
    public Produto Get(long id)
    {
        return _context.produtos.Find(id);
    }
    public Produto Create(Produto produto)
    {
        if (produto is null) {
            throw new ArgumentNullException(nameof(produto));
        }
    
            _context.produtos.Add(produto);
            _context.SaveChanges();     
        return produto;
    }
    public Produto Update(Produto produto, long id)
    {
        if(produto.ProdutoId != id)
        {
            throw new Exception();
        }
        _context.produtos.Update(produto);
        _context.SaveChanges();
        return produto;
    }
    public Produto Delete(long id)
    {
        var produto = _context.produtos.Find(id);
        if (produto is null)
        {
            throw new Exception();
        }
        _context.produtos.Remove(produto);
        _context.SaveChanges();
        return produto;

    }
}
