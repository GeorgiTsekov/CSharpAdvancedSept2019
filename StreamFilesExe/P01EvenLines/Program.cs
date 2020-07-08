using System;
using System.IO;
using System.Linq;
using System.Text;

namespace P01EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            using (var streamReader = new StreamReader("text.txt"))
            {
                var lineCounter = 0;

                var symbolsToReplace = new[] { "-", ",", ".", "!", "?" };

                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();

                    if (lineCounter % 2 == 0)
                    {
                        string[] words = line
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        for (int i = 0; i < words.Length; i++)
                        {
                            var currendWord = words[i];

                            foreach (var symbol in symbolsToReplace)
                            {
                                currendWord = currendWord.Replace(symbol, "@");
                            }

                            words[i] = currendWord;
                        }

                        var result = string.Join(" ", words.Reverse());
                        sb.AppendLine(result);
                        Console.WriteLine(result);
                    }

                    lineCounter++;
                }
            }

            File.WriteAllText("output.txt", sb.ToString());
        }
    }
}
