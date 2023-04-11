namespace WebApplication2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Categoria CategoriaProduto { get; set; }

        public Produto ObterProdutoById(int idProduto)
        {
            List<Produto> listaProdutos = ObterTodosProdutos();
            return listaProdutos.Find(produtoDaLista =>
                produtoDaLista.Id == idProduto);
        }

        public List<Produto> ObterTodosProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>()
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Produto 1",
                    Descricao = "Descrição 1",
                    Preco = 10,
                    CategoriaProduto = new Categoria()
                    {
                        Id = 1,
                        Descricao = "Higiene"
                    }
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Produto 2",
                    Descricao = "Descrição 2",
                    Preco = 20,
                    CategoriaProduto = new Categoria()
                    {
                        Id = 2,
                        Descricao = "Limpeza"
                    }
                },
            };

            return listaProdutos;
        }
    }
}
