using System;

namespace Exercise2_algo
{
    class Program
    {
        // Deklarasi ranii int dengan ukuran 49 + 10 + 20 + 20 - 2 x 15
        private int[] a = new int[69];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada ranii
        private int n;

        // Fungsi / Method untuk menerima masukkan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada ranii
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada ranii: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 69)
                    break;
                else
                    Console.WriteLine("\nranii dapat mempunyai maksimal 169 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_________________");
            Console.WriteLine(" Masukkan elemen ");
            Console.WriteLine("_________________");

            // Pengguna memasukkan elemen pada ranii
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string? v = Console.ReadLine();
                string s1 = v;
                a[i] = int.Parse(s1);
            }
        }
        public void dislay()
        {
            // Menampilkan ranii yang tersusun
            Console.WriteLine("");
            Console.WriteLine("____________________________");
            Console.WriteLine(" Elemen yang telah tersusun ");
            Console.WriteLine("____________________________");
            for (int BE = 0; BE < n; BE++)
            {
                Console.WriteLine(a[BE]);
            }
            Console.WriteLine("");
        }
        public void Exercise2AlgoRanii()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // Pada pass i, bandingakan n - i elemen pertama dengan elemen selanjutnya
                for (int BE = 0; BE < n - i; BE++)
                {
                    if (a[BE] > a[BE + 1]) // JIka elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[BE];
                        a[BE] = a[BE + 1];
                        a[BE + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Membuat objek dari Exercise
            Program myList = new Program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.Exercise2AlgoRanii();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.dislay();
            // Exit
            Console.WriteLine("\n\nTekan Dimana Saja Untuk Keluar.");
            Console.Read();
        }
    }
}