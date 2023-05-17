
namespace Projeto_loginMenuMarcaProduto
{
    public class Usuario : NewBaseType
    {
        public Usuario(int codigo, string email, DateTime dataCadastro)
        {
            this.Codigo = codigo;
            this.Email = email;
            this.DataCadastro = dataCadastro;

        }

        public Usuario(int codigo, string email, DateTime dataCadastro) 
        {
            this.Codigo = codigo;
    this.Email = email;
    this.DataCadastro = dataCadastro;
   
        }
                public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public DateTime DataCadastro { get; set; }
    }
    public void Usuario(object Cadastro)
    {
        object value = Cadastro();

    }
    public void Cadastrar()
    {
        this.Nome = "Tania";
        this.Email = "Tania1912@gmail.com";
        this.Senha = "1234";
        this.SetDataCadastro(DataTime.Now);
    }
    public void Deletar()
    {
        this.Nome = "Tania";
        this.Email = "Tania1912@gmail.com";
        this.Senha = "1234";
        this.SetDataCadastro(DataTime.("0000-00-00T00:00.00"));
    }
}

    