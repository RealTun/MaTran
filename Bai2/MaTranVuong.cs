using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class MaTranVuong
    {
        public int N { get; set; }
        public int[,] Matran { get; set; }

        public void Nhap()
        {
            Console.Write("Nhap size ma tran vuong: ");
            N = Convert.ToInt32(Console.ReadLine());
            Matran = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Nhap phan tu [{i},{j}]: ");
                    Matran[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Xuat()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{Matran[i, j]} ");
                    
                }
                Console.WriteLine();
            }
        }

        public static MaTranVuong operator +(MaTranVuong mt1, MaTranVuong mt2)
        {
            MaTranVuong mt = new MaTranVuong();
            int s = mt1.N;
            mt.N = s;
            mt.Matran = new int[mt.N, mt.N];
            for (int i = 0; i < mt.N; i++)
            {
                for (int j = 0; j < mt.N; j++)
                {
                    mt.Matran[i, j] = mt1.Matran[i, j] + mt2.Matran[i, j]; 
                }
            }
            return mt;
        }

        public static MaTranVuong operator -(MaTranVuong mt1, MaTranVuong mt2)
        {
            MaTranVuong mt = new MaTranVuong();
            int s = mt1.N;
            mt.N = s;
            mt.Matran = new int[mt.N, mt.N];
            for (int i = 0; i < mt.N; i++)
            {
                for (int j = 0; j < mt.N; j++)
                {
                    mt.Matran[i, j] = mt1.Matran[i, j] - mt2.Matran[i, j];
                }
            }
            return mt;
        }
    }
}
