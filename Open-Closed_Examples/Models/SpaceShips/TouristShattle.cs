using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class TouristShattle : ISpaceMachine, ITouristShuttle, IValidMachine
    {
        private string description = $"Some {nameof(TouristShattle)} description.";
        public TouristShattle(string id)
        {
            Identifier = id;
        }

        public string Identifier { get; set; }

        public string Description => description;

        public bool IsValid { get ; set ; }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"I am {nameof(TouristShattle)} - \'{Identifier}\'.";
        }
    }
}