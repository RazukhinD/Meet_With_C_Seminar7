// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

WriteLine("Введите размер матрицы, минимальное и максимальное значение через пробел:  ");
int [] parameters = GetArrayForString(ReadLine()!);
int [,] matrix=GetMatrixArray(parameters[0],parameters[1],parameters[2],parameters[3]);
PrintMatrix(matrix);
WriteLine("среднее арифмитические каждго столба равны");
double[] averageeverycolumns = AverageEveryColumns(matrix);
for (int j = 0; j < averageeverycolumns.Length; j++)
        {
            Write($"{averageeverycolumns[j]}\t");
        }






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
            Write($"{inMatrix[i,j]}\t");
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

double [] AverageEveryColumns(int[,] Matrix)
{
    double[] average = new double[Matrix.GetLength(1)];
    for (int j = 0; j < average.Length; j++)
    {
        double summ = 0;
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            summ = summ + Matrix[i,j];
        }
        average[j] =Math.Round(summ/Matrix.GetLength(0),1);
    }
    return average;
}