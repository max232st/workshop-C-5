// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = new int[10];
FillArray(array);
Console.Write("-> ");
NumArray(number, array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
        Console.Write($"{arr[i]} ");
    }
}
void NumArray(int num, int[] arr) // 
{
    string check = "нет";
    foreach (int el in arr)
    {
        if (el == num)
        {
            check = "Да";
            break;
        }
    }
    Console.WriteLine(check);
}