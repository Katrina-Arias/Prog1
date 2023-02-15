# include <stdio.h>

int mad(int);
int main(void)
{
int NUM, RES;
printf("\nIngresa el número: ");
scanf("%d", &NUM);
RES = mad(NUM);
printf("\nEl mayor divisor de %d es: %d", NUM, RES);
}
int mad(int N1)
{
	int I = (N1 / 2);

while (N1 % I)
I--;
return I;
}
