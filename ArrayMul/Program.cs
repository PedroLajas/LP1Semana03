using System;
using System.Numerics;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            float [ , ] A = new float [2, 2];
            float [] B = new float [2];
            float [] resultado = new float[2];

            A[0, 0] = float.Parse(args[0]); 
            A[0, 1] = float.Parse(args[1]);
            A[1, 0] = float.Parse(args[2]);
            A[1, 1] = float.Parse(args[3]);

            B[0] = float.Parse(args[4]);
            B[1] = float.Parse(args[5]);

            for (int i = 0; i < A.GetLength(0); i++)
            {
                resultado[i] = 0;

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    resultado[i] += A[i, j] * B[j];
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine("| {0,7:F2} |", resultado[i]);
            }
        }
    }
}

