#include <stdio.h>

int main() {
    int idItem, qtdeItem;

    scanf("%d %d", &idItem, &qtdeItem);

    switch (idItem)
    {
    case 1:
        printf("%.2lf", qtdeItem * 4.0);
        break;

    case 2:
        printf("%.2lf", qtdeItem * 4.50);
        break;
        
    case 3:
        printf("%.2lf", qtdeItem * 5.0);
        break;

    case 4:
        printf("%.2lf", qtdeItem * 2.0);
        break;

    case 5:
        printf("%.2lf", qtdeItem * 1.50);
        break;
    }

    return 0;
}