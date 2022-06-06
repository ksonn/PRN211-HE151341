﻿using System;
using System.IO;
using System.Text;

namespace Slot12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Demo FileStream Class*****\n");
            using FileStream fStream = File.Open("MyFile.dat",FileMode.Create);
            String msg = "BCDEF";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fStream.Position = 0;
            Console.WriteLine("Print mesage as an array of bytes : \n");
            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++) {
                bytesFromFile[i] = (byte)fStream.ReadByte();
                Console.Write($"{bytesFromFile[i],5}");

            }
            Console.Write("\nDecoded Message : ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.ReadLine();
        }
    }
}
