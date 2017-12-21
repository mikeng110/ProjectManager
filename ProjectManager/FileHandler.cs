using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmProjectCreator
{
    public class FileHandler
    {
        public string RootDirectory {get;set;}

        public FileHandler()
        {
            RootDirectory = "";
        }

        public void GenerateFile(IFile file)
        {
            var path = GeneratePath(file.Path);
            if (path != "" && !Directory.Exists(path))
            {
                GenerateDirectory(path);
            }

            var writer = new StreamWriter(path + file.FileName + "." + file.Extension);
            file.Content.ForEach(line => {
                writer.WriteLine(line);
            });
            writer.Close();
        }

        public void GenerateDirectory(string directory)
        {
            var container = new List<string>();
            container.Add(directory);
            GenerateDirectories(new List<string>(container)); 
        }

        public void GenerateDirectories(List<String> Directories)
        {
            Directories.ForEach(directory => {
                Directory.CreateDirectory(GeneratePath(directory));
            });
        }
        private string GeneratePath(string directory)
        {
            return RootDirectory == "" ? directory : RootDirectory + "/" + directory ;
        }
    }
}
