namespace SmartRefrigerator
{
    public interface IEmailSubject : INotification
    {
        bool SendSubject(string subject);
    }
}
