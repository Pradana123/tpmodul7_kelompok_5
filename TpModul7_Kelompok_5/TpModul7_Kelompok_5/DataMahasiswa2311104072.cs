using System.Text.Json;

public class DataMahasiswa2311104072
{
    public JSONFormat ReadJSON(string filename)
    {
        return JsonSerializer.Deserialize<JSONFormat>(File.ReadAllText(filename));
    }
}

public class JSONFormat
{
    public NameFormat nama { get; set; }
    public double nim { get; set; }
    public string fakultas { get; set; }
}

public class NameFormat
{
    public string depan { get; set; }
    public string belakang { get; set; }
}