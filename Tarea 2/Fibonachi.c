#include <stdio.h>
#include <stdlib.h>

// Prototipo de funcion
void bimonachi(int n);

int main() {
    int n;

    printf("Ingrese el numero de elementos de la sucesion de Bimonachi que desea calcular: ");
    scanf("%d", &n);

    printf("\nSucesion de Bimonachi de %d elementos:\n", n);
    bimonachi(n);

    return 0;
}

// Definicion de funciun
void bimonachi(int n) {
    int i, b1 = 1, b2 = 2, temp;

    printf("%d %d ", b1, b2);  // Imprime los primeros dos elementos

    for (i = 3; i <= n; i++) {
        temp = b2;  // Guarda el valor de b2 en una variable temporal
        b2 = b2 + b1;  // Calcula el siguiente valor de b2
        b1 = temp;  // Asigna el valor temporal a b1 para calcular el siguiente valor de b2
        printf("%d ", b2);  // Imprime el valor de b2
    }
    printf("\n");
}
//En la primera linea, se incluye la biblioteca stdio.h, que es necesaria para poder usar las funciones de entrada y salida estandar de C.
//Se define el prototipo de la funcion bimonachi, que se encarga de calcular y mostrar los elementos de la sucesion de Bimonachi.
//En la funcion main, se declaran las variables necesarias para el programa y se solicita al usuario el numero de elementos que desea calcular.
//Se imprime un mensaje para indicar que se mostrara la sucesion de Bimonachi de N elementos.
//Se llama a la funcion bimonachi con el valor ingresado por el usuario como argumento.
//La funcion bimonachi recibe un entero que indica la cantidad de elementos que se deben calcular y mostrar.
//Se declaran las variables i, b1 y b2. Las variables b1 y b2 representan los dos primeros elementos de la sucesion.
//Se imprimen los dos primeros elementos.
//Se utiliza un bucle for para calcular y mostrar los siguientes elementos de la sucesion. El bucle comienza en i = 3, ya que los primeros dos elementos ya se imprimieron.
//Se guarda el valor de b2 en una variable temporal temp.
//Se calcula el siguiente valor de b2 sumando b1 al valor anterior de b2.
//Se asigna el valor temporal a b1, ya que el siguiente valor de b2 dependera del valor anterior de b1.
//Se imprime el valor de b2.
//Despues de que el bucle haya terminado, se imprime un salto de linea para separar la salida de la sucesion de Bimonachi de otros mensajes del programa./