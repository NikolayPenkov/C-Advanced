using System;
using System.Linq;

namespace Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            char[,] squareMatrix = new char[size, size];
            int currCol = 0;
            int currRow = 0;
            int prevCurrRow = 0;
            int prevCurrCol = 0;
            int countHoles = 0;
            int countRodes = 0;
            for (int row = 0; row < size; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    squareMatrix[row, col] = rowData[col];
                    if (squareMatrix[row, col] == 'V')
                    {
                        currRow = row;
                        currCol = col;
                        squareMatrix[row, col] = '*';
                        countHoles++;
                    }
                }
            }
            bool electrecuted = false;
            string command = Console.ReadLine().ToLower();
            while (command != "end" && electrecuted == true)
            {
                switch (command)
                {
                    case "up":
                        prevCurrCol = currCol;
                        currCol--;
                        if (squareMatrix[currRow, currCol] == '-')
                        {
                            squareMatrix[currRow, currCol] = '*';
                            countHoles++;
                        }
                        else if (squareMatrix[currRow, currCol] == 'R')
                        {
                            squareMatrix[currRow, currCol] = squareMatrix[currCol, prevCurrCol];
                            countRodes++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (squareMatrix[currRow, currCol] == 'E')
                        {
                            squareMatrix[currRow, currCol] = '*';
                            countHoles++;
                            electrecuted = true;
                         
                        }
                        else if (squareMatrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow},{currCol}]!");
                        }
                        break;
                    case "down":
                        prevCurrCol = currCol;
                        currCol++;
                        if (squareMatrix[currRow, currCol] == '-')
                        {
                            squareMatrix[currRow, currCol] = '*';
                        }
                        else if (squareMatrix[currRow, currCol] == 'R')
                        {
                            squareMatrix[currRow, currCol] = squareMatrix[currRow, prevCurrCol];
                            countRodes++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (squareMatrix[currRow, currCol] == 'E')
                        {
                            squareMatrix[currRow, currCol] = '*';
                            countHoles++;
                            electrecuted = true;

                        }
                        else if (squareMatrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow},{currCol}]!");
                        }
                        break;
                    case "left":
                        prevCurrRow = currRow;
                        currRow--;
                        if (squareMatrix[currRow, currCol] == '-')
                        {
                            squareMatrix[currRow, currCol] = '*';
                        }
                        else if (squareMatrix[currRow, currCol] == 'R')
                        {
                            squareMatrix[currRow, currCol] = squareMatrix[prevCurrRow, currCol];
                            countRodes++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (squareMatrix[currRow, currCol] == 'E')
                        {
                            squareMatrix[currRow, currCol] = '*';
                            countHoles++;
                            electrecuted = true;

                        }
                        else if (squareMatrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow},{currCol}]!");
                        }
                        break;
                    case "right":
                        prevCurrRow = currRow;
                        currRow++;
                        if (squareMatrix[currRow, currCol] == '-')
                        {
                            squareMatrix[currRow, currCol] = '*';
                        }
                        else if (squareMatrix[currRow, currCol] == 'R')
                        {
                            squareMatrix[currRow, currCol] = squareMatrix[prevCurrRow, currCol];
                            countRodes++;
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (squareMatrix[currRow, currCol] == 'E')
                        {
                            squareMatrix[currRow, currCol] = '*';
                            countHoles++;
                            electrecuted = true;

                        }
                        else if (squareMatrix[currRow, currCol] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow},{currCol}]!");
                        }
                        break;
                }
                command = Console.ReadLine().ToLower();
            }
            if (electrecuted == true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {countHoles} hole(s) and he hit only {countRodes} rod(s).");
            }
            for (int row = 0; row < size; row++) // print Matrix
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(squareMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
