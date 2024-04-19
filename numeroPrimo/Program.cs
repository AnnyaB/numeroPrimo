// 1. faça um programa que leia um numero (qualquer tipo) e informe se esse numero é primo;

int num = 0;
int div = 0;
int aux = 0;

do
{
    Console.WriteLine("NÚMEROS PRIMOS");
    Console.WriteLine("Digite um número positivo e maior que 1 e veja se ele é primo:");
    num = int.Parse(Console.ReadLine());

    if (num > 1)
    {
        for (int i = num; i > 0; i--)
        {
            div = num % i;
            if (div == 0)
            {
                aux++;
            }
        }
        if (aux == 2)
        {
            Console.WriteLine($"{num} é primo;");
        }
        else
        {
            Console.WriteLine($"{num} não é primo;");
        }
    }
}
while (num <= 1);
