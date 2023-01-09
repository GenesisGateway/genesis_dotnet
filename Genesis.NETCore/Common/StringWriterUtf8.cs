using System.IO;
using System.Text;

namespace Genesis.NetCore.Common
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
