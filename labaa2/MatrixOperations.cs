using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace labaa2
{
    public partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new ArgumentException("Matrixes should be the same size");
            }
            double[,] result = new double[matrix1.Height, matrix2.Width];
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix1.Width; j++)
                {
                    result[i,j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return new MyMatrix(result);
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.Width != matrix2.Height)
            {
                throw new ArgumentException("Row of second matrix and column of first matrix should be equal");

            }
            double[,] result = new double[matrix1.Height, matrix2.Width];
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix2.Width; j++)
                {
                    for (int k=0;k<matrix1.Width;k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k,j];
                    }
                }
            }
            return new MyMatrix(result);
        }
        private double [,] GetTransponedArray()
        {
            double[,] transponed = new double[Width,Height];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    transponed[j,i] = array[i,j];
                }
            }
            return transponed;
        }
        public MyMatrix GetTrasponedCopy()
        {
            double[,] transposedArray = GetTransponedArray();
            return new MyMatrix(transposedArray);

        }
        public void TransponeMe()
        {
            double[,] transponed = GetTransponedArray();
            this.array = transponed;
        }
    }
    internal class MatrixOperations
    {
    }
}
