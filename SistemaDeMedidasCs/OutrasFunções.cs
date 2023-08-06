﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeMedidasCs;

namespace RetornoDaFuncao
{
    class OutrasFunções
    {

        public static string number(
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
            float salario)
        {

            Console.WriteLine("Realizar a raiz quadrada = 1 ou 0 para cálcular a potenciação ou para converter valores de medidas ou 3 para reajuste");
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

            }else if (escolha == "2")
            {
                Console.WriteLine("Valor para conversão de medidas: ");
                numero5 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha a opção de Conversão");
                opcao = Console.ReadLine();

                Console.WriteLine("Escolha a opção de Conversão para determinado medida");
                opcao2 = Console.ReadLine();

                double SistemaDeMedidasCs = SistemaDeMedidas.SistemaMedidas(opcao, opcao2, numero5);
                return SistemaDeMedidasCs.ToString();
            }else if (escolha == "3")
            {
                Console.WriteLine("Passe o id: ");
                id = Console.ReadLine();
                Console.WriteLine("Passe o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Passe o reajuste: ");
                reajuste = int.Parse(Console.ReadLine());
                Console.WriteLine("Passe o sálario: ");
                salario = float.Parse(Console.ReadLine());
                Console.WriteLine("Opções de visualização = nome, salario ou reajuste em minúsculo ");
                OpcaoDeGUI = Console.ReadLine();

                // Criar uma instância de Salario
                Salario salarioObj = new Salario();


                string valores = salarioObj.Retorno(id, nome, reajuste, salario, OpcaoDeGUI);
                return valores.ToString();
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
