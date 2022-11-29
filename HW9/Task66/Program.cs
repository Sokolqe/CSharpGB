// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int[] EnterIndex(string atr)
{
    Console.WriteLine($"Введите {atr}: ");
    Console.Write($"M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] indexes = new int[] { m, n };
    return indexes;
}

int SumDigitsBetweenNumbers(int mDigit, int nDigit)
{
    if (mDigit > nDigit)
    {
        return nDigit + SumDigitsBetweenNumbers(mDigit, nDigit + 1);
    }
    if (mDigit < nDigit)
    {
        return nDigit + SumDigitsBetweenNumbers(mDigit, nDigit - 1);
    }
    return +mDigit;
}


int[] numbers = EnterIndex("значения M и N");
int sum = SumDigitsBetweenNumbers(numbers[0], numbers[1]);
Console.Write($"Сумма натуральных элементов в промежутке от M = {numbers[0]} до N = {numbers[1]}: {sum}");

