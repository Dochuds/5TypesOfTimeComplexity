// Constant Time
// Function to sum of arr index [0] + [1]
using System;

namespace BigOTimeComplexity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int[] Angka = { 2, 3, 4, 2, 1, 5, 13, 3, 43 };

                for (int i = 0; i < Angka.Length; i++)
                {
                    Console.Write(Angka[i] + " ");
                }
                Console.WriteLine("");
                tambah(Angka);

                Console.ReadLine();
            }

            static int tambah(int[] arr)
            {
                int hasil = arr[0] + arr[1];
                Console.WriteLine("hasil penjumlahan dari index [0] + [1] = {0}", hasil);
                return hasil;
            }
        }
    }
}


// Logarhitmic Time
// Recursive Function
using System;

namespace Logaritmic_Time
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(Faktorial(5));
            Console.ReadLine();
        }

        static int Faktorial(int angka)
        {
            if (angka == 1)
            {
                Console.WriteLine("1 =");
                return 0;
            }
            Console.Write(angka + "*");
            return angka * Faktorial(angka - 1);
        }
    }
}


// Linear Time
// Function to find the lowest price
using System;

namespace linear_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] harga = { 100, 25, 250, 150, 225, 75, 15, 145, 10, 220 };

            hargaMurah(harga);

            Console.ReadLine();
        }

        static void hargaMurah(int[] arr)
        {
            int min = 99999999;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine(min);
        }
    }
}


// Quadratic Time
// Function to find 2 numbers when added together gives 4
using System;

namespace quadratic_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 1, 4, 6, 8, 13, 3, };

            duaAngka(angka);

            Console.ReadLine();
        }

        static void duaAngka(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i + j == 4)
                        Console.WriteLine("{0} + {1}", i, j);

                }

            }
        }
    }
}


// Exponential Time
// Function to try all possible numbers if added yields 10
using System;

namespace Exponential_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Angka = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Cari10(Angka);

            Console.ReadLine();
        }

        static void Cari10(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        for (int l = 0; l < arr.Length; l++)
                        {
                            if (i + j + k + l == 10)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3}", i, j, k, l);
                            }
                        }
                    }
                }
            }
        }
    }
}