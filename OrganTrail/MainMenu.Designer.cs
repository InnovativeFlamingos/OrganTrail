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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.radExit = new System.Windows.Forms.RadioButton();
            this.radLearn = new System.Windows.Forms.RadioButton();
            this.radTravel = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.radHunting = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.radHunting);
            this.gboxOptions.Controls.Add(this.radExit);
            this.gboxOptions.Controls.Add(this.radLearn);
            this.gboxOptions.Controls.Add(this.radTravel);
            this.gboxOptions.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gboxOptions.Location = new System.Drawing.Point(212, 103);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(300, 176);
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
            this.radExit.Location = new System.Drawing.Point(91, 130);
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
            this.radLearn.Location = new System.Drawing.Point(61, 61);
            this.radLearn.Name = "radLearn";
            this.radLearn.Size = new System.Drawing.Size(170, 29);
            this.radLearn.TabIndex = 1;
            this.radLearn.TabStop = true;
            this.radLearn.Text = "Map Of The Body";
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
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Black;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinue.Location = new System.Drawing.Point(212, 285);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(304, 36);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // radHunting
            // 
            this.radHunting.Appearance = System.Windows.Forms.Appearance.Button;
            this.radHunting.AutoSize = true;
            this.radHunting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radHunting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radHunting.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHunting.Location = new System.Drawing.Point(72, 95);
            this.radHunting.Name = "radHunting";
            this.radHunting.Size = new System.Drawing.Size(150, 29);
            this.radHunting.TabIndex = 3;
            this.radHunting.TabStop = true;
            this.radHunting.Text = "Shoot A Virus";
            this.radHunting.UseVisualStyleBackColor = true;
            this.radHunting.CheckedChanged += new System.EventHandler(this.radHunting_CheckedChanged);
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(709, 377);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxOptions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organ Trail";
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.RadioButton radTravel;
        private System.Windows.Forms.RadioButton radExit;
        private System.Windows.Forms.RadioButton radLearn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.RadioButton radHunting;
    }
}

