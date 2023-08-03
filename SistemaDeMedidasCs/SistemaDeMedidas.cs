using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedidasCs
{
    class SistemaDeMedidas
    {
        public static double SistemaMedidas(string opcao, double numero5)
        {

            if(opcao == "km")
            {
                return numero5;
            }
            else
            {
                return 0;
            }
        }

        // Km
        
        private static double Km(double numero5)
        {
            return numero5;
        }

        // Hm

        private static double Hm(double numero5) 
        {
            return numero5;
        }

        // Dam

        private static double Dam(double numero5) 
        {
            return (numero5);
        }

        // M 

        private static double M(double numero5)
        {
            return (numero5);
        }

        // Dm

        private static double Dm(double numero5)
        {
            return (numero5);
        }

        // Cm

        private static double Cm(double numero5)
        {
            return (numero5);
        }

        // Mm

        private static double Mm(double numero5)
        {
            return (numero5);
        }
    }
}
