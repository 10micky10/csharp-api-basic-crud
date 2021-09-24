using System.Net;

namespace Api.Responses
{
    public class ResponseBuilder
    {
        private static Response _response = new Response();

        public static Response Successfully(HttpStatusCode status, object body)
        {
            _response.Success = 1;
            _response.Status = status;
            _response.Body = body;
            return _response;
        }

        public static Response Error(HttpStatusCode status, object body)
        {
            _response.Status = status;
            _response.Body = body;
            return _response;
        }
    }
}
