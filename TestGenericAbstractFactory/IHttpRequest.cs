/// <summary>
/// The interface
/// required by the request
/// factory
/// </summary>
namespace TestGenericAbstractFactory
{
    public interface IHttpRequest
    {
        /// <summary>
        /// Makes the request and gets a response.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The server response</returns>
        string MakeRequestAndGetResponse(string settings, string parameters);
    }
}
