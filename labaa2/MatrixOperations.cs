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
            MyMatrix newMatrix = new MyMatrix(new double[matrix1.Height, matrix1.Width]);
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix1.Width; j++)
                {
                    newMatrix.array[i,j] = matrix1.array[i, j] + matrix2.array[i, j];
                }
            }
            return newMatrix;
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1.Width != matrix2.Height)
            {
                throw new ArgumentException("Row of second matrix and column of first matrix should be equal");

            }
            MyMatrix newMatrix = new MyMatrix(new double[matrix1.Height, matrix2.Width]);
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix2.Width; j++)
                {
                    for (int k=0;k<matrix1.Width;k++)
                    {
                        newMatrix[i, j] += matrix1[i, k] * matrix2[k,j];
                    }
                }
            }
            return newMatrix;
        }
    }
    internal class MatrixOperations
    {
    }
}
