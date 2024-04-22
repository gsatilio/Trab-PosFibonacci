//1 - faça um programa que leia um numero inteiro e imprima até esta posição da sequencia fibonacci (ex 3 - 3 primeiro, 10 - 10 primeiros)
//só imprimir, usar laço, 0 nao entra

int anterior, atual, fibonacci, posicao;

while (true)
{
    anterior = -1;
    atual = 1;
    fibonacci = 0;
    posicao = 0;

    Console.WriteLine("Informe até qual posição do valor de Fibonacci que deseja visualizar:");
    posicao = int.Parse(Console.ReadLine());

    for (int i = 0; i <= posicao; i++)
    {
        fibonacci = anterior + atual;

        if (fibonacci > 0)
        {
            Console.Write($"{fibonacci} ");
        }
        anterior = atual;
        atual = fibonacci;
    }
    Console.WriteLine("\nAperte qualquer tecla para repetir o processo.");
    Console.ReadKey();
    Console.Clear();
}