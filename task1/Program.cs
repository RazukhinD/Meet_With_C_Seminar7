// **Задача 48:** Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

using static System.Console;
Clear();
Write("Введите рамер матрицы через пробел: ");
int[] size = GetArrayFromString(ReadLine()!);
int[,] resultmatrix = FillMatrix(size[0],size[1]);
PrintMatrix(resultmatrix);









int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[parames.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i]=Convert.ToInt32(parames[i]);
    }  
    return result;
}

// int[,] FillMatrix(int rows, int columns)
// {
//     int[,] matrix = new int[rows,columns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) ; j++)
//         {
//             matrix[i,j] = i+j;
//         }
//     }
//     return matrix;
// }


int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) ; j++)
        {
            matrix[i,j] =matrix.GetLength(0)-i+matrix.GetLength(1)-j-2;
        }
    }
    return matrix;
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