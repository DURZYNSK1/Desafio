using System;
using System.Collections.Generic;
using System.Linq;

namespace DESAFIO
{
    public class Estacionamento
    {
        private int preco = 0;
        private int precoHora = 0;
        private List<string> veiculos = new List<string>();

        
        public Estacionamento(int precoInicial, int precoPorHora)
        {
            preco = precoInicial;
            precoHora = precoPorHora;
        }

        
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do seu carro: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso.");
        }

       
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do seu carro: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento: ");
                int horas = int.Parse(Console.ReadLine());

                int valorTotal = preco + (precoHora * horas);
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados no estacionamento:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo está estacionado no estacionamento.");
            }
        }
    }
}
