using System;
using System.IO;

namespace Fileinfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            Console.WriteLine("********Demo FileInfo Class*******\n");

            File.WriteAllText(FileName, "HelloWorld.");
            Console.WriteLine("ReadFile: ");
            string content = File.ReadAllText(FileName);
            Console.WriteLine(content);
            Console.WriteLine("File information: ");
            FileInfo testFile = new FileInfo(FileName);
            Console.WriteLine($"Name: {testFile.Name}");
            Console.WriteLine(testFile.CreationTime);
            Console.WriteLine(testFile.LastWriteTime);
            Console.WriteLine(testFile.DirectoryName);
            Console.ReadLine();
        }
    }
}
