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


void NewPrintMatrix(int[,] matrixForPrint, int row, int col)
{
    for (int j = 0; j < matrixForPrint.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrixForPrint.GetLength(0); i++)
        {
            sum += matrixForPrint[i, j];
        }
        sum = sum / matrixForPrint.GetLength(0);
        System.Console.Write(Math.Round(sum, 1) + "\t");
    }
}
// -----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 10);
PrintMatrix(matrix);
NewPrintMatrix(matrix, rows, cols);
