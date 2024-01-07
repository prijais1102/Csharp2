using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Assignment1b
{
    class Program
    {
        static double sum;
        static void Main(string[] args)
        {
            //1
           
            int[] a = { 1, 2, 3, 4 };
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            double avg = (sum / a.Length);
            Console.WriteLine("Sum is "+sum);
            Console.WriteLine("Average is "+avg);
            //2
            MatrixSum();
            //3
            MaxValue();
            //4
            ColSum();
            //5
            RowSum();
            
        }
        static void MatrixSum()
        {
            int sum = 0;
            int[,] b = { { 1, 2, 3 }, { 3, 4, 5 }, { 2, 3, 4 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += b[i, j];
                }               
            }
            Console.WriteLine("Sum of 3*3 matrix is " + sum);
        }
        static void MaxValue()
        {
            int max = 0;
            int[] a = { 1, 4, 2, 4, 5, 9, 1, 0 };
            for(int i = 0;i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("Maximum Value is " + max);
        }
        static void ColSum()
        {
            Console.WriteLine("Sum of Matrix Column-wise");
            int sum = 0;
            int[,] b = { { 1, 2, 3 }, { 3, 4, 5 }, { 2, 3, 4 } };
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += b[j,i];
                }
                Console.WriteLine("Column"+(i+1)+"-"+sum);
            }
            Console.WriteLine();
        }
        static void RowSum()
        {
            Console.WriteLine("Sum of Matrix Row-wise");
            int sum = 0;
            int[,] b = { { 1, 2, 3 }, { 3, 4, 5 }, { 2, 3, 4 } };
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += b[i, j];
                }
                Console.WriteLine("Row" + (i + 1) + "-" + sum);
            }
            Console.WriteLine();
        }
    }//class
}//namespace
