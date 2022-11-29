// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void FindElem(int row, int col, int[,] matrix)
{
    if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с индексами [{row}, {col}] равен: {matrix[row,col]}");
    }
    else Console.WriteLine($"Элемента массива с индексами [{row}, {col}] не существует");
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
int[] size = EnterIndex("количество строк (m) и столбцов (n)");
int[,] matrix = CreateMatrixRndInt(size[0],size[1],0,10);
PrintMatrix(matrix);
int[] index = EnterIndex("номер строки (m) и номер столбца (n)");
FindElem(index[0], index[1], matrix);