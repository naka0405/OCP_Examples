namespace Helper
{
    public static class Utils
    {
        static readonly Random rnd = new Random();

        public static void SetSeparator(string? partName = null)
        {
            var stringSeparator = new string('-', 24);
            Console.WriteLine($"\n {stringSeparator} \'{partName}\' {stringSeparator} \n ");
        }

        public static bool GetBoolRandomValue()
        {  
            return rnd.Next(2) == 0;
        }

        public static IEnumerable<int> GetNumbersFrom(IList<string> stringNumbers, int count)
        {
            List<int> numbers = new List<int>(count);

            foreach (var s in stringNumbers!)
            {
                numbers.Add(int.Parse(s));
            }
            return numbers;
        }

        public static double GetRandomDouble()
        {
            return rnd.NextDouble();
        }
    }
}