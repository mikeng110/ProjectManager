using ArmProjectCreator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjectManager
{
    //todo 
    //add ability to open project in explorer or even choosen code editor.
    public partial class Form1 : Form
    {
        private string _projectName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            GenerateProject(_projectName);
            btn_create.Enabled = false;
            btn_transfer.Enabled = true;
            lb_output.Text = "Project Named " + _projectName + " Created";
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            Transfer(_projectName);
            lb_output.Text = "Project Named " + _projectName + " Sent To Desination";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //improve this to take in account on server side to.
            _projectName = tbx_project_name.Text;
            tbx_project_name.Text = "";
            lbx_output.Items.Clear();
            if (_projectName == "")
            {
                var projects = GetAllProjects();
                projects.ForEach(project => {
                    lbx_output.Items.Add(project);
                });
                btn_create.Enabled = false;
                btn_transfer.Enabled = false;
                lb_output.Text = "";

            }
            else if (Directory.Exists(_projectName))
            {
                btn_create.Enabled = false;
                btn_transfer.Enabled = true;
                lbx_output.Items.Add(_projectName);                 
            }
            else
            {
                btn_transfer.Enabled = false;
                btn_create.Enabled = true;
                tbx_project_name.Text = _projectName;
                lb_output.Text = "No Existing Project Named " + _projectName + " Found, you can create it.";
            }
        }

        public static void GenerateProject(string projectName)
        {
            var fileHandler = new FileHandler();
            fileHandler.RootDirectory = projectName;

            fileHandler.GenerateDirectory("src"); //rewrite GD()
            fileHandler.GenerateDirectory("bin");

            var file = new ArmAssemblyFile();
            file.SetDefaultContent();
            file.Path = "src";

            fileHandler.GenerateFile(file);

            var buildFile = new PythonFile("build");
            var buildContent = new List<string>();
            buildContent.Add("import os");
            buildContent.Add("os.system(\"as -o src/main.o src/main.s\")");
            buildContent.Add("os.system(\"gcc -o bin/main src/main.o\")");
            buildContent.Add("os.system(\"./bin/main\")");
            buildFile.Content = buildContent;
            fileHandler.GenerateFile(buildFile);
        }

        private void lbx_output_SelectedIndexChanged(object sender, EventArgs e)
        {
             var selectedIndex = lbx_output.SelectedIndex;
            if (selectedIndex > -1 && lbx_output.GetSelected(selectedIndex))
            {
                _projectName = lbx_output.SelectedItem.ToString();
                btn_create.Enabled = false;
                btn_transfer.Enabled = true;
            }
        }

        public static void Transfer(string fileName)
        {
            string destination = ConfigurationManager.ConnectionStrings["destination_ip"].ConnectionString;
            string username = ConfigurationManager.ConnectionStrings["username"].ConnectionString;
            string password = ConfigurationManager.ConnectionStrings["password"].ConnectionString;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "pscp";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            startInfo.Arguments = "-pw " + password + " -r " + fileName + " " + username + "@" + destination + ":";

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }
        public List<string> GetAllProjects()
        {
            var allProjects = new List<string>();
            var dir = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (string directory in dir)
            {
                string temp = directory.Split('\\').Last();
                allProjects.Add(temp);
            }

            return allProjects;
        }

        
    }
}
