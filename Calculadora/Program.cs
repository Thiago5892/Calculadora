using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operarçaõ deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");
                       
            int operacao = int.Parse(Console.ReadLine());

         
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1: resultado = Adicionar(num1, num2);
                    break;
                case 2: resultado = Subtrair(num1, num2);
                    break;
                case 3:resultado = Multiplicar(num1,num2);
                    break;
                case 4: resultado = Divisao(num1,num2);
                    break;
                default:
                    Console.WriteLine("Digite um número válido.");
                    break;
            }
            Console.WriteLine("O Resultado da operação é {0} e {1} é: {2} ",num1, num2, resultado);
            Console.ReadLine();
        }

        public static int Adicionar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        public static int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        public static int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }   
}
