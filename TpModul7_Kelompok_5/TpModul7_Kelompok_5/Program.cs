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

            // Jalankan fungsi pertama (Data Mahasiswa)
            Console.WriteLine("\n===============MENAMBAHKAN JSON DESERIALIZATON 1==================");
            Console.WriteLine("\n[1] MEMBACA DATA MAHASISWA");
            DataMahasiswa2311104051.ReadJSON();
           
            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadLine();

        }
    }
}
