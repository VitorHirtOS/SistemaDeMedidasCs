#include <stdio.h>
#include <string>
#include <math.h>
#include <locale.h>
#include <tchar.h>

double RealBrazil(int opcaoReal, double brazilReal) {

	printf_s("Escolha uma convers�o do real Brazil para alguma moeda estrangeira: ");
	scanf_s("%lf", &opcaoReal);
	printf_s("Op��es de convers�es: Euro = 1, Dollar = 2, Chines = 3, Russo = 4 ");
	printf_s("Quanto voc� quer converter: ");
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
		printf_s("Op��o inv�lida");
		break;
	}

	return opcaoReal;

}