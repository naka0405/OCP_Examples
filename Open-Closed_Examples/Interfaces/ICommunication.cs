namespace Open_Closed_Examples.Interfaces
{
    internal interface ICommunication
    {
        void Send(object message);
        void ListenTo(object message);
    }
}