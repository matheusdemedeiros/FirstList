using System;

namespace FirstListQ4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a temperatura em graus Celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 1.8f) + 32;
            Console.Write("Temperatura em graus Fahrenheit: {0}", fahrenheit);
        }
    }
}
