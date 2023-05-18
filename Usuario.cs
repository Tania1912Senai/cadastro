namespace Projeto_loginMenuMarcaProduto
{
    public class Usuario()
    {   
    cadastrar()
    }
    {  public Usuario(int_codigo, string_nome, string_email, string_senha)
        codigo = _codigo;
        nome = _nome;
        Email = _email;
        senha =_senha;
        DataCadastro = DateTime.Utchow;
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public void Cadastrar()
        {
            this.Nome = "Tania";
            this.Email = "Tania1912@gmail.com";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;
        }
        public void Deletar()
        {
            this.Nome = "Tania";
            this.Email = "Tania1912@gmail.com";
            this.Senha = "1234";
            this.DataCadastro = (DateTime.Parse("0000-00-00T00:00.00"));
        }
    }
    
}

