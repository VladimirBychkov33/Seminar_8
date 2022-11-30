//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] array = GetArray(2, 2, 1, 4);
PrintArray(array);
Console.WriteLine();
int[,] array1 = GetArray(2, 2, 1, 4);
PrintArray(array1);
Console.WriteLine();

int[,] result =  MultiplicationMatrix(array,array1);
PrintArray(result);
 

int[,] MultiplicationMatrix(int[,] massiv, int[,] massiv1)
{
    int[,] newarray = new int[massiv.GetLength(0), massiv1.GetLength(1)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv1.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(1); k++)
            {
                newarray[i, j] = newarray[i, j] + massiv[i, k] * massiv1[k, j];
            }
        }

    }
    return newarray;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}