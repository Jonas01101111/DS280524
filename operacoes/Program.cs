using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacoes
{
    internal class Program
    {
        static void calcular(string operacao,int v1, int v2)
        {
            switch (operacao)
            {
                case "+": Console.WriteLine("Operação:Soma\nResultado: "+(v1+v2)) ; break;
                case "-": Console.WriteLine("Operação:Subtração\nResultado: " + (v1 - v2)); break;
                case "*": Console.WriteLine("Operação:Multiplicação\nResultado: " + (v1 * v2)); break;
                case "/": Console.WriteLine("Operação:Divisão\nResultado: " + (v1 / v2)); break;
            }
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira a operação +,-,/,*");
            string op = Console.ReadLine();
            Console.WriteLine("Insira o primeiro valor:");
            int n1 =   int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            int n2 = int.Parse(Console.ReadLine());

            calcular(op, n1, n2);
            Console.ReadKey();
        }




    }
}
