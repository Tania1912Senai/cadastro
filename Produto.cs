

namespace Projeto_loginMenuMarcaProduto
{
        public class Produto
        {
        public Produto()
        {
        }
        public Produto(int codigoProduto, string nomeProduto, float preco, Usuario, DataCadastro, Usuario cadastroPor) 
        {
        this.Produto = nomeProduto;
        this.Codigo = codigoProduto;
        this.Preco = preco;
        this.CadastroPor = cadastroPor;
        }
        //informacoes do produto sendo cadastrado armazenado na classe produto
        public int CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        
        private const string V = $" CadastradoPor";
        
        public Marca Marca = new Marca();        
        public Usuario CadastroPor { get; set; }
        
        public Produto ListaDeProdutos { get; private set; }

        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        Produto novoProduto = newProduto()
        NovoProduto.CadastradoPor = new Usuario();
        NovoProduto.Marca = Marca.CadastrarMarca();
        //cadastro um novo produto com seus dados, nome, codigo, preco e data.
        //cadastra acionando o menu e depois ser adicionado na lista de produtos
        {
           
        }
           System.Console.Write ("Codigo do Produto:");
           NovoProduto.Codigo = Int.Parse(Console.readLine());
           System.Console.Write ("Nome do Produto:");
           NovoProduto.NomeProduto = Int.Parse(Console.readLine());
           System.Console.Write ("Preco do Produto:");
           NovoProduto.PrecoProduto = Int.Parse(Console.readLine());
           Novo.Produto.DataCadastro = DateTime.UtcNow;
           
        public void Listar()
        {
            foreach( var item in listaDeProdutos)
            {
               System.Console.WriteLine($" Marca| (Item,Marca)");
               System.Console.WriteLine($" Codigoproduto| (Item,CodigoProduto)");
               System.Console.WriteLine($" NomeProduto| (Item, NomeProduto)");
               System.Console.WriteLine($" Preco| (Item,Preco)");
               System.Console.WriteLine($" DataCadastro|(Item, DataCadatro)");
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
        {       

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

    
