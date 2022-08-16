using System.Net;

namespace ADP.Model.DTO
{
    public class RequestResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
