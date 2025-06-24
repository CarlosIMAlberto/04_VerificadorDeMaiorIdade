using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pojecto 4 rumo a maestria em c#");
            string nome;
            byte idade;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade");
            idade = byte.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("O senhor(a) tem {idade} e maior de idade " + idade);

            }
            else {
                Console.WriteLine(" O senhor(a) tem {idade} e menor de idade " + idade);
            }

        }
    }
}
