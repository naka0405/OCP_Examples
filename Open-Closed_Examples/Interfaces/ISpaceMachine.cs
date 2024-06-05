namespace Open_Closed_Examples.Interfaces
{
    public interface ISpaceMachine
    {
        string Identifier { get; }
        string Description { get; }
        void Run();
    }
}