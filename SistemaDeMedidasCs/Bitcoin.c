#include <stdio.h>
#include <math.h>
#include <locale.h>
#include <tchar.h>
#include <string>
#include "FunctionSystem.h"

double ConversaoBitcoin(double valueC) {

	printf("Escreva o n�mero para convers�o: ");
	scanf("%lf", &valueC);

	double valueBitcoin = bitcoin(valueC);

	return 0;
}

double bitcoin(double valueC) {

	return valueC * 0.001;

}