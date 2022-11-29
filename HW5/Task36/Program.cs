// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100, 101);
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

int SumNeChet(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
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
int res = SumNeChet(mass);
Console.WriteLine($" -> сумма нечетных элементов массива равна {res}");