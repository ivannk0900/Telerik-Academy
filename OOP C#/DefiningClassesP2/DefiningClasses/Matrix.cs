using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Matrix<T> where T : struct, IComparable
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public int Rows
        {
            get
            {
                return this.rows;
            }

        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
           
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }


        public T this[int rows, int cols]
        {
            get
            {
                if (rows >= this.rows || cols >= this.cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return this.matrix[rows, cols];
                }
            }
            set
            {
                if ((rows >= 0 && rows <= this.rows) || (cols >= 0 && cols <= this.cols))
                {
                    this.matrix[rows, cols] = value;
                    //    this.index++;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }


        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.cols != matrix2.cols)
            {
                throw new ArithmeticException("The action cannot be completed! Check numbers of rows and cols");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.cols != matrix2.cols)
            {
                throw new ArithmeticException("The action cannot be completed! Check numbers of rows and cols");
            }
            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < matrix1.rows; i++)
            {
                for (int j = 0; j < matrix1.cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.cols != matrix2.cols)
            {
                throw new ArithmeticException("The action cannot be completed! Check numbers of rows and cols");
            }
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.Rows, matrix1.Cols);


            T result = (dynamic)0;
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        result += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }

            return resultMatrix;

        }

        public static bool operator true (Matrix<T> matrix)
        {
            for(int i = 0 ; i < matrix.rows;i++)
            {
                for(int j = 0; i < matrix.cols;i++)
                {
                    if(matrix[i,j]==(dynamic)0)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }
        public static bool operator false (Matrix<T> matrix)
        {

            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; i < matrix.cols; i++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                   
                }
            }
            return false;
        }


    }
}

