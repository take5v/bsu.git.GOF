using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public static class StreamFactoryMethod
    {
        public static IStream GetMemoryStream()
        {
            return new MemoryStream();
        }

        public static IStream GetFileStream(string fileName)
        {
            return new FileStream(fileName);
        }

        public static IStream GetDecorateCompressionStream(IStream stream)
        {
            return new CompressingStream(stream);
        }

        public static IStream GetDecorateAscii7Stream(IStream stream)
        {
            return new Ascii7Stream
            {
                Stream = stream
            };
        }
    }
}
