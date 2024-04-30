using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayVenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] venda = new double[5];
            double[] comi = new double[5];
            double[] total = new double[5];

            for (int i = 0; i <= 4 ; i++)
            {
                Console.WriteLine("Insira o nome do vendedor: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira o valor total da venda");
                venda[i] = double.Parse(Console.ReadLine());
                Console.Clear();

                if (venda[i] <= 20000)
                {
                    comi[i] = venda[i] * 0.05;
                    total[i] = venda[i] + comi[i];
                }
                else if (venda[i] <= 40000)
                {
                    comi[i] = venda[i] * 0.06;
                    total[i] = venda[i] + comi[i];
                }
                else
                {
                    comi[i] = venda[i] * 0.07;
                    total[i] = venda[i] + comi[i];
                }
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("O vendedor " + nome[j] + " atingiu " + venda[j].ToString("C") + " e ganhou " + comi[j].ToString("C") + " de comissão ");
            }

            Console.ReadKey();

        }
    }
}
