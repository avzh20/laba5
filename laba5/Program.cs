using System;
using System.IO;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, C;
            int[] A, B;
            ВводДанных(out N, out C, out A);
            ФормированиеМассива(C, A, out B);
            ВыводРезультата(B);
        }

        static void ВводДанных(out int N, out int C, out int[] A)
        {
            using (StreamReader файлIn = new StreamReader("Inlet.in"))
            {
                string строкаВвода = файлIn.ReadLine();
                string[] аргумент = строкаВвода.Split(' ');
                N = Convert.ToInt32(аргумент[0]);
                C = Convert.ToInt32(аргумент[1]);
                A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    string число = файлIn.ReadLine();
                    A[i] = Convert.ToInt32(число);
                }
            }
        }
        static void ФормированиеМассива(int C, int[] A, out int[] B)
        {
            if (C == 1)
            {
                B = new int[1];
                B[0] = A[0];
            }
            else
            {
                int k = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % C == 0)
                    {
                        k++;
                    }
                }
                B = new int[k];
                int index = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % C == 0)
                    {
                        B[index] = A[i];
                        index++;
                    }
                }
            }
        }
        static void ВыводРезультата(int[] B)
        {
            using (StreamWriter файлOut = new StreamWriter("Outlet.out"))
            {
                foreach (int элемент in B)
                {
                    файлOut.WriteLine(элемент);
                }
            }

            Console.WriteLine("Результаты были записаны в файл Outlet.out.");
        }
    }
}
