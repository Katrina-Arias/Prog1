#include <stdio.h>
#include <math.h>
/* Pares e impares.
El programa, al recibir como datos N n�meros enteros, calcula cu�ntos
? de ellos son pares y cu�ntos impares, con la ayuda de una funci�n. */
void parimp(int, int *, int *); /* Prototipo de funci�n. */
int main(void)
{
int I, N, NUM, PAR = 0, IMP = 0;
printf("Ingresa el numero de datos: ");
scanf("%d", &N);
for (I =1; I <= N; I++)
{
printf("Ingresa el numero %d:", I);
scanf("%d", &NUM);
parimp(NUM, &PAR, &IMP);
}
printf("\nNumero de pares: %d", PAR);
printf("\nNumero de impares: %d", IMP);
}
void parimp(int NUM, int *P, int *I)
{
int RES;
RES = pow(-1, NUM);
if (RES > 0)
*P += 1;
else
if (RES < 0)
*I += 1;
}
