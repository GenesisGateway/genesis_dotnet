using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Genesis.Net.Specs.Mocks
{
    class MockWebRequest : WebRequest
    {
        readonly MemoryStream requestStream;
        readonly MemoryStream responseStream;

        public override WebHeaderCollection Headers { get; set; }
        public override string Method { get; set; }
        public override string ContentType { get; set; }
        public override long ContentLength { get; set; }

        public MockWebRequest(string response)
        {
            requestStream = new MemoryStream();
            Headers = new WebHeaderCollection();
            responseStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(response));
        }

        public override Stream GetRequestStream()
        {
            return requestStream;
        }

        public override Task<WebResponse> GetResponseAsync()
        {
            return Task.FromResult<WebResponse>(new MockWebResponse(responseStream));
        }

        public override WebResponse GetResponse()
        {
            return new MockWebResponse(responseStream);
        }
    }
}
