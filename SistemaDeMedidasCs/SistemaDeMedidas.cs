using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedidasCs
{
    class SistemaDeMedidas
    {
        public static double SistemaMedidas(string opcao, string opcao2, double numero5)
        {

            string[] unidade = { "KM", "HM", "DAM", "M", "DM", "CM", "MM" };

            if (opcao == "Km")
            {
                if (opcao2 == "Hm")
                {
                    return Km(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return Km(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Km(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return Km(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return Km(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return Km(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "Hm")
            {
                if (opcao2 == "Km")
                {
                    return Hm(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return Hm(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Hm(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return Hm(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return Hm(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return Hm(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "Dam")
            {
                if (opcao2 == "Km")
                {
                    return Dam(opcao2, numero5);
                }
                else if (opcao2 == "Hm")
                {
                    return Dam(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Dam(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return Dam(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return Dam(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return Dam(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "M") 
            {
                if (opcao2 == "Km")
                {
                    return M(opcao2, numero5);
                }
                else if (opcao2 == "Hm")
                {
                    return M(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return M(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return M(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return M(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return M(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "Dm")
            {
                if (opcao2 == "Km")
                {
                    return Dm(opcao2, numero5);
                }
                else if (opcao2 == "Hm")
                {
                    return Dm(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return Dm(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Dm(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return Dm(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return Dm(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "Cm")
            {
                if (opcao2 == "Km")
                {
                    return Cm(opcao2, numero5);
                }
                else if (opcao2 == "Hm")
                {
                    return Cm(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return Cm(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Cm(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return Cm(opcao2, numero5);
                }
                else if (opcao2 == "Mm")
                {
                    return Cm(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else if(opcao == "Mm")
            {
                if (opcao2 == "Km")
                {
                    return Mm(opcao2, numero5);
                }
                else if (opcao2 == "Hm")
                {
                    return Mm(opcao2, numero5);
                }
                else if (opcao2 == "Dam")
                {
                    return Mm(opcao2, numero5);
                }
                else if (opcao2 == "M")
                {
                    return Mm(opcao2, numero5);
                }
                else if (opcao2 == "Dm")
                {
                    return Mm(opcao2, numero5);
                }
                else if (opcao2 == "Cm")
                {
                    return Mm(opcao2, numero5);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        // Km
        
        private static double Km(string opcao2, double numero5)
        {
            if (opcao2 == "Hm")
            {
                return numero5 * 10;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 * 100;
            }
            else if (opcao2 == "M")
            {
                return numero5 * 1000;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 * 10000;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 100000;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 1000000;
            }
            else
            {
                return 0;
            }
        }

        // Hm

        private static double Hm(string opcao2, double numero5) 
        {
            if (opcao2 == "Km")
            {
                return numero5 / 10;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 * 10;
            }
            else if (opcao2 == "M")
            {
                return numero5 * 100;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 * 1000;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 10000;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 100000;
            }
            else
            {
                return 0;
            }
        }

        // Dam

        private static double Dam(string opcao2, double numero5) 
        {
            if (opcao2 == "Km")
            {
                return numero5 / 100;
            }
            else if (opcao2 == "Hm")
            {
                return numero5 / 10;
            }
            else if (opcao2 == "M")
            {
                return numero5 * 10;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 * 100;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 1000;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 10000;
            }
            else
            {
                return 0;
            }
        }

        // M 

        private static double M(string opcao2, double numero5)
        {
            if (opcao2 == "Km")
            {
                return numero5 / 1000;
            }
            else if (opcao2 == "Hm")
            {
                return numero5 / 100;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 / 10;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 * 10;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 100;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 1000;
            }
            else
            {
                return 0;
            }
        }

        // Dm

        private static double Dm(string opcao2, double numero5)
        {
            if (opcao2 == "km")
            {
                return numero5 / 100000;
            }
            else if (opcao2 == "Hm")
            {
                return numero5 / 1000;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 / 100;
            }
            else if (opcao2 == "M")
            {
                return numero5 / 10;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 10;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 100;
            }
            else
            {
                return 0;
            }
        }

        // Cm

        private static double Cm(string opcao2, double numero5)
        {
            if (opcao2 == "Km")
            {
                return numero5 / 1000000;
            }
            else if (opcao2 == "Hm")
            {
                return numero5 / 10000;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 / 1000;
            }
            else if (opcao2 == "M")
            {
                return numero5 / 100;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 / 10;
            }
            else if (opcao2 == "Mm")
            {
                return numero5 * 10;
            }
            else
            {
                return 0;
            }
        }

        // Mm

        private static double Mm(string opcao2, double numero5)
        {
            if (opcao2 == "Km")
            {
                return numero5 * 1000000;
            }
            else if (opcao2 == "Hm")
            {
                return numero5 * 100000;
            }
            else if (opcao2 == "Dam")
            {
                return numero5 * 10000;
            }
            else if (opcao2 == "M")
            {
                return numero5 * 1000;
            }
            else if (opcao2 == "Dm")
            {
                return numero5 * 100;
            }
            else if (opcao2 == "Cm")
            {
                return numero5 * 10;
            }
            else
            {
                return 0;
            }
        }
    }
}
