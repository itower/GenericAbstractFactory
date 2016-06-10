/// <summary>
/// Makes a new JSON POST
/// to the server and receives a response
/// </summary>
namespace TestGenericAbstractFactory
{
    public class HttpJsonRequest : IHttpRequest
    {
        public string MakeRequestAndGetResponse(string settings, string parameters)
        {
            return "I am a new instance of a json request";
        }
    }
}
