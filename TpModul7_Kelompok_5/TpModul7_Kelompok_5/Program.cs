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
            Console.WriteLine("=== Praktikum Modul 7 - NIM 2311104052 ===\n");

            Console.WriteLine("=============== JSON DESERIALIZATION ===============");
            Console.WriteLine("[1] Membaca Data Mahasiswa\n");

            DataMahasiswa2311104052.ReadJSON();

            Console.WriteLine("\n=== SEMUA PROSES TELAH SELESAI ===");
            Console.WriteLine("Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}