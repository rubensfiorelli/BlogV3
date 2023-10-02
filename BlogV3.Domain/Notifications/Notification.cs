using BlogV3.Domain.Notifications.Interfaces;

namespace BlogV3.Domain.Notifications
{
    public class Notification : INotification
    {
        public object Data { get; init; }
        private List<string> _listErrors { get; init; } = new List<string>();
        public IReadOnlyCollection<string> Notifications => _listErrors;

        public Notification(object data,
                            List<string> errors)
        {
            Data = data;
            _listErrors = errors;
        }
        public Notification(object data)
                => Data = data;
        public Notification(List<string> errors)
                => _listErrors = errors;
        public Notification(string error)
                => _listErrors.Add(error);


    }
}
