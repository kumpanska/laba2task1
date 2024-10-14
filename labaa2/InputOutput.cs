using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa2
{
    internal class InputOutput
    {
        public void Output()
        {
            while (true)
            {
                Console.WriteLine("Choose type of matrix(1-5) or operations(6-7) or exit the program(0)");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Exit the program");
                    break;
                }
                switch (n)
                {
                    case 1:
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[] numbers = Console.ReadLine().Split(' ');
                        int rows = Convert.ToInt32(numbers[0]);
                        int cols = Convert.ToInt32(numbers[1]);
                        double[,] matrix1 = new double[rows, cols];
                        Console.WriteLine("Enter matrix elements (separated by spaces):");
                        for (int i = 0; i < rows; i++)
                        {
                            string[] elements = Console.ReadLine().Split(' ');
                            for (int j = 0; j < cols; j++)
                            {
                                matrix1[i, j] = Convert.ToDouble(elements[j]);
                            }
                        }
                        MyMatrix myMatrix1 = new MyMatrix(matrix1);
                        Console.WriteLine("Matrix from 2D array");
                        Console.WriteLine(myMatrix1.ToString());
                        myMatrix1.TransponeMe();
                        Console.WriteLine("Transposed matrix from 2D array:");
                        Console.WriteLine(myMatrix1.ToString());
                        break;
                    case 2:
                        Console.Write("Enter the number of rows for the jagged array: ");
                        rows = Convert.ToInt32(Console.ReadLine());
                        double[][] jagged = new double[rows][];
                        for (int i = 0; i < rows; i++)
                        {
                            string[] elements = Console.ReadLine().Split(' ');
                            jagged[i] = new double[elements.Length];
                            for (int j = 0; j < elements.Length; j++)
                            {
                                jagged[i][j] = Convert.ToDouble(elements[j]);
                            }
                        }
                        MyMatrix myMatrix2 = new MyMatrix(jagged);
                        Console.WriteLine("Matrix from jagged array");
                        Console.WriteLine(myMatrix2.ToString());
                        myMatrix2.TransponeMe();
                        Console.WriteLine("Transposed jagged matrix:");
                        Console.WriteLine(myMatrix2.ToString());
                        break;
                    case 3:
                        Console.Write("Enter the number of rows for the string array: ");
                        rows = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter elements");
                        string[] strArray = new string[rows];
                        for (int i = 0; i < rows; i++)
                        {
                            strArray[i] = Console.ReadLine();
                        }
                        MyMatrix myMatrix3 = new MyMatrix(strArray);
                        Console.WriteLine("Matrix from string array");
                        Console.WriteLine(myMatrix3.ToString());
                        myMatrix3.TransponeMe();
                        Console.WriteLine("Transposed matrix from string array:");
                        Console.WriteLine(myMatrix3.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Enter the matrix data (separated by spaces and rows by \\n): ");
                        string str = Console.ReadLine();
                        str = str.Replace("\\n", Environment.NewLine);
                        MyMatrix myMatrix4 = new MyMatrix(str);
                        Console.WriteLine("Matrix from string");
                        Console.WriteLine(myMatrix4.ToString());
                        myMatrix4.TransponeMe();
                        Console.WriteLine("Transposed matrix from string:");
                        Console.WriteLine(myMatrix4.ToString());
                        break;
                    case 5:
                        double[,] array = { { 1, 0, 5 }, { 14, 32, 134 } };
                        MyMatrix origMatrix = new MyMatrix(array);
                        Console.WriteLine("Origin matrix");
                        Console.WriteLine(origMatrix.ToString());
                        MyMatrix copyMatrix = new MyMatrix(origMatrix);
                        Console.WriteLine("Matrix from copy of other instance");
                        Console.WriteLine(copyMatrix.ToString());
                        copyMatrix.TransponeMe();
                        Console.WriteLine("Transposed matrix:");
                        Console.WriteLine(copyMatrix.ToString());
                        break;
                    case 6:
                        Console.WriteLine("First matrix");
                        double[,] arr1 = { { 5, 34 }, { 3, 4 } };
                        MyMatrix m1 = new MyMatrix(arr1);
                        Console.WriteLine(m1.ToString());
                        Console.WriteLine("Second matrix");
                        double[,] arr2 = { { 5, 6 }, { 2, 4 } };
                        MyMatrix m2 = new MyMatrix(arr2);
                        Console.WriteLine(m2.ToString());
                        MyMatrix result = m1 + m2;
                        Console.WriteLine("New matrix");
                        Console.WriteLine(result.ToString());
                        break;
                    case 7:
                        Console.WriteLine("First matrix");
                        double[,] arr3 = { { 1, 2, 3 }, { 4, 5, 3 } };
                        MyMatrix m3 = new MyMatrix(arr3);
                        Console.WriteLine(m3.ToString());
                        Console.WriteLine("Second matrix");
                        double[,] arr4 = { { 1, 2 }, { 7, 4 }, { 1, 2 } };
                        MyMatrix m4 = new MyMatrix(arr4);
                        Console.WriteLine(m4.ToString());
                        MyMatrix res = m3 * m4;
                        Console.WriteLine("New matrix");
                        Console.WriteLine(res.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }
    }
}
