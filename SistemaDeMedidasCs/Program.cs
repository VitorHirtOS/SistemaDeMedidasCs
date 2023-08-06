using System;
using RetornoDaFuncao;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Program
{

    class Calculadora
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe dois números de entrada e sua operação: ");
            Console.WriteLine("Operação escolhida: ");
            char operacao = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Primeiro número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Chama o método Escolha da classe Operacao para obter a operação desejada
            string resultado = Operacao.Escolha(operacao, numero, numero2);
            Console.WriteLine(resultado);

            /*int num = OperacaoBasica.Resto((int)numero, (int)numero2);
            Console.WriteLine(num);*/

            string PotenciacaoOrRaiz = OutrasFunções.Number(0, 0, "", 0, "", "", "", "", 0, "", 0); // Parametro obrigatório por falta de entrade de dados ReadLine()

            Console.WriteLine(PotenciacaoOrRaiz);

        }
    }

    class Operacao
    {
        public static string Escolha(char operacao, double numero, double numero2)
        {
            if (operacao == '+')
            {
                return OperacaoBasica.Somar(numero, numero2).ToString();
            }
            else if (operacao == '-')
            {
                return OperacaoBasica.Subtrair(numero, numero2).ToString();
            }
            else if (operacao == '*')
            {
                return OperacaoBasica.Multiplicacao(numero, numero2).ToString();
            }
            else if (operacao == '/')
            {
                return OperacaoBasica.Dividir(numero, numero2).ToString();
            }
            else if (operacao == '%')
            {
                return OperacaoBasica.Resto((int)numero, (int)numero2).ToString();
            }
            else
            {
                return null;
            }
        }
    }

    class OperacaoBasica
    {
        public static double Somar(double numero, double numero2)
        {
            return numero + numero2;
        }

        public static double Subtrair(double numero, double numero2)
        {
            return numero - numero2;
        }

        public static double Multiplicacao(double numero, double numero2)
        {
            return numero * numero2;
        }

        public static double Dividir(double numero, double numero2)
        {
            return numero / numero2;
        }

        public static int Resto(int numero, int numero2)
        {
            return numero % numero2;
        }
    }
    

}