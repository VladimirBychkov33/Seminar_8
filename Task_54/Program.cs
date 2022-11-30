// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
int[,] newarray = SelectionSort(array);
PrintArray(newarray);

int[,] SelectionSort(int[,] massiv)
{
   int[,] result = new int[massiv.GetLength(0),massiv.GetLength(1)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(1) -1; k++)
            {
                if(massiv[i,k] < massiv[i, k+1])
                {
                    int temporary = massiv[i,k+1];
                    massiv[i,k+1] = massiv[i, k];
                    massiv[i, k] = temporary;
                }
                
            }
        }
    }
    return massiv;
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

