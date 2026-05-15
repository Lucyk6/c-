namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Folder";
            DirectoryInfo folder = new DirectoryInfo(path);
            Console.WriteLine(folder.FullName);
            Console.WriteLine(folder.Name);
            Console.WriteLine(folder.Root);
            Console.WriteLine(folder.LinkTarget);
            Console.WriteLine(folder.Extension);
            Console.WriteLine(folder.CreationTime);
            Console.WriteLine(folder.LastAccessTime);
            Console.WriteLine(folder.LastWriteTime);
            if (folder.Exists) {
                folder.Delete();
            }
            else 
            { 
                Console.WriteLine("NOT");
            }


            //if (!folder.Exists)
            //{
            //    folder.Create();
            //}

            DirectoryInfo parentFolder=folder.Parent;
            foreach (var Files in parentFolder.GetFiles())
            {
                if (Files.Extension == ".ico")
                    Console.WriteLine($"{Files.FullName}{Files.CreationTime}");
               
                Console.WriteLine($"{Files.Name} {Files.CreationTime}");
            }

        }
    }
}
