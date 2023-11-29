namespace SMKLib
{
    public class Artwork
    {
        public Artwork(int artid, string name, double mintemp, double maxtemp, double minhumidity, double maxhumidity) 
        {
            ArtId = artid;
            Name = name;
            MinTemp = mintemp;
            MaxTemp = maxtemp;
            MinHumidity = minhumidity;
            MaxHumidity = maxhumidity;
        
        }

        public int ArtId { get; set; }
        public string Name { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public double MinHumidity { get; set; }
        public double MaxHumidity { get; set; }

        public void ValidateTemp()
        {
            if(MinTemp < 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(MinTemp), $"The Temperature is too low!");
            }
            if(MaxTemp > 0) 
            {
                throw new ArgumentOutOfRangeException(nameof(MaxTemp), $"The Temperature is too high!");
            }

        }

        public void ValidateHumidity()
        {
            if (MinHumidity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(MinHumidity), $"The Humidity is too low!");
            }
            if ( MaxHumidity > 0)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxHumidity), $"The Humidity is too high!");
            }
        }

        public void Validate()
        {
            ValidateHumidity();
            ValidateTemp();
        }
                        

    }
}
