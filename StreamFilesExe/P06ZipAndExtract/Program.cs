using System;
using System.IO.Compression;
using System.IO;

namespace P06ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "copyMe.png";
            string zipFile = "../../myNewZip.zip";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }

            ZipFile.ExtractToDirectory(zipFile, "../../");
        }
    }
}
