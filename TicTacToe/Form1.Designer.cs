namespace TicTacToe
{
    partial class Form1
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
            this.newgameBUT = new System.Windows.Forms.Button();
            this.brPIC = new System.Windows.Forms.PictureBox();
            this.bcPIC = new System.Windows.Forms.PictureBox();
            this.blPIC = new System.Windows.Forms.PictureBox();
            this.mrPIC = new System.Windows.Forms.PictureBox();
            this.mcPIC = new System.Windows.Forms.PictureBox();
            this.mlPIC = new System.Windows.Forms.PictureBox();
            this.trPIC = new System.Windows.Forms.PictureBox();
            this.tcPIC = new System.Windows.Forms.PictureBox();
            this.tlPIC = new System.Windows.Forms.PictureBox();
            this.aiBUT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.brPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mlPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // newgameBUT
            // 
            this.newgameBUT.Location = new System.Drawing.Point(62, 390);
            this.newgameBUT.Name = "newgameBUT";
            this.newgameBUT.Size = new System.Drawing.Size(100, 27);
            this.newgameBUT.TabIndex = 9;
            this.newgameBUT.Text = "NEW GAME";
            this.newgameBUT.UseVisualStyleBackColor = true;
            this.newgameBUT.Click += new System.EventHandler(this.newgameBUT_Click);
            // 
            // brPIC
            // 
            this.brPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.brPIC.Location = new System.Drawing.Point(224, 264);
            this.brPIC.Name = "brPIC";
            this.brPIC.Size = new System.Drawing.Size(100, 120);
            this.brPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brPIC.TabIndex = 8;
            this.brPIC.TabStop = false;
            this.brPIC.Click += new System.EventHandler(this.brPIC_Click);
            // 
            // bcPIC
            // 
            this.bcPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.bcPIC.Location = new System.Drawing.Point(118, 264);
            this.bcPIC.Name = "bcPIC";
            this.bcPIC.Size = new System.Drawing.Size(100, 120);
            this.bcPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bcPIC.TabIndex = 7;
            this.bcPIC.TabStop = false;
            this.bcPIC.Click += new System.EventHandler(this.bcPIC_Click);
            // 
            // blPIC
            // 
            this.blPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.blPIC.Location = new System.Drawing.Point(12, 264);
            this.blPIC.Name = "blPIC";
            this.blPIC.Size = new System.Drawing.Size(100, 120);
            this.blPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blPIC.TabIndex = 6;
            this.blPIC.TabStop = false;
            this.blPIC.Click += new System.EventHandler(this.blPIC_Click);
            // 
            // mrPIC
            // 
            this.mrPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.mrPIC.Location = new System.Drawing.Point(224, 138);
            this.mrPIC.Name = "mrPIC";
            this.mrPIC.Size = new System.Drawing.Size(100, 120);
            this.mrPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mrPIC.TabIndex = 5;
            this.mrPIC.TabStop = false;
            this.mrPIC.Click += new System.EventHandler(this.mrPIC_Click);
            // 
            // mcPIC
            // 
            this.mcPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.mcPIC.Location = new System.Drawing.Point(118, 138);
            this.mcPIC.Name = "mcPIC";
            this.mcPIC.Size = new System.Drawing.Size(100, 120);
            this.mcPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mcPIC.TabIndex = 4;
            this.mcPIC.TabStop = false;
            this.mcPIC.Click += new System.EventHandler(this.mcPIC_Click);
            // 
            // mlPIC
            // 
            this.mlPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.mlPIC.Location = new System.Drawing.Point(12, 138);
            this.mlPIC.Name = "mlPIC";
            this.mlPIC.Size = new System.Drawing.Size(100, 120);
            this.mlPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mlPIC.TabIndex = 3;
            this.mlPIC.TabStop = false;
            this.mlPIC.Click += new System.EventHandler(this.mlPIC_Click);
            // 
            // trPIC
            // 
            this.trPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.trPIC.Location = new System.Drawing.Point(224, 12);
            this.trPIC.Name = "trPIC";
            this.trPIC.Size = new System.Drawing.Size(100, 120);
            this.trPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trPIC.TabIndex = 2;
            this.trPIC.TabStop = false;
            this.trPIC.Click += new System.EventHandler(this.trPIC_Click);
            // 
            // tcPIC
            // 
            this.tcPIC.Image = global::TicTacToe.Properties.Resources._pic;
            this.tcPIC.Location = new System.Drawing.Point(118, 12);
            this.tcPIC.Name = "tcPIC";
            this.tcPIC.Size = new System.Drawing.Size(100, 120);
            this.tcPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tcPIC.TabIndex = 1;
            this.tcPIC.TabStop = false;
            this.tcPIC.Click += new System.EventHandler(this.tcPIC_Click);
            // 
            // tlPIC
            // 
            this.tlPIC.Image = global::TicTacToe.Properties.Resources.dpic;
            this.tlPIC.Location = new System.Drawing.Point(12, 12);
            this.tlPIC.Name = "tlPIC";
            this.tlPIC.Size = new System.Drawing.Size(100, 120);
            this.tlPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tlPIC.TabIndex = 0;
            this.tlPIC.TabStop = false;
            this.tlPIC.Click += new System.EventHandler(this.tlPIC_Click);
            // 
            // aiBUT
            // 
            this.aiBUT.Location = new System.Drawing.Point(168, 390);
            this.aiBUT.Name = "aiBUT";
            this.aiBUT.Size = new System.Drawing.Size(100, 27);
            this.aiBUT.TabIndex = 10;
            this.aiBUT.Text = "Play with ai?";
            this.aiBUT.UseVisualStyleBackColor = true;
            this.aiBUT.Click += new System.EventHandler(this.aiBUT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 421);
            this.Controls.Add(this.aiBUT);
            this.Controls.Add(this.newgameBUT);
            this.Controls.Add(this.brPIC);
            this.Controls.Add(this.bcPIC);
            this.Controls.Add(this.blPIC);
            this.Controls.Add(this.mrPIC);
            this.Controls.Add(this.mcPIC);
            this.Controls.Add(this.mlPIC);
            this.Controls.Add(this.trPIC);
            this.Controls.Add(this.tcPIC);
            this.Controls.Add(this.tlPIC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mlPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tlPIC;
        private System.Windows.Forms.PictureBox tcPIC;
        private System.Windows.Forms.PictureBox trPIC;
        private System.Windows.Forms.PictureBox mlPIC;
        private System.Windows.Forms.PictureBox mcPIC;
        private System.Windows.Forms.PictureBox mrPIC;
        private System.Windows.Forms.PictureBox blPIC;
        private System.Windows.Forms.PictureBox bcPIC;
        private System.Windows.Forms.PictureBox brPIC;
        private System.Windows.Forms.Button newgameBUT;
        private System.Windows.Forms.Button aiBUT;
    }
}

