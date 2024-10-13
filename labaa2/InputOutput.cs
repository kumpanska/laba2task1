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
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine("Enter matrix from 2D array");
                    double[,] arr = { { 1, 0, 5 }, { 14, 32, 134 } };
                    MyMatrix myMatrix1 = new MyMatrix(arr);
                    Console.WriteLine("Matrix from 2D array");
                    Console.WriteLine(myMatrix1.ToString());
                    myMatrix1.TransponeMe();
                    Console.WriteLine("Transposed matrix from 2D array:");
                    Console.WriteLine(myMatrix1.ToString());
                    break;
                case 2:
                    double[][] jagged = { new double[] { 0, 1 }, new double[] { 112, 13 }, new double[] { -23, 312 } };
                    MyMatrix myMatrix2 = new MyMatrix(jagged);
                    Console.WriteLine("Matrix from jagged array");
                    Console.WriteLine(myMatrix2.ToString());
                    myMatrix2.TransponeMe();
                    Console.WriteLine("Transposed jagged matrix:");
                    Console.WriteLine(myMatrix2.ToString());
                    break;
                case 3:
                    string[] strArray = { "0 8 9 0", "23 42 44 134", "244 -2 1 -3" };
                    MyMatrix myMatrix3 = new MyMatrix(strArray);
                    Console.WriteLine("Matrix from string array");
                    Console.WriteLine(myMatrix3.ToString());
                    myMatrix3.TransponeMe();
                    Console.WriteLine("Transposed matrix from string array:");
                    Console.WriteLine(myMatrix3.ToString());
                    break;
                case 4:
                    string str = "0 3 0\n76 2 4\n43 22 -23";
                    MyMatrix myMatrix4 = new MyMatrix(str);
                    Console.WriteLine("Matrix from string");
                    Console.WriteLine(myMatrix4.ToString());
                    myMatrix4.TransponeMe();
                    Console.WriteLine("Transposed matrix from string:");
                    Console.WriteLine(myMatrix4.ToString());
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
