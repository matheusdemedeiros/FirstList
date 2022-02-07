using System;

namespace FirstList.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal area = -1;
            do
            {
                Console.WriteLine("=====================");

                Console.Write("Informe a largura do terreno: ");

                bool isNumeric1 = decimal.TryParse($"{Console.ReadLine()}", out decimal width);
                Console.Write("Informe o comprimento do terreno: ");
                bool isNumeric2 = decimal.TryParse($"{Console.ReadLine()}", out decimal height);

                if (isNumeric1 && isNumeric2 && width > 0 && height > 0)
                {
                    area = width * height;
                    Console.WriteLine("A area do seu terreno {0}: ", area);
                }
                else
                {
                    Console.WriteLine("\nO valor informado deve ser numerico e maior que zero!!");
                    continue;
                }
            } while (area < 0);
        }
    }
}
