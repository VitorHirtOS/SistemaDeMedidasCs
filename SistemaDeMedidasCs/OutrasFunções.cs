using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetornoDaFuncao
{
    class OutrasFunções
    {

        public static string number(double numero2, int x, string escolha)
        {

            Console.WriteLine("Realizar a raiz quadrada = 1 ou 0 para cálcular a potenciação");
            escolha = Console.ReadLine();
  
            if(escolha == "1")
            {


                Console.WriteLine("Passe um número para a raiz: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                string numero3 = Raiz(numero2).ToString();
                return numero3;

            }else if (escolha == "0")
            {

                Console.WriteLine("Passe um número para o denominador: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Passe um número para a expoente: ");
                x = Convert.ToInt32(Console.ReadLine());

                string Potenciacao2 = Potenciacao(numero2, x).ToString();
                return Potenciacao2;

            }
            else
            {
                return null;
            }
        }

        private static double Potenciacao(double numero2, int x)
        {
            return Math.Pow(numero2, x);
        }


        private static double Raiz(double numero2)
        {
            return Math.Sqrt(numero2);
        }

    }
}
