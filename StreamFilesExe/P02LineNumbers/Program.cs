using System;
using System.IO;
using System.Linq;
using System.Text;

namespace P02LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            using (var streamReader = new StreamReader("text.txt"))
            {
                var lineCounter = 0;

                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();

                    var countOfLetters = 0;
                    var countOfSymbols = 0;

                    foreach (var character in line)
                    {
                        if (char.IsLetter(character))
                        {
                            countOfLetters++;
                        }
                        else if(char.IsPunctuation(character))
                        {
                            countOfSymbols++;
                        }
                    }

                    var result = $"Line {++lineCounter}: {line} ({countOfLetters})({countOfSymbols})";

                    sb.AppendLine(result);
                }
            }

            File.WriteAllText("output.txt", sb.ToString());
        }
    }
}
