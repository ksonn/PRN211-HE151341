using System;
using System.IO;
using System.Text;

namespace MyLibrary
{
    class Program
    {
        static void Main(String [] args)
        {
            Console.WriteLine("***** Demo FileStream Class*****");
            using FileStream stream = File.Open("MyFile.dat", FileMode.Create);

            String msg = "ABCDEF";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            stream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            stream.Position = 0;
            Console.WriteLine("Print msg as an array of bytes: \n");
            byte[] byteFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++)
            {
                byteFromFile[i] = (byte)stream.ReadByte();
                Console.Write($"{byteFromFile[i],5}");

            }
            Console.Write("\n Decoded Message: ");
                Console.WriteLine(Encoding.Default.GetString(byteFromFile));
            Console.ReadLine();
        }
    }
}
