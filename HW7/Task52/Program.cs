// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(min, max);
        }

    }
    return array;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < (matr.GetLength(1) - 1)) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine("]");
    }

}

int[] EnterIndex(string atr)
{
    Console.WriteLine($"Введите {atr}: ");
    Console.Write($"m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] indexes = new int[] { m, n };
    return indexes;
}

double[] AverageValueColumn(int[,] matr)
{
    double sum = 0;
    double[] result = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        result[j] = Math.Round(sum / matr.GetLength(0), 1, MidpointRounding.ToZero);
        sum = 0;
    }
    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}

Console.Clear();
int[] size = EnterIndex("количество строк (m) и столбцов (n)");
int[,] matrix = CreateMatrixRndInt(size[0], size[1], 0, 10);
PrintMatrix(matrix);
double[] average = AverageValueColumn(matrix);
Console.Write("Среднее арифметическое столбцов ->");
PrintArray(average);