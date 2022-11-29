// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] mult = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int k = 0; k < matr2.GetLength(1); k++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                mult[i, k] += matr1[i, j] * matr2[j, k];
            }
        }
    }
    return mult;
}

Console.Clear();
int[] size1 = EnterIndex("количество строк (m) и столбцов (n) для первой матрицы:");
int[,] matrix1 = CreateMatrixRndInt(size1[0], size1[1], 0, 10);
int[] size2 = EnterIndex("количество строк (m) и столбцов (n) для второй матрицы:");
int[,] matrix2 = CreateMatrixRndInt(size2[0], size2[1], 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
if (size1[1] != size2[0]) Console.WriteLine("Невозможно вычислить произведение двух матриц");
else
{
    int[,] result = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица равна:");
    PrintMatrix(result);
}