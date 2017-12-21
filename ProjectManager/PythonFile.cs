using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmProjectCreator
{
    public class PythonFile : IFile
    {
        public PythonFile()
        {
            self.FileName = "main";
            Path = "";
        }

        public PythonFile(string fileName)
        {
            FileName = fileName;
            Path = "";
        }
    }
}
