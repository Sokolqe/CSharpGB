// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] EnterIndex(string atr)
{
    Console.WriteLine($"Введите {atr}: ");
    Console.Write($"m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write($"n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"k = ");
    int k = Convert.ToInt32(Console.ReadLine());
    int[] indexes = new int[] { m, n, k };
    return indexes;
}

int[,,] CreateMatrixNoRepeatInt(int x, int y, int z, int min, int max)
{
    int[,,] array = new int[x, y, z];
    int size = max - min;
    int[] numbers = new int[size];
    Random rnd = new Random();
    int elem = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int p = 0; p < z; p++)
            {
                while (CheckNumber(numbers, elem) == false)
                {
                    elem = rnd.Next(min, max);
                }
                numbers[elem-10] = elem;
                array[i, j, p] = elem;
            }
        }
    }
    return array;
}

void PrintNumbers(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int p = 0; p < matr.GetLength(1); p++)
        {
            for (int j = 0; j < matr.GetLength(2); j++)
            {
                Console.Write($"{matr[i, p, j]}({i},{p},{j}) ");
            }
            Console.WriteLine();
        }
    }
}

bool CheckNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return false;
    }
    return true;
}

Console.Clear();
int[] size = EnterIndex("размеры массива (m, n, k)");
int[,,] matrix = CreateMatrixNoRepeatInt(size[0], size[1], size[2], 10, 100);
PrintNumbers(matrix);