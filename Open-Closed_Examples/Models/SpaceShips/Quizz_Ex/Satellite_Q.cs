namespace Open_Closed_Examples.Models.SpaceShips.Quizz_Ex
{
    internal class Satellite_Q : SpaceMachine
    {
        protected override string Identifier => nameof(Satellite_Q);

        public override string Move()
        {
            return $"I'm { Identifier } flying in orbit.";
        }
    }
}