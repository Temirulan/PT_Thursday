using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTest
{
    class Program
    {

        static void print(List<Object> entries, int pos)
        {
            Console.SetCursorPosition(0, 0);
            int cur = 0;
            foreach (Object obj in entries)
            {
                if (cur == pos)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                cur = cur + 1;
                if (obj is DirectoryInfo)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(((DirectoryInfo)obj).Name);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(((FileInfo)obj).Name);
                }
            }
        }

        static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\Desktop";
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            List<Object> entries = new List<Object>();
            foreach (DirectoryInfo directory1 in directories)
            {
                entries.Add(directory1);
            }
            foreach (FileInfo file in files)
            {
                entries.Add(file);
            }

            int pos = 0;
            
            while (true)
            {
                print(entries, pos);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pos > 0)
                    {
                        pos--;
                    } else
                    {
                        pos = entries.Count - 1;
                    }
                } else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (pos + 1 < entries.Count)
                    {
                        pos++;
                    } else
                    {
                        pos = 0;
                    }
                } else
                {
                }                
            }
        }
    }
}
