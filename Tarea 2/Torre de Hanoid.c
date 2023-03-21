#include <stdio.h>
#include <stdlib.h>

/*Aqui se incluye la libreria estandar de C que provee 
funciones para entrada y salida de datos.*/

void hanoi(int n, char origen, char destino, char auxiliar);

/*Esta linea define la funcion "hanoi". Recibe cuatro parametros: 
el numero de discos "n", las torres "origen", "destino" y "auxiliar".*/


int main()

/*Esta es la funcion principal del programa. Aqui se pide al usuario 
que ingrese el numero de discos que desea mover y se llama a la funcipn "hanoi".*/

{
    int n;

    printf("Ingrese el n�mero de discos: ");

    /*Esta linea muestra un mensaje en la pantalla para que el 
    usuario ingrese el numero de discos que desea mover.*/
    scanf("%d", &n);

    /*Esta linea utiliza la funcion "scanf" para leer el numero de 
    discos ingresado por el usuario y lo guarda en la variable "n".*/

    hanoi(n, 'A', 'C', 'B'); // 'A': torre origen, 'C': torre destino, 'B': torre auxiliar

    /*Esta linea llama a la funcion "hanoi" con los parametros correspondientes: el numero 
    de discos ingresado por el usuario, la torre "A" como origen, la torre "C" 
    como destinoy la torre "B" como auxiliar.*/


    return 0;
}

void hanoi(int n, char origen, char destino, char auxiliar) /*Aqui se define la funcion "hanoi". 
Como se menciono antes, recibe cuatro parametros: el numero de discos "n" las torres "origen", "destino" y "auxiliar"*/
{
    if (n == 1) {
        printf("Mover disco 1 de %c a %c\n", origen, destino); /*Si el numero de discos es 1, el programa simplemente 
        mueve el disco desde la torre origen a la torre destino.*/
        return;
    }

    hanoi(n-1, origen, auxiliar, destino);
    printf("Mover disco %d de %c a %c\n", n, origen, destino); /*Esta linea muestra en la pantalla el movimiento
     que se ha realizado, indicando la torre origen y la torre destino.*/
    hanoi(n-1, auxiliar, destino, origen);
}