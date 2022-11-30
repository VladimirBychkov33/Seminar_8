// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] array = GetArray(3, 4, 1, 4);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элемнтов равен {SumRows(array)}");



int SumRows(int[,] massiv)
{
    int str = 0;
    int min = 0;
    for (int i = 0; i < massiv.GetLength(1); i++)  // двигаемся по 1-ой строке и получаем сумму ее элемнтов, что бы 
                                                    //потом сравнивать эту сумму с другими суммами остальных строк 
    {
        min = min + massiv[0, i];
    }

    for (int i = 1; i < massiv.GetLength(0); i++) // тут уже начинаем двигаться от второй строки (i=1)
    {
        int sum = 0;
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            sum = sum + massiv[i,j]; // находим сумму каждой строки
        }
        if(min > sum)
        {
            min= sum;
            str = i;
        }
    }
    return str;
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