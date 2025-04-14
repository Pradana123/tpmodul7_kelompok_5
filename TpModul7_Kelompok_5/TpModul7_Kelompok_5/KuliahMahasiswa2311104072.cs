using System.Text.Json;

public class KuliahMahasiswa2311104072
{
    public JSONFormat2 ReadJSON(string filename)
    {
        return JsonSerializer.Deserialize<JSONFormat2>(File.ReadAllText(filename));
    }
}

public class JSONFormat2
{
    public List<CodeName> courses { get; set; }
}

public class CodeName
{
    public string code { get; set; }
    public string name { get; set; }
}