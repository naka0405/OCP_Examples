namespace Open_Closed_Examples.Models.SpaceShips.Quizz_Ex
{
    internal class SpaceShattle_Q : SpaceMachine
    {
        protected override string Identifier => nameof(SpaceShattle_Q);

        public override string Move()
        {
            return $"I'm { Identifier }. I move people from point A to point B in space.";
        }
    }
}
