using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedidasCs
{
    class ConversorDeMoedas
    {

        public static string MoedasConvert(string moedasEscolhas, double moeda, double euro, double eua, double russo, double china)
        {
            Internacional internacional = new Internacional(euro, eua, russo, china);

            string ValoresRetorno = Moedas.MoedasConversao(moedasEscolhas, moeda);
            return ValoresRetorno;

        }

    }


    class Moedas
    {
        public static string MoedasConversao(string moedasEscolhas, double moeda)
        {

            switch (moedasEscolhas)
            {
                case "Euro":
                    return Moedas.Euro(moeda).ToString();
                case "Dollar": 
                    return Moedas.Dollar(moeda).ToString();
                case "Rublo":
                    return Moedas.Russo(moeda).ToString();
                case "Jijinping":
                    return Moedas.China(moeda).ToString();
                default:
                    return "Operação Inválido";
            }
        }

        private static double Euro(double moeda)
        {
            return moeda * 4.62;
        }

        private static double Dollar(double moeda)
        {
            return moeda * 1.25;
        }

        private static double Russo(double moeda)
        {
            return moeda * 0.25;
        }

        private static double China(double moeda)
        {
            return moeda * 0.85;
        }

    }

    struct Internacional
    {

        public double euro;
        public double eua;
        public double russo;
        public double china;

        public Internacional(double euro, double eua, double russo, double china)
        {
            euro = 4.62;
            eua = 1.25;
            russo = 0.25;
            china = 0.85;

            Console.WriteLine(euro);
            Console.WriteLine(eua);
            Console.WriteLine(russo);
            Console.WriteLine(china);
        }

    }
}
