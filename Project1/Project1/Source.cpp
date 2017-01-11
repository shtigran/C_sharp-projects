#include <stdlib.h>
#include <stdio.h>





// Программа для поиска из файла
void func(FILE *f, char *);

int main()
{
	char * word = "<name>";
	FILE *f = fopen("file", "r");

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


	char * text = (char *)malloc((i + 1) * sizeof(char));
	for (j; j < i, text[j] = getc(f) != EOF; j++)
	{
		printf("%c", getc(f));
	}
	text[i] = '\0';



	int k;
	for (k = 0; k <= i; k++)
		printf("%c", text[k]);


	int count = 0;
	while (word[count] != '\0')
		++count;

	j = 0;
	k = 0;
	int x, y;
	for (j; j < i; j++)
	{ if (word[k] == text[j])
		{
			x = k;
			y = j;
			while (word[x] == text[y])
			{
				x++;
				y++;
				if (x == count)
				{
					while (text[++y] != '<')
					printf("%c", text[y]);
					printf("\n");
				}
			}
		}
			j++;
			k = 0;
		}

	
}