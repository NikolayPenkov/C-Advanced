using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
           int rows = sizes[0];
            int cols = sizes[1];
            var sum = 0;
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = int.Parse(rowData[col]);
                   sum += int.Parse(rowData[col]);
                }
            }

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write($"{matrix[row, col]} ");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
