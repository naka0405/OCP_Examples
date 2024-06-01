using Open_Closed_Examples.Interfaces;

namespace Open_Closed_Examples.Models.Communication
{
    internal abstract class BaseCommunicationService : ICommunication
    {
        public void ListenTo(object message)
        {
            Console.WriteLine($"The \'{message}\' was listened.");
        }

        public void Send(object message)
        {
            Console.WriteLine($"The \'{message}\' was sent.");
        }
    }
}