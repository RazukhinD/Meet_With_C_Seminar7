using static System.Console;
Clear();

WriteLine("Введите размер матрицы, минимальное и максимальное значение через пробел:  ");
int [] parameters = GetArrayForString(ReadLine()!);
int [,] matrix=GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);






int[,] GetMatrixArray(int rows,int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i=0; i<resultMatrix.GetLength(0);i++)
    {
        for (int j=0; j<resultMatrix.GetLength(1);j++)
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayForString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametersNum = new int[parames.Length];
    for (int i = 0; i < parametersNum.Length ; i++)
    {
        parametersNum[i]=int.Parse(parames[i]);
    }


    return parametersNum;

}