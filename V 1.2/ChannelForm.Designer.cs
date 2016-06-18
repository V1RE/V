namespace V_1._2
{
    partial class ChannelForm
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
            this.channelConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // channelConnectButton
            // 
            this.channelConnectButton.Location = new System.Drawing.Point(273, 11);
            this.channelConnectButton.Name = "channelConnectButton";
            this.channelConnectButton.Size = new System.Drawing.Size(75, 22);
            this.channelConnectButton.TabIndex = 5;
            this.channelConnectButton.Text = "Connect";
            this.channelConnectButton.UseVisualStyleBackColor = true;
            this.channelConnectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Channel";
            // 
            // ChannelBox
            // 
            this.ChannelBox.Location = new System.Drawing.Point(64, 13);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(203, 20);
            this.ChannelBox.TabIndex = 3;
            // 
            // ChannelForm
            // 
            this.AcceptButton = this.channelConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 45);
            this.Controls.Add(this.channelConnectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChannelBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 84);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 84);
            this.Name = "ChannelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change channel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChannelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button channelConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChannelBox;
    }
}