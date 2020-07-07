using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCostumer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek Costumer
        static List<Costumer> daftarCostumer = new List<Costumer>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahCostumer();
                        break;

                    case 2:
                        HapusCostumer();
                        break;

                    case 3:
                        TampilCostumer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Costumer");
            Console.WriteLine("2. Hapus Costumer");
            Console.WriteLine("3. Tampilkan Costumer");
            Console.WriteLine("4. Keluar");
        }
        static void TambahCostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan Costumer ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Tambah Data Costumer\n");
            Costumer Costumer = new Costumer();
            Console.Write("Kode Costumer : ");
            Costumer.Code = Console.ReadLine();
            Console.Write("Nama Costumer : ");
            Kostumer.Name = Console.ReadLine();
            Console.Write("Total Debt  : ");
            Kostumer.Debt = Convert.ToDouble(Console.ReadLine());
            daftarCostumer.Add(Costumer);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER Untuk Kembali ke Menu");
            Console.ReadKey();
        }

        static void HapusCostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus Costumer dari dalam collection
            int i = -1, hapus = -1;
            Console.WriteLine("Hapus Data Costumer\n");
            Console.Write("Kode Costumer : ");
            string kode = Console.ReadLine();
            foreach (Costumer Costumer in daftarCostumer)
            {
                i++;
                if (Costumer.Code == kode)
                {
                    hapus = i;
                }
            }
            if (hapus != -1)
            {
                daftarCostumer.RemoveAt(hapus);
                Console.WriteLine("\nData Costumer Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Costumer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER Untuk Kembali ke Menu");
            Console.ReadKey();
        }

        static void TampilKostumer()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar Costumer yang ada di dalam collection
            int Urut = 0;
            Console.WriteLine("Data Kostumer\n");
            foreach (Costumer Costumer in daftarCostumer)
            {
                Urut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", Urut, Costumer.Code, Costumer.Name, Costumer.Debt);
            }
            if (Urut < 1)
            {
                Console.WriteLine("Data Costumer Kosong");
            }

            Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            Console.ReadKey();
        }
    }
}
