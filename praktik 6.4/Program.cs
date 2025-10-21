using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._4_yulmenina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. inisialisasi variabel penghitung (counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            // 2. Perulangan 'while'
            // Kondisi: selama nilai 'hitungan' lebih besar dari o
            while (hitungan > 0)
            {
                // Blok kode di dalam perulangan 
                Console.WriteLine($"Hitungan: {hitungan}");

                // 3. Update variabel penghitung (decrement/pengurangan)
                // INI PENTING agar pengulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                // atau bisa juga ditulis: hitungan--;
            }
            // Kode setelah perulangan selesai
            Console.WriteLine("Selesai! Hitungan mundur telah berakhir. ");
        }
    }
}
