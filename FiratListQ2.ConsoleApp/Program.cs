using System;

namespace FirstListQ2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de paes vendidos hoje: ");
            int qtdPaes = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de broas vendidos hoje: ");
            int qtdBroas = int.Parse(Console.ReadLine());

            double valorPaes = qtdPaes * 0.12;
            double valorBroas = qtdBroas * 1.5;
            double totalArrecadado = valorPaes + valorBroas;
            double guardarPoupanca = totalArrecadado * 0.1;

            Console.Write("\nO total arrecado hoje foi R$: {0}", totalArrecadado);
            Console.Write("\nVoce deve quardar R$: {0}", guardarPoupanca);

        }
    }
}
