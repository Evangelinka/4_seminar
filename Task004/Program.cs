// Программа, которая выводит массив из 8 элементов, заполненных нулями 
// и единицами в случайном порядке. [1, 0, 1, 1, 0, 1, 0, 0].

int[] ArrayZerosOnes(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}
void PrintArrayZerosOnes(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArrayZerosOnes(ArrayZerosOnes(8));