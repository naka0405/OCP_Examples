using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class SpaceStation : ISpaceMachine
    {
        private string description = $"Some {nameof(SpaceStation)} description.";
        public SpaceStation(string id)
        {
            Identifier = id;
        }

        public string Identifier { get; set; }

        public string Description => description;

        public override string ToString()
        {
            return $"I am {nameof(SpaceStation)} - \'{Identifier}\'.";
        }
    }
}