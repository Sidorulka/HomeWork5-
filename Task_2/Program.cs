// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
        }
        return sum;
}

int rows = ReadInt("Введите число строк");
int columns = ReadInt("Введите число столбцов");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    if (sum > SumLine(array, i))
    {
        sum = SumLine(array, i);
        minSum = i+1;
        }
}

Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");






