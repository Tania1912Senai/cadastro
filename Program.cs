

{
   
    private static bool Autenticar(string usuario, string senha)
    {
        
        //  o usuário é "Tania" e a senha é "password".
        return usuario == "Tania" && senha == "1234";
    }

    private static void MostrarOpcoes()
    {
        Console.WriteLine("\nOpções disponíveis:");
        Console.WriteLine("1. Visualizar perfil");
        Console.WriteLine("2. Alterar senha");
        Console.WriteLine("3. Sair\n");

        Console.Write("Digite o número da opção desejada: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Visualizando perfil...");
                // Lógica para visualizar o perfil do usuário
                break;
            case "2":
                Console.WriteLine("Alterando senha...");
                // Lógica para alterar a senha do usuário
                break;
            case "3":
                Console.WriteLine("Saindo do programa...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.\n");
                MostrarOpcoes();
                break;
        }
    }

    private static void MostrarMenu()
    {
        bool autenticado = false;
        string usuario, senha;

        while (!autenticado)
        {
            Console.WriteLine("==O que voce deseja comprar hoje?==");
            Console.WriteLine("Por favor, faça login:");
            Console.Write("Nome do Usuário: ");
            usuario = Console.ReadLine();
            Console.Write("Sua Senha: ");
            senha = Console.ReadLine();

            autenticado = Autenticar(usuario, senha);

            if (autenticado)
            {
                Console.WriteLine("Login bem-sucedido!");
                MostrarOpcoes();
            }
            else
            {
                Console.WriteLine("Credenciais inválidas. Tente novamente.\n");
            }
        }
    }
}
