using System.Globalization;
string mensagemDeBoasVindas = "Boas Vindas ao Screen Soud";
//List<string> ListaDasBandas = new List<string>() { "Calypso", "U2", "The Beatles"}; //Usando Listas
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List <int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 2, 10 });
bandasRegistradas.Add("The Beatles", new List<int>());
bandasRegistradas.Add("U2", new List<int>());
bandasRegistradas.Add("Ira", new List<int>());
ExibirLogo();
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
        case 3: AvaliarUmaBanda();
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
        ExibirTituloDaOpcao("Registro das bandas!");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
    void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação!");
        //for (int i = 0; i < ListaDasBandas.Count; i++) // Opção com o for
        //{
        //    Console.WriteLine($" Banda: {ListaDasBandas[i]}\n");            
        //}
        foreach (string bandas in bandasRegistradas.Keys) // Aqui com foreach
        {
            Console.WriteLine(bandas);
        }
        Thread.Sleep(2000);
        Console.Write("\nDigite uma tecla para voltar ao menu ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
    void ExibirTituloDaOpcao(string titulo) 
    {
        int QauntidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(QauntidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    
    }

    void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDabanda = Console.ReadLine()!;
        Console.WriteLine();
        if (bandasRegistradas.ContainsKey(nomeDabanda)) 
        {
            Console.Write($"Qaul a nota que a banda {nomeDabanda} merece: ");
            int nota = int.Parse(Console.ReadLine()!);
            bandasRegistradas[nomeDabanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDabanda}\n");           
            Thread.Sleep(3000);            
            Console.Clear();
            ExibirLogo();
            ExibirOpcoesDoMenu();
           
        }
        else 
        {
            Console.WriteLine($"\nA banda {nomeDabanda} não foi encontrada");
            Console.WriteLine("Digite uma tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();
            ExibirLogo();
            ExibirOpcoesDoMenu();
        }
        


    }

}



ExibirOpcoesDoMenu();