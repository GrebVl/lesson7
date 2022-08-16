/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int lines, int col)
{
    int[,] arr = new int[lines, col];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-100, 100);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SumArray(int[,] arr)
{
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        int count = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
            count++;
        }
        Console.Write(Math.Round(sum / count, 2) + "\t");
    }
}

Console.WriteLine("Введите количество строк и столбцов через пробел");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int column = int.Parse(input[1]);

int[,] UsArray = GetArray(row, column);
PrintArray(UsArray);
SumArray(UsArray);