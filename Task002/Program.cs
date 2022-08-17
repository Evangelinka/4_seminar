// Программа, которая принимает на вход число, и выдает количество цифр в числе

int NumberDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}

void printNumberDigits(int number)
{
    Console.WriteLine($"Количество цифр в числе {number} равна {NumberDigits(number)}");
}

printNumberDigits(1234);
printNumberDigits(12345678);
printNumberDigits(1);

