using System;

namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sizeSquareMatrix = int.Parse(Console.ReadLine());
           char[,] charMatrix = new char[sizeSquareMatrix,sizeSquareMatrix];
            for (int row = 0; row < sizeSquareMatrix; row++)
            {
                char [] rowdata = Console.ReadLine().ToCharArray();
                for (int col = 0; col < sizeSquareMatrix; col++)
                {
                    charMatrix[row,col] = (char)rowdata[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            int cordinatsRow = 0;
            int cordinatsCol = 0;
            bool cordinatePrint = false;
            for (int row = 0; row < sizeSquareMatrix; row++)
            {
                for (int col = 0; col < sizeSquareMatrix; col++)
                {
                    if (charMatrix[row, col] == symbol)
                    {
                        cordinatsRow = row;
                        cordinatsCol = col;
                        cordinatePrint = true;
                    }
                }
            }
            if (cordinatePrint == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
            else
            {
                Console.WriteLine($"({cordinatsRow}, {cordinatsCol})");
            }
            
        }
    }
}
