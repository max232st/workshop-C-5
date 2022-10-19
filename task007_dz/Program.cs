// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
FillArray(array);
Console.Write("-> ");
SumOddArray(array);
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, +100);
        Console.Write($"{arr[i]} ");
    }
}
void SumOddArray(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count = count + arr[i];
    }
    Console.Write(count);
}