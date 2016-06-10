/// <summary>
/// Creates A URL request
/// providing it implements
/// IHttpRequest
/// </summary>
namespace TestGenericAbstractFactory
{
    /// <summary>
    /// Pass an IHttpRequest
    /// then the type you
    /// want created
    /// then creates a new 
    /// instance of the desired type
    /// of request
    /// </summary>
    /// <typeparam name="TRequestInterface">The type of the request interface.</typeparam>
    /// <typeparam name="TRequestInstance">The type of the request instance.</typeparam>
    /// <seealso cref="IHttpRequestFactory{TRequestInterface}" />
    public class HttpRequestFactory<TRequestInterface, TRequestInstance> : IHttpRequestFactory<TRequestInterface>
        where TRequestInstance : IHttpRequest, TRequestInterface, new()
    {
        /// <summary>
        /// Creates a HttpRequestFactory
        /// </summary>
        /// <returns>A HttpRequestFactory of desired type</returns>
        public TRequestInterface Create()
        {
            TRequestInterface httpRequest = new TRequestInstance();

            return httpRequest;
        }
    }
}
