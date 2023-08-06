using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMedidasCs
{
    class Salario
    {
        public string Retorno(string id, string nome, int reajuste, float salario, string OpcaoDeGUI)
        {
            ReajusteSalarial retorno = new ReajusteSalarial(id, nome, reajuste, salario);
            
            if(OpcaoDeGUI == "salario"){
                return retorno.Salario.ToString();
            }else if (OpcaoDeGUI == "nome")
            {
                return retorno.Nome;
            }else if(OpcaoDeGUI == "reajuste")
            {
                return retorno.Soma.ToString();
            }
            else
            {
                return null;
            }

         
        }
    }

    struct ReajusteSalarial
    {

        // Campos públicos para armazenar informações do produto
        public string Id;
        public string Nome;
        public int Reajuste;
        public float Salario;
        public float Soma;

        public ReajusteSalarial(string id, string nome, int reajuste, float salario) // Construtor - Da estrutura de informações
        {
            Id = id; // Identificador
            Nome = nome; // Nome do destinatário
            Reajuste = reajuste; // Porcentagem de reajuste
            Salario = salario; // Salario atual
            Soma = Salario + Reajuste; // Soma dos valores + o reajuste
        }

        public double ValorDeAumento()
        {
            return Soma;
        }

    }
}
