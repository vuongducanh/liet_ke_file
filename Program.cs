using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Bai_tap_file_io
{
    class Program
    {
        public static void tree(string args )
        {
            string[] folder=Directory.GetDirectories(args);
            string[] files=Directory.GetFiles(args);

            if(folder.Length>0){
                for (int i = 0; i < folder.Length; i++)
                {
                    string extension = Path.GetFileName(folder[i]);
                    args+="\n"+"│"  +"\n"+ "├── "+"["+extension+"]"; 
                    tree(folder[i]);
                }
            }
            if(files.Length>0){
                for (int i = 0; i < files.Length; i++)
                {
                    string extension = Path.GetFileName(files[i]);
                    args+="\n"+ "│" +"\n"+ "├──"+extension; 
                }
                 System.Console.WriteLine(args); 
            }
        }
        static void Main(string[] args)
        {
            string input = "/home/ducanh/Desktop/folder/";
            System.Console.WriteLine(Path.GetFileName(input));
            tree(input);
        }
    }
}
