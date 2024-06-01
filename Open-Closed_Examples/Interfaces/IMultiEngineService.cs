namespace Open_Closed_Examples.Interfaces
{
    public interface IMultiEngineService
    {
        void Process();
        void ProcessWith(Type engineType);
    }
}