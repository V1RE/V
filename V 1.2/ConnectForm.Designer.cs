namespace V_1._2
{
    partial class ConnectForm
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
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(96, 12);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(203, 20);
            this.IPBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server address";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(305, 11);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 22);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 44);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 83);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 83);
            this.Name = "ConnectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to server";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
    }
}