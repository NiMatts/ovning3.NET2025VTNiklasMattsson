using System.Xml.Linq;
namespace ovning3.NET2025VTNiklasMattsson.Core.vehicles;

public abstract class Vehicle
{
    private string brand = "";
    private string model = "";
    private int year;
    private double weight;

    public Vehicle(string brandValue, string modelValue, int yearValue, double weightValue)
    {
        Brand = brandValue;
        Model = modelValue;
        Year = yearValue;
        Weight = weightValue;
    }
    
    public string Brand
    {
        get => brand;
        set
        {
            if (value.Length < 2 || value.Length > 20)
                throw new ArgumentException($"{value} är för kort. Måste vara mellan 2-20tecken långt");
            brand = value;
        }
    }
    public string Model
    {
        get => model;
        set
        {
            if (value.Length < 2 || value.Length > 20)
                throw new ArgumentException($"{value} är för kort. Måste vara mellan 2-20tecken långt");
            model = value;
        }
    }
    public int Year
    {
        get => year;
        set
        {
            int currentYear = DateTime.Now.Year;
            if (value < 1886 || value > currentYear)
                throw new ArgumentException($"{value} felaktigt. Måste vara mellan 1886 och {currentYear}");
            year = value;
        }
    }
    public double Weight
    {
        get => weight;
        set
        {
            if (value <= 0.0)
                throw new ArgumentException($"Vikten måste vara större än 0.0");
            weight = value;
        }
    }
    public string Stats()
    {
        return $"Märke:{brand} Modell:{model} Årsmodell:{year} Vikt:{weight}    {SpecificStats()}";
    }
    public abstract void StartEngine();
    public abstract string SpecificStats();
}
