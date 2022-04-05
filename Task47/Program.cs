/* Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] Generate2DArray(int m, int n)
{
    double[,] getArray = new double[m,n];
    for (int i = 0; i < getArray.GetLength(0); i++)
    {
        for (int j = 0; j < getArray.GetLength(1); j++)
        {
            getArray[i,j] = Convert.ToDouble(new Random().Next(-100, 101)/10.0);
        }
    }
    return getArray;
}

void PrintArray(double[,] getArray)
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

double[,] getArray = Generate2DArray(3, 4);
PrintArray(getArray);
