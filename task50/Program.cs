/* 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
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

int CearchArray(int[,] arr, int indLin, int indCol)
{
    int des = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (i == (indLin - 1) && j == (indCol - 1))
            {
                des = arr[i, j];
                return des;
            }
    }
    return des;

}

Console.WriteLine("Введите количество строк и столбцов через пробел");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int column = int.Parse(input[1]);

Console.WriteLine("Введите номер строки и столбца искомого значения через пробел");
string[] index = Console.ReadLine().Split();
int indRow = int.Parse(index[0]);
int indColumn = int.Parse(index[1]);

int[,] UsArray = GetArray(row, column);
PrintArray(UsArray);
Console.WriteLine();

if (CearchArray(UsArray, indRow, indColumn) == 0)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    Console.WriteLine("Искомое число =" + CearchArray(UsArray, indRow, indColumn));
}