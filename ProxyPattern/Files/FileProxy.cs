using System.IO;
using System.Windows.Forms;

namespace ProxyPattern.Files
{
    public class FileProxy : IFile
    {
        private string filePath;
        private RealFile realFile;

        public FileProxy(string filePath)
        {
            this.filePath = filePath;
        }

        public string Read()
        {
            if (realFile == null)
            {
                MessageBox.Show(">> [Proxy] Вперше відкриваємо файл через проксі...");
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("Файл не знайдено", filePath);

                realFile = new RealFile(filePath);
            }

            return realFile.Read();
        }
    }
}
