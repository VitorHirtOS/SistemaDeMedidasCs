#include <stdio.h>
#include <string>
#include <math.h>
#include <locale.h>
#include <tchar.h>

double RealBrazil(int opcaoReal, double brazilReal) {

	printf_s("Escolha uma conversão do real Brazil para alguma moeda estrangeira: ");
	scanf_s("%lf", &opcaoReal);
	printf_s("Opções de conversões: Euro = 1, Dollar = 2, Chines = 3, Russo = 4 ");
	printf_s("Quanto você quer converter: ");
	scanf_s("lf", &brazilReal);

	double returnBrazilReal = operacaoEscolha(opcaoReal, brazilReal);

	return 0;

}

int operacaoEscolha(int opcaoReal, double brazilReal) {

	switch (opcaoReal)
	{
	case 1:
		brazilReal * 1.61;
		break;
	case 2:
		brazilReal * 2.56;
		break;
	case 3:
		brazilReal * 0.20;
		break;
	case 4: 
		brazilReal * 1.20;
		break;
	default:
		printf_s("Opção inválida");
		break;
	}

	return opcaoReal;

}