/**
 * *************************************************
 * Copyright (c) 2019, Grant D. Miller
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
﻿using System;
using System.IO;

namespace cli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && File.Exists(args[0]))
            {
                Console.WriteLine("Read a file...");
                DateTime start = DateTime.Now;
                Console.WriteLine("Read started: " + start.ToLongTimeString());
                readFile(args[0]);
                DateTime end = DateTime.Now;
                Console.WriteLine("Read ended: " + end.ToLongTimeString());
                TimeSpan runlength = end - start;
                Console.WriteLine("Read Duration: " + runlength.TotalMilliseconds.ToString());
            } else {
                Console.WriteLine("Write a file...");
                DateTime start = DateTime.Now;
                Console.WriteLine("Write started: " + start.ToLongTimeString());
                createFile("test36m.txt", 3600000);
                DateTime end = DateTime.Now;
                Console.WriteLine("Write ended: " + end.ToLongTimeString());
                TimeSpan runlength = end - start;
                Console.WriteLine("Duration: " + runlength.TotalMilliseconds.ToString());
            }
        }

        static void readFile(string path) {
            using (FileStream fs = File.OpenRead(path)) 
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string line = reader.ReadLine();
                    while (line != null) 
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine(); 
                    }
                }
            }
        }

        static void createFile(string newFilename, int lineCount) {
            using (FileStream fs = File.OpenWrite(newFilename)) {
                using (StreamWriter writer = new StreamWriter(fs)) {
                    for (int i=0; i<lineCount; i++) {
                        writer.WriteLine(i.ToString() + " some text");
                    }          
                }
            }            
        }
    }
}
