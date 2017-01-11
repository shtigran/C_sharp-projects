#pragma warning(disable: 4996)


#include <stdio.h>
#include <stdlib.h>
#include <cstdio>
// программа для посика слова в файла

void func(FILE *f, char *);

int main()
{
	char * word = "<name>";
	FILE *f = fopen ("file.txt", "r");

	func(f, word);


	return 0;
}

void func(FILE *f, char * word)
{
	int i = 0, j = 0;
	while (getc(f) != EOF)
			++i;
	printf("\n%i\n", i);

	fseek(f, 0, SEEK_SET);


	char * text = (char *) malloc((i + 1) * sizeof(char));
	for (j; j < i, text[j] = getc(f) != EOF; j++)
	{
		printf("%c", getc(f));
	}
	text[i] = '\0';



	int k;
	for (k = 0; k <= i; k++)
		printf("%c", text[k]);

	}