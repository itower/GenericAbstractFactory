/// <summary>
/// Test Harness
/// </summary>
namespace TestGenericAbstractFactory
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new HttpUrlRequestFactory");

            var factory = new HttpRequestFactory<IHttpRequest, HttpUrlRequest>();

            Console.WriteLine("Created a HttpUrlRequestFactory");

            Console.WriteLine("Creating a HttpJsonRequestFactory");

            var factoryJson = new HttpRequestFactory<IHttpRequest, HttpJsonRequest>();

            Console.WriteLine("Created a HttpJsonRequestFactory");

            Console.WriteLine(factory.Create().MakeRequestAndGetResponse("A setting", "A parameter"));

            Console.WriteLine(factoryJson.Create().MakeRequestAndGetResponse("A setting", "A parameter"));

            Console.Read();
        }
    }
}
