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
    }
    internal class MatrixOperations
    {
    }
}
