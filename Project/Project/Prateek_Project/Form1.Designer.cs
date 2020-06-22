namespace Prateek_Project
{
    partial class DatabaseAppF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMS = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.commandMS = new System.Windows.Forms.ToolStripMenuItem();
            this.runqueryMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.readfileMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.inputRTB = new System.Windows.Forms.RichTextBox();
            this.resultDG = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMS,
            this.databaseMS,
            this.commandMS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMS
            // 
            this.fileMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMSI});
            this.fileMS.Name = "fileMS";
            this.fileMS.Size = new System.Drawing.Size(37, 20);
            this.fileMS.Text = "File";
            // 
            // exitMSI
            // 
            this.exitMSI.Name = "exitMSI";
            this.exitMSI.Size = new System.Drawing.Size(92, 22);
            this.exitMSI.Text = "Exit";
            this.exitMSI.Click += new System.EventHandler(this.exitMSI_Click);
            // 
            // databaseMS
            // 
            this.databaseMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMSI,
            this.disconnectMSI});
            this.databaseMS.Name = "databaseMS";
            this.databaseMS.Size = new System.Drawing.Size(67, 20);
            this.databaseMS.Text = "Database";
            // 
            // connectMSI
            // 
            this.connectMSI.Name = "connectMSI";
            this.connectMSI.Size = new System.Drawing.Size(133, 22);
            this.connectMSI.Text = "Connect";
            this.connectMSI.Click += new System.EventHandler(this.connectMSI_Click);
            // 
            // disconnectMSI
            // 
            this.disconnectMSI.Enabled = false;
            this.disconnectMSI.Name = "disconnectMSI";
            this.disconnectMSI.Size = new System.Drawing.Size(133, 22);
            this.disconnectMSI.Text = "Disconnect";
            this.disconnectMSI.Click += new System.EventHandler(this.disconnectMSI_Click);
            // 
            // commandMS
            // 
            this.commandMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runqueryMSI,
            this.readfileMSI});
            this.commandMS.Name = "commandMS";
            this.commandMS.Size = new System.Drawing.Size(76, 20);
            this.commandMS.Text = "Command";
            // 
            // runqueryMSI
            // 
            this.runqueryMSI.Name = "runqueryMSI";
            this.runqueryMSI.Size = new System.Drawing.Size(180, 22);
            this.runqueryMSI.Text = "Run Query";
            this.runqueryMSI.Click += new System.EventHandler(this.runqueryMSI_Click);
            // 
            // readfileMSI
            // 
            this.readfileMSI.Name = "readfileMSI";
            this.readfileMSI.Size = new System.Drawing.Size(180, 22);
            this.readfileMSI.Text = "Read File";
            this.readfileMSI.Click += new System.EventHandler(this.readfileMSI_Click);
            // 
            // inputRTB
            // 
            this.inputRTB.Location = new System.Drawing.Point(0, 25);
            this.inputRTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputRTB.Name = "inputRTB";
            this.inputRTB.Size = new System.Drawing.Size(601, 134);
            this.inputRTB.TabIndex = 1;
            this.inputRTB.Text = "";
            // 
            // resultDG
            // 
            this.resultDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDG.Location = new System.Drawing.Point(0, 163);
            this.resultDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultDG.Name = "resultDG";
            this.resultDG.RowTemplate.Height = 24;
            this.resultDG.Size = new System.Drawing.Size(600, 203);
            this.resultDG.TabIndex = 2;
            // 
            // DatabaseAppF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.resultDG);
            this.Controls.Add(this.inputRTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DatabaseAppF";
            this.Text = "DatabaseApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMS;
        private System.Windows.Forms.ToolStripMenuItem exitMSI;
        private System.Windows.Forms.ToolStripMenuItem databaseMS;
        private System.Windows.Forms.ToolStripMenuItem connectMSI;
        private System.Windows.Forms.ToolStripMenuItem disconnectMSI;
        private System.Windows.Forms.ToolStripMenuItem commandMS;
        private System.Windows.Forms.ToolStripMenuItem runqueryMSI;
        private System.Windows.Forms.ToolStripMenuItem readfileMSI;
        private System.Windows.Forms.RichTextBox inputRTB;
        private System.Windows.Forms.DataGridView resultDG;
    }
}

