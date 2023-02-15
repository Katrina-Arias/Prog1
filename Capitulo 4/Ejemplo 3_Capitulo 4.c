#include <stdio.h>

void f1(void);
int k = 5

void main (void)
{
    int for;
    for (I = 1; I <= 3; I++)
        f1();
}
void f1 (void)
{
    int K = 2;
    printf("\n\nEl valor de la variable local es: %d", K);
    ::K = ::K + K;
    printf("\nEl valor de la variable goblal es: %d", ::K);
}
