using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Ascii7Stream : IStreamDecorator
    {
        public IStream Stream { get; set; }

        public Ascii7Stream() { }

        public Ascii7Stream(IStream stream)
        {
            Stream = stream;
        }

        public void PutBytes(byte[] bytes)
        {
            // from default encoding to US-ASCII(7 bit)
            Stream.PutBytes(Encoding.Convert(Encoding.Default, Encoding.ASCII, bytes));
        }

        public void PutInt(int number)
        {
            PutBytes(BitConverter.GetBytes(number));
        }

        public void HandleBufferFull()
        {
            Stream.HandleBufferFull();
        }
    }
}
