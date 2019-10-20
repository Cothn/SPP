using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLib
{
    public static class TextFileGenerator
    {
        private static Random Random = new Random((int)DateTime.Now.Ticks);
        public static void GenerateTextFile(String outputFilePath, Int64 minfileSize)
        {
            Int64 fileLength = 0;
            using (StreamWriter streamWriter = new StreamWriter(outputFilePath))
            {
                Int32 newLineSymbolSize = streamWriter.NewLine.Length;
                while (fileLength < minfileSize)
                {
                    for (Int32 i = 0; i < 100; i++)
                    {
                        String randomString = GetRandomString();
                        fileLength += randomString.Length + newLineSymbolSize;
                        streamWriter.WriteLine(randomString);
                    }
                }
            }
        }

        private static String GetRandomString()
        {

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Int32 lenght = Random.Next(100, 1000);
            StringBuilder builder = new StringBuilder(lenght);

            for (int i = 0; i < lenght; ++i)
                builder.Append(chars[Random.Next(chars.Length)]);

            return builder.ToString();
        }

    }
}
