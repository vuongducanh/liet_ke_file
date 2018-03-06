using System;
using System.IO;

namespace directory
{
   class Program
   {
    

       static void tree(string args,string padding){
           string[] path = Directory.GetDirectories(args);
           string[] files = Directory.GetFiles(args);
           if (path.Length>0){
               for (int x = 0; x< path.Length; x++){                    
                   string getfile = Path.GetFileName(path[x]);
                   if (x==path.Length-1){                        
                       if (files.Length>0){
                           System.Console.WriteLine(padding+"  ├──"+"["+getfile+"]");                            
                           tree(args+"//"+getfile,padding+"  │  ");
                       }
                       else{
                           System.Console.WriteLine(padding+"  └──"+"["+getfile+"]");                            
                           tree(args+"//"+getfile,padding+"     ");
                       }
                   }
                   else{
                       System.Console.WriteLine(padding+"  ├──"+"["+getfile+"]");                      
                       tree(args+"//"+getfile,padding+"  │  ");
                   }                    
               }
           }
           for( int y = 1; y<= files.Length; y++){
               string current_file = Path.GetFileName(files[y-1]);
                if (y==files.Length){
                       System.Console.WriteLine(padding+"  └──"+current_file);                      
                   }
                   else{
                       System.Console.WriteLine(padding+"  ├──"+current_file);                        
                   }
           }
       }
        static void Main(string[] args)        
       {                    
           System.Console.Write("ban  nhap vao duong dan input =  : ");
           string input = Convert.ToString(Console.ReadLine());
            // @"C:\Users\DucAnh\Desktop\testree";
           System.Console.WriteLine(Path.GetFileName(input));
           tree(input,"");      
       }
   }
}