/*
Задача 36: Задайте одномерный массив, заполненый случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitialArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

int SummOddIndex(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) summ+= array[i];
    }
    return summ;
}

Console.WriteLine("Enter length array");
int length = int.Parse(Console.ReadLine());

int[] array = InitialArray(length);
PrintArray(array);

int result = SummOddIndex(array);
Console.WriteLine($"Sum of odd numbers: {result}");
