namespace blackJackForm
{
    partial class popupBox
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Names";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(122, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(40, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Scores";
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messageLabel.Enabled = false;
            this.messageLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(12, 9);
            this.messageLabel.Multiline = true;
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.ReadOnly = true;
            this.messageLabel.Size = new System.Drawing.Size(150, 46);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.TabStop = false;
            this.messageLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 60);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Keep going!";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(87, 60);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Leave Table";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // popupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(174, 95);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "popupBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.escapeForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox messageLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button quitButton;
    }
}