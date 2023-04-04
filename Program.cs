//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double [rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);
    return array;
}
void Prit2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение индекса: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение индекса: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = Create2DRandomArray(rows, columns, minValue, maxValue);
Prit2DArray(randomArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет

int[,] Create2DRandomArray1()
{
    int[,] array = new int[5, 5];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    return array;
}
bool Check2DArray(int[,] arr, int row, int col) => row <= arr.GetLength(0) && col <= arr.GetLength(1);
void Prit2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
Console.Write("Enter a row position: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a column position: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = Create2DRandomArray1();
Prit2DArray(arr);
bool result = Check2DArray(arr, row, column);
if (result) Console.WriteLine($"Значение индекса [{row},{column}] равно: {arr[row-1,column-1]}");
else Console.WriteLine($"Указанная позиция отсутствует");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

double[] FindAverageInColumns(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, j];
        newArray[j] = sum / array.GetLength(0);
    }
    return newArray;
}

void Prit2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void PritArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(Math.Round(array[i], 2) + "  ");
}

Console.Write("Enter rows amount: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns amount: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimum index value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximum index value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
int[,] array = Create2DRandomArray(row, column, minValue, maxValue);
double[] averageArray = FindAverageInColumns(array);
Prit2DArray(array);
Console.WriteLine();
PritArray(averageArray);
*/