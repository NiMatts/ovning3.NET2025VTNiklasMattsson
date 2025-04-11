namespace ovning3.Core2
{
    public class Vehicle
    {
        private string brand;
        private string model;
        private int year;
        private double weight;

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
            get => Model;
            set
            {
                if (value.Length < 2 || value.Length > 20)
                    throw new ArgumentException($"{value} är för kort. Måste vara mellan 2-20tecken långt");
                model = value;
            }
        }
        public int Year
        {
            get => Year;
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
            get => Weight;
            set
            {
                if (weight <= 0.0)
                    throw new ArgumentException($"Vikten måste vara större än 0.0");
                weight = value;
            }
        }
    }
}
