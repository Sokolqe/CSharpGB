// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void FindMaximumAndReplace(int[,] matr, int row, int startPos)
{
    int max = matr[row, startPos];
    int maxIndex = startPos;
    for (int j = startPos; j < matr.GetLength(1); j++)
    {
        if (matr[row, j] > max)
        {
            max = matr[row, j];
            maxIndex = j;
        }
    }
    int temp = matr[row, startPos];
    matr[row, startPos] = max;
    matr[row, maxIndex] = temp;
}

void SortRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            FindMaximumAndReplace(matr, i, j);
        }
    }
}

Console.Clear();
int[] size = EnterIndex("количество строк (m) и столбцов (n)");
int[,] matrix = CreateMatrixRndInt(size[0], size[1], 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortRows(matrix);
PrintMatrix(matrix);