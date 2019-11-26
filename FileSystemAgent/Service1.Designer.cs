namespace FileSystemAgent
{
    partial class Service1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fswAgent = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fswAgent)).BeginInit();
            // 
            // fswAgent
            // 
            this.fswAgent.EnableRaisingEvents = true;
            this.fswAgent.IncludeSubdirectories = true;
            this.fswAgent.NotifyFilter = ((System.IO.NotifyFilters)((((((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Attributes) 
            | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess) 
            | System.IO.NotifyFilters.CreationTime) 
            | System.IO.NotifyFilters.Security)));
            this.fswAgent.Path = "G:\\data";
            this.fswAgent.Changed += new System.IO.FileSystemEventHandler(this.fswAgent_Changed);
            this.fswAgent.Created += new System.IO.FileSystemEventHandler(this.fswAgent_Created);
            this.fswAgent.Deleted += new System.IO.FileSystemEventHandler(this.fswAgent_Deleted);
            this.fswAgent.Renamed += new System.IO.RenamedEventHandler(this.fswAgent_Renamed);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.fswAgent)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher fswAgent;
    }
}
