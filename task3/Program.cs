// * Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using static System.Console;
Clear();
WriteLine("Введите размер матрицы, минимальное и максимальное значение через пробел:  ");
int [] parameters = GetArrayFromString(ReadLine()!);
int [,] matrix=FillMatrixStart(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
int summmaindiag = SummElementMainDiagonal(matrix);
WriteLine($"Сумма элементов главной диагонали равна: {summmaindiag} ");






int[] GetArrayFromString(string parameters)
{
    string[] param = parameters.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[param.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=Convert.ToInt32(param[i]);
    }
    return result;
}

int[,] FillMatrixStart(int rows,int columns,int minValue,int maxValue)
{
    int[,] matrixstart = new int[rows,columns];
    for (int i = 0; i < matrixstart.GetLength(0); i++)
    {
        for (int j = 0; j < matrixstart.GetLength(1) ; j++)
        {
            matrixstart[i,j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return matrixstart;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]}\t");
        }
        WriteLine();
    }
}


int SummElementMainDiagonal(int[,] matrix1)
{
    int summ = 0;
    int temp = matrix1.GetLength(0);
    if (matrix1.GetLength(0)>matrix1.GetLength(1))
    {
        temp = matrix1.GetLength(1);
    }
    for (int i = 0; i < temp ; i++)
    {
        // for (int j = 0; j < matrix1.GetLength(1) ; j++)
        // {
        //     if (i==j)
        //     {
        //         summ=summ+matrix1[i,j];
        //     }
        // }
        summ=summ+matrix1[i,i];
    }
    
    return summ;
}
