using System.IO;
using System.Net;

namespace Genesis.NetCore.Specs.Mocks
{
    class MockWebResponse : WebResponse
    {
        readonly Stream responseStream;

        public MockWebResponse(Stream responseStream)
        {
            this.responseStream = responseStream;
        }

        public override Stream GetResponseStream()
        {
            return responseStream;
        }
    }
}