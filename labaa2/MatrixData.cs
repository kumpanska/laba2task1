using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa2
{
    public partial class MyMatrix
    {
        private double[,] array;
        public int Height
        { get { return array.GetLength(0); } }
        public int Width
        { get { return array.GetLength(1); } }
        public int getHeight() { return Height; }
        public int getWidth() { return Width; }
        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i > array.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Row index is out of range");
                }
                if (j < 0 || j > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Column index is out of range");
                }
                return array[i, j];
            }
            set
            {
                if (i < 0 || i > array.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Row index is out of range");
                }
                if (j < 0 || j > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Column index is out of range");
                }
                array[i, j] = value;
            }

        }
        public double getElement(int i, int j)
        { return array[i, j]; }
        public void setElement(int i, int j, double value)
        { array[i, j] = value; }
        override public String ToString()
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < Height; i++)
            {
                bool isEmpty = true;
                for (int j = 0; j < Width; j++)
                {
                    if (array[i,j]!=0)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        res.Append(array[i, j].ToString()).Append("\t");
                    }
                }
                res.AppendLine();
            }
            return res.ToString().TrimEnd('\n');
        }
        public MyMatrix(MyMatrix copyMatrix)
        {
            this.array = new double[copyMatrix.Height, copyMatrix.Width];
            for (int i = 0; i < copyMatrix.Height; i++)
            {
                for (int j = 0; j < copyMatrix.Width; j++)
                {
                    this.array[i, j] = copyMatrix.array[i, j];
                }
            }
        }
        public MyMatrix(double[,] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array can't be null");
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool isEmpty = true;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j]!=0)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    throw new ArgumentException("Row can't be empty");
                }
            }
            this.array = array;
        }
        public MyMatrix(double[][] jagged)
        {
            this.array = new double[jagged.Length, jagged[0].Length];
            for(int i=0;i<jagged.Length;i++)
            {
                if (jagged[i].Length != jagged[0].Length)
                {
                    throw new ArgumentException("Jagged array should be rectangular");
                }
                bool isEmpty = true;
                for (int j = 0; j < jagged[0].Length; j++)
                {
                    if (jagged[i][j] != 0)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    throw new ArgumentException("Row cannot be empty");
                }
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[0].Length; j++)
                {
                    this.array[i, j] = jagged[i][j];
                }
            }
        }
        public MyMatrix(string[] str)
        {
            if (str == null || str.Length == 0)
            {
                throw new ArgumentException("Input can't be null or empty");
            }
            int row = str.Length;
            int col = str[0].Split(' ').Length;
            for (int i = 1; i < row; i++)
            {
                if (str[i].Split(' ').Length != col)
                {
                    throw new ArgumentException("All rows should be the same length");
                }
            }
            try
            {
                this.array = new double[row, col];
                for (int i = 0; i < row; i++)
                {
                    string[] elements = str[i].Split(new[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);
                    bool isEmpty = true;
                    for (int j = 0; j < col; j++)
                    {
                        array[i, j] = Convert.ToDouble(elements[j]);
                        if (array[i, j] != 0)
                        {
                            isEmpty = false;
                        }
                    }
                    if (isEmpty)
                    {
                        throw new ArgumentException("Row can't be zero");
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Array of strings contain non-numeric values",ex);
            }
        }
        public MyMatrix(string str) : this(str.Split(new[] { '\n'},StringSplitOptions.RemoveEmptyEntries))
        {
            
        }
    }
    internal class MatrixData
    {
        static void Main(string[] args)
        {
            double[,] arr = { { 1, 0, 5 }, { 14, 32, 134 }, { 123, 23, 55 } };
            MyMatrix myMatrix1 = new MyMatrix(arr);
            Console.WriteLine("Matrix from 2D array");
            Console.WriteLine(myMatrix1.ToString());
            Console.WriteLine($"Access to element:{arr[0, 0]}");
            double[][] jagged = { new double[] { 0, 1 }, new double[] { 112, 13 }, new double[] { -23, 312 } };
            MyMatrix myMatrix2 = new MyMatrix(jagged);
            Console.WriteLine("Matrix from jagged array");
            Console.WriteLine(myMatrix2.ToString());
            string[] strArray = { "0 8 9 0", "23 42 44 134", "244 -2 1 -3" };
            MyMatrix myMatrix3 = new MyMatrix(strArray);
            Console.WriteLine("Matrix from string array");
            Console.WriteLine(myMatrix3.ToString());
            string str = "0 3 0\n76 2 4\n43 22 -23";
            MyMatrix myMatrix4 = new MyMatrix(str);
            Console.WriteLine("Matrix from string");
            Console.WriteLine(myMatrix4.ToString());
            MyMatrix origMatrix = new MyMatrix(arr);
            MyMatrix copyMatrix = new MyMatrix(origMatrix);
            Console.WriteLine("Matrix from copy of other instance");
            Console.WriteLine(copyMatrix.ToString());
        }
    }
}
