using BlogV3.Domain.Entities;

namespace BlogV3.Application.Results
{
    public class Result<T> : IResult
    {

        public Result(int httpCode, T data, List<string> notifications)
        {
            Data = data;
            HttpCode = httpCode;
            _notifications = notifications;
        }

        public Result(T data)
        {
            Data = data;
        }

        public Result(List<string> notifications)
        {
            _notifications = notifications;
        }
      

        public Result(string error)
        {
            _notifications.Add(error);
        }


        public T Data { get; private set; }
        public int HttpCode { get; private set; }
        private List<string> _notifications { get; init; }
        public IReadOnlyCollection<string> Notifications => _notifications;




    }
}
