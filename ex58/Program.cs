//ex 58

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}


Console.Write("Введите кол-во строк первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов у первой матрицы и ");
Console.Write("это же число будет числом строк у второй матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = new int[n, m];
InputMatrix(matrix1);
PrintMatrix(matrix1);

int[,] matrix2 = new int[m, s];
InputMatrix(matrix2);
PrintMatrix(matrix2);

int[,] result = new int[n, s];

void UmnozhitMatrixs(int[,] matrix1, int[,] matrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
}

UmnozhitMatrixs(matrix1, matrix2, result);
Console.WriteLine("Произведение матриц:");
PrintMatrix(result);