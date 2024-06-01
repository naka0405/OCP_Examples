using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples
{
    internal class EngineTestService
    {
        List<IRocketEngine>? testEngines;
        public void Test()
        {
            ArgumentNullException.ThrowIfNull(testEngines);

            for (int i = 1; i < testEngines?.Count; i++)
            {
                Console.WriteLine($"{i}.");
                testEngines[i].Process();
            }
        }

        public void TakeTestInstanses(List<IRocketEngine> engines)
        {
            testEngines = engines;
        }
    }
}