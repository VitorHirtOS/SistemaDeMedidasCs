#include <iostream>
#include <math.h>
#include <locale.h>
#include <tchar.h>
#include <string>
#include "FunctionSystem.h"

class SistemaDeConversaoEuroDollar {

	setlocale(LC_ALL, "portuguese");

	class Conversao {

		public: static void DollarEuro() {

			std::cout << "Sistema de conversão entre moedas americana e europeu: " << std::endl;

			std::string conversao = OpcaoConvert.EscolhaConvert(acao);

			std::cout << conversao << "\n";

		}

	};

	class OpcaoConvert {

		private: static std::string EscolhaConvert() {

			std::cout << "Pode escolha para realizar operação: " << "\n";
			std::cout << "Euro -> 'Dollar' ou Dollar -> 'Euro'" << "\n";
			std::cout << "Escreva em minúsculo dollar ou euro" << "\n";

			std::string acao = "" ;

			std::cin >> acao;

			std::cout << "Valor da moeda para conversão: " << std::endl;

			double moeda;

			std::cin >> moeda;

			RetornoEscolha(acao);
			return acao;

		}

	};

	class RetornoEscolha {

		private: static std::string RetornoOpcao(std::string acao, double moeda) {

			double cambio[100] = { 0.7618 };

			switch (acao)
			{
			case "dollar":

				std:: << cambio << "\n";

				std::printf("O resultado da conversão é = %s", std::to_string(moeda * cambio))

				break;

			case "euro":

				std:: << cambio << "\n";

				std::printf("O resultado da conversão é = %s", std::to_string(moeda * cambio))

				break;
			
			default:
				std::cout << "Operação inválida" << std::endl;
				break;
			}

			return acao;

		}

	};

};




