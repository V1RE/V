namespace V_1._2
{
    partial class MainView
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
            this.sendMsgBox = new System.Windows.Forms.TextBox();
            this.chatHistoryMsgBox = new System.Windows.Forms.RichTextBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMsgBox
            // 
            this.sendMsgBox.AllowDrop = true;
            this.sendMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMsgBox.AutoCompleteCustomSource.AddRange(new string[] {
            "/connect ",
            "/exit",
            "/channel ",
            "/clear",
            "/username ",
            "/invite "});
            this.sendMsgBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.sendMsgBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sendMsgBox.Location = new System.Drawing.Point(12, 278);
            this.sendMsgBox.Name = "sendMsgBox";
            this.sendMsgBox.Size = new System.Drawing.Size(329, 20);
            this.sendMsgBox.TabIndex = 2;
            // 
            // chatHistoryMsgBox
            // 
            this.chatHistoryMsgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatHistoryMsgBox.BackColor = System.Drawing.Color.White;
            this.chatHistoryMsgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatHistoryMsgBox.Location = new System.Drawing.Point(12, 27);
            this.chatHistoryMsgBox.Name = "chatHistoryMsgBox";
            this.chatHistoryMsgBox.ReadOnly = true;
            this.chatHistoryMsgBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.chatHistoryMsgBox.Size = new System.Drawing.Size(426, 243);
            this.chatHistoryMsgBox.TabIndex = 4;
            this.chatHistoryMsgBox.TabStop = false;
            this.chatHistoryMsgBox.Text = "";
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMsgButton.Location = new System.Drawing.Point(347, 276);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(91, 23);
            this.sendMsgButton.TabIndex = 3;
            this.sendMsgButton.Text = "Send";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem,
            this.channelToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // channelToolStripMenuItem
            // 
            this.channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            this.channelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.channelToolStripMenuItem.Text = "Channel";
            this.channelToolStripMenuItem.Click += new System.EventHandler(this.channelToolStripMenuItem_Click);
            // 
            // MainView
            // 
            this.AcceptButton = this.sendMsgButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 311);
            this.Controls.Add(this.sendMsgButton);
            this.Controls.Add(this.sendMsgBox);
            this.Controls.Add(this.chatHistoryMsgBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MainView";
            this.Text = "V 1.2";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sendMsgBox;
        public System.Windows.Forms.RichTextBox chatHistoryMsgBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
    }
}