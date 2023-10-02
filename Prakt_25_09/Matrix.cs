using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt_25_09
{
    internal class Matrix
    {
        private int[,] matrix;
        private int row;
        private int col;
        private static int seed;
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            matrix = new int[row, col];
        }
        public static int GetSeed()
        {
            return seed;
        }
        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.row != m2.row || m1.col != m2.col)
                throw new ArgumentException("Помилка розміру.");

            Matrix result = new Matrix(m1.row, m1.col);
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.row != m2.row || m1.col != m2.col)
                throw new ArgumentException("Помилка розміру.");

            Matrix result = new Matrix(m1.row, m1.col);
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }
        public static bool operator >=(Matrix m1, Matrix m2)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.col; j++)
                {
                    sum1 += m1[i, j];
                    sum2 += m2[i, j];
                }
            }

            return sum1 >= sum2;
        }
        public static bool operator <=(Matrix m1, Matrix m2)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < m2.row; i++)
            {
                for (int j = 0; j < m2.col; j++)
                {
                    sum1 += m1[i, j];
                    sum2 += m2[i, j];
                }
            }

            return sum1 <= sum2;
        }
        public void SetRandom(int min, int max)
        {
            Random rand = new Random(++seed);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rand.Next(min, max);
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
