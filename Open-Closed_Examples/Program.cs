using Helper;
using Open_Closed_Ex1.Models.Roles;
using Open_Closed_Examples.Interfaces;
using Open_Closed_Examples.Models;
using Open_Closed_Examples.Models.Communication;
using Open_Closed_Examples.Models.Engines;
using Open_Closed_Examples.Models.SpaceShips;
using Open_Closed_Examples.Models.SpaceShips.Quizz_Ex;

namespace Open_Closed_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utils.SetSeparator("Task 1. Easy level.");
            //var spaceShattle = new SpaceShattle("OCP001");
            //var satellite = new Satellite("OCP002");
            //var spaceStation = new SpaceStation("OCP003");

            //var spaceMachineCollection = new List<ISpaceMachine>() { spaceStation, satellite, spaceShattle };
            //foreach (var sm in spaceMachineCollection)
            //{
            //    Console.WriteLine(sm);
            //}

            //Utils.SetSeparator("Task 2. Easy level.");
            //var newTranscenter = new Transcenter();
            //var touristShattle = new TouristShattle("OCP004");
            //var rocket1 = new Rocket("OCP005");
            //var rocket2 = new Rocket("OCP006");

            //newTranscenter.TechicalService.Check(touristShattle);
            //newTranscenter.TechicalService.Check(rocket1);
            //newTranscenter.TechicalService.Check(rocket2);

            //newTranscenter.LaunchStation.Start(touristShattle);
            //newTranscenter.LaunchStation.Start(rocket2);
            //newTranscenter.LaunchStation.Start(rocket1);

            //Utils.SetSeparator("Task 3. Easy level.");
            //Console.WriteLine("Not inplemented.");

            //Utils.SetSeparator("Task 1. Middle level. \'Organize your space team.\'");
            //var astronomManager = new RoleManager();
            //var engineer = new Astronaut("NK", 38, new Engineer());
            //var aircraftMechanic = new Astronaut("James Arnb", 35, new AircraftMechanic());
            //var astromomer = new Astronaut("Ana Ree", 35, new Astronomer(astronomManager));

            //var crew = new Crew();
            //crew.TeamMembers.Add(engineer);
            //crew.TeamMembers.Add(aircraftMechanic);
            //crew.TeamMembers.Add(astromomer);

            //var spaceCraft = new SpaceCraft("OCP_SpaceCraft");
            //spaceCraft.Crew = crew;
            //spaceCraft.Crew.GetAllMembers();

            //Utils.SetSeparator("Task 2. Middle level.");
            //var products = new List<IRocketEngine>();

            //// Create engines
            //for (int i = 0; i < 10; i++)
            //{
            //    var liquidFuelEngine = new LiquidFuelEngine();
            //    var solidFuelEngine = new SolidFuelEngine();
            //    var elEngine = new ElectricEngine();

            //    products.AddRange(new List<IRocketEngine> { liquidFuelEngine, solidFuelEngine, elEngine });
            //}

            //Console.WriteLine($"Please, input 5 numbers from 1 to {products.Count-1}. Use \',\' to separate them.");
            //var stringNumbers = Console.ReadLine()?.Split(",");
            //var numbers = Utils.GetNumbersFrom(stringNumbers!, 5);

            //// Test random engine items
            //for (int i = 0; i < products.Count; i++)
            //{
            //    if (numbers.Contains(i))
            //    {
            //        products[i].Process();
            //    }
            //}


            //Utils.SetSeparator("2 varient.");
            //var testCollection = new List<IRocketEngine>()
            //{
            //    new LiquidFuelEngine(), new SolidFuelEngine(), new ElectricEngine()
            //};

            //var testService = new EngineTestService();
            //testService.TakeTestInstanses(testCollection);
            //testService.Test();

            //Utils.SetSeparator("Task 3. Middle level. Switching engines due to changes in pressure outside.");
            //var isSwitchToElectric = "n";

            //var spaceShip = new SpaceShip("SS001");

            //var engineService = new RocketMultiEngine();
            //engineService.Add(new LiquidFuelEngine());
            //engineService.Add(new ElectricEngine());

            //spaceShip.SetEngineService(engineService);
            //spaceShip.EngineService?.ProcessWith(typeof(LiquidFuelEngine));

            //while (isSwitchToElectric != "y")
            //{
            //    Thread.Sleep(6000);

            //    Console.WriteLine("The ship entered orbit. Switch the engine to electric? y/n");
            //    isSwitchToElectric = Console.ReadLine();
            //}
            //engineService.ProcessWith(typeof(ElectricEngine));
            //spaceShip.LetsGo();

            //Utils.SetSeparator("Task 1. Hard level.");
            //var communicationBloc = new CommunicationBlock(DateTime.UtcNow);
            //communicationBloc.Send("Test message.");
            //communicationBloc.Receive(new
            //{
            //    Id = "Some test object",
            //    Weight = 10
            //});

            //communicationBloc.Get();

            //Utils.SetSeparator("Task 2. Hard level.");
            //var energyService = new EnergyService(28977);
            //Console.WriteLine(energyService.GetCurrentState());
            //var response = Console.ReadLine();
            
            //if(response == "y")
            //{
            //    energyService.SuspendWork(nameof(PowerSupplySystem));
            //}

            //IPowerSupplySystem newsystem = new PowerSupplySystem(DateTime.UtcNow);
            //energyService.AddNewSystem(nameof(PowerSupplySystem)+1, (System)newsystem);
            //Console.WriteLine(energyService.GetCurrentState());

            Utils.SetSeparator("Quiz examples.");
            var collectionOfSpaceShips = new SpaceMachine[3];

            collectionOfSpaceShips[0] = new SpaceCraft_Q();
            collectionOfSpaceShips[1] = new Satellite_Q();
            collectionOfSpaceShips[2] = new SpaceShattle_Q();

            collectionOfSpaceShips.ToList().ForEach(sm => Console.WriteLine(sm.Move()));

        }
    }
}