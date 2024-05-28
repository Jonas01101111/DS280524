using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opcomreturn
{
    internal class Program
    {
         static int Calcular(string operacao, int v1, int v2)
        {
            switch (operacao)
            {
                case "+": return v1 + v2;
                case "-": return v1 - v2;
                case "*": return v1 * v2;
                case "/": return v1 / v2;
                default: return 000;
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira a operação +,-,/,*");
            string op = Console.ReadLine();
            Console.WriteLine("Insira o primeiro valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado:"+ Calcular(op,n1,n2));
            Console.ReadKey();
        }
    }
    }
