using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FileStream : AbstractStream
    {
        public FileStream(string fileName)
        {
            Stream = new System.IO.FileStream(fileName, FileMode.OpenOrCreate);
        }
    }
}
