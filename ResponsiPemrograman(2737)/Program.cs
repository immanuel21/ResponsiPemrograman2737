using System;

namespace ResponsiPemrograman_2737_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Immanuel Yofi Zakarias Manafe");
            Console.WriteLine("NIM      : 19.11.2737");
            Console.WriteLine("Kelas    : 19-S1IF-03");

            Console.WriteLine("\n");


            Karyawan karyawan1 = new Karyawan(4343, "Immanuel", 3000000);
            Karyawan karyawan2 = new Karyawan(7373, "Yofi", -2000000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);


            Console.ReadKey();
        }
    }
}
