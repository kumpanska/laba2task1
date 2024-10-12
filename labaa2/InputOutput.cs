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
            }
        }
    }
}
