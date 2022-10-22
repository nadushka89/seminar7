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
double GetSummOfCol(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            //sum=sum / matrix.GetLength(0);
           
        }
        Console.Write($"Среднее арифметическое {j+1} столбца: {sum}/{matrix.GetLength(0)} = {sum / matrix.GetLength(0)} ");
    }
    return sum;
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
int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
Console.WriteLine();
int[,] matrix = InitArray(m, n);
PrintMatrix(matrix);
double sum = GetSummOfCol(matrix);
//Console.Write($"Среднее арифметическое каждого столбца:   ");