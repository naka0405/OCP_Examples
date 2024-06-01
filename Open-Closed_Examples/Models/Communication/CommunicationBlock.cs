using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Communication
{
    internal class CommunicationBlock
    {
        private readonly SmartSpaceCommunicationService smartSpaceCommunication;
        private readonly RadioCommunicationService radioCommunication;

        private readonly IList<object> receivedMessages;        

        public CommunicationBlock()
        {
            smartSpaceCommunication = new SmartSpaceCommunicationService();
            radioCommunication = new RadioCommunicationService();
            receivedMessages = new List<object>();
        }

        public void Send(object message)
        {
            smartSpaceCommunication.Send(message);
            radioCommunication.Send(message);
        }

        public void Get()
        {
            smartSpaceCommunication.ListenTo("Test secure message.");
            radioCommunication.ListenTo("Test general message.");
        }

        public void Receive(object message)
        {
            var receivedObject = smartSpaceCommunication.Receive();
            receivedMessages.Add(receivedObject);
        }
    }
}