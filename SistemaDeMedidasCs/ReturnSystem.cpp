#include <iostream>
#include <math.h>
#include <locale.h>
#include <tchar.h>
#include <string>
#include "FunctionSystem.h"

class SistemaDeConversaoEuroDollar {

	class Conversao {

	public: static void DollarEuro(std::string acao) {

			std::cout << "Sistema de conversão entre moedas americana e europeu: " << std::endl;


		}

	};

	class OpcaoConvert {

		private: static std::string EscolhaConvert() {

			std::cout << "Pode escolha para realizar operação: " << "\n";
			std::cout << "Euro -> 'Dollar' ou Dollar -> 'Euro'" << "\n";
			std::cout << "Escreva em minúsculo dollar ou euro" << "\n";

			std::string acao = "";

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

			double cambio = { 0.7618 };

			if (acao == "dollar") {

				std::cout << cambio << "\n";

				std::printf("O resultado da conversão é = %s", std::to_string(moeda * cambio));
			}
			else if (acao == "euro") {

				std::cout << cambio << "\n";

				std::printf("O resultado da conversão é = %s", std::to_string(moeda * cambio));

			}else{
				std::cout << "Operação inválida" << std::endl;
			}

			return acao;

		}

	};

};




