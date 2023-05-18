

namespace Projeto_loginMenuMarcaProduto
{
        public class Produto
    {
        public Produto()
        {
        }
        public Produto(int codigo, float preco, Usuario cadastroPor) 
        {
            this.Codigo = codigo;
    this.Preco = preco;
    this.CadastroPor = cadastroPor;
   
        }
                public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }

        private const string V = $" CadastradoPor";
        public Marca Marca = new Marca();        
        public Usuario CadastroPor { get; set; }
        public Produto ListaDeProdutos { get; private set; }

        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
           
        }

        public void Listar()
        {
            foreach( var item in listaDeProdutos)
            {
                System.Console.WriteLine($" Marca| (Item,Marca)");
                System.Console.WriteLine($" Codigo| (Item,Codigo)");
                System.Console.WriteLine($" Produto| (Item, Produto)");
                System.Console.WriteLine($" Preco| (Item,Preco)");
                System.Console.WriteLine($" Data de Cadastro|(Item,DataDeCadatro)");
                System.Console.WriteLine($ CadastradoPor: (item, CadastroPor)");
            }
            
        }

        public void Deletar(int codigo)
        {
           Produto produtoDelete = ListaDeProdutos,Find(p => p.Codigo == codigo);
           ListaDeProdutos.Remove(produtoDelete);
            
        }

        private void Remove(Produto produtoDelete)
        {
            throw new NotImplementedException();
        }
    }

    public record struct NewStruct(Produto item, Usuario CadastroPor)
    {
        public static implicit operator (Produto item, Usuario CadastroPor)(NewStruct value)
        {
            return (value.item, value.CadastroPor);
        }

        public static implicit operator NewStruct((Produto item, Usuario CadastroPor) value)
        {
            return new NewStruct(value.item, value.CadastroPor);
        }
    }
}

    