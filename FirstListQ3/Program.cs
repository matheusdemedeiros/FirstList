using System;

namespace FirstListQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int dias, meses, semanas;

            dias = idade * 365;
            meses = idade * 12;
            semanas = meses * 30;
            Console.WriteLine("{0} VOCE JA VIVEU {1} DIAS!!", nome, dias);
            Console.WriteLine("{0} VOCE JA VIVEU APROXIMADAMENTE {1}  SEMANAS!!", nome, semanas);
            Console.WriteLine("{0} VOCE JA VIVEU APROXIMADAMENTE {1} MESES!!", nome, meses);
        }
    }
}
