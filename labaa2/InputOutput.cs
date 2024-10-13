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
            }
        }
    }
}
