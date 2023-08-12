using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeMedidasCs;

namespace RetornoDaFuncao
{
    class OutrasFunções
    {

        public static string Number(
            double numero2,
            int x,
            string escolha,
            double numero5,
            string opcao,
            string opcao2,
            string id,
            string nome,
            int reajuste,
            string OpcaoDeGUI,
            float salario,
            string moedasEscolhas,
            double moeda,
            double euro,
            double eua,
            double russo,
            double china
            )
        {

            Console.WriteLine("Loop - sim ou stop");
            escolha = Console.ReadLine();

            if(escolha == "sim")
            {
                while (true)
                {

                    Console.WriteLine("Realizar a raiz quadrada = 1 ou 0 para cálcular a potenciação ou para converter valores de medidas ou 3 para reajuste ou 4 para conversão de moedas");
                    string escolha1 = Console.ReadLine();


                    if (escolha1 == "1")
                    {

                        Console.WriteLine("Passe um número para a raiz: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        string numero3 = Raiz(numero2).ToString();
                        Console.WriteLine(numero3);

                    }
                    else if (escolha1 == "0")
                    {

                        Console.WriteLine("Passe um número para o denominador: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Passe um número para a expoente: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        string Potenciacao2 = Potenciacao(numero2, x).ToString();
                        Console.WriteLine(Potenciacao2);

                    }
                    else if (escolha1 == "2")
                    {
                        Console.WriteLine("Valor para conversão de medidas: ");
                        numero5 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Escolha a opção de Conversão");
                        opcao = Console.ReadLine();

                        Console.WriteLine("Escolha a opção de Conversão para determinado medida");
                        opcao2 = Console.ReadLine();

                        double SistemaDeMedidasCs = SistemaDeMedidas.SistemaMedidas(opcao, opcao2, numero5);
                        Console.WriteLine(SistemaDeMedidasCs);
                    }
                    else if (escolha1 == "3")
                    {
                        Console.WriteLine("Passe o id: ");
                        id = Console.ReadLine();
                        Console.WriteLine("Passe o nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("Passe o reajuste: ");
                        reajuste = int.Parse(Console.ReadLine());
                        Console.WriteLine("Passe o sálario: ");
                        salario = float.Parse(Console.ReadLine());
                        Console.WriteLine("Opções de visualização = nome, salario, reajuste ou id em minúsculo: ");
                        OpcaoDeGUI = Console.ReadLine();

                        // Criar uma instância de Salario
                        Salario salarioObj = new Salario();


                        string valores = salarioObj.Retorno(id, nome, reajuste, salario, OpcaoDeGUI);
                        Console.WriteLine(valores);
                    }
                    else if (escolha1 == "4")
                    {
                        Console.WriteLine("Escolha a operação de conversão: ");
                        moedasEscolhas = Console.ReadLine();
                        Console.WriteLine("E o valor da moeda: ");
                        moeda = Convert.ToDouble(Console.ReadLine());

                        // Criar uma instância de Moedas
                        Internacional moedas = new Internacional();

                        Console.WriteLine(moedas);

                        string ValoresRetorno = ConversorDeMoedas.MoedasConvert(moedasEscolhas, moeda, euro, eua, russo, china);
                        Console.WriteLine(ValoresRetorno);
                    }
                    else if (escolha1 == "sair")
                    {
                        Console.WriteLine("Encerrando");
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            else if(escolha == "stop")
            {
                return "Encerrando";
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
