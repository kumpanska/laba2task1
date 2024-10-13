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
            Console.WriteLine("Choose type of matrix");
            MyMatrix matrix;
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Enter matrix from 2D array");
                    string[] rows = Console.ReadLine().Split('\n');
                    double[,] array = new double[rows.Length, rows[0].Split(' ').Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] elements = rows[i].Split(' ');
                        for (int j = 0; j < elements.Length; j++)
                        {
                            array[i, j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix matrix1 = new MyMatrix(array);
                    Console.WriteLine(matrix1.ToString());
                    Console.WriteLine("Transposed matrix");
                    MyMatrix transposed = matrix1.GetTrasponedCopy();
                    Console.WriteLine(transposed.ToString());
                    break;
                case 2:
                    Console.WriteLine("Enter matrix from jaggged array");
                    string[] r = Console.ReadLine().Split('\n');
                    double[][] jaggedArray = new double[r.Length][];
                    for (int i = 0; i < r.Length; i++)
                    {
                        string[] elements = r[i].Split(' ');
                        jaggedArray[i] = new double[elements.Length];
                        for (int j = 0; j < elements.Length; j++)
                        {
                            jaggedArray[i][j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix matrix2 = new MyMatrix(jaggedArray);
                    Console.WriteLine(matrix2.ToString());
                    Console.WriteLine("Transpose matrix");
                    MyMatrix transposed2 = matrix2.GetTrasponedCopy();
                    Console.WriteLine(transposed2.ToString());
                    break;
                case 3:
                    Console.WriteLine("Enter matrix from array string");
                    rows = Console.ReadLine().Split('\n');
                    string[] stringArray = new string[rows.Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        stringArray[i] = rows[i];
                    }
                    MyMatrix matrix3 = new MyMatrix(stringArray);
                    Console.WriteLine(matrix3.ToString());
                    Console.WriteLine("Transpose matrix");
                    MyMatrix transposed3 = matrix3.GetTrasponedCopy();
                    Console.WriteLine(transposed3.ToString());
                    break;
                case 4:
                    Console.WriteLine("Enter matrix from string");
                    string str = Console.ReadLine();
                    matrix = new MyMatrix(str.Split(new[] {'\t' },StringSplitOptions.RemoveEmptyEntries));
                    Console.WriteLine(matrix.ToString());
                    break;
                case 5:
                    Console.WriteLine("Enter first matrix");
                    rows = Console.ReadLine().Split('\n');
                    double[,] array1 = new double[rows.Length, rows[0].Split(' ').Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] elements = rows[i].Split(' ');
                        for (int j = 0; j < elements.Length; j++)
                        {
                            array1[i, j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix firstMatrix = new MyMatrix(array1);
                    Console.WriteLine("Enter second matrix");
                    rows = Console.ReadLine().Split('\n');
                    double[,] array2 = new double[rows.Length, rows[0].Split(' ').Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] elements = rows[i].Split(' ');
                        for (int j = 0; j < elements.Length; j++)
                        {
                            array2[i, j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix secondMatrix = new MyMatrix(array2);
                    MyMatrix sum = firstMatrix + secondMatrix;
                    Console.WriteLine("Result of sum:");
                    Console.WriteLine(sum.ToString());
                    break;
                case 6:
                    Console.WriteLine("Enter first matrix");
                    rows = Console.ReadLine().Split('\n');
                    double[,] array3 = new double[rows.Length, rows[0].Split(' ').Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] elements = rows[i].Split(' ');
                        for (int j = 0; j < elements.Length; j++)
                        {
                            array3[i, j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix firstMatrix1 = new MyMatrix(array3);
                    Console.WriteLine("Enter second matrix");
                    rows = Console.ReadLine().Split('\n');
                    double[,] array4 = new double[rows.Length, rows[0].Split(' ').Length];
                    for (int i = 0; i < rows.Length; i++)
                    {
                        string[] elements = rows[i].Split(' ');
                        for (int j = 0; j < elements.Length; j++)
                        {
                            array4[i, j] = Convert.ToDouble(elements[j]);
                        }
                    }
                    MyMatrix secondMatrix2= new MyMatrix(array4);
                    MyMatrix multiply = firstMatrix1 * secondMatrix2;
                    Console.WriteLine("Result of multiply");
                    Console.WriteLine(multiply.ToString());
                    break;
            }
        }
    }
}
