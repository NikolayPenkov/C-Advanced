using System;


namespace Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string [] rowData = Console.ReadLine().Split(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }
            int subMatrixRow = 2;
            int subMatrixCol = 2;
            int maxSum = 0;

            int squareStartRow = 0;
            int squareStartCol = 0;
            for (int row = 0; row < rows - subMatrixRow + 1; row++)
            {
                for (int col = 0; col < cols - subMatrixCol + 1; col++)
                {
                    int sum =0;
                    sum += matrix[row, col];
                    sum += matrix[row + 1, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        squareStartRow = row;
                        squareStartCol = col;
                        maxSum = sum;
                        //topLeft = matrix[row, col];
                        //topRight = matrix[row + 1, col];
                        //bottomLeft = matrix[row, col + 1];
                        //bottomRight = matrix[row + 1, col + 1];
                    }
                }
            }
            //Console.WriteLine($"{topLeft} {topRight}");
            //Console.WriteLine($"{bottomLeft} {bottomRight}");
            Console.WriteLine($"{matrix[squareStartRow, squareStartCol]} {matrix[squareStartRow, squareStartCol + 1]}");
            Console.WriteLine($"{matrix[squareStartRow + 1, squareStartCol]} {matrix[squareStartRow + 1, squareStartCol + 1]}");
            Console.WriteLine(maxSum);

        }
    }
}
