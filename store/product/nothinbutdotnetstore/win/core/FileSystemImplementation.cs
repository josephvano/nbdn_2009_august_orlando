using System.Collections.Generic;
using System.IO;

namespace nothinbutdotnetstore.win.core
{
    public class FileSystemImplementation : FileSystem
    {
        public IEnumerable<string> get_directories(string path)
        {
            return Directory.GetDirectories(path);
        }
    }
}