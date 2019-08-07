namespace SmartRefrigerator
{
    public class NotifyByEmail : IEmailSubject
    {
        string _logMessage;
        string _subject;

        public NotifyByEmail()
        {
            _logMessage = "";
        }
        public bool Send(string logMessage)
        {
            _logMessage = logMessage;
            return true;
        }

        public bool SendSubject(string subject)
        {
            _subject = subject;
            return true;
        }
    }
}
