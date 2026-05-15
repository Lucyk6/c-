using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Logs";
            DirectoryInfo folder = new DirectoryInfo(path);
 
            if (!folder.Exists)
            {
                folder.Create();
            }

            DirectoryInfo parentFolder=folder.Parent;
 
            DirectoryInfo subDirectory = folder.CreateSubdirectory(parentFolder.Name);

            if (subDirectory.Exists)
            {
                Console.WriteLine(subDirectory.CreationTime);
            }

            string path2 = @"C:\Users\Student\Downloads\aboba";
            DirectoryInfo dir = new DirectoryInfo(path2);
            foreach(FileInfo file in dir.GetFiles())
            {
                double sizeinkb = file.Length / 1024;
                if (file.Extension==".txt"|| file.Extension == ".pdf")
                {
                    Console.WriteLine($"{file.Name},{sizeinkb},{file.CreationTime}");
                }

            }


        }

    }
    
}
