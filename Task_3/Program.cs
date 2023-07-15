// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int[,] CreateArr(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(0, 10);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");

        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

void MultiplyArr(int[,] firstArr, int[,] secondArr, int[,] resultArr)
{
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int m = 0; m < firstArr.GetLength(1); m++)
            {
                sum += firstArr[i,m] * secondArr[m,j];
            }
            resultArr[i,j] = sum;
        }
    }
}

int rows = ReadInt("Введите число строк 1-й матрицы");
int columnsRows = ReadInt("Введите число столбцов 1-й матрицы и число строк 2-й матрицы");
int[,] matrix1 = CreateArr(rows, columnsRows);
Console.WriteLine("Первая матрица");
ShowArray(matrix1);
int columns2 = ReadInt("Введите число столбцов 2-й матрицы");
int[,] matrix2 = CreateArr(columnsRows, columns2);
Console.WriteLine("Вторая матрица");
ShowArray(matrix2);
int[,] resultMatrix = new int[rows, columnsRows];
MultiplyArr(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение матриц равно: ");
ShowArray(resultMatrix);