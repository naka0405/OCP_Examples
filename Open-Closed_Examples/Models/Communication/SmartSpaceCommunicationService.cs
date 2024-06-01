using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Communication
{
    internal class SmartSpaceCommunicationService : BaseCommunicationService, ISmartSpaceCommunication
    {
        private bool isConnected;

        public bool IsConnected => isConnected;

        public void Connect()
        {
            Console.WriteLine("Trying to connect by altarnative ways.");
            isConnected = true;
        }

        public object Receive()
        {
            Console.WriteLine("Object was received.");
            return new object();
        }
    }
}