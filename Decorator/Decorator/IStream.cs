using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IStream
    {
        void PutBytes(byte[] bytes);

        void PutInt(int number);

        void HandleBufferFull();
    }
}
