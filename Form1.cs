namespace TestTunnerGUI2
{
    #region using

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// TestRunnerGUI app start window.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Fields and Constants;

        protected string pathToRepo; //A variable that stores the full path to the test repository.
        protected string pathToTool; //A variable that stores the full path to the tool/framework that runs the tests.
        protected string pathToConfigs; //A variable that stores the full path to the configuration files for the tests.
        protected string pathToLogs; //A variable that stores the full path to the test log files.
        protected bool isAnyNodeInTreeviwRepoChecked; //A flag indicating whether any tree node has been checked.
        protected bool isAnyNodeInTreeviwConfigsChecked; //A flag indicating whether any tree node has been checked.
        protected TreeView tempTree; //Temporary tree to save changes.
        protected bool wasAnyNodeInTreeviewRepoSelected; //A flag indicating was any tree node selected. Needs to prevent null refferance.
        protected string repoFolder; //A variable that stores the address of the repo folder. Required as an argument to launch the terminal.
        protected string configsFolder; //A variable that stores the address of the configs folder. Required as an argument to launch the terminal.
        protected string toolFolder; //A variable that stores the address of the toolbox folder. Required as an argument to launch the terminal.
        protected string logsFolder; // A variable that stores the address of the logs folder. Required as an argument to launch the terminal.
        protected string command; //A variable containing a formatted list of commands (also as a single command).
        protected bool testWasCheched; //A flag indicating whether at least some test was selected.
        protected string testProject;//A the variable is required to generate the terminal command for each test. Stores the test project path.
        protected string testName; //A variable is required to generate the terminal command for each test. Stores the full test file path without the project path.
        protected string testConfig; //A variable is required to generate the terminal command for each test. Stores the path of the configuration file with which to run the test
        protected string singleCommand; //A variable that stores a command for the terminal to run one specified test.
        protected string tests; //Temporary variable;
        protected List<string> testList; //A list of the full paths (relative) of cheched nodes in the tree repo.

        #endregion

        #region Private methods

        /// <summary>
        /// Occurs before a form is displayed for the first time.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Hadles a Click event on PictureBoxRepoFolder.
        /// Select a folder with the tests.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxRepoFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogRepo.ShowDialog() == DialogResult.Cancel)
                return;            
            pathToRepo = folderBrowserDialogRepo.SelectedPath;
            textBoxPathToRepo.Text = pathToRepo;
            repoFolder = pathToRepo.Substring(0, pathToRepo.LastIndexOf('\\'));
            MessageBox.Show("Path to repo/tests accepted.");
            PopulateTreeView(pathToRepo, treeViewRepo);
            treeViewRepo.ExpandAll();
            return;
        }

        /// <summary>
        /// Hadles a press Enter event in TextBoxPathToRepo.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxPathToRepo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToRepo.Text != null && textBoxPathToRepo.Text.Length > 0)
                {
                    pathToRepo = textBoxPathToRepo.Text;
                    if (!Directory.Exists(pathToRepo))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToTool.Text = pathToRepo;
                        return;
                    }
                    else
                    {
                        repoFolder = pathToRepo.Substring(0, pathToRepo.LastIndexOf('\\'));
                        MessageBox.Show("Path to repo/tests accepted.");
                        PopulateTreeView(pathToRepo, treeViewRepo);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToRepo.Text = pathToRepo;
                    return;
                }
            }
        }

        /// <summary>
        /// Hadles a Click event on PictureBoxToolFolder.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxToolFolder_Click(object sender, EventArgs e)
        {
            if (openFileDialogTool.ShowDialog() == DialogResult.Cancel)
                return;
            pathToTool = openFileDialogTool.FileName;
            textBoxPathToTool.Text = pathToTool;
            toolFolder = pathToTool.Substring(0, pathToTool.LastIndexOf('\\'));
            richTextBoxCommandLine.Text = "cd " + toolFolder;
            richTextBoxCommandLine.Find("cd " + toolFolder);
            richTextBoxCommandLine.SelectionColor = Color.Blue;
            MessageBox.Show("Path to tool/framework accepted.");
            return;
        }

        /// <summary>
        /// Hadles a press Enter event in TextBoxPathToTool.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxPathToTool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToTool.Text != null && textBoxPathToTool.Text.Length > 0)
                {
                    pathToTool = textBoxPathToTool.Text;
                    if (!File.Exists(pathToTool))
                    {
                        MessageBox.Show("Invalid file path or name. Try again");
                        textBoxPathToTool.Text = pathToTool;
                        return;
                    }
                    else
                    {
                        toolFolder = pathToTool.Substring(0, pathToTool.LastIndexOf('\\'));
                        richTextBoxCommandLine.Text = "cd " + toolFolder;
                        richTextBoxCommandLine.Find("cd " + toolFolder);
                        richTextBoxCommandLine.SelectionColor = Color.Blue;
                        MessageBox.Show("Path to tool/framework accepted.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file path or name. Try again");
                    textBoxPathToTool.Text = pathToTool;
                    return;
                }
            }
        }

        /// <summary>
        /// Hadles a Click event on PictureBoxConfigsFolder.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxConfigsFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogConfigs.ShowDialog() == DialogResult.Cancel)
                return;
            pathToConfigs = folderBrowserDialogConfigs.SelectedPath;
            textBoxPathToConfigs.Text = pathToConfigs;
            configsFolder = pathToConfigs.Substring(0, pathToConfigs.LastIndexOf('\\'));
            MessageBox.Show("Path to configs accepted.");
            PopulateTreeView(pathToConfigs, treeViewConfigs);
            treeViewConfigs.ExpandAll();
            TreeView temp = new TreeView();
            PopulateTreeView(pathToConfigs, temp);
            foreach(TreeNode node in treeViewRepo.Nodes)
            {
                AddTreeviewConfigsToTreeviewRepoAsTag(node);
            }
            tempTree = treeViewConfigs;
            return;
        }

        /// <summary>
        /// Hadles a press Enter event in TextBoxPathToConfigs.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxPathToConfigs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToConfigs.Text != null && textBoxPathToConfigs.Text.Length > 0)
                {
                    pathToConfigs = textBoxPathToConfigs.Text;
                    if (!Directory.Exists(pathToConfigs))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToConfigs.Text = pathToConfigs;
                        return;
                    }
                    else
                    {
                        configsFolder = pathToConfigs.Substring(0, pathToConfigs.LastIndexOf('\\'));
                        MessageBox.Show("Path to tests configs accepted.");
                        PopulateTreeView(pathToConfigs, treeViewConfigs);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToConfigs.Text = pathToConfigs;
                    return;
                }
            }
        }

        /// <summary>
        /// Hadles a Click event on PictureBoxLogsFolder.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void PictureBoxLogsFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogLogs.ShowDialog() == DialogResult.Cancel)
                return;
            pathToLogs = folderBrowserDialogLogs.SelectedPath;
            textBoxPathToLogs.Text = pathToLogs;
            logsFolder = pathToLogs.Substring(0, pathToLogs.LastIndexOf('\\'));
            MessageBox.Show("Path to test logs accepted.");
            return;
        }

        /// <summary>
        /// Hadles a press Enter event in TextBoxPathToLogs.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TextBoxPathToLogs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxPathToLogs.Text != null && textBoxPathToLogs.Text.Length > 0)
                {
                    pathToLogs = textBoxPathToLogs.Text;
                    if (!Directory.Exists(pathToLogs))
                    {
                        MessageBox.Show("Invalid directory path or name. Try again");
                        textBoxPathToLogs.Text = pathToLogs;
                        return;
                    }
                    else
                    {
                        logsFolder = pathToLogs.Substring(0, pathToLogs.LastIndexOf('\\'));
                        MessageBox.Show("Path to test logs accepted.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid directory path or name. Try again");
                    textBoxPathToLogs.Text = pathToLogs;
                    return;
                }
            }
        }

        /// <summary>
        /// The method that changes the tree, creates a hierarchy of nodes (also nested) according to the specified path.
        /// </summary>
        /// <param name="path">
        /// A folder that is created as an element in the tree hierarchy (including all contents)
        /// </param>
        /// <param name="tree">
        /// A tree which is being rebuilt.
        /// </param>
        private void PopulateTreeView(string path, TreeView tree)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path); // Specify the directories you want to manipulate.
            {
                tree.Nodes.Clear(); 
                tree.Nodes.Add(LoadDirectory(directoryInfo)); //Adds the main тode of the tree at the specified path
                                                              //and calls a function that reads the folder and forms its contents as tree elements.
            }
        }

        /// <summary>
        /// A method that loads the contents of a folder and creates the same hierarchy.
        /// </summary>
        /// <param name="dir">
        /// Folder/directory.
        /// </param>
        /// <returns>
        /// Returns (TreeNode)the node of the tree with its children.
        /// Returns null if the specified folder does not exist.
        /// </returns>
        private TreeNode LoadDirectory(DirectoryInfo dir)
        {
            if (!dir.Exists)
                return null;

            TreeNode output = new TreeNode(dir.Name, 0, 0);

            if (pathToConfigs != string.Empty || pathToConfigs != null)
            {
                output.Tag = treeViewConfigs;
            }

            foreach (var subDir in dir.GetDirectories())
            {
                output.Nodes.Add(LoadDirectory(subDir));
            }

            foreach (var file in dir.GetFiles())
            {
                if (file.Exists)
                {
                    output.Nodes.Add(file.Name);
                    output.Nodes[output.Nodes.Count - 1].ImageIndex = 1;
                    output.Nodes[output.Nodes.Count - 1].SelectedImageIndex = 1;
                    if (pathToConfigs != null || pathToConfigs != string.Empty) output.Nodes[output.Nodes.Count - 1].Tag = treeViewConfigs;
                }
            }

            return output;
        }

        /// <summary>
        /// A method that applies the selection to all node children.
        /// </summary>
        /// <param name="node">
        /// A node whose children need to be checked.
        /// </param>
        private void CheckItems(TreeNode node)
        {
            node.Checked = true;
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = true;
                CheckItems(childNode);
            }
        }

        /// <summary>
        /// A method that applies the selection to all node children
        /// </summary>
        /// <param name="node">
        /// A node whose children need to be unchecked.
        /// </param>
        private void UnCheckItems(TreeNode node)
        {
            node.Checked = false;
            foreach (TreeNode childNode in node.Nodes)
            {
                childNode.Checked = false;
                UnCheckItems(childNode);
            }
        }

        /// <summary>
        /// A method that checks whether the state of any of the elements has been changed and applies the selection to all children.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TreeViewRepo_AfterCheck(object sender, TreeViewEventArgs e)
        {
            isAnyNodeInTreeviwRepoChecked = e.Node.Checked;
            if (isAnyNodeInTreeviwRepoChecked == true)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                    CheckItems(node);
                }
                isAnyNodeInTreeviwRepoChecked = true;
                return;
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                    UnCheckItems(node);
                }
                isAnyNodeInTreeviwRepoChecked = false;
                return;
            }
        }

        /// <summary>
        /// A method that checks whether the state of any of the elements has been changed and applies the selection to all children.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TreeViewConfigs_AfterCheck(object sender, TreeViewEventArgs e)
        {
            isAnyNodeInTreeviwConfigsChecked = e.Node.Checked;
            if (isAnyNodeInTreeviwConfigsChecked == true)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = true;
                    CheckItems(node);
                }
                isAnyNodeInTreeviwConfigsChecked = true;
                return;
            }
            else
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = false;
                    UnCheckItems(node);
                }
                isAnyNodeInTreeviwConfigsChecked = false;
                return;
            }
        }

        

        /// <summary>
        /// A method that adds to all nodes of the repository tree the config tree as a tag value.
        /// </summary>
        /// <param name="node">
        /// Еhe tree node and its children (if any) to which the tag value needs to be added.
        /// </param>
        private void AddTreeviewConfigsToTreeviewRepoAsTag(TreeNode node)
        {
            node.Tag = treeViewConfigs;
            foreach(TreeNode childNode in node.Nodes)
            {
                AddTreeviewConfigsToTreeviewRepoAsTag(childNode);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TreeViewRepo_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (wasAnyNodeInTreeviewRepoSelected == true)
            {
                //e.Node.Tag = treeViewConfigs;
                treeViewRepo.SelectedNode.Tag = treeViewConfigs;
            }
            else return;
                        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TreeViewRepo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode currentNode = e.Node;
            string fullPath = currentNode.FullPath;
            MessageBox.Show(fullPath);
            wasAnyNodeInTreeviewRepoSelected = true;
            treeViewConfigs = (TreeView)treeViewRepo.SelectedNode.Tag;
            //treeViewConfigs = (TreeView)e.Node.Tag;

        }

        public void IterateTreeNodes()
        {

        }

        /// <summary>
        /// Handles a DoubleClick event on TreeViewConfigs Node.
        ///  Forms a command for the terminal by the selected config file (or folder) for the checked node in the repo tree.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void TreeViewConfigs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (string test in GetTestsList())
            {
                string temp = test.Substring(test.IndexOf('\\') + 1);
                testProject = temp;
                int len = temp.IndexOf('\\');
                //string temp2 = temp.Substring(0, len);
                testName = test.Substring(test.LastIndexOf('\\') + 1);
                testConfig = pathToConfigs + e.Node.FullPath.Substring(e.Node.FullPath.IndexOf('\\'));
                singleCommand = pathToTool + " -p " + testProject + " " + len + " " + " -n " + testName + " -c " + testConfig;
                richTextBoxCommandLine.Text += "\n" + singleCommand;
                //richTextBoxCommandLine.Find(singleCommand.Substring(0, pathToTool.Length)); // highlights full path to tool.
                //richTextBoxCommandLine.SelectionColor = Color.Green;
                //richTextBoxCommandLine.Find(" -p "); // highlights -p.
                //richTextBoxCommandLine.SelectionColor = Color.Blue;
                //richTextBoxCommandLine.Find(" -n "); // highlights -n.
                //richTextBoxCommandLine.SelectionColor = Color.Blue;
                //richTextBoxCommandLine.Find(" -c "); // highlights -c.
                //richTextBoxCommandLine.SelectionColor = Color.Blue;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        protected List<string> GetTestsList()
        {
            List<string> testList = new List<string>();
            foreach (TreeNode node in treeViewRepo.Nodes)
            {
                if (node.ImageIndex == 1 && node.Checked)
                {
                    tests += "\n" + node.FullPath;
                    tests.TrimStart('\n');
                }
                else
                {
                    FindTests(node);
                }
            }
            string[] splited = tests.Split('\n');
            for (int i = 0; i < splited.Length; i++)
            {
                testList.Add(splited[i]);
            }
            return testList;
            //if (testWasCheched == false) MessageBox.Show("Choose an other folder, no tests here.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node">
        /// 
        /// </param>
        private void FindTests(TreeNode node)
        {
            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.ImageIndex == 1 && childNode.Checked)
                {
                    tests += "\n" + childNode.FullPath;
                    tests.TrimStart('\n');
                }
                else
                {
                    FindTests(childNode);
                }
            }
        }

        /// <summary>
        /// Handles a Click event on ButtonHelp.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonHelp_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles a Click event on ButtonLoad.
        /// Loads a previously saved file with a list of tests and selected configurations for them as commands to run from the terminal.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogBat.ShowDialog() == DialogResult.Cancel)
                return;
            //richTextBoxCommandLine.Text = presetText;            
            MessageBox.Show(".bat loaded.");
            return;
        }

        /// <summary>
        /// Handles a Click event on ButtonSave.
        /// Saves a list of tests and selected configurations for them as commands to run from the terminal in a single file.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogBat.ShowDialog() == DialogResult.Cancel)
                return;
            //filePresetName = saveFileDialogBat.FileName;
            //File.WriteAllText(filePresetName, presetText);
            //pathToPreset = openFileDialogBat.FileName;
            MessageBox.Show(".bat saved.");
            //richTextBoxCommandLine.Text = presetText;
            return;
        }

        /// <summary>
        /// Handles a Click event on ButtonClear.
        /// Clear text in RichTextBoxCommandLine.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonClean_Click(object sender, EventArgs e)
        {
            richTextBoxCommandLine.Clear();
            richTextBoxCommandLine.Text = "cd " + toolFolder;
            richTextBoxCommandLine.Find("cd " + toolFolder);
            richTextBoxCommandLine.SelectionColor = Color.Blue;
        }

        /// <summary>
        /// Handles a Click event on ButtonRun.
        /// Run a terminal with administrator permission (admin mode) and initializes the cd command to the selected folder.
        /// </summary>
        /// <param name="sender">
        /// Default parametr.
        /// </param>
        /// <param name="e">
        /// Default parametr.
        /// </param>
        private void ButtonRun_Click(object sender, EventArgs e)
        {            
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/k arp -d")
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Normal,
                UseShellExecute = true,
                Verb = "runas",
                WorkingDirectory = toolFolder
            };
            
            //tests = string.Empty;
            ///File.WriteAllText("C:\\TestRunner\\Bat_runer.bat", "command1\n" +"command2\n");
            ///Process.Start("C:\\TestRunner\\Bat_runer.bat");

            

            command = richTextBoxCommandLine.Text;
            Process.Start(processStartInfo);
        }

        

        

        #endregion

        #region Public methods

        /// <summary>
        /// Contains the code that creates and initializes the user interface objects dragged on the form surface 
        /// with the values provided by you (the programmer) using the Property Grid of the Form Designer.
        /// Not try to modify manually this method!
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            isAnyNodeInTreeviwRepoChecked = false;
            isAnyNodeInTreeviwConfigsChecked = false;
            //richTextBoxCommandLine.Text = "TestFrameworkProgr.exe -p SomeProject -n SomeTest -c C:\\CorrectRegressionBranch\\configFiles\\Some_Config.xml";
            tempTree = null;
            wasAnyNodeInTreeviewRepoSelected = false;
            testWasCheched = false;
            testProject = string.Empty;
            testName = string.Empty;
            testConfig = string.Empty;
            singleCommand = string.Empty;
            tests = string.Empty;
        }

        #endregion
        
    }
}
