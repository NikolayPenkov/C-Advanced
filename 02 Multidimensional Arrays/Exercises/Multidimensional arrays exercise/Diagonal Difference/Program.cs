using System;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            var primaryDiagonal = 0;
            var secondaryDiagonal = 0;
            for (int row = 0; row < size; row++)
            {
                string [] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                {
                    int currRowData = int.Parse(rowData[col]);
                    matrix[row, col] = currRowData;
                    if (row == col)
                    {
                        primaryDiagonal += matrix[row, col];
                    }
                    if (row + col == size - 1)
                    {
                        secondaryDiagonal += matrix[row, col];
                    }
                }
            }
            var sum = Math.Abs(primaryDiagonal - secondaryDiagonal);
            //Console.WriteLine(Math.Abs(primaryDiagonal));
            //Console.WriteLine(Math.Abs(secondaryDiagonal));
            Console.WriteLine(sum);
        }
    }
}
