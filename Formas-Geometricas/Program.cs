using System;
using System.Globalization;
using System.Collections.Generic;

namespace Formas_Geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamando a lista 
            List<Forma> list = new List<Forma>();
            //interaçao com usuario
            Console.WriteLine("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine($"Forma#{i}: ");
                //interaçao com usuario
                Console.Write("Retâmgulo ou Circulo? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: (Preto/Azul/Vermelho):");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                //condiçao
                if (ch == 'R')
                {
                    //interaçao com usuario
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    list.Add(new Retangulo(largura, altura, cor));
                }
                //caso escolha o criculo
                else
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

            }
            //interaçao com usuario
            Console.WriteLine();
            Console.WriteLine("Area de cada forma: ");
            foreach (Forma forma in list)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
