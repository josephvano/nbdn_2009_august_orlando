using System;
using System.IO;

namespace nothinbutdotnetstore.win.core
{
    public class SimpleFileInfoImpl : SimpleFileInfo {
        readonly FileInfo file_info;

        public SimpleFileInfoImpl(FileInfo file_info)
        {
            this.file_info = file_info;
        }

        public string name
        {
            get { return file_info.Name; }
        }
    }
}