using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        /// <summary>
        /// Este método retorna todos os produtos.
        /// </summary>
        /// <returns></returns>
        [HttpGet("[action]")]
        public List<Produto> ObterTodosProdutos()
        { 
            Produto produto = new Produto();
            return produto.ObterTodosProdutos();
        }

        /// <summary>
        /// Este método busca 1 produto de acordo com o ID pessado por parâmetro
        /// </summary>
        /// <param name="idProduto"></param>
        /// <returns>Este método retorna um objeto produto</returns>
        [HttpGet("[action]/{idProduto}")]
        public Produto ObterProdutoById(int idProduto)
        {
            Produto produto = new Produto();
            return produto.ObterProdutoById(idProduto);
        }
    }
}
