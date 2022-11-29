// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

int CountChet(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.Clear();
int size = 0;
do
{
    Console.Write("Введите длину массива или введите -1 для выхода из программы: ");
    size = Convert.ToInt32(Console.ReadLine());
    if (size == -1) break;
} while (size <= 0);
if (size == -1) return;

int[] mass = RandomArray(size);
PrintArray(mass);
int res = CountChet(mass);
Console.WriteLine($" -> количество четных элементов массива равняется {res}");

