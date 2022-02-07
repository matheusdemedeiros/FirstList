using System;

namespace FirstListQ5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o salario do funcionario em R$: ");
            double salario = double.Parse(Console.ReadLine());
            double novoSalario = (salario * 0.15) + salario;
            double salarioDescontado = novoSalario - (novoSalario * 0.08);
            Console.WriteLine("=====================================");
            Console.WriteLine("Salario inicial R$: {0}", salario);
            Console.WriteLine("Salario com aumento R$: {0}", novoSalario);
            Console.WriteLine("Novo salário com impostos descontados R$: {0}", salarioDescontado);

        }
    }
}
