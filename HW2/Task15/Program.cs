// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int number = 0;
do 
{
    Console.WriteLine("Введите число, обозначающее день недели (от 1 до 7 включительно) или напишите -1 для выхода!");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1) break;
} while (number < 1 || number > 7);
if (number == -1) return;
if (number == 6 || number == 7) Console.WriteLine($"{number} день недели -> выходной");
else Console.WriteLine($"{number} день недели -> не выходной");