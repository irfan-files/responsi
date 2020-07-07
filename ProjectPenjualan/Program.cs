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

        DaftarPenjualan daftarpenjualan = new DaftarPenjualan();
        Penjualan.Nota = int;
        Penjualan.Tanggal = int;
        Penjualan.Customer = string;
        Penjualan.Jenis = switch;
        Penjualan.Total = int;

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

            DaftarPenjualan daftarpenjualan = new DaftarPenjualan();


                Console.WriteLine("Tambah Karyawan Tetap");

                // Input Data ke instance Karyawantetap
                Console.Write("Masukkan Nota \t\t: ");
                Penjualan.Nota = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                Penjualan.Customer = Console.ReadLine();

                Console.Write("Masukkan tanggal \t\t: ");
                Penjualan.Tanggal = Console.ReadLine();

                // Menambahkan Data
                karyawan.Add(karyawanTetap);

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
