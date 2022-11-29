// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    if (num > 999)
    {
        do
        {
            num = num / 10;
        } while (num > 999);
    }
    else if (num < 100)
    {
        return -1;
    }
    int thirdDigit = num % 10;
    return thirdDigit;
}
if (ThirdDigit(number) == -1) Console.WriteLine($"У числа {number} нет третьей цифры");
else Console.WriteLine($"Третья цифра числа {number} -> {ThirdDigit(number)}");