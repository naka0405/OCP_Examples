namespace Open_Closed_Examples.Models.SpaceShips.Quizz_Ex
{
    internal abstract class SpaceMachine
    {
        protected abstract string Identifier { get; }

        public Crew? Crew { get; set; }

        public abstract string Move();

        public virtual void Return(string parameter)
        {
            Console.WriteLine($"The {Identifier} returns according to" +
                $" the specified parameter \'{parameter}\'.");
        }
    }
}
