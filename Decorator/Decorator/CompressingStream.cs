﻿using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CompressingStream : IStreamDecorator
    {
        public IStream Stream { get; set; }

        public CompressingStream() { }

        public CompressingStream(IStream stream)
        {
            Stream = stream;
        }

        public void PutBytes(byte[] bytes)
        {
            Stream.PutBytes(Compress(bytes));
        }

        public void PutInt(int number)
        {
            PutBytes(System.BitConverter.GetBytes(number));
        }

        public void HandleBufferFull()
        {
            Stream.HandleBufferFull();
        }

        private static byte[] Compress(byte[] input)
        {
            using (var output = new System.IO.MemoryStream())
            {
                using (var compression = new GZipStream(output, CompressionMode.Compress))
                {
                    compression.Write(input, 0, input.Length);
                }

                return output.ToArray();
            }
        }
    }
}
