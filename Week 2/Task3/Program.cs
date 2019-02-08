﻿using System;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void PrintSpaces(int level)
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("     ");
            }
        }

        public static void Ex5(DirectoryInfo directory, int level)
        {
            foreach (FileInfo f in directory.GetFiles())
            {
                PrintSpaces(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in directory.GetDirectories()){
                PrintSpaces(level);
                Console.WriteLine(d.Name);
                Ex5(d, level+1);
            }
        }

        static void Main(string[] args)
        {
            Ex5(new DirectoryInfo("C:/KBTU study/2nd semester/PP2/Week 2/Task3"), 1);
        }
    }
}