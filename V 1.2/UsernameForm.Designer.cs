namespace V_1._2
{
    partial class UsernameForm
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(305, 11);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 22);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New username";
            // 
            // uNameBox
            // 
            this.uNameBox.Location = new System.Drawing.Point(96, 12);
            this.uNameBox.MaxLength = 20;
            this.uNameBox.Name = "uNameBox";
            this.uNameBox.Size = new System.Drawing.Size(203, 20);
            this.uNameBox.TabIndex = 3;
            // 
            // UsernameForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 44);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 83);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 83);
            this.Name = "UsernameForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change username";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UsernameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uNameBox;
    }
}