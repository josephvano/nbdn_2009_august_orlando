using System.Collections.Generic;
using System.IO;

namespace nothinbutdotnetstore.win.core
{
    public class SimpleDirectoryInfoImpl : SimpleDirectoryInfo
    {
        readonly DirectoryInfo directory_info;

        public SimpleDirectoryInfoImpl(DirectoryInfo directory_info) {
            this.directory_info = directory_info;
        }

        public IEnumerable<SimpleDirectoryInfo> get_directories()
        {
            var directories = directory_info.GetDirectories();
            foreach(var directoryInfo in directories)
            {
                yield return new SimpleDirectoryInfoImpl(directoryInfo);
            }
        }

        public IEnumerable<SimpleFileInfo> get_files()
        {
            var files = directory_info.GetFiles();
            foreach(var fileInfo in files)
            {
                yield return new SimpleFileInfoImpl(fileInfo);
            }

        }

        public string name
        {
            get { return directory_info.Name; }
        }
    }
}