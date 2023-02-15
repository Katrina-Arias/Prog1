#include <stdio.h>
#include <stdlib.h>

int main()
{
    int cantidad, j = 1;

    printf("\nIngrese la cantidad del array: ");
    scanf("%d", &cantidad);

    int array1[cantidad], array2[cantidad], resul[cantidad];

    printf("\n Valores del primer array: ");

    for (int i = 0; i < cantidad; i++)
    {
        scanf("%d", &array1[i]);
    }

    printf("\n Valores del Segundo array: ");

    for (int i = 0; i < cantidad; i++)
    {
        scanf("%d", &array2[i]);
    }

    printf("\n Resultado de Suma: [");

    for (int i = 0; i < cantidad; i++)
    {
        resul[i] = array1[i] + array2[cantidad - j];
        printf("%d,", resul[i]);
        j++;
    }
    printf("]");

    return 0;
}
