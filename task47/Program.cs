/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] GetArray(int lines, int col)
{
    double[,] arr = new double[lines, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.NextDouble() * 100 - 50;
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите число m и n черз пробел");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int column = int.Parse(input[1]);

double[,] UserArray = GetArray(row, column);
PrintArray(UserArray);


