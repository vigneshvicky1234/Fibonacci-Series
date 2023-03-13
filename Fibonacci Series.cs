// See https://aka.ms/new-console-template for more information

int a = 0;
int b = 1;
int i = 0;
while (i <= 5)
{
    int c = a + b;
    a = b;
    b = c;
    i++;
    Console.Write(c + " ");
}

