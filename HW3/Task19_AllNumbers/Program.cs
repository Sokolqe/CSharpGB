// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int number = 0;
do
{
    Console.Write("Введите натуральное число или введите -1 для выхода из программы: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 0);
if (number == -1) return;
if (number < 10)
{
    Console.WriteLine($"Число {number} является палиндромом.");
    return;
}

string Palindrom(int num)
{
    int i = 0;
    int diff = num;
    do                                   // в этом цикле считаем разрядность
    {
        diff = diff / 10;
        i++;
    } while (diff > 0);
    int[] cifri = new int[i];            // инициализируем массив теперь уже известной длины

    i = 0;
    do                                   // в этом цикле забиваем каждый разряд в соответствующий элемент массива
    {
        cifri[i] = num % 10;
        num = num / 10;
        i++;
    } while (num > 0);

    for (i = 0; (i < (cifri.Length / 2)); i++) //в этом цикле движемся с обоих концов массива и сравниваем крайние элементы
    {
        if (cifri[i] != cifri[cifri.Length - (1 + i)]) // при первом же несовпадении выходим из метода
        {
            return "не является палиндромом";
        }
    }
    return "является палиндромом";
}

Console.WriteLine($"Число {number} {Palindrom(number)}");