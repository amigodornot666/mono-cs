#include <stdio.h>

void swap(int *a, int *b)
{
	int c = *a;
	*a = *b;
	*b = c;
	printf("a: %d - b: %d\n", *a, *b);
}

int main()
{
	int x = 3;
	int y = 5;

	swap(&x, &y);
	printf("x: %d - y: %d\n", x, y);
	
	return 0;
}
