namespace Open_Closed_Examples.Models.SpaceShips.Quizz_Ex
{
    internal class SpaceCraft_Q : SpaceMachine
    {
        protected override string Identifier => nameof(SpaceCraft_Q);

        public override string Move()
        {
            return $"I'm { Identifier } flying in space beyond Earth's orbit.";
        }
    }
}
