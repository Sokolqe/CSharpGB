// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write($"Искомые четные числа в диапозоне от 1 до {number}: ");
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}

// Есть способ проще, на мой взгляд:

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// Console.Write($"Искомые четные числа в диапозоне от 1 до {number}: ");
// while (count <= number)
// {
//     Console.Write($"{count} ");
//     count += 2;
// }

