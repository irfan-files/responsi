using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        

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
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
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
             Console.WriteLine("Silahkan Pilih Menu Aplikasi: ");
                Console.WriteLine("1. Tambah penjualan\n2. Hapus penjualan \n3. Tampilkan penjualan \n4. Keluar");

                Console.WriteLine("");
        }

         static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan");
            Console.Write("Nota : ");
            
            penjualan.nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            penjualan.tanggal = Console.ReadLine();

            Console.Write("Customer : ");
            penjualan.customer = Console.ReadLine();

            Console.Write("Jenis [T/K] : ");
            penjualan.jenis = Console.ReadLine();

            Console.Write("Total Nota : ");
            penjualan.total = double.Parse(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("Hapus  Penjualan");
            Console.Write("Nota  : ");
            string nota = Console.ReadLine();

            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                if (penjualan.nota == nota)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\nData penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\n Nota tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            int no = 0;
            Console.WriteLine("Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                string jenis;
                if(penjualan.jenis == "T")
                {
                    jenis = "Tunai";
                }
                else if(penjualan.jenis == "K")
                {
                    jenis = "Kredit";
                }
                else
                {
                    jenis = "Jenis tidak diketahui";
                }
                    Console.WriteLine(no + "." + penjualan.nota + "," + penjualan.tanggal + "," + penjualan.customer + "," + jenis + "," + penjualan.total);
                }
                if (no < 1)
                {
                    Console.WriteLine("Data Penjualan Kosong");
                }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}