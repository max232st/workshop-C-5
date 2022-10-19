// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
FillArray(array);
NumArray(array);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write($"{arr[i]} ");
    }
}
void NumArray(int[] arr)
{
    int num = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            num++;
        }
    }
    Console.Write($"-> {num}");
}