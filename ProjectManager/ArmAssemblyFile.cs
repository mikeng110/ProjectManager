using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmProjectCreator
{
    class ArmAssemblyFile : IFile
    {
        private string _path; 
        public string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = value == "" ? value : value + "/";
            }
        }

        public string FileName { get; set; }
   
        public string Extension
        {
            get
            {
                return "s";
            }
        }

        public List<string> Content { get; set; }

        public ArmAssemblyFile()
        {
            FileName = "main";
            Path = "";
        }

        public ArmAssemblyFile(string fileName)
        {
            FileName = fileName;
            Path = "";
        }

        public void SetDefaultContent()
        {
            List<string> content = new List<string>();

            content.Add(".global main");
            content.Add("main:");
            content.Add("   MOV R7, #4");
            content.Add("   MOV R0, #1");
            content.Add("   LDR R2, =len");
            content.Add("   LDR R1, =string");
            content.Add("   SWI 0");
            content.Add("   MOV R7, #1");
            content.Add("   SWI 0");
            content.Add(".data");
            content.Add("");
            content.Add("string:");
            content.Add(".ascii \"Hello World\\n\"");
            content.Add("len = . - string");

            Content = content;
        }
    }
}
