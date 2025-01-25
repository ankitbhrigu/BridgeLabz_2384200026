
using System;

namespace Assignment04Level1
{
    class Copy2DArrayTo1D
    {
        static void Main(string[] args)
        {
            // Taking user input for number of rows and columns
            int rows, columns;

            while (true)
            {
                Console.Write("Enter the number of rows: ");
                if (int.TryParse(Console.ReadLine(), out rows) && rows > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            while (true)
            {
                Console.Write("Enter the number of columns: ");
                if (int.TryParse(Console.ReadLine(), out columns) && columns > 0)
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            // Create a 2D array (Matrix) with specified rows and columns
            int[,] matrix = new int[rows, columns];

            // Taking user input for matrix elements
            Console.WriteLine("Enter the elements of the matrix:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    while (true)
                    {
                        Console.Write($"Element at [{i + 1}, {j + 1}]: ");
                        if (int.TryParse(Console.ReadLine(), out int value))
                        {
                            matrix[i, j] = value;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                    }
                }
            }

            // Create a 1D array to store the elements of the 2D array
            int[] array1D = new int[rows * columns];

            // Variable to track the index in the 1D array
            int index = 0;

            // Copy elements from the 2D array to the 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array1D[index++] = matrix[i, j];
                }
            }

            // Display the 1D array
            Console.WriteLine("\nThe elements of the 1D array are:");
            for (int i = 0; i < array1D.Length; i++)
            {
                Console.Write(array1D[i] + " ");
            }

            Console.WriteLine();
        }
    }
}



