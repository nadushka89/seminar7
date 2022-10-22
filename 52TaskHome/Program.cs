/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод");
    return result;
}
int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(2, 10);
        }
    }
    return newArray;
}
(double, double, double, double, int) GetSummOfCol(int[,] matrix)
{
    double summ0 = 0;
    double summ1 = 0;
    double summ2 = 0;
    double summ3 = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
            {
                count = count + 1;
                summ0 += (matrix[i, j]);
            }
            if (j == 1)
            {
                summ1 += matrix[i, j];
            }
            if (j == 2)
            {
                summ2 += matrix[i, j];
            }
            if (j == 3)
            {
                summ3 += matrix[i, j];
            }
        }
    }
    return (summ0, summ1, summ2, summ3, count);
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = InitArray(4, 4);
PrintMatrix(matrix);
(double summ0, double summ1, double summ2, double summ3, int count) = GetSummOfCol(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {summ0 / count}, {summ1 / count}, {summ2 / count}, {summ3 / count}");
