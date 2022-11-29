// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
int number = 0;
do
{
    Console.Write("Введите натуральное число больше единицы, или введите -1 для выхода из программы: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 1);
if (number == -1) return;

Console.WriteLine("-------------");
Console.WriteLine("  N  |  N^3  ");
Console.WriteLine("-------------");

for (int i = 1; i <= number; i++)
{
        Console.Write($"{i,3}  |");
        Console.WriteLine($"  {i * i * i, 3}");
}