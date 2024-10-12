using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa2
{
    public partial class MyMatrix
    {
        double[,] array;
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
            int row = str.Length;
            int col = str[0].Split(' ').Length;
            try
            {
                this.array = new double[row, col];
                for (int i = 0; i < row; i++)
                {
                    string[] elements = str[i].Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        array[i, j] = Convert.ToDouble(elements[j]);
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Array of strings contain non-numeric values",ex);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
