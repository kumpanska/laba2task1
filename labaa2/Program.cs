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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
