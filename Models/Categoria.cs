using System.Reflection.Metadata.Ecma335;

namespace WebApplication2.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Categoria ObterCategoriaById(int idCategoria)
        {
            List<Categoria> categorias = ObterTodasCategorias();
            return categorias.Find(categoriaDaLista => 
            categoriaDaLista.Id == idCategoria);
        }

        public List<Categoria> ObterTodasCategorias()
        {
            List<Categoria>  categorias = new List<Categoria>()
            { 
                new Categoria()
                { 
                    Id = 1,
                    Descricao = "Higiene"
                },
                new Categoria()
                {
                    Id = 2,
                    Descricao = "Limpeza"
                },
            };

            return categorias;
        }
    }
}
