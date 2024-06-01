namespace Open_Closed_BadEx1.Models
{
    public class Rocket
    {
        public string SerialNumber { get; set; }
        public Crew? Crew { get; set; }
        public RocketEngine? Engine { get; set; }

        public Rocket(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public void Start()
        {
            Console.WriteLine($"Rocket \'{SerialNumber}\' start with {Engine?.FuelType}.");
        }
    }
}
