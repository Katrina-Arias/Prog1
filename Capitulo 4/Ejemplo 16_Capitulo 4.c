#include <stdio.h>
#include <math.h>

int Acutem(float);
int Maxima(float, int);
int Minima(float, int);
float ACT = 0.0;
float MAX = -50.0;
float MIN = 60.0;
int HMAX;
int HMIN;
int main(void)
{
float TEM;
int I;
for (I = 1; I <= 24; I++)
{
printf("Ingresa la temperatura de la hora %d: ", I);
scanf("%f", &TEM);
Acutem(TEM);
Maxima(TEM, I);
Minima(TEM, I);
}
printf("\nPromedio del día: %5.2f", (ACT / 24));
printf("\nMáxima del día: %5.2f \tHora: %d", MAX, HMAX);
printf("\nMínima del día: %5.2f \tHora: %d", MIN, HMIN);
}
int Acutem(float T)

{
ACT += T;
}
int Maxima(float T, int H)

{
if (MAX < T)
{
MAX = T;
HMAX = H;
}
}
int Minima(float T, int H)
{
if (MIN > T)
{
MIN = T;
HMIN = H;
}
}
