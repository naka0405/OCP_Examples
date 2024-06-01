namespace Open_Closed_Examples.Interfaces
{
    internal interface ISmartSpaceCommunication
    {
        bool IsConnected { get; }

        void Connect();

        object Receive();
    }
}