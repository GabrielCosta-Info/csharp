using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("1: Quadrado.\n2: Retângulo.\n0: Sair.");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Digite lado do quadrado");
                    Quadrado quadrado = new Quadrado(double.Parse(Console.ReadLine()));
                    Console.WriteLine(quadrado);
                    Console.WriteLine();
                    Console.ReadKey();
                }
                if (opcao == 2)
                {
                    Console.WriteLine("Base do retângulo.");
                    double basee = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura do retângulo.");
                    double altura = double.Parse(Console.ReadLine());
                    Retangulo retangulo = new Retangulo(basee, altura);
                    Console.WriteLine(retangulo);
                    Console.WriteLine();
                    Console.ReadKey();
                }
            } while (opcao != 0);
        }
    }
}
