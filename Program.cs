using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Bai_tap_file_io
{
    class Program
    {
        public static string tree(string args)
        {
            string[] folder=Directory.GetDirectories(args);
            string[] files=Directory.GetFiles(args);
            for (int i = 0; i < folder.Length; i++)
            {
                    string[] files2=Directory.GetFiles(folder[i]);
                    string[] folder2=Directory.GetDirectories(folder[i]);
                    for (int j = 0; j < folder2.Length; j++)
                    {
                       args+="\n" + "|" + "\n" +"├── " +folder[i]+"\n"+"\t└──"+folder2[j]; 
                    }
            }
             return args;
        }
        static void Main(string[] args)
        {
                    
            string kq = tree("/home/ducanh/Desktop/folder/");
            System.Console.WriteLine(kq);
        }
    }
}
