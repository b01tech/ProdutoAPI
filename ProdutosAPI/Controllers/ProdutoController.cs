using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Models;
using ProdutosAPI.Repositories;

namespace ProdutosAPI.Controllers;
[Route("[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoRepository _repository;

    public ProdutoController(IProdutoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetAll()
    {
        var produtos = _repository.GetAll();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> Get(long id)
    {
        var produto = _repository.Get(id);
        if (produto == null)
        {
            return NotFound($"Produto id = {id} não encontrado.");
        }
        return Ok(produto);
    }

    [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
    [HttpPost]
    public ActionResult<Produto> Post([FromBody] Produto produto)
    {
        _repository.Create(produto);
        return Created(string.Empty, produto);
    }

    [HttpPut("{id}")]
    public ActionResult<Produto> Put( [FromBody] Produto produto, long id)
    {
        _repository.Update(produto, id);
        return Ok(produto);
    }

    [HttpDelete("{id}")]
    public ActionResult<Produto> Delete(long id)
    {
        var produto = _repository.Delete(id);
        return Ok(produto);
    }
}
