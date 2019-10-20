using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLib
{
    public class MergeSort
    {
        private delegate Int32 StringCompareDelegate(String str1, String str2);

        internal class MergePair
        {
            public MergePair(StreamReader streamReader)
            {
                StreamReader = streamReader;
                FirstLine = streamReader.ReadLine();
            }

            ~MergePair()
            {
                StreamReader.Dispose();
            }

            public StreamReader StreamReader;
            public String FirstLine;
        }

        public MergeSort()
        {
        }

        private void CheckParameters(String sourceFilePath, Int64 maxTempFileSize, ref String tempFilesPath)
        {
            if (!File.Exists(sourceFilePath))
                throw new Exception("File not found");
            if (maxTempFileSize > 250_000_000)
                throw new Exception("Too large temp file size.");
            if (maxTempFileSize < 1_000_000)
                throw new Exception("Too small temp file size.");
            if (string.IsNullOrEmpty(tempFilesPath))
            {
                tempFilesPath = Path.Combine(Path.GetTempPath(),"MergeSortTempDirectory");
                if (Directory.Exists(tempFilesPath))
                    Directory.CreateDirectory(tempFilesPath);
            } 
            else
            {
                if (!Directory.Exists(tempFilesPath))
                    throw new Exception("Temp directory does not exist");
            }
        }

        public void Sort(String sourceFilePath, Boolean isAscending = true, Int64 maxTempFileSize = 25_000_000, String tempFilesPath = null)
        {   
            try
            {
                CheckParameters(sourceFilePath, maxTempFileSize, ref tempFilesPath);
            }
            catch (Exception e)
            {
                throw e;
            }

            StringCompareDelegate compareFunc;
            if (isAscending)
                compareFunc = SortAscending;
            else
                compareFunc = SortDescending;

            List<String> tempFiles = this.DivideFile(sourceFilePath, tempFilesPath, maxTempFileSize);
            SortTempFiles(tempFiles, compareFunc);
            List<MergePair> mergePairs = CreatePairs(tempFiles);
            CreateResultFile(sourceFilePath, mergePairs, compareFunc);

            /*using (StreamWriter streamWriter = new StreamWriter(sourceFilePath))
            {
                while (mergePairs.Count != 0)
                    streamWriter.WriteLine(GetSuitableString(mergePairs, compareFunc));
            }*/

            foreach (String filename in tempFiles)
                File.Delete(filename);
        }

        private void CreateResultFile(String sourceFilePath,List<MergePair> mergePairs,StringCompareDelegate compareFunc)
        {
            using (StreamWriter streamWriter = new StreamWriter(sourceFilePath))
            {
                while (mergePairs.Count != 0)
                    streamWriter.WriteLine(GetSuitableString(mergePairs, compareFunc));
            }
        }

        private static Int32 SortAscending(String string1, String string2)
        {
            return String.Compare(string1, string2, false);
        }

        private static Int32 SortDescending(String string1, String string2)
        {
            return String.Compare(string2, string1, false);
        }

        private String GetSuitableString(List<MergePair> mergePairs, StringCompareDelegate comparedelegate)
        { 
            MergePair suitablePair = mergePairs[0];
            foreach (MergePair mergePair in mergePairs)
            {
                Int32 compareResult = comparedelegate(suitablePair.FirstLine, mergePair.FirstLine);
                if (compareResult > 0)
                    suitablePair = mergePair;
            }

            String result = suitablePair.FirstLine;
            suitablePair.FirstLine = null;

            if (!RefreshPair(suitablePair))
            {
                mergePairs.Remove(suitablePair);
                suitablePair.StreamReader.Close();
            }

            return result;
        }

        private Boolean RefreshPair(MergePair mergePair)
        {
            if (String.IsNullOrEmpty(mergePair.FirstLine))
            {
                if (!mergePair.StreamReader.EndOfStream)
                {
                    mergePair.FirstLine = mergePair.StreamReader.ReadLine();
                    return true;
                }
                return false;
            }
            return false;
        }

        private List<String> DivideFile(String filepath,String tempPath , Int64 maxTempFileSize)
        {
            FileInfo fileInfo = new FileInfo(filepath);
            Int64 tempFileCount = (Int64)Math.Ceiling(fileInfo.Length / (Double)maxTempFileSize);
            List<String> tempFiles = new List<String>();
            using (StreamReader streamReader = new StreamReader(fileInfo.FullName))
            {
                for (Int32 i = 0; i < tempFileCount; i++)
                {
                    String tempFileName = Path.Combine(tempPath, "mergetemp" + i.ToString() + ".tmp");

                    if (File.Exists(tempFileName))
                        File.Delete(tempFileName);

                    using (StreamWriter streamWriter = new StreamWriter(tempFileName))
                    {
                        Int64 tempFileSize = 0;
                        while ((tempFileSize < maxTempFileSize) && (!streamReader.EndOfStream))
                        {
							///!!!
                            String tempString = streamReader.ReadLine();
                            tempFileSize += tempString.Length + 2;
                            streamWriter.WriteLine(tempString);
                        }
                    }
                    tempFiles.Add(tempFileName);
                }
            }
            return tempFiles;
        }

        private void SortTempFiles(List<String> tempFiles,StringCompareDelegate compareFunc)
        {
            foreach (var tempFile in tempFiles)
                this.SortFile(tempFile, compareFunc);
        }

        private void SortFile(String filePath, StringCompareDelegate compareFunc)
        {
            List<String> tempList = File.ReadLines(filePath).ToList();
            Comparison<String> comparison = new Comparison<String>(compareFunc);
            tempList.Sort(comparison);
            File.WriteAllLines(filePath, tempList);
        }

        private List<MergePair> CreatePairs(List<String> filePathes)
        {
            List<MergePair> mergePairs = new List<MergePair>();
            foreach (String filePath in filePathes)
                mergePairs.Add(new MergePair(new StreamReader(filePath)));
            return mergePairs;
        }
    }

}
