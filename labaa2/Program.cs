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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
