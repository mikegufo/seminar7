// Задача 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void NewPrintMatrix(int[,] matrix, int a, int b, int row, int col)
{
    if (a > row && b > col)
        Console.WriteLine("Искомый элемент отсутствует");
    else
    {
        Console.WriteLine($"Значение элемента массива = {matrix[a, b]} ");
    }
}

// -----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int findRow = ReadInt("Ведите искомую строку: ");
int findCol = ReadInt("Ведите искомый столбец: ");
int[,] matrix = FillMatrix(rows, cols, 0, 100);
PrintMatrix(matrix);
NewPrintMatrix(matrix, findRow, findCol, rows, cols);