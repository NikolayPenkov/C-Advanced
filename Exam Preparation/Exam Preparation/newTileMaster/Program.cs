using System;

namespace newTileMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            char[,] squareMatrix = new char[size, size];
            int currCol = 0;
            int currRow = 0;
            
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
            
            while (command != "end" && electrecuted == false)
            {
                int prevCurrRow = currRow;
                int prevCurrCol = currCol;
                switch (command)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                }
                if (currCol>= 0 && currCol < size || currRow >= 0 && currRow < size)
                {
                    if (squareMatrix[currRow, currCol] == '-')
                    {
                        squareMatrix[currRow, currCol] = '*';
                        countHoles++;
                    }
                    else if (squareMatrix[currRow, currCol] == 'R')
                    {
                        countRodes++;
                        Console.WriteLine("Vanko hit a rod!");
                        currRow = prevCurrRow;
                        currCol = prevCurrCol;
                    }
                    else if (squareMatrix[currRow, currCol] == 'C')
                    {
                        squareMatrix[currRow, currCol] = 'E';
                        countHoles++;
                        electrecuted = true;
                    }
                    else if (squareMatrix[currRow, currCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                    }
                }
                else
                {
                    currRow = prevCurrRow;
                    currCol = prevCurrCol;
                }
                //squareMatrix[currRow, currCol] = 'V';
                //Console.WriteLine(new String('-', 55));

                command = Console.ReadLine().ToLower();
            }
            if (electrecuted == true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHoles} hole(s).");
            }
            else
            {
                squareMatrix[currRow, currCol] = 'V';
                Console.WriteLine($"Vanko managed to make {countHoles} hole(s) and he hit only {countRodes} rod(s).");
            }

            for (int row = 0; row < size; row++) // print Matrix
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(squareMatrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
