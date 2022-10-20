// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
FillArray(array);
Console.Write("-> ");
MaxMinArray(array);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, +100);
        Console.Write($"{arr[i]} ");
    }
}

void MaxMinArray(int[] arr)
{
    int minValue = arr[0];
    int maxValue = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
        else
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    Console.Write(maxValue - minValue);
}