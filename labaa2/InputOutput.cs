using System;
using System.Collections.Concurrent;
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
                            string[] number = Console.ReadLine().Split(' ');
                            for (int j = 0; j < cols; j++)
                            {
                                matrix1[i, j] = Convert.ToDouble(number[j]);
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
                        int  row = Convert.ToInt32(Console.ReadLine());
                        double[][] jagged = new double[row][];
                        for (int i = 0; i < row; i++)
                        {
                            string[] num = Console.ReadLine().Split(' ');
                            jagged[i] = new double[num.Length];
                            for (int j = 0; j < num.Length; j++)
                            {
                                jagged[i][j] = Convert.ToDouble(num[j]);
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
                        int r = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter elements");
                        string[] strArray = new string[r];
                        for (int i = 0; i < r; i++)
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
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string []elements = Console.ReadLine().Split(' ');
                        int rowsOrigin= Convert.ToInt32(elements[0]);
                        int colsOrigin = Convert.ToInt32(elements[1]);
                        double[,]m1= new double[rowsOrigin, colsOrigin];
                        Console.WriteLine("Enter matrix elements (separated by spaces): ");
                        for (int i = 0; i < rowsOrigin; i++)
                        {
                            string[] num = Console.ReadLine().Split(' ');
                            for (int j = 0; j < colsOrigin; j++)
                            {
                                m1[i, j] = Convert.ToDouble(num[j]);
                            }
                        }
                        MyMatrix origMatrix = new MyMatrix(m1);
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
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[]el1 = Console.ReadLine().Split(' ');
                        int rFirst = Convert.ToInt32(el1[0]);
                        int cFirst = Convert.ToInt32(el1[1]);
                        double [,]matrixFirst = new double[rFirst, cFirst];
                        Console.WriteLine("Enter matrix elements (separated by spaces): ");
                        for (int i = 0; i < rFirst; i++)
                        {
                            string[] input1 = Console.ReadLine().Split(' ');
                            for (int j = 0; j < cFirst; j++)
                            {
                                matrixFirst[i, j] = Convert.ToDouble(input1[j]);
                            }
                        }
                        MyMatrix firstMatrix = new MyMatrix(matrixFirst);
                        Console.WriteLine(firstMatrix.ToString());
                        Console.WriteLine("Second matrix");
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[]el2= Console.ReadLine().Split(' ');
                        int rSecond = Convert.ToInt32(el2[0]);
                        int cSecond = Convert.ToInt32(el2[1]);
                        double[,] secondMatrix = new double[rSecond, cSecond];
                        Console.WriteLine("Enter matrix elements (separated by spaces): ");
                        for (int i = 0; i < rSecond; i++)
                        {
                            string[] input2 = Console.ReadLine().Split(' ');
                            for (int j = 0; j < cSecond; j++)
                            {
                                secondMatrix[i, j] = Convert.ToDouble(input2[j]);
                            }
                        }
                        MyMatrix matrixSecond = new MyMatrix(secondMatrix);
                        Console.WriteLine(matrixSecond.ToString());
                        MyMatrix result = firstMatrix + matrixSecond;
                        Console.WriteLine("New matrix");
                        Console.WriteLine(result.ToString());
                        break;
                    case 7:
                        Console.WriteLine("First matrix");
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[] el3= Console.ReadLine().Split(' ');
                        int rFirst1 = Convert.ToInt32(el3[0]);
                        int cFirst1 = Convert.ToInt32(el3[1]);
                        double[,] matrixFirst1 = new double[rFirst1, cFirst1];
                        Console.WriteLine("Enter matrix elements (separated by spaces): ");
                        for (int i = 0; i < rFirst1; i++)
                        {
                            string[] element1= Console.ReadLine().Split(' ');
                            for (int j = 0; j < cFirst1; j++)
                            {
                                matrixFirst1[i, j] = Convert.ToDouble(element1[j]);
                            }
                        }
                        MyMatrix m3 = new MyMatrix(matrixFirst1);
                        Console.WriteLine(m3.ToString());
                        Console.WriteLine("Second matrix");
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[] el4 = Console.ReadLine().Split(' ');
                        int rFirst2 = Convert.ToInt32(el4[0]);
                        int cFirst2 = Convert.ToInt32(el4[1]);
                        double[,] matrixFirst2 = new double[rFirst2, cFirst2];
                        Console.WriteLine("Enter matrix elements (separated by spaces): ");
                        for (int i = 0; i < rFirst2; i++)
                        {
                            string[] element2 = Console.ReadLine().Split(' ');
                            for (int j = 0; j < cFirst2; j++)
                            {
                                matrixFirst2[i, j] = Convert.ToDouble(element2[j]);
                            }
                        }
                        MyMatrix m4 = new MyMatrix(matrixFirst2);
                        Console.WriteLine(m4.ToString());
                        MyMatrix res = m3 * m4;
                        Console.WriteLine("New matrix");
                        Console.WriteLine(res.ToString());
                        break;
                    case 8:
                        Console.Write("Enter matrix dimensions (rows cols): ");
                        string[] rowAndCol= Console.ReadLine().Split(' ');
                        int rowss = Convert.ToInt32(rowAndCol[0]);
                        int colss= Convert.ToInt32(rowAndCol[1]);
                        double[,] matrix8 = new double[rowss, colss];
                        Console.WriteLine("Enter matrix elements (separated by spaces):");
                        for (int i = 0; i < rowss; i++)
                        {
                            string[] elem = Console.ReadLine().Split(' ');
                            for (int j = 0; j < colss; j++)
                            {
                                matrix8[i, j] = Convert.ToDouble(elem[j]);
                            }
                        }
                        MyMatrix originalMatrix= new MyMatrix(matrix8);
                        Console.WriteLine("Origin matrix");
                        Console.WriteLine(originalMatrix.ToString());
                        MyMatrix transposedCopy = originalMatrix.GetTrasponedCopy();
                        Console.WriteLine("Transponed copy of matrix");
                        Console.WriteLine(transposedCopy.ToString());
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }
    }
}
