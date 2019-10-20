
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
            if (genFile == "y")
            {
                Console.Write("Enter file path: ");
                String genFilePath = Console.ReadLine();
                TextFileGenerator.GenerateTextFile(genFilePath, 1_000_000_000);
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
            mergeSorter.Sort(filepath, isAscending, 50_000_000, tempPath);
            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
