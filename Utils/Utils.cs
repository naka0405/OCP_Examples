namespace Helper
{
    public static class Utils
    {
        public static void SetSeparator(string? partName = null)
        {
            var stringSeparator = new string('-', 24);
            Console.WriteLine($"\n {stringSeparator} \'{partName}\' {stringSeparator} \n ");
        }

        public static bool GetBoolRandomValue()
        {
            Random rnd = new Random();

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
    }
}