﻿using System;
using System.IO;
using System.Text.Json;
using TpModul7_Kelompok_5;

namespace TpModul7_Kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM DESERIALISASI JSON ===");
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104051 ===\n");

            // Jalankan fungsi kedua (Daftar Mata Kuliah)
            Console.WriteLine("\n==================MENAMBAHKAN JSON DESERIALIZATON 2=====================");
            Console.WriteLine("\n[2] MEMBACA DAFTAR MATA KULIAH");
            KuliahMahasiswa2311104051.ReadJSON();

            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();

        }
    }
}
