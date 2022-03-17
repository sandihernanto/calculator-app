using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            float jumlah, kurang, kali, bagi;
            float a, b;
            int pilih;

            Console.WriteLine("Pilih Menu Calculator");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("5. Keluar");

            Console.Write("Masukkan Menu Pilihan (1-5): ");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    jumlah = a + b;
                    Console.Write("Hasil Penjumlahan " + a + " + " + b + " adalah " + jumlah);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    kurang = a - b;
                    Console.Write("Hasil Pengurangan " + a + " - " + b + " adalah " + kurang);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    kali = a * b;
                    Console.Write("Hasil Perkalian " + a + " x " + b + " adalah " + kali);
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    bagi = a / b;
                    Console.Write("Hasil Pembagian " + a + " : " + b + " adalah " + bagi);
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Write("Terimakasih Sudah Mengunakan Aplikasi ini");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Input Yang Anda Masukkan Salah");
                    Console.WriteLine("Silahkan Ulangi !!!!");
                    Console.ReadKey();
                    break;
            }


        }
    }
}