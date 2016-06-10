/// <summary>
/// A faked example of a URL
/// request
/// </summary>
namespace TestGenericAbstractFactory
{
    /// <summary>
    /// A class to make an HttpRequest
    /// with the desired parameters in the URL
    /// </summary>
    /// <seealso cref="TestGenericAbstractFactory.IHttpRequest" />
    public class HttpUrlRequest : IHttpRequest
    {
        public string MakeRequestAndGetResponse(string settings, string parameters)
        {
            return "I am a new instance of a url request";
        }
    }
}
