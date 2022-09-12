namespace TestTunnerGUI2
{
    #region using

    using System;
    using System.IO;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    /// TestRunnerGUI app start window.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Fields and Constants;

        public string pathToRepo; //Variable that stores the full path to the test repository.
        public string pathToTool; //Variable that stores the full path to the tool/framework that runs the tests.
        public string pathToConfigs; //Variable that stores the full path to the configuration files for the tests.
        public string pathToLogs; //Variable that stores the full path to the test log files.


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
            MessageBox.Show("Path to repo/tests accepted.");
            PopulateTreeView(pathToRepo, treeViewRepo);
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
            MessageBox.Show("Path to configs accepted.");
            //AddTreeviewConfigsToTreeviewRepoAsTag();
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

            //if (pathToConfigs != string.Empty || pathToConfigs != null)
            //{
            //    output.Tag = treeViewConfigs;
            //}

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
                    //output.Nodes[output.Nodes.Count - 1].Tag = treeViewConfigs;
                }
            }

            return output;
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
        }

        #endregion        
    }
}
