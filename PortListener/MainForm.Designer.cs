namespace PortListener
{
    partial class MainForm
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
            this.lbAvailableInterfaces = new System.Windows.Forms.ListBox();
            this.gbInterfaces = new System.Windows.Forms.GroupBox();
            this.btnAddInterface = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectedInterfaces = new System.Windows.Forms.ListBox();
            this.lblAvailText = new System.Windows.Forms.Label();
            this.lblPortText = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.gbListeningLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.gbInterfaces.SuspendLayout();
            this.gbListeningLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAvailableInterfaces
            // 
            this.lbAvailableInterfaces.FormattingEnabled = true;
            this.lbAvailableInterfaces.Location = new System.Drawing.Point(9, 42);
            this.lbAvailableInterfaces.Name = "lbAvailableInterfaces";
            this.lbAvailableInterfaces.Size = new System.Drawing.Size(120, 95);
            this.lbAvailableInterfaces.TabIndex = 0;
            this.lbAvailableInterfaces.SelectedIndexChanged += new System.EventHandler(this.lbAvailableInterfaces_SelectedIndexChanged);
            // 
            // gbInterfaces
            // 
            this.gbInterfaces.Controls.Add(this.btnAddInterface);
            this.gbInterfaces.Controls.Add(this.label1);
            this.gbInterfaces.Controls.Add(this.lbSelectedInterfaces);
            this.gbInterfaces.Controls.Add(this.lblAvailText);
            this.gbInterfaces.Controls.Add(this.lbAvailableInterfaces);
            this.gbInterfaces.Location = new System.Drawing.Point(12, 12);
            this.gbInterfaces.Name = "gbInterfaces";
            this.gbInterfaces.Size = new System.Drawing.Size(316, 158);
            this.gbInterfaces.TabIndex = 1;
            this.gbInterfaces.TabStop = false;
            this.gbInterfaces.Text = "Interfaces:";
            // 
            // btnAddInterface
            // 
            this.btnAddInterface.Enabled = false;
            this.btnAddInterface.Location = new System.Drawing.Point(117, 129);
            this.btnAddInterface.Name = "btnAddInterface";
            this.btnAddInterface.Size = new System.Drawing.Size(75, 23);
            this.btnAddInterface.TabIndex = 3;
            this.btnAddInterface.Text = "-->";
            this.btnAddInterface.UseVisualStyleBackColor = true;
            this.btnAddInterface.Click += new System.EventHandler(this.btnAddInterface_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected:";
            // 
            // lbSelectedInterfaces
            // 
            this.lbSelectedInterfaces.FormattingEnabled = true;
            this.lbSelectedInterfaces.Location = new System.Drawing.Point(181, 42);
            this.lbSelectedInterfaces.Name = "lbSelectedInterfaces";
            this.lbSelectedInterfaces.Size = new System.Drawing.Size(120, 95);
            this.lbSelectedInterfaces.TabIndex = 1;
            // 
            // lblAvailText
            // 
            this.lblAvailText.AutoSize = true;
            this.lblAvailText.Location = new System.Drawing.Point(6, 26);
            this.lblAvailText.Name = "lblAvailText";
            this.lblAvailText.Size = new System.Drawing.Size(105, 13);
            this.lblAvailText.TabIndex = 0;
            this.lblAvailText.Text = "Available for binding:";
            // 
            // lblPortText
            // 
            this.lblPortText.AutoSize = true;
            this.lblPortText.Location = new System.Drawing.Point(15, 186);
            this.lblPortText.Name = "lblPortText";
            this.lblPortText.Size = new System.Drawing.Size(83, 13);
            this.lblPortText.TabIndex = 2;
            this.lblPortText.Text = "Port to listen on:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(104, 183);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(50, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "25";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(167, 181);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(161, 23);
            this.btnStartListening.TabIndex = 4;
            this.btnStartListening.Text = "Start";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // gbListeningLog
            // 
            this.gbListeningLog.Controls.Add(this.rtbLog);
            this.gbListeningLog.Location = new System.Drawing.Point(12, 219);
            this.gbListeningLog.Name = "gbListeningLog";
            this.gbListeningLog.Size = new System.Drawing.Size(316, 207);
            this.gbListeningLog.TabIndex = 5;
            this.gbListeningLog.TabStop = false;
            this.gbListeningLog.Text = "Log:";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.ForeColor = System.Drawing.Color.Lime;
            this.rtbLog.Location = new System.Drawing.Point(9, 20);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(301, 181);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 430);
            this.Controls.Add(this.gbListeningLog);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lblPortText);
            this.Controls.Add(this.gbInterfaces);
            this.Name = "MainForm";
            this.Text = "Port Listener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbInterfaces.ResumeLayout(false);
            this.gbInterfaces.PerformLayout();
            this.gbListeningLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailableInterfaces;
        private System.Windows.Forms.GroupBox gbInterfaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSelectedInterfaces;
        private System.Windows.Forms.Label lblAvailText;
        private System.Windows.Forms.Button btnAddInterface;
        private System.Windows.Forms.Label lblPortText;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.GroupBox gbListeningLog;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

