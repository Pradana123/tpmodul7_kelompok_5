class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa2311104072 dataMahasiswa2311104072 = new DataMahasiswa2311104072();
        var data = dataMahasiswa2311104072.ReadJSON("tp7_1_2311104072.json");

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} " +
                          $"dengan nim {data.nim} " +
                          $"dari fakultas {data.fakultas}");
    }
}