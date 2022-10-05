using System;
using System.Linq;
namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeSquareMatrix = int.Parse(Console.ReadLine());

            int[,] squareMatrix = new int[sizeSquareMatrix, sizeSquareMatrix];
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < sizeSquareMatrix; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizeSquareMatrix; col++)
                {
                    squareMatrix[row, col] = rowData[col];
                    if (col == row)
                    {
                        primaryDiagonal += squareMatrix[row, col];
                    }
                    
                    if (row == sizeSquareMatrix - col - 1)
                    {
                        secondaryDiagonal += squareMatrix[row, col];
                    }
                }
            }
            Console.WriteLine(primaryDiagonal);
            Console.WriteLine(secondaryDiagonal);
        }
    }
}
