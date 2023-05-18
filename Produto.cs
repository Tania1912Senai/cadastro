

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
        {
           
        }

        public void Listar()
        {
            foreach( var item in listaDeProdutos)
            {
                Console.WriteLine($" Marca| (Item,Marca)");
                Console.WriteLine($" Codigoproduto| (Item,CodigoProduto)");
                Console.WriteLine($" NomeProduto| (Item, NomeProduto)");
                Console.WriteLine($" Preco| (Item,Preco)");
                Console.WriteLine($" DataCadastro|(Item, DataCadatro)");
                Console.WriteLine($ CadastradoPor: (item, CadastroPor)");
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

    
