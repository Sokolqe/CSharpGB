// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

void FillMatrixAround(int[,] matr)
{
    int val = 0;
    int i = 0;
    int j = 0;
    do
    {
        for (; j < matr.GetLength(1) && matr[i, j] == 0; j++)
        {
            val++;
            matr[i, j] = val;
        }
        j--;
        i++;
        for (; i < matr.GetLength(0) && matr[i, j] == 0; i++)
        {
            val++;
            matr[i, j] = val;
        }
        i--;
        j--;
        for (; (j >= 0 && matr[i, j] == 0); j--)
        {
            val++;
            matr[i, j] = val;
        }
        j++;
        i--;
        for (; (i >= 0 && matr[i, j] == 0); i--)
        {
            val++;
            matr[i, j] = val;
        }
        i++;
        j++;
    } while (val != matr.GetLength(0) * matr.GetLength(1));
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

Console.Clear();
int[] size = EnterIndex("количество строк (m) и столбцов (n) для матрицы");
int[,] matrix = new int[size[0], size[1]];
PrintMatrix(matrix);
Console.WriteLine();
FillMatrixAround(matrix);
PrintMatrix(matrix);
