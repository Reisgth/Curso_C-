#include <stdio.h>

int main () {
    int qtdeValues, value, in=0, out=0, i;

    scanf("%d", &qtdeValues);

    for(i=0; i<qtdeValues; i++) {
        scanf("%d", &value);
        if(value < 10 || value > 20)
            out++;
        else
            in++;
    }

    printf("%d in\n", in);
    printf("%d out\n", out);

    return 0;
}