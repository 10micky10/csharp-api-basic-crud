using System.Net;

namespace Api.Responses
{
    public class Response
    {
        public int Success { get; set; } = 0;
        public object Body { get; set; }
        public HttpStatusCode Status { get; set; }
    }
}
