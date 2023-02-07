namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaTranVuong mt1, mt2, mt;
            mt1 = new MaTranVuong();
            mt1.Nhap();

            mt2 = new MaTranVuong();
            mt2.Nhap();

            Console.WriteLine("\nMa tran 1");
            mt1.Xuat();
            Console.WriteLine("\nMa tran 2");
            mt2.Xuat();


            mt = mt1 + mt2;
            Console.WriteLine("\nPhep cong");
            mt.Xuat();

            mt = mt1 - mt2;
            Console.WriteLine("\nPhep tru");
            mt.Xuat();
        }
    }
}