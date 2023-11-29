namespace SMKLib
{
    public class Artwork
    {
        public Artwork(int id, string name, double mintemp, double maxtemp, double minhumidity, double maxhumidity) 
        {
            Id = id;
            Name = name;
            MinTemp = mintemp;
            MaxTemp = maxtemp;
            MinHumidity = minhumidity;
            MaxHumidity = maxhumidity;
        
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public double MinHumidity { get; set; }
        public double MaxHumidity { get; set; }

        public void ValidateMinTemp()
        {
            if(MinTemp < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(MinTemp), $"");
            }
            if(MaxTemp < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(MaxTemp), $"");
            }

        }
        
                                        

    }
}
