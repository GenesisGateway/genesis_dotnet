using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Genesis.Net.Common
{
    internal class StringWriterUtf8 : StringWriter
    {
        public override Encoding Encoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }
    }
}
