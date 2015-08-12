using System;
using System.Net;

namespace Genesis.Net.Specs.Mocks
{
    class MockWebRequestCreate : IWebRequestCreate
    {
        static WebRequest nextRequest;
        static readonly object lockObject = new object();

        static public WebRequest NextRequest
        {
            get
            {
                return nextRequest;
            }
            set
            {
                lock (lockObject)
                {
                    nextRequest = value;
                }
            }
        }

        public WebRequest Create(Uri uri)
        {
            return nextRequest;
        }

        public static void SetResponseForNextMockHttpWebRequest(string response)
        {
            var httpWebRequest = new MockWebRequest(response);
            NextRequest = httpWebRequest;
        }
    }
}