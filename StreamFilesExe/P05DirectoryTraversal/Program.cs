using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P05DirectoryTraversal
{
    class Program
    {
        public static void Main(string[] args)
        {
            var filesByExtension = new Dictionary<string, Dictionary<string, long>>();

            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);

            var files = di.GetFiles();

            foreach (var file in files)
            {
                var extension = file.Extension;

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension.Add(extension, new Dictionary<string, long>());
                }

                filesByExtension[extension].Add(file.Name, file.Length);
            }

            filesByExtension = filesByExtension
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            using (var streamWriter = new StreamWriter("../../../report.txt"))
            {
                foreach (var extension in filesByExtension)
                {
                    streamWriter.WriteLine(extension.Key);

                    var currentFile = extension.Value
                        .OrderBy(x => x.Value)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var file in currentFile)
                    {
                        streamWriter.WriteLine($"--{file.Key} - {(file.Value / 1000.0):F3}kb");
                    }
                }
            }

        }
    }
}
