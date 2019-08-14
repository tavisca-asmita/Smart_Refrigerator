namespace SmartRefrigerator
{
    public class Notifier
    {
        string _notifierType;

        public Notifier()
        {
            _notifierType = "";
        }

        public void SetNotifierType(string notifierType)
        {
            this._notifierType = notifierType;
        }

        public bool Notify(string message)
        {
            var notifier = new NotifierFactory().GetNotifier(_notifierType);
            bool acknowledgement = notifier.Send(message);
            return acknowledgement;
        }
    }

    public class NotifierFactory
    {
        public INotification GetNotifier(string type)
        {
            switch (type.ToLowerInvariant())
            {
                case "bysms":
                    return new NotifyByMessage();
                    
                case "byemail":
                    return new NotifyByEmail();
                    
                default:
                    return null;
            }
        }
    }
}