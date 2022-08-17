// Программа, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int Sum(int a)
{
    int result = 0;
    for (int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

Console.WriteLine(Sum(5));
Console.WriteLine(Sum(1));

void PrintSum(int a)
{
    Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");
}

PrintSum(5);
PrintSum(1);