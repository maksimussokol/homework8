// ex 62

Console.Clear();

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


Console.Write("Введите кол-во строк и столбцов спиральной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[n, n];

int i = 0, j = 0, temp = 0;

while (temp <= n * n)
{
    matrix1[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
}

PrintMatrix(matrix1);
