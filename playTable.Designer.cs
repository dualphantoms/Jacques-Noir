namespace blackJackForm
{
    partial class playTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playTable));
            this.hitBox = new System.Windows.Forms.Button();
            this.stayBox = new System.Windows.Forms.Button();
            this.DValue = new System.Windows.Forms.Label();
            this.PValue = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.dealerBox = new System.Windows.Forms.RichTextBox();
            this.playerBox = new System.Windows.Forms.RichTextBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.potLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.gg = new System.Windows.Forms.PictureBox();
            this.dealButton = new System.Windows.Forms.PictureBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealButton)).BeginInit();
            this.SuspendLayout();
            // 
            // hitBox
            // 
            this.hitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hitBox.Location = new System.Drawing.Point(13, 103);
            this.hitBox.Name = "hitBox";
            this.hitBox.Size = new System.Drawing.Size(53, 25);
            this.hitBox.TabIndex = 0;
            this.hitBox.TabStop = false;
            this.hitBox.Text = "Hit";
            this.hitBox.UseVisualStyleBackColor = true;
            this.hitBox.Click += new System.EventHandler(this.hitEm);
            // 
            // stayBox
            // 
            this.stayBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stayBox.Location = new System.Drawing.Point(131, 103);
            this.stayBox.Name = "stayBox";
            this.stayBox.Size = new System.Drawing.Size(55, 25);
            this.stayBox.TabIndex = 0;
            this.stayBox.TabStop = false;
            this.stayBox.Text = "Stay";
            this.stayBox.UseVisualStyleBackColor = true;
            this.stayBox.Click += new System.EventHandler(this.stayEm);
            // 
            // DValue
            // 
            this.DValue.AutoSize = true;
            this.DValue.Location = new System.Drawing.Point(169, 13);
            this.DValue.Name = "DValue";
            this.DValue.Size = new System.Drawing.Size(0, 13);
            this.DValue.TabIndex = 8;
            // 
            // PValue
            // 
            this.PValue.AutoSize = true;
            this.PValue.Location = new System.Drawing.Point(169, 203);
            this.PValue.Name = "PValue";
            this.PValue.Size = new System.Drawing.Size(0, 13);
            this.PValue.TabIndex = 9;
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealerLabel.Location = new System.Drawing.Point(10, 13);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(38, 13);
            this.dealerLabel.TabIndex = 10;
            this.dealerLabel.Text = "Dealer";
            this.dealerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dealerLabel.Click += new System.EventHandler(this.highscoresButton);
            // 
            // dealerBox
            // 
            this.dealerBox.Enabled = false;
            this.dealerBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBox.Location = new System.Drawing.Point(13, 31);
            this.dealerBox.Name = "dealerBox";
            this.dealerBox.ReadOnly = true;
            this.dealerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.dealerBox.Size = new System.Drawing.Size(173, 67);
            this.dealerBox.TabIndex = 13;
            this.dealerBox.Text = "";
            // 
            // playerBox
            // 
            this.playerBox.Enabled = false;
            this.playerBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBox.Location = new System.Drawing.Point(13, 133);
            this.playerBox.Name = "playerBox";
            this.playerBox.ReadOnly = true;
            this.playerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.playerBox.Size = new System.Drawing.Size(173, 67);
            this.playerBox.TabIndex = 14;
            this.playerBox.Text = "";
            // 
            // cashLabel
            // 
            this.cashLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cashLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cashLabel.Location = new System.Drawing.Point(72, 204);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(53, 23);
            this.cashLabel.TabIndex = 15;
            this.cashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potLabel
            // 
            this.potLabel.BackColor = System.Drawing.Color.Gold;
            this.potLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.potLabel.Location = new System.Drawing.Point(72, 3);
            this.potLabel.Name = "potLabel";
            this.potLabel.Size = new System.Drawing.Size(53, 23);
            this.potLabel.TabIndex = 16;
            this.potLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betLabel
            // 
            this.betLabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.betLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.betLabel.Location = new System.Drawing.Point(72, 104);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(53, 23);
            this.betLabel.TabIndex = 20;
            this.betLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gg
            // 
            this.gg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gg.Image = global::JacquesNoirForm.Properties.Resources.flag;
            this.gg.Location = new System.Drawing.Point(10, 203);
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(25, 27);
            this.gg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gg.TabIndex = 0;
            this.gg.TabStop = false;
            this.gg.Click += new System.EventHandler(this.ggButton);
            // 
            // dealButton
            // 
            this.dealButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealButton.Image = ((System.Drawing.Image)(resources.GetObject("dealButton.Image")));
            this.dealButton.Location = new System.Drawing.Point(162, 203);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(25, 25);
            this.dealButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealButton.TabIndex = 21;
            this.dealButton.TabStop = false;
            this.dealButton.Click += new System.EventHandler(this.dealCards);
            // 
            // downButton
            // 
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downButton.Location = new System.Drawing.Point(131, 203);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(25, 25);
            this.downButton.TabIndex = 0;
            this.downButton.TabStop = false;
            this.downButton.Text = "-";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.decreaseBet);
            // 
            // upButton
            // 
            this.upButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upButton.Location = new System.Drawing.Point(41, 203);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(25, 25);
            this.upButton.TabIndex = 0;
            this.upButton.TabStop = false;
            this.upButton.Text = "+";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.increaseBet);
            // 
            // playTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(199, 231);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.potLabel);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.DValue);
            this.Controls.Add(this.PValue);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.dealerBox);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.stayBox);
            this.Controls.Add(this.hitBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "playTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jacques Noir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leaveEm);
            ((System.ComponentModel.ISupportInitialize)(this.gg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button hitBox;
        private System.Windows.Forms.Button stayBox;
        private System.Windows.Forms.Label DValue;
        private System.Windows.Forms.Label PValue;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.RichTextBox dealerBox;
        private System.Windows.Forms.RichTextBox playerBox;
        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Label potLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.PictureBox gg;
        private System.Windows.Forms.PictureBox dealButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
    }
}