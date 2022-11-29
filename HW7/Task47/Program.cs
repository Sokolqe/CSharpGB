// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
        }

    }
    return array;
}

void PrintMatrix(double[,] matr)
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

Console.Clear();
int[] index = EnterIndex("количество строк (m) и столбцов (n)");
double[,] matrix = CreateMatrixRndDouble(index[0], index[1], -10, 10);
PrintMatrix(matrix);