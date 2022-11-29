// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int number = 0;
do
{
    Console.Write("Введите трехзначное число или напишите -1 для выхода: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 100 || number > 999);
if (number == -1) return;

int SecondDigit(int num)
{
    int secondDigit = (num % 100 - num % 10) / 10;
    return secondDigit;
}
Console.WriteLine($"Вторая цифра числа {number} -> {SecondDigit(number)}");
