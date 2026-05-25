using System;
using System.Text;

    //FileStream;
    //StreamReader;
    //StreamWriter;
    //BinaryReader;
    //BinaryWriter;
    string path = "test.dat";
    using (FileStream file = new FileStream(path, FileMode.Create)) 
    {
    string text = "hello World";
    byte[] buffer = Encoding.UTF8.GetBytes(text);
    file.Write(buffer, 0, 4);
    file.Write(buffer,0,text.Length);
    }
    using (FileStream file = new FileStream(path, FileMode.Open))
  {
    //Console.WriteLine(file.Length);
    //Console.WriteLine(file.Name);
    //Console.WriteLine(file.ReadByte());
    //file.Seek(1, SeekOrigin.Begin);
    //Console.WriteLine(file.Position);
    byte[] buffer = new byte[file.Length];
    file.Read(buffer, 0, buffer.Length);
    Console.WriteLine(Encoding.UTF8.GetString(buffer));
  }
   using (StreamReader file = new StreamReader(path, true))
{
    string text = "hello World";
    file.WriteLine(text);
}
using(StreamReader file = new StreamReader(path))
{
    Console.WriteLine(file.ReadToEnd());
}
