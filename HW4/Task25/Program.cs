// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int number1 = 0;
do
{
    Console.Write("Введите число целое положительное число А или введите -1 для выхода из программы: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    if (number1 == -1) break;
} while (number1 < 0);
if (number1 == -1) return;

int number2 = 0;
do
{
    Console.Write("Введите число целое положительное число B или введите -1 для выхода из программы: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    if (number2 == -1) break;
} while (number2 < 0);
if (number2 == -1) return;
if (number1 >= 0 && number2 == 0)
{
    Console.WriteLine($"Число {number1} в степени {number2} -> 1");
    return;
}
if (number1 == 0 && number2 > 0)
{
    Console.WriteLine($"Число {number1} в степени {number2} -> 0");
    return;
}

int Pow(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}
int result = Pow(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} -> {result}");
