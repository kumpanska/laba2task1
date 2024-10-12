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
            get {
                if (i < 0 || i > array.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Row index is out of range");
                }
                if (j < 0 || j > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Column index is out of range");
                }
                return array[i, j]; }
            set {
                if (i < 0 || i > array.GetLength(0))
                {
                    throw new IndexOutOfRangeException("Row index is out of range");
                }
                if (j < 0 || j > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Column index is out of range");
                }
                array[i, j] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
