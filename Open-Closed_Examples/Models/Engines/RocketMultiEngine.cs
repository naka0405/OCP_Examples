using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Engines
{
    public class RocketMultiEngine : IMultiEngineService
    {
        int currentEngineNumber = 0;
        Dictionary<int, IRocketEngine> engines { get; }

        public RocketMultiEngine()
        {
            engines = new Dictionary<int, IRocketEngine>();   
        }

        public void Add(IRocketEngine engine)
        {
            var currentNumber = engines.Count;
            engines.Add(currentNumber + 1, engine);
        }

        public void ProcessWith(Type engineType)
        {
            for (int i = 0; i <= engines.Count; i++)
            {
                var engine = engines.ElementAt(i);
                if (engine.Value.GetType() == engineType)
                {
                    engine.Value.Process();
                    currentEngineNumber = i+1;
                    break;
                }
            }            
        }

        public void Process()
        {
            var currentEngine = engines.First(e => e.Key == currentEngineNumber).Value;
            var type = currentEngine.GetType();
            Console.WriteLine($"Engine service controls the system. Current engine is {type.Name}.");
        }
    }
}