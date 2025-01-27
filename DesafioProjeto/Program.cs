List<string> veiculos = new List<string>();

Console.WriteLine("Seja bem vindo ao Programa de cadastrar veiculos.\nDigite o preço Inicial.");
float preco_inicial = float.Parse(Console.ReadLine()!);
Console.WriteLine("Agora digite o preço por hora.");
float preco_hora = float.Parse(Console.ReadLine()!);

bool exibirMenu = true;

while (exibirMenu)
{

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    Console.WriteLine("Digite a sua opção");
    int opcao = int.Parse(Console.ReadLine()!);

    
    switch (opcao)
    {
        case 1:
            AdicionarVeiculo();
            break;
        case 2:
            RemoverVeiculo();
            break;
        case 3:
            ListarVeiculos();
            break;
        case 4:
            Console.WriteLine("Ate a proxima.");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção invalida.");
            break;

    }
}
void AdicionarVeiculo()
{
    string placaDoCarro = string.Empty;
    Console.Clear();
    Console.WriteLine("Digite a placa do veiculo que deseja cadastrar.");
    placaDoCarro = Console.ReadLine()!;
    veiculos.Add(placaDoCarro);
    Console.WriteLine("Carro Registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
}

void RemoverVeiculo()
{
    
    Console.Clear();
    Console.WriteLine("Digite a placa do veiculo que deseja remover: ");
    string placa = Console.ReadLine()!;
    if (veiculos.Contains(placa))
    {
        veiculos.Remove(placa);
        Console.WriteLine($"Veiculo com placa {placa} removido com sucesso.");
    }
    else
    {
        Console.WriteLine($"Placa {placa} não foi encontrado");
    }
    Console.Clear();
}

void ListarVeiculos()
{
    int contador = 1;
    Console.Clear();
    Console.WriteLine("Veículos cadastrados.");
    foreach (string veiculo in veiculos)
    {
        Console.WriteLine($"Veículo {contador}: {veiculo}");
        contador++;
    }
    Thread.Sleep(2000);
    Console.Clear();
}
