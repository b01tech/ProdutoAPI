namespace ProdutosAPI.Models;

public class Produto
{
    public long ProdutoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal preco  { get; set; }
    public bool Ativo { get; set; } = true;
}
