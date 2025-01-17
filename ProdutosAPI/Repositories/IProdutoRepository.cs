using ProdutosAPI.Models;
using ProdutosAPI.Pagination;

namespace ProdutosAPI.Repositories;

public interface IProdutoRepository
{
    IEnumerable<Produto> GetAll();

    IEnumerable<Produto> GetProdutos(PageParams pageParams);
    Produto Get(long id);
    Produto Create(Produto produto);
    Produto Update(Produto produto, long id);
    Produto Delete(long id);

}
