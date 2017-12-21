using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmProjectCreator
{
    public interface IFile
    {
        string Path { get; set; }
        string FileName { get; set; }
        string Extension { get; }
        List<string> Content { get; set; }
    }
}
