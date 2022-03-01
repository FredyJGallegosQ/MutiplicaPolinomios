using System;

namespace MultiPoliArray
{
    class Program
    {
        static void Encabezado()
        {
            Console.WriteLine("***************MULTIPLICACIÓN DE POLINOMIOS***************");
            Console.WriteLine("*********************USANDO ARREGLOS**********************");
            Console.WriteLine("**********************************************************");
            Console.WriteLine(" ");
        }
        static void LeerArreglo(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
        }
        static void MostrarArreglo(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" " + A[i]);
            }
        }
        static void MultiplicarPol(int[] A, int[] B)
        {
            int col = A.Length + B.Length - 1;
            int[,] M = new int[A.Length, col];
            InicializarMatriz(M, A.Length, col);
            int k = 0;
            int[] R = new int[col];
            InicializarArreglo(R);
            for (int i = 0; i < A.Length; i++)
            {
                k = i;
                for (int j = 0; j < B.Length; j++)
                {
                    M[i, k] = A[i] * B[j];
                    k++;
                }
            }
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    R[j] = R[j] + M[i, j];
                }
            }
            MostrarArreglo(R);
        }
        static void InicializarMatriz(int [,] A, int f, int c)
        {
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    A[i, j] = 0;
                }
            }
        }
        static void InicializarArreglo(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 0;
            }
        }
        static void Main(string[] args)
        {
            Encabezado();
            int a, b;
            Console.Write("Ingrese grado de primer polinomio: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] A = new int[a + 1];
            Console.WriteLine("Ingrese coeficientes del polinomio: ");
            LeerArreglo(A);
            Console.Write("Ingrese grado de segundo polinomio: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[] B = new int[b + 1];
            Console.WriteLine("Ingrese coeficientes del polinomio: ");
            LeerArreglo(B);
            Console.WriteLine("Los coeficientes de la mutiplicacón son: ");
            MultiplicarPol(A, B);

            Console.ReadKey();
        }
    }
}
