using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        [HttpGet("[action]")]
        public List<Categoria> ObterTodasCategorias()
        {
            Categoria categoria = new Categoria();
            return categoria.ObterTodasCategorias();
        }

        [HttpGet("[action]/{id}")]
        public Categoria ObterCategoriaById(int id)
        {
            Categoria categoria = new Categoria();
            return categoria.ObterCategoriaById(id);
        }
    }
}
