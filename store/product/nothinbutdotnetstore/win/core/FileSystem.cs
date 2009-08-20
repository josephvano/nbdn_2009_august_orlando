using System.Collections.Generic;

namespace nothinbutdotnetstore.win.core
{
    public interface FileSystem
    {
        IEnumerable<string> get_directories(string path);
    }
}