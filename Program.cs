using System;

namespace matrixGhostHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm run = new Algorithm();

            int[][] testData = new int[3][];

            testData[0] = new int[] { 0, 1, 1, 2 };

            testData[1] = new int[] { 0, 5, 0, 0 };

            testData[2] = new int[] { 2, 0, 3, 3 };

            int result = run.matrixElementsSum(testData);

            Console.WriteLine("Expected = 9");

            Console.WriteLine("Result = {0}", result);
        }
    }

    class Algorithm
    {
        public int matrixElementsSum(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            int sum = 0;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (matrix[j][i] != 0)
                    {
                        sum = sum + matrix[j][i];
                    }
                    else
                        break;
                }
            }
            return sum;
        }

    }
}
