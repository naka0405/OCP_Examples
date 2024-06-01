namespace Open_Closed_BadEx1.Models
{
    public class RocketEngine
    {
        public string FuelType = "solid fuel";
        public void Process(string fuelType)
        {
            if (fuelType == "solid fuel")
            {
                Console.WriteLine($"Rocket process with solid fuel type");
            }
        }
    }
}