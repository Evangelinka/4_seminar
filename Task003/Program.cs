// Программа, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int ProductNumbers(int N)
{
    int result = 1;
    for (int number = 1; number <= N; number++)
    {
        result *= number;
    }
    return result;
}

void PrintProductNumbers(int N)
{
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {ProductNumbers(N)}");
}

PrintProductNumbers(4);
PrintProductNumbers(5);
