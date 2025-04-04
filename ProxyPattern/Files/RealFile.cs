
using System;
using System.IO;


namespace ProxyPattern.Files
{
    public class RealFile : IFile
    {
        private string filePath;
        private string content;

        public RealFile(string filePath)
        {
            this.filePath = filePath;
            Console.WriteLine(">> [RealFile] Файл відкрито.");
            content = File.ReadAllText(filePath);
        }

        public string Read()
        {
            return content;
        }
    }
}