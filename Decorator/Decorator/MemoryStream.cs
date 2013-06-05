using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MemoryStream : AbstractStream
    {
        public MemoryStream()
        {
            Stream = new System.IO.MemoryStream(new byte[1000]);
        }
    }
}
