using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class Satellite : ISpaceMachine
    {
        private string description = $"Some {nameof(Satellite)} description.";
        public Satellite(string id)
        {
            Identifier = id;
        }

        public string Identifier { get; set; }

        public string Description => description;

        public void Run()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"I am {nameof(Satellite)} - \'{Identifier}\'.";
        }
    }
}