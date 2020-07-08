using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsInfo = new Dictionary<string, int>();

            using (var streamReader = new StreamReader("text.txt"))
            {
                using (var streamReaderWords = new StreamReader("words.txt"))
                {
                    while (!streamReaderWords.EndOfStream)
                    {
                        var word = streamReaderWords.ReadLine();

                        if (!wordsInfo.ContainsKey(word))
                        {
                            wordsInfo.Add(word, 0);
                        }
                    }

                    var words = streamReader
                               .ReadToEnd()
                               .ToLower()
                               .Split(' ', '\n', '\r', ',', '-', '.', '?', '!')
                               .Where(x => wordsInfo.ContainsKey(x));
                    Console.WriteLine(string.Join(" ", words));
                    foreach (var currentWord in words)
                    {
                        if (wordsInfo.ContainsKey(currentWord))
                        {
                            wordsInfo[currentWord]++;
                        }
                    }
                }
            }
            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";

            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualResultPath, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
