/* Задача 50: Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int[,] Generate2DArray(int row, int col)
{
    int[,] getArray = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            getArray[i,j] = new Random().Next(0,101);
        }
    }
    return getArray;
}

void PrintArray(int[,] getArray)
{
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            Console.Write($"{getArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void FindArrayElement(int[,] getArray, int rowNumber, int colNumber)
{
    if (getArray.GetLength(0) - 1 < rowNumber || getArray.GetLength(1) - 1 < colNumber)
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
    else
    {
        Console.WriteLine($"Элемент на данной позиции: {getArray[rowNumber,colNumber]}");
    }
}

Console.Write("Введите количество строк двухмерного массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите количество столбцов двухмерного массива: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] getArray = Generate2DArray(row, col);
PrintArray(getArray);
Console.WriteLine();

Console.Write("Введите строку элемента: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите столбец элемента: ");
int colNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FindArrayElement(getArray, rowNumber, colNumber);
