// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int size = 0;
do
{
    Console.Write("Введите длину массива или введите -1 для выхода из программы: ");
    size = Convert.ToInt32(Console.ReadLine());
    if (size == -1) break;
} while (size <= 0);
if (size == -1) return;

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0,100);   // вроде условились поставить предел от 0 до 99 включительно
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

int[] res = RandomArray(size);
PrintArray(res);