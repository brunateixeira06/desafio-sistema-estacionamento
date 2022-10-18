using DESAFIOFUNDAMENTOS.Models;

string nomeDonoVeiculo = "";
DateTime data = DateTime.Now;
decimal precoInicial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Bem Vindo ao Estacionamento! " +data);

Console.WriteLine("Informe o seu Nome: ");
nomeDonoVeiculo = Console.ReadLine();
Console.WriteLine("Digite o preço inicial: ");
precoInicial = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite o preço por hora: ");
precoPorHora = decimal.Parse(Console.ReadLine());


Estacionamento estacio = new Estacionamento( precoInicial, precoPorHora);


string opc = string.Empty;
bool exibeMenu = true;
//menu
while (exibeMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção: ");
    Console.WriteLine("1- Cadastrar Veiculos");
    Console.WriteLine("2- Remover Veiculos");
    Console.WriteLine("3- Listar Veiculos");
    Console.WriteLine("4- Sair");
    

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("1- AdicionarVeiculo"); 
            break;

        case "2":
           Console.WriteLine("2- RemoveVeiculo");
            break;

        case "3":
            Console.WriteLine("3- ListarVeiculo");
            break;

        case "4":
            exibeMenu = false;
            break;

        default:
            Console.WriteLine("Opçao invalida!");
            break;
    }

        Console.ReadLine();
}