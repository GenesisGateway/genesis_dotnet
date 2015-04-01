using System;
using System.IO;
using System.Linq;
using System.Net;

namespace Genesis.Net.Specs.Mocks
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