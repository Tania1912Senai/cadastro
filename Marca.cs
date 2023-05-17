

namespace Projeto_loginMenuMarcaProduto
{
    public class Marca
    {
        public Marca()
        public Marca Marca = new Marca();
    { 
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }        
        public Usuario CadastroPor { get; set; }

        List<Produto> listaDeProdutos = new List<Produto>();public int Codigo {get;set;}
        
        public void Cadastrar()
        {
            //aqui vai a lógica
            //instanciar o objeto
            //receber os dados e cadastrar nesse objeto
            //armazenar o objeto na lista
        }

        public void Listar()
        {
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
        }

        public void Deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
        }
    }
        {
           
        }
    }
}