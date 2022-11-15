/*
Задача 34: Задайте массив, заполненный случайными положительными трехзначными числами. 
Напишите программу, которая покажет количество четных чисел в массиве
[345, 897, 568, 234] -> 2
*/

int[] InitArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int QuantityEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0) result++;
    }
    return result;
}

Console.WriteLine("Enter length array");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = InitArray(length);
PrintArray(array);
int result = QuantityEvenNumbers(array);
Console.WriteLine($"Quantity even numbers: {result}");

