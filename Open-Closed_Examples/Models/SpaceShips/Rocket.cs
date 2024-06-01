using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class Rocket : ISpaceMachine, IValidMachine
    {
        private string description = $"Some {nameof(Rocket)} description.";
        public Rocket(string id)
        {
            Identifier = id;
        }

        public string Identifier { get; set; }

        public string Description => description;

        public bool IsValid { get; set; }

        public override string ToString()
        {
            return $"{nameof(Rocket)} - \'{Identifier}\'.";
        }
    }
}