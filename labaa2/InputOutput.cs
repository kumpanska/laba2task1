using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaa2
{
    internal class InputOutput
    {
        public void Input(MyMatrix matrix)
        {
            double[,] array = new double[matrix.Height, matrix.Width];
            for (int i = 0; i < matrix.Height; i++)
            {
                string[] elements = Console.ReadLine().Split(' ');
                for (int j = 0; j < matrix.Width; j++)
                {
                    array[i, j] = Convert.ToDouble(elements[j]);
                }
            }

        }
      
    }
}
