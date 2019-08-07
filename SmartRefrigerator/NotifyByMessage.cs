namespace SmartRefrigerator
{
    public class NotifyByMessage : INotification
    {
        string logMessage;

        public NotifyByMessage()
        {
            logMessage = "";
        }
        public bool Send(string logMessage)
        {
            this.logMessage = logMessage;
            return true;
        }
    }
}
