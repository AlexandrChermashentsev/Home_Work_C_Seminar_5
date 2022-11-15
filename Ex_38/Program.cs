/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между минимальным и максимальным элементами массива
[3, 7, 22, 2, 78] -> 76
*/

double[] InitArray(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(double, double) GetMinAndMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    return(min, max);
}

Console.WriteLine("Enter the length array");
int length = Convert.ToInt32(Console.ReadLine());

double[] array = InitArray(length);
PrintArray(array);

(double min, double max) = GetMinAndMax(array);
double result = max - min;
Console.WriteLine($"Difference between min and max: {result}");
