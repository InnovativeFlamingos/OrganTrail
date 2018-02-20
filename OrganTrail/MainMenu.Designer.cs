namespace OrganTrail
{
    partial class MainMenu
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
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.radExit = new System.Windows.Forms.RadioButton();
            this.radLearn = new System.Windows.Forms.RadioButton();
            this.radTravel = new System.Windows.Forms.RadioButton();
            this.gboxDifficulty = new System.Windows.Forms.GroupBox();
            this.radFarmer = new System.Windows.Forms.RadioButton();
            this.radCarp = new System.Windows.Forms.RadioButton();
            this.radBanker = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gboxOptions.SuspendLayout();
            this.gboxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.radExit);
            this.gboxOptions.Controls.Add(this.radLearn);
            this.gboxOptions.Controls.Add(this.radTravel);
            this.gboxOptions.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxOptions.Location = new System.Drawing.Point(212, 103);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(300, 141);
            this.gboxOptions.TabIndex = 4;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Choose An Option";
            // 
            // radExit
            // 
            this.radExit.Appearance = System.Windows.Forms.Appearance.Button;
            this.radExit.AutoSize = true;
            this.radExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radExit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExit.Location = new System.Drawing.Point(91, 96);
            this.radExit.Name = "radExit";
            this.radExit.Size = new System.Drawing.Size(110, 29);
            this.radExit.TabIndex = 2;
            this.radExit.TabStop = true;
            this.radExit.Text = "Exit Game";
            this.radExit.UseVisualStyleBackColor = true;
            // 
            // radLearn
            // 
            this.radLearn.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLearn.AutoSize = true;
            this.radLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radLearn.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLearn.Location = new System.Drawing.Point(37, 61);
            this.radLearn.Name = "radLearn";
            this.radLearn.Size = new System.Drawing.Size(220, 29);
            this.radLearn.TabIndex = 1;
            this.radLearn.TabStop = true;
            this.radLearn.Text = "Learn About The Body";
            this.radLearn.UseVisualStyleBackColor = true;
            // 
            // radTravel
            // 
            this.radTravel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTravel.AutoSize = true;
            this.radTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTravel.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTravel.Location = new System.Drawing.Point(61, 26);
            this.radTravel.Name = "radTravel";
            this.radTravel.Size = new System.Drawing.Size(170, 29);
            this.radTravel.TabIndex = 0;
            this.radTravel.TabStop = true;
            this.radTravel.Text = "Travel The Body";
            this.radTravel.UseVisualStyleBackColor = true;
            // 
            // gboxDifficulty
            // 
            this.gboxDifficulty.Controls.Add(this.radFarmer);
            this.gboxDifficulty.Controls.Add(this.radCarp);
            this.gboxDifficulty.Controls.Add(this.radBanker);
            this.gboxDifficulty.Enabled = false;
            this.gboxDifficulty.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDifficulty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxDifficulty.Location = new System.Drawing.Point(397, 250);
            this.gboxDifficulty.Name = "gboxDifficulty";
            this.gboxDifficulty.Size = new System.Drawing.Size(300, 141);
            this.gboxDifficulty.TabIndex = 5;
            this.gboxDifficulty.TabStop = false;
            this.gboxDifficulty.Text = "Choose An Option";
            this.gboxDifficulty.Visible = false;
            // 
            // radFarmer
            // 
            this.radFarmer.Appearance = System.Windows.Forms.Appearance.Button;
            this.radFarmer.AutoSize = true;
            this.radFarmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radFarmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radFarmer.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFarmer.Location = new System.Drawing.Point(49, 96);
            this.radFarmer.Name = "radFarmer";
            this.radFarmer.Size = new System.Drawing.Size(200, 29);
            this.radFarmer.TabIndex = 2;
            this.radFarmer.TabStop = true;
            this.radFarmer.Text = "Be A Farmer (Hard)";
            this.radFarmer.UseVisualStyleBackColor = true;
            // 
            // radCarp
            // 
            this.radCarp.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCarp.AutoSize = true;
            this.radCarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCarp.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCarp.Location = new System.Drawing.Point(26, 61);
            this.radCarp.Name = "radCarp";
            this.radCarp.Size = new System.Drawing.Size(250, 29);
            this.radCarp.TabIndex = 1;
            this.radCarp.TabStop = true;
            this.radCarp.Text = "Be A Carpenter (Medium)";
            this.radCarp.UseVisualStyleBackColor = true;
            // 
            // radBanker
            // 
            this.radBanker.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBanker.AutoSize = true;
            this.radBanker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radBanker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radBanker.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBanker.Location = new System.Drawing.Point(49, 26);
            this.radBanker.Name = "radBanker";
            this.radBanker.Size = new System.Drawing.Size(200, 29);
            this.radBanker.TabIndex = 0;
            this.radBanker.TabStop = true;
            this.radBanker.Text = "Be A Banker (Easy)";
            this.radBanker.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrganTrail.Properties.Resources.Untitled_document__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinue.Location = new System.Drawing.Point(212, 259);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(304, 36);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "go to hunting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(709, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxDifficulty);
            this.Controls.Add(this.gboxOptions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MainMenu";
            this.Text = "Organ Trail";
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.gboxDifficulty.ResumeLayout(false);
            this.gboxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.RadioButton radTravel;
        private System.Windows.Forms.RadioButton radExit;
        private System.Windows.Forms.RadioButton radLearn;
        private System.Windows.Forms.GroupBox gboxDifficulty;
        private System.Windows.Forms.RadioButton radFarmer;
        private System.Windows.Forms.RadioButton radCarp;
        private System.Windows.Forms.RadioButton radBanker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button button1;
    }
}

