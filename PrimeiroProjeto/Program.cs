using System.Globalization;

string mensagemDeBoasVindas = "Boas Vindas ao Screen Soud";
List<string> ListaDasBandas = new List<string>() { "Calypso\n", "U2\n", "The\n", "Beatles"};

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas + "\n");

}
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registra uma banda\n");
    Console.WriteLine("Digite 2 para mostrar todas as bandas\n");
    Console.WriteLine("Digite 3 para avaliar uma banda\n");
    Console.WriteLine("digite 4 para a média de uma banda\n");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você Escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau tchal :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
    void RegistrarBanda()
    {
        Console.Clear();
        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        ListaDasBandas.Add(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine(" Exibindo todas as bandas registradas!");
        Console.WriteLine("**************************************\n");
        //for (int i = 0; i < ListaDasBandas.Count; i++) 
        //{
        //    Console.WriteLine($" Banda: {ListaDasBandas[i]}\n");            
        //}
        foreach(string bandas in ListaDasBandas) 
        {
            Console.WriteLine(bandas);
        }
        Thread.Sleep(2000);
        Console.WriteLine("\nDigite uma tecla para voltar ao meunu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    
}
ExibirLogo();
ExibirOpcoesDoMenu();

