// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4

using static System.Console;
Clear();
WriteLine("Введите размер матрицы, минимальное и максимальное значение через пробел:  ");
int [] parameters = GetArrayFromString(ReadLine()!);
int [,] matrix=FillMatrixStart(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
WriteLine();
int[,] matrixwithpow=ConvertMatrixwithPow(matrix);
PrintMatrix(matrixwithpow);





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


int[,] ConvertMatrixwithPow(int[,] matrix1)
{
    int[,] matrixfinish = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrixfinish.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrixfinish.GetLength(1) ; j++)
        {
            if (i%2==0 && j%2==0)
            {
                matrixfinish[i,j]=matrix1[i,j]*matrix1[i,j];
            }
            else
            {
                matrixfinish[i,j]=matrix1[i,j];
            }
        }
    }
    return matrixfinish;
}

