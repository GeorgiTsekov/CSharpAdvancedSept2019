using System;
using System.IO;

namespace P04CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (var streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (var streamWriter = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        var byteArray = new byte[4096];

                        var size = streamReader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        streamWriter.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
