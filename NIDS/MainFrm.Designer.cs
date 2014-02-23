namespace WindowsFormsApplication1
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSystemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSystemSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daaTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileReciverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRecvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.suspectipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.daaTransferToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netWorkToolStripMenuItem,
            this.currentSystemInfoToolStripMenuItem,
            this.currentSystemSpeedToolStripMenuItem,
            this.activeConnectionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // netWorkToolStripMenuItem
            // 
            this.netWorkToolStripMenuItem.Name = "netWorkToolStripMenuItem";
            this.netWorkToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.netWorkToolStripMenuItem.Text = "NetWork Monitor";
            this.netWorkToolStripMenuItem.Click += new System.EventHandler(this.netWorkToolStripMenuItem_Click);
            // 
            // currentSystemInfoToolStripMenuItem
            // 
            this.currentSystemInfoToolStripMenuItem.Name = "currentSystemInfoToolStripMenuItem";
            this.currentSystemInfoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.currentSystemInfoToolStripMenuItem.Text = "Current System Info";
            this.currentSystemInfoToolStripMenuItem.Click += new System.EventHandler(this.currentSystemInfoToolStripMenuItem_Click);
            // 
            // currentSystemSpeedToolStripMenuItem
            // 
            this.currentSystemSpeedToolStripMenuItem.Name = "currentSystemSpeedToolStripMenuItem";
            this.currentSystemSpeedToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.currentSystemSpeedToolStripMenuItem.Text = "Network Speed";
            this.currentSystemSpeedToolStripMenuItem.Click += new System.EventHandler(this.currentSystemSpeedToolStripMenuItem_Click);
            // 
            // activeConnectionsToolStripMenuItem
            // 
            this.activeConnectionsToolStripMenuItem.Name = "activeConnectionsToolStripMenuItem";
            this.activeConnectionsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.activeConnectionsToolStripMenuItem.Text = "Active Connections";
            this.activeConnectionsToolStripMenuItem.Click += new System.EventHandler(this.activeConnectionsToolStripMenuItem_Click);
            // 
            // daaTransferToolStripMenuItem
            // 
            this.daaTransferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileReciverToolStripMenuItem,
            this.fileSenderToolStripMenuItem,
            this.dataRecvToolStripMenuItem,
            this.dataSendToolStripMenuItem});
            this.daaTransferToolStripMenuItem.Name = "daaTransferToolStripMenuItem";
            this.daaTransferToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.daaTransferToolStripMenuItem.Text = "Data Transfer";
            this.daaTransferToolStripMenuItem.Click += new System.EventHandler(this.daaTransferToolStripMenuItem_Click);
            // 
            // fileReciverToolStripMenuItem
            // 
            this.fileReciverToolStripMenuItem.Name = "fileReciverToolStripMenuItem";
            this.fileReciverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileReciverToolStripMenuItem.Text = "File Reciver";
            this.fileReciverToolStripMenuItem.Click += new System.EventHandler(this.fileReciverToolStripMenuItem_Click);
            // 
            // fileSenderToolStripMenuItem
            // 
            this.fileSenderToolStripMenuItem.Name = "fileSenderToolStripMenuItem";
            this.fileSenderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fileSenderToolStripMenuItem.Text = "File Sender";
            this.fileSenderToolStripMenuItem.Click += new System.EventHandler(this.fileSenderToolStripMenuItem_Click);
            // 
            // dataRecvToolStripMenuItem
            // 
            this.dataRecvToolStripMenuItem.Name = "dataRecvToolStripMenuItem";
            this.dataRecvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataRecvToolStripMenuItem.Text = "Data Recv";
            this.dataRecvToolStripMenuItem.Click += new System.EventHandler(this.dataRecvToolStripMenuItem_Click);
            // 
            // dataSendToolStripMenuItem
            // 
            this.dataSendToolStripMenuItem.Name = "dataSendToolStripMenuItem";
            this.dataSendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataSendToolStripMenuItem.Text = "DataSend";
            this.dataSendToolStripMenuItem.Click += new System.EventHandler(this.dataSendToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suspectipToolStripMenuItem,
            this.transactionDetailsToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "                     Creating Intrusion Detection\r\n  Signatures Using PatternMatc" +
                "hing techniques(ukkons)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // suspectipToolStripMenuItem
            // 
            this.suspectipToolStripMenuItem.Name = "suspectipToolStripMenuItem";
            this.suspectipToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.suspectipToolStripMenuItem.Text = "suspectip";
            this.suspectipToolStripMenuItem.Click += new System.EventHandler(this.suspectipToolStripMenuItem_Click);
            // 
            // transactionDetailsToolStripMenuItem
            // 
            this.transactionDetailsToolStripMenuItem.Name = "transactionDetailsToolStripMenuItem";
            this.transactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.transactionDetailsToolStripMenuItem.Text = "Transaction Details";
            this.transactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSystemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSystemSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeConnectionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem daaTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileReciverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataRecvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suspectipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}