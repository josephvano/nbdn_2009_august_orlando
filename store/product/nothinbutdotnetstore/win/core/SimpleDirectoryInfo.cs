using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.win.core
{
    public interface SimpleDirectoryInfo
    {
        IEnumerable<SimpleDirectoryInfo> get_directories();
        IEnumerable<SimpleFileInfo> get_files();
        string name { get; }
    }
}