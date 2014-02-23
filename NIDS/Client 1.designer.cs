namespace WindowsFormsApplication1
{
    partial class Client1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.lbls10 = new System.Windows.Forms.Label();
            this.lbls9 = new System.Windows.Forms.Label();
            this.lbls6 = new System.Windows.Forms.Label();
            this.lbls8 = new System.Windows.Forms.Label();
            this.lbls2 = new System.Windows.Forms.Label();
            this.lbls7 = new System.Windows.Forms.Label();
            this.lbls5 = new System.Windows.Forms.Label();
            this.lbls4 = new System.Windows.Forms.Label();
            this.lbls3 = new System.Windows.Forms.Label();
            this.lbls1 = new System.Windows.Forms.Label();
            this.Split = new System.Windows.Forms.Button();
            this.BtnSView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpen.Location = new System.Drawing.Point(318, 247);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 33);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilePath.Location = new System.Drawing.Point(6, 251);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(306, 27);
            this.txtFilePath.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSend.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSend.Location = new System.Drawing.Point(164, 365);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 34);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(20, 300);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.lbls10);
            this.groupBox1.Controls.Add(this.lbls9);
            this.groupBox1.Controls.Add(this.lbls6);
            this.groupBox1.Controls.Add(this.lbls8);
            this.groupBox1.Controls.Add(this.lbls2);
            this.groupBox1.Controls.Add(this.lbls7);
            this.groupBox1.Controls.Add(this.lbls5);
            this.groupBox1.Controls.Add(this.lbls4);
            this.groupBox1.Controls.Add(this.lbls3);
            this.groupBox1.Controls.Add(this.lbls1);
            this.groupBox1.Controls.Add(this.Split);
            this.groupBox1.Controls.Add(this.BtnSView);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 416);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Transmit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1.ForeColor = System.Drawing.Color.PeachPuff;
            this.cb1.Location = new System.Drawing.Point(164, 329);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(114, 20);
            this.cb1.TabIndex = 12;
            this.cb1.Text = "lose segment";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // lbls10
            // 
            this.lbls10.AutoSize = true;
            this.lbls10.BackColor = System.Drawing.Color.Gold;
            this.lbls10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls10.Location = new System.Drawing.Point(209, 165);
            this.lbls10.Name = "lbls10";
            this.lbls10.Size = new System.Drawing.Size(117, 20);
            this.lbls10.TabIndex = 11;
            this.lbls10.Text = "Segments 10";
            // 
            // lbls9
            // 
            this.lbls9.AutoSize = true;
            this.lbls9.BackColor = System.Drawing.Color.Gold;
            this.lbls9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls9.Location = new System.Drawing.Point(209, 134);
            this.lbls9.Name = "lbls9";
            this.lbls9.Size = new System.Drawing.Size(107, 20);
            this.lbls9.TabIndex = 11;
            this.lbls9.Text = "Segments 9";
            // 
            // lbls6
            // 
            this.lbls6.AutoSize = true;
            this.lbls6.BackColor = System.Drawing.Color.Gold;
            this.lbls6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls6.Location = new System.Drawing.Point(209, 41);
            this.lbls6.Name = "lbls6";
            this.lbls6.Size = new System.Drawing.Size(107, 20);
            this.lbls6.TabIndex = 11;
            this.lbls6.Text = "Segments 6";
            // 
            // lbls8
            // 
            this.lbls8.AutoSize = true;
            this.lbls8.BackColor = System.Drawing.Color.Gold;
            this.lbls8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls8.Location = new System.Drawing.Point(209, 103);
            this.lbls8.Name = "lbls8";
            this.lbls8.Size = new System.Drawing.Size(107, 20);
            this.lbls8.TabIndex = 10;
            this.lbls8.Text = "Segments 8";
            // 
            // lbls2
            // 
            this.lbls2.AutoSize = true;
            this.lbls2.BackColor = System.Drawing.Color.Gold;
            this.lbls2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls2.Location = new System.Drawing.Point(67, 72);
            this.lbls2.Name = "lbls2";
            this.lbls2.Size = new System.Drawing.Size(107, 20);
            this.lbls2.TabIndex = 11;
            this.lbls2.Text = "Segments 2";
            // 
            // lbls7
            // 
            this.lbls7.AutoSize = true;
            this.lbls7.BackColor = System.Drawing.Color.Gold;
            this.lbls7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls7.Location = new System.Drawing.Point(209, 72);
            this.lbls7.Name = "lbls7";
            this.lbls7.Size = new System.Drawing.Size(107, 20);
            this.lbls7.TabIndex = 9;
            this.lbls7.Text = "Segments 7";
            // 
            // lbls5
            // 
            this.lbls5.AutoSize = true;
            this.lbls5.BackColor = System.Drawing.Color.Gold;
            this.lbls5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls5.Location = new System.Drawing.Point(67, 165);
            this.lbls5.Name = "lbls5";
            this.lbls5.Size = new System.Drawing.Size(107, 20);
            this.lbls5.TabIndex = 10;
            this.lbls5.Text = "Segments 5";
            // 
            // lbls4
            // 
            this.lbls4.AutoSize = true;
            this.lbls4.BackColor = System.Drawing.Color.Gold;
            this.lbls4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls4.Location = new System.Drawing.Point(67, 134);
            this.lbls4.Name = "lbls4";
            this.lbls4.Size = new System.Drawing.Size(107, 20);
            this.lbls4.TabIndex = 9;
            this.lbls4.Text = "Segments 4";
            // 
            // lbls3
            // 
            this.lbls3.AutoSize = true;
            this.lbls3.BackColor = System.Drawing.Color.Gold;
            this.lbls3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls3.Location = new System.Drawing.Point(67, 103);
            this.lbls3.Name = "lbls3";
            this.lbls3.Size = new System.Drawing.Size(107, 20);
            this.lbls3.TabIndex = 10;
            this.lbls3.Text = "Segments 3";
            // 
            // lbls1
            // 
            this.lbls1.AutoSize = true;
            this.lbls1.BackColor = System.Drawing.Color.Gold;
            this.lbls1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbls1.Location = new System.Drawing.Point(67, 41);
            this.lbls1.Name = "lbls1";
            this.lbls1.Size = new System.Drawing.Size(107, 20);
            this.lbls1.TabIndex = 9;
            this.lbls1.Text = "Segments 1";
            // 
            // Split
            // 
            this.Split.BackColor = System.Drawing.Color.SeaGreen;
            this.Split.Enabled = false;
            this.Split.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Split.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Split.Location = new System.Drawing.Point(44, 365);
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(114, 34);
            this.Split.TabIndex = 8;
            this.Split.Text = "Split";
            this.Split.UseVisualStyleBackColor = false;
            this.Split.Click += new System.EventHandler(this.Split_Click);
            // 
            // BtnSView
            // 
            this.BtnSView.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSView.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSView.Location = new System.Drawing.Point(301, 376);
            this.BtnSView.Name = "BtnSView";
            this.BtnSView.Size = new System.Drawing.Size(114, 34);
            this.BtnSView.TabIndex = 7;
            this.BtnSView.Text = "View";
            this.BtnSView.UseVisualStyleBackColor = false;
            this.BtnSView.Click += new System.EventHandler(this.BtnSView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Path of The File";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Client1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(472, 526);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client1";
            this.Text = "Channel 1";
            this.Load += new System.EventHandler(this.Normal_File_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSView;
        private System.Windows.Forms.Button Split;
        private System.Windows.Forms.Label lbls10;
        private System.Windows.Forms.Label lbls9;
        private System.Windows.Forms.Label lbls6;
        private System.Windows.Forms.Label lbls8;
        private System.Windows.Forms.Label lbls2;
        private System.Windows.Forms.Label lbls7;
        private System.Windows.Forms.Label lbls5;
        private System.Windows.Forms.Label lbls4;
        private System.Windows.Forms.Label lbls3;
        private System.Windows.Forms.Label lbls1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}