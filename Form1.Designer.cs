
namespace TestTunnerGUI2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.labelPathToRepo = new System.Windows.Forms.Label();
            this.textBoxPathToRepo = new System.Windows.Forms.TextBox();
            this.treeViewRepo = new System.Windows.Forms.TreeView();
            this.imageListRepo = new System.Windows.Forms.ImageList(this.components);
            this.labelPathToLogs = new System.Windows.Forms.Label();
            this.labelPathToTool = new System.Windows.Forms.Label();
            this.textBoxPathToTool = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CommandLine = new System.Windows.Forms.TabPage();
            this.Logs = new System.Windows.Forms.TabPage();
            this.textBoxPathToLogs = new System.Windows.Forms.TextBox();
            this.labelPathToConfigs = new System.Windows.Forms.Label();
            this.textBoxPathToConfigs = new System.Windows.Forms.TextBox();
            this.treeViewConfigs = new System.Windows.Forms.TreeView();
            this.imageListConfigs = new System.Windows.Forms.ImageList(this.components);
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.pictureBoxLogsFolder = new System.Windows.Forms.PictureBox();
            this.pictureBoxToolFolder = new System.Windows.Forms.PictureBox();
            this.pictureBoxRepoFolder = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfigsFolder = new System.Windows.Forms.PictureBox();
            this.openFileDialogTool = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogRepo = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogConfigs = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogBat = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogBat = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialogLogs = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogsFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepoFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigsFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPathToRepo
            // 
            this.labelPathToRepo.AutoSize = true;
            this.labelPathToRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToRepo.Location = new System.Drawing.Point(10, 10);
            this.labelPathToRepo.Name = "labelPathToRepo";
            this.labelPathToRepo.Size = new System.Drawing.Size(153, 20);
            this.labelPathToRepo.TabIndex = 0;
            this.labelPathToRepo.Text = "The path to the repo";
            // 
            // textBoxPathToRepo
            // 
            this.textBoxPathToRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToRepo.Location = new System.Drawing.Point(10, 40);
            this.textBoxPathToRepo.Name = "textBoxPathToRepo";
            this.textBoxPathToRepo.Size = new System.Drawing.Size(374, 26);
            this.textBoxPathToRepo.TabIndex = 1;
            this.textBoxPathToRepo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToRepo_KeyDown);
            // 
            // treeViewRepo
            // 
            this.treeViewRepo.CheckBoxes = true;
            this.treeViewRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewRepo.ImageIndex = 0;
            this.treeViewRepo.ImageList = this.imageListRepo;
            this.treeViewRepo.Location = new System.Drawing.Point(10, 76);
            this.treeViewRepo.Name = "treeViewRepo";
            this.treeViewRepo.SelectedImageIndex = 0;
            this.treeViewRepo.Size = new System.Drawing.Size(410, 488);
            this.treeViewRepo.TabIndex = 22;
            // 
            // imageListRepo
            // 
            this.imageListRepo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRepo.ImageStream")));
            this.imageListRepo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRepo.Images.SetKeyName(0, "folder_icon.png");
            this.imageListRepo.Images.SetKeyName(1, "file_icon.png");
            // 
            // labelPathToLogs
            // 
            this.labelPathToLogs.AutoSize = true;
            this.labelPathToLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToLogs.Location = new System.Drawing.Point(10, 579);
            this.labelPathToLogs.Name = "labelPathToLogs";
            this.labelPathToLogs.Size = new System.Drawing.Size(150, 20);
            this.labelPathToLogs.TabIndex = 3;
            this.labelPathToLogs.Text = "The path tp the logs";
            // 
            // labelPathToTool
            // 
            this.labelPathToTool.AutoSize = true;
            this.labelPathToTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToTool.Location = new System.Drawing.Point(430, 10);
            this.labelPathToTool.Name = "labelPathToTool";
            this.labelPathToTool.Size = new System.Drawing.Size(147, 20);
            this.labelPathToTool.TabIndex = 4;
            this.labelPathToTool.Text = "The path to the tool";
            // 
            // textBoxPathToTool
            // 
            this.textBoxPathToTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToTool.Location = new System.Drawing.Point(430, 40);
            this.textBoxPathToTool.Name = "textBoxPathToTool";
            this.textBoxPathToTool.Size = new System.Drawing.Size(374, 26);
            this.textBoxPathToTool.TabIndex = 5;
            this.textBoxPathToTool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToTool_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CommandLine);
            this.tabControl1.Controls.Add(this.Logs);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(430, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 488);
            this.tabControl1.TabIndex = 6;
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(4, 29);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Padding = new System.Windows.Forms.Padding(3);
            this.CommandLine.Size = new System.Drawing.Size(402, 455);
            this.CommandLine.TabIndex = 0;
            this.CommandLine.Text = "Command Line";
            this.CommandLine.UseVisualStyleBackColor = true;
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(4, 29);
            this.Logs.Name = "Logs";
            this.Logs.Padding = new System.Windows.Forms.Padding(3);
            this.Logs.Size = new System.Drawing.Size(402, 455);
            this.Logs.TabIndex = 1;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            // 
            // textBoxPathToLogs
            // 
            this.textBoxPathToLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToLogs.Location = new System.Drawing.Point(170, 576);
            this.textBoxPathToLogs.Name = "textBoxPathToLogs";
            this.textBoxPathToLogs.Size = new System.Drawing.Size(634, 26);
            this.textBoxPathToLogs.TabIndex = 7;
            this.textBoxPathToLogs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToLogs_KeyDown);
            // 
            // labelPathToConfigs
            // 
            this.labelPathToConfigs.AutoSize = true;
            this.labelPathToConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPathToConfigs.Location = new System.Drawing.Point(850, 10);
            this.labelPathToConfigs.Name = "labelPathToConfigs";
            this.labelPathToConfigs.Size = new System.Drawing.Size(172, 20);
            this.labelPathToConfigs.TabIndex = 8;
            this.labelPathToConfigs.Text = "The path to the configs";
            // 
            // textBoxPathToConfigs
            // 
            this.textBoxPathToConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPathToConfigs.Location = new System.Drawing.Point(850, 40);
            this.textBoxPathToConfigs.Name = "textBoxPathToConfigs";
            this.textBoxPathToConfigs.Size = new System.Drawing.Size(374, 26);
            this.textBoxPathToConfigs.TabIndex = 9;
            this.textBoxPathToConfigs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPathToConfigs_KeyDown);
            // 
            // treeViewConfigs
            // 
            this.treeViewConfigs.CheckBoxes = true;
            this.treeViewConfigs.ImageIndex = 0;
            this.treeViewConfigs.ImageList = this.imageListConfigs;
            this.treeViewConfigs.Location = new System.Drawing.Point(850, 76);
            this.treeViewConfigs.Name = "treeViewConfigs";
            this.treeViewConfigs.SelectedImageIndex = 0;
            this.treeViewConfigs.Size = new System.Drawing.Size(410, 488);
            this.treeViewConfigs.TabIndex = 10;
            // 
            // imageListConfigs
            // 
            this.imageListConfigs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListConfigs.ImageStream")));
            this.imageListConfigs.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListConfigs.Images.SetKeyName(0, "folder_icon.png");
            this.imageListConfigs.Images.SetKeyName(1, "file_icon.png");
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.White;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(850, 574);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(30, 30);
            this.buttonHelp.TabIndex = 11;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(1000, 574);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save .bat";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Yellow;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(890, 574);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(100, 30);
            this.buttonLoad.TabIndex = 13;
            this.buttonLoad.Text = "Load .bat";
            this.buttonLoad.UseVisualStyleBackColor = false;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(1160, 574);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(100, 30);
            this.buttonRun.TabIndex = 14;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogsFolder
            // 
            this.pictureBoxLogsFolder.Image = global::TestTunnerGUI2.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxLogsFolder.Location = new System.Drawing.Point(814, 577);
            this.pictureBoxLogsFolder.Name = "pictureBoxLogsFolder";
            this.pictureBoxLogsFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxLogsFolder.TabIndex = 15;
            this.pictureBoxLogsFolder.TabStop = false;
            this.pictureBoxLogsFolder.Click += new System.EventHandler(this.PictureBoxLogsFolder_Click);
            // 
            // pictureBoxToolFolder
            // 
            this.pictureBoxToolFolder.Image = global::TestTunnerGUI2.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxToolFolder.Location = new System.Drawing.Point(814, 41);
            this.pictureBoxToolFolder.Name = "pictureBoxToolFolder";
            this.pictureBoxToolFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxToolFolder.TabIndex = 16;
            this.pictureBoxToolFolder.TabStop = false;
            this.pictureBoxToolFolder.Click += new System.EventHandler(this.PictureBoxToolFolder_Click);
            // 
            // pictureBoxRepoFolder
            // 
            this.pictureBoxRepoFolder.Image = global::TestTunnerGUI2.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxRepoFolder.Location = new System.Drawing.Point(394, 41);
            this.pictureBoxRepoFolder.Name = "pictureBoxRepoFolder";
            this.pictureBoxRepoFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxRepoFolder.TabIndex = 17;
            this.pictureBoxRepoFolder.TabStop = false;
            this.pictureBoxRepoFolder.Click += new System.EventHandler(this.PictureBoxRepoFolder_Click);
            // 
            // pictureBoxConfigsFolder
            // 
            this.pictureBoxConfigsFolder.Image = global::TestTunnerGUI2.Properties.Resources.icons8_file_folder_24;
            this.pictureBoxConfigsFolder.Location = new System.Drawing.Point(1234, 41);
            this.pictureBoxConfigsFolder.Name = "pictureBoxConfigsFolder";
            this.pictureBoxConfigsFolder.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxConfigsFolder.TabIndex = 18;
            this.pictureBoxConfigsFolder.TabStop = false;
            this.pictureBoxConfigsFolder.Click += new System.EventHandler(this.PictureBoxConfigsFolder_Click);
            // 
            // openFileDialogTool
            // 
            this.openFileDialogTool.DefaultExt = "exe";
            this.openFileDialogTool.FileName = "openFileDialogTool";
            this.openFileDialogTool.Filter = "exe files (*.exe)|*.exe";
            this.openFileDialogTool.InitialDirectory = "C:\\";
            this.openFileDialogTool.RestoreDirectory = true;
            // 
            // folderBrowserDialogRepo
            // 
            this.folderBrowserDialogRepo.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogRepo.ShowNewFolderButton = false;
            // 
            // folderBrowserDialogConfigs
            // 
            this.folderBrowserDialogConfigs.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogConfigs.ShowNewFolderButton = false;
            // 
            // openFileDialogBat
            // 
            this.openFileDialogBat.DefaultExt = "bat";
            this.openFileDialogBat.FileName = "openFileDialogBat";
            this.openFileDialogBat.Filter = "bat files (*.bat)|*.bat";
            this.openFileDialogBat.InitialDirectory = "C:\\";
            // 
            // saveFileDialogBat
            // 
            this.saveFileDialogBat.CheckFileExists = true;
            this.saveFileDialogBat.CreatePrompt = true;
            this.saveFileDialogBat.Filter = "bat files (*.bat)|*.bat";
            this.saveFileDialogBat.InitialDirectory = "C:\\";
            this.saveFileDialogBat.RestoreDirectory = true;
            // 
            // folderBrowserDialogLogs
            // 
            this.folderBrowserDialogLogs.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 615);
            this.Controls.Add(this.pictureBoxConfigsFolder);
            this.Controls.Add(this.pictureBoxRepoFolder);
            this.Controls.Add(this.pictureBoxToolFolder);
            this.Controls.Add(this.pictureBoxLogsFolder);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.treeViewConfigs);
            this.Controls.Add(this.textBoxPathToConfigs);
            this.Controls.Add(this.labelPathToConfigs);
            this.Controls.Add(this.textBoxPathToLogs);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxPathToTool);
            this.Controls.Add(this.labelPathToTool);
            this.Controls.Add(this.labelPathToLogs);
            this.Controls.Add(this.treeViewRepo);
            this.Controls.Add(this.textBoxPathToRepo);
            this.Controls.Add(this.labelPathToRepo);
            this.Name = "MainWindow";
            this.Text = "TestRunnerGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogsFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToolFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRepoFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfigsFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPathToRepo;
        private System.Windows.Forms.TextBox textBoxPathToRepo;
        private System.Windows.Forms.TreeView treeViewRepo;
        private System.Windows.Forms.Label labelPathToLogs;
        private System.Windows.Forms.Label labelPathToTool;
        private System.Windows.Forms.TextBox textBoxPathToTool;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CommandLine;
        private System.Windows.Forms.TabPage Logs;
        private System.Windows.Forms.TextBox textBoxPathToLogs;
        private System.Windows.Forms.Label labelPathToConfigs;
        private System.Windows.Forms.TextBox textBoxPathToConfigs;
        private System.Windows.Forms.TreeView treeViewConfigs;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.PictureBox pictureBoxLogsFolder;
        private System.Windows.Forms.PictureBox pictureBoxToolFolder;
        private System.Windows.Forms.PictureBox pictureBoxRepoFolder;
        private System.Windows.Forms.PictureBox pictureBoxConfigsFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialogTool;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRepo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogConfigs;
        private System.Windows.Forms.OpenFileDialog openFileDialogBat;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBat;
        private System.Windows.Forms.ImageList imageListRepo;
        private System.Windows.Forms.ImageList imageListConfigs;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLogs;
    }
}

