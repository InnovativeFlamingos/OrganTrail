//namespace OrganTrail
//{
//    partial class Hunting
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.progressBar1 = new System.Windows.Forms.ProgressBar();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.picPlayer = new System.Windows.Forms.PictureBox();
//            this.pictureBox5 = new System.Windows.Forms.PictureBox();
//            this.pictureBox2 = new System.Windows.Forms.PictureBox();
//            this.timer1 = new System.Windows.Forms.Timer(this.components);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label1.Location = new System.Drawing.Point(38, 18);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(103, 25);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Ammo: 0";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label2.Location = new System.Drawing.Point(258, 18);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(84, 25);
//            this.label2.TabIndex = 1;
//            this.label2.Text = "Kills: 0";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
//            this.label3.Location = new System.Drawing.Point(577, 18);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(87, 25);
//            this.label3.TabIndex = 2;
//            this.label3.Text = "Health:";
//            // 
//            // progressBar1
//            // 
//            this.progressBar1.Location = new System.Drawing.Point(679, 20);
//            this.progressBar1.Name = "progressBar1";
//            this.progressBar1.Size = new System.Drawing.Size(178, 23);
//            this.progressBar1.TabIndex = 3;
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Location = new System.Drawing.Point(74, 133);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
//            this.pictureBox1.TabIndex = 4;
//            this.pictureBox1.TabStop = false;
//            this.pictureBox1.Tag = "zombie";
//            // 
//            // picPlayer
//            // 
//            this.picPlayer.Location = new System.Drawing.Point(380, 196);
//            this.picPlayer.Name = "picPlayer";
//            this.picPlayer.Size = new System.Drawing.Size(71, 100);
//            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
//            this.picPlayer.TabIndex = 6;
//            this.picPlayer.TabStop = false;
//            // 
//            // pictureBox5
//            // 
//            this.pictureBox5.Location = new System.Drawing.Point(735, 110);
//            this.pictureBox5.Name = "pictureBox5";
//            this.pictureBox5.Size = new System.Drawing.Size(71, 71);
//            this.pictureBox5.TabIndex = 8;
//            this.pictureBox5.TabStop = false;
//            this.pictureBox5.Tag = "zombie";
//            // 
//            // pictureBox2
//            // 
//            this.pictureBox2.Location = new System.Drawing.Point(380, 463);
//            this.pictureBox2.Name = "pictureBox2";
//            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
//            this.pictureBox2.TabIndex = 9;
//            this.pictureBox2.TabStop = false;
//            this.pictureBox2.Tag = "zombie";
//            // 
//            // timer1
//            // 
//            this.timer1.Enabled = true;
//            this.timer1.Interval = 20;
//            this.timer1.Tick += new System.EventHandler(this.gameEngine);
//            // 
//            // HuntingGame
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
//            this.ClientSize = new System.Drawing.Size(923, 667);
//            this.Controls.Add(this.pictureBox2);
//            this.Controls.Add(this.pictureBox5);
//            this.Controls.Add(this.picPlayer);
//            this.Controls.Add(this.pictureBox1);
//            this.Controls.Add(this.progressBar1);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.Name = "Hunting";
//            this.Text = "Hunting";
//            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
//            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.ProgressBar progressBar1;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.PictureBox picPlayer;
//        private System.Windows.Forms.PictureBox pictureBox5;
//        private System.Windows.Forms.PictureBox pictureBox2;
//        private System.Windows.Forms.Timer timer1;
//    }
//}