// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].  Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5 
Console.Clear();
int[] array = new int[123];
FillArray(array);
NumArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 999);
        Console.Write($"{arr[i]} ");
    }
}
void NumArray(int[] arr)
{
    int i = 0;
    foreach (int el in arr)
    {
        if (el >= 10 && el <= 99)
        {
            i++;
        }
    }
    Console.WriteLine($"\nчисло элементов от 10 до 99 = {i}");
}