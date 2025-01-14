using ProdutosAPI.Models;

namespace ProdutosAPI.Repositories;

public interface IProdutoRepository
{
    IEnumerable<Produto> GetAll();
    Produto Get(long id);
    Produto Create(Produto produto);
    Produto Update(Produto produto, long id);
    Produto Delete(long id);

}
