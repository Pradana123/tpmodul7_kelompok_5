class Program
{
    static void Main(string[] args)
    {
        KuliahMahasiswa2311104072 kuliahMahasiswa2311104072 = new KuliahMahasiswa2311104072();
        var data = kuliahMahasiswa2311104072.ReadJSON("tp7_2_2311104072.json");
        int index = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"MK{index} {course.code} {course.name}");
            index++;
        }
    }
}