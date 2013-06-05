using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = new byte[5000];
            const int intVal = int.MaxValue;

            for (var i = 0; i < bytes.Length; ++i)
                bytes[i] = (byte)i;

            var fileStream = StreamFactoryMethod.GetFileStream("fileStream.txt");
            fileStream.PutBytes(bytes);
            fileStream.PutInt(intVal);
            fileStream.HandleBufferFull();

            var compressedFileStream = StreamFactoryMethod.GetDecorateCompressionStream(
                StreamFactoryMethod.GetFileStream("compressedFileStream.txt"));
            compressedFileStream.PutBytes(bytes);
            compressedFileStream.PutInt(intVal);
            compressedFileStream.HandleBufferFull();

            var acsii7FileStream = StreamFactoryMethod.GetDecorateAscii7Stream(
                StreamFactoryMethod.GetFileStream("ascii7FileStream.txt"));
            acsii7FileStream.PutBytes(bytes);
            acsii7FileStream.PutInt(intVal);
            acsii7FileStream.HandleBufferFull();

            var acsii7CompressedFileStream = StreamFactoryMethod.GetDecorateAscii7Stream(
                StreamFactoryMethod.GetDecorateCompressionStream(
                StreamFactoryMethod.GetFileStream("acsii7CompressedFileStream.txt")));
            acsii7CompressedFileStream.PutBytes(bytes);
            acsii7CompressedFileStream.PutInt(intVal);
            acsii7CompressedFileStream.HandleBufferFull();
        }
    }
}
