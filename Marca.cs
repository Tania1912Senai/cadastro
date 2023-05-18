

namespace Projeto_loginMenuMarcaProduto
{
    public class NewBaseType
    {
        public string? Cadastrar(string? v, string? v, Console console)
        {
            List<string> listaString = new List<string>();
            string? v = Console.ReadLine();
            Console.WriteLine("Digite uma Marca:");
            string Marca =
            Console.WriteLine($"Digite o Codigo:");
            string Codigo =
            Console.WriteLine($"Digite o Nome do Produto:");
            string NomeProduto
            Console.WriteLine($"Digite o Preco:");
            float Preco =
            Console.WriteLine($"Digite a data do Cadastro");
            Console.WriteLine($"Digite quem efetuou o cadastro");
        }
    
    public class Marca : NewBaseType
        {
        public Marca()
        {
        }
        public Marca marca = new Marca();
        public Marca(int codigo, float preco, Usuario cadastroPor, int codigo) 
        {
            this.Codigo = codigo;
        this.Preco = preco;
        this.CadastroPor = cadastroPor;
        this.Codigo = codigo;
   
        
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }        
        public Usuario CadastroPor { get; set; }
         
        List<Produto> listaDeProdutos = new List<Produto>();public int Codigo {get;set;}
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
}