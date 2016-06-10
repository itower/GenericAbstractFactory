/// <summary>
/// The contract
/// for a new 
/// instance of the request factory
/// </summary>
/// <typeparam name="TRequestInterface"></typeparam>
public interface IHttpRequestFactory<TRequestInterface>
{
    /// <summary>
    /// Creates an instance of
    /// the HttpRequest factory
    /// </summary>
    /// <returns>A new factory of the desired type</returns>
    TRequestInterface Create();

}
