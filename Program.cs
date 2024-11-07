using System;
using DESAFIO;

int preco = 0;
int precoHora = 0;

Console.WriteLine("Bem-vindo ao Estacionamento da Cidade!" +
    "\nDigite o preço inicial: ");
preco = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o preço por hora: ");
precoHora = Convert.ToInt32(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(preco, precoHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover um veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("Saindo do programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    
    Console.WriteLine("Pressione uma tecla para continuar...");
    Console.ReadLine();
}
