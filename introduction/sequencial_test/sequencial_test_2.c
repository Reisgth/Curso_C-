#include <stdio.h>

int main() {
    double raio;

    scanf("%lf", &raio);

    raio *= raio;

    printf("%.4lf", raio*3.14159);

    return 0;
}