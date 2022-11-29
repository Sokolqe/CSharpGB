// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int number = 0;
do
{
    Console.Write("Введите целое положительное число или введите -1 для выхода из программы: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 0);
if (number == -1) return;

int Sum(int num)
{
    int summa = 0;
    for (int i = 0; num > 0; i++)
    {
        summa = summa + (num % 10);
        num = num / 10;
    }
    return summa;
}

int result = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {result}");