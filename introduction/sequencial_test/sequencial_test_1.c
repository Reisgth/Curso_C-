#include <stdio.h>
#include <stdlib.h>

int main()
{
    int idPiece1, quantityPiece1, idPiece2, quantityPiece2;
    double pricePiece1, pricePiece2, totalCost;

    scanf("%d %d %lf", &idPiece1, &quantityPiece1, &pricePiece1);
    scanf("%d %d %lf", &idPiece2, &quantityPiece2, &pricePiece2);

    totalCost = quantityPiece1*pricePiece1 + quantityPiece2*pricePiece2;

    printf("%.2lf", totalCost);

    return 0;
}