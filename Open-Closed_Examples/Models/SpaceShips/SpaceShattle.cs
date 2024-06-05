using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.SpaceShips
{
    internal class SpaceShattle : ISpaceMachine, IGlobal
    {
        private string description = $"Some {nameof(SpaceShattle)} description.";
        public SpaceShattle(string id)
        {
            Identifier = id;
        }

        public string Identifier { get; set; }

        public string Description => description;

        public string GetAccess(string key)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"I am {nameof(SpaceShattle)} - \'{Identifier}\'.";
        }
    }
}