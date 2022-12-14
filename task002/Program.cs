// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] array = new int[4];
FillArray(array);
//WriteArray(array);
Console.Write("-> ");
ReversArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
        Console.Write($"{arr[i]} ");
    }
}

// void WriteArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
void ReversArray(int[] arr)
{
    int i = 0;
    foreach (int el in arr)
    {
        arr[i] = el * -1;
        i++;

    }
    Console.WriteLine(string.Join(" ", arr));
}