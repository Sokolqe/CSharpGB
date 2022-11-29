// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int number = 0;
do
{
    Console.Write("Введите пятизначное число или введите -1 для выхода из программы: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 10000 || number > 99999);
if (number == -1) return;

string Palindrom(int num)
{
    bool res1 = (num / 10000 == num % 10);
    bool res2 = (((num / 1000) % 10) == ((num / 10) % 10));
    if (res1 == true && res2 == true) return "является палиндромом.";
    return "не является палиндромом.";
}

Console.WriteLine($"Число {number} {Palindrom(number)}");