
using MergeSortLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to generate file?(y/n): ");
            String genFile = Console.ReadLine();
            String FileEncod;
            if (genFile == "y")
            {
                Console.Write("Enter file path: ");
                String genFilePath = Console.ReadLine();
                Console.Write("Enter file encoding Unicode/MBSC/UTF-16: ");
                FileEncod = Console.ReadLine();
                if (FileEncod == "Unicode")
                    TextFileGenerator.GenerateTextFile(genFilePath, 1_000_000_000, System.Text.Encoding.UTF8);
                else if (FileEncod == "MBSC")
                        TextFileGenerator.GenerateTextFile(genFilePath, 500_000_000,  System.Text.Encoding.BigEndianUnicode);
                    else if(FileEncod == "UTF-16")
                            TextFileGenerator.GenerateTextFile(genFilePath, 500_000_000, System.Text.Encoding.Unicode);
                else
                {
                    Console.WriteLine("Incorrect Encoding type");
                    Console.Write("Press any key to exit...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Console.Write("Enter sort file path: ");
            String filepath = Console.ReadLine();
            Console.Write("Enter sort type(\"as\" for ascending and \"des\" for descending): ");
            String sortType = Console.ReadLine();


            Boolean isAscending = true;
            if (sortType == "as")
                isAscending = true;
            else if (sortType == "des")
                isAscending = false;
            else
            {
                Console.WriteLine("Incorrect sort type");
                Console.Write("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //String textFilePath = @"D:\Test\test.tmp";
            String tempPath = @"D:\Test\Temp";
            Console.WriteLine("Sort...");
            MergeSort mergeSorter = new MergeSort();
            //Console.Write("Enter file encoding Unicode/MBSC/UTF-16: ");
            //FileEncod = Console.ReadLine();
            //if (FileEncod == "Unicode")
            //    mergeSorter.Sort(filepath, isAscending, 50_000_000, tempPath);
            //else if (FileEncod == "MBSC")
            //    mergeSorter.Sort(filepath, isAscending, 50_000_000, tempPath, 16);
            //else if (FileEncod == "UTF-16")
            //    mergeSorter.Sort(filepath, isAscending, 50_000_000, tempPath, 16);
            mergeSorter.Sort(filepath, isAscending, 50_000_000, tempPath);

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
