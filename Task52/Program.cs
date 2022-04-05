/* Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] Generate2DArray(int row, int col)
{
    int[,] getArray = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            getArray[i,j] = new Random().Next(1,10);
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

void ArithmeticMeanOfEachColumnInArray(int[,] getArray)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double arithmeticMean = new double();
    for (int i = 0; i < getArray.GetLength(1); i++)
    {
        arithmeticMean = 0;
        for (int j = 0; j < getArray.GetLength(0); j++)
        {
            arithmeticMean += getArray[j,i];
        }
        arithmeticMean /= getArray.GetLength(0);
        arithmeticMean = Math.Round(arithmeticMean, 1);
        if (i < getArray.GetLength(1) - 1)
        {
            Console.Write($"{arithmeticMean}; ");
        }
        else
        {
            Console.WriteLine($"{arithmeticMean}."); 
        }        
    }
}

int[,] getArray = Generate2DArray(3, 4);
PrintArray(getArray);
Console.WriteLine();
ArithmeticMeanOfEachColumnInArray(getArray);
