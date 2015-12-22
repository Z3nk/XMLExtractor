using System;
using System.Windows.Forms;
namespace XMLExtractor
{
    partial class MainWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.UploadFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nbLineTextBox = new System.Windows.Forms.TextBox();
            this.GOButton = new System.Windows.Forms.Button();
            this.OutputDirectoryButton = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Mode1Button = new System.Windows.Forms.Button();
            this.Mode2Button = new System.Windows.Forms.Button();
            this.Mode1Text = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadFile
            // 
            this.UploadFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UploadFile.BackColor = System.Drawing.Color.Black;
            this.UploadFile.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.UploadFile.FlatAppearance.BorderSize = 3;
            this.UploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadFile.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadFile.Location = new System.Drawing.Point(52, 158);
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(172, 93);
            this.UploadFile.TabIndex = 1;
            this.UploadFile.Text = "UploadFile";
            this.UploadFile.UseVisualStyleBackColor = false;
            this.UploadFile.Click += new System.EventHandler(this.UploadFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nbLineTextBox
            // 
            this.nbLineTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbLineTextBox.BackColor = System.Drawing.Color.Black;
            this.nbLineTextBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbLineTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.nbLineTextBox.Location = new System.Drawing.Point(573, 181);
            this.nbLineTextBox.Name = "nbLineTextBox";
            this.nbLineTextBox.Size = new System.Drawing.Size(237, 27);
            this.nbLineTextBox.TabIndex = 4;
            this.nbLineTextBox.Text = "How many line by files ?";
            this.nbLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbLineTextBox.Click += new System.EventHandler(this.nbLineTextBox_Click);
            // 
            // GOButton
            // 
            this.GOButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GOButton.BackColor = System.Drawing.Color.Black;
            this.GOButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.GOButton.FlatAppearance.BorderSize = 3;
            this.GOButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GOButton.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOButton.Location = new System.Drawing.Point(359, 316);
            this.GOButton.Name = "GOButton";
            this.GOButton.Size = new System.Drawing.Size(106, 58);
            this.GOButton.TabIndex = 0;
            this.GOButton.Text = "GO";
            this.GOButton.UseVisualStyleBackColor = false;
            this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
            // 
            // OutputDirectoryButton
            // 
            this.OutputDirectoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputDirectoryButton.BackColor = System.Drawing.Color.Black;
            this.OutputDirectoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.OutputDirectoryButton.FlatAppearance.BorderSize = 3;
            this.OutputDirectoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputDirectoryButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputDirectoryButton.Location = new System.Drawing.Point(704, 316);
            this.OutputDirectoryButton.Name = "OutputDirectoryButton";
            this.OutputDirectoryButton.Size = new System.Drawing.Size(101, 58);
            this.OutputDirectoryButton.TabIndex = 5;
            this.OutputDirectoryButton.Text = "Output directory";
            this.OutputDirectoryButton.UseVisualStyleBackColor = false;
            this.OutputDirectoryButton.Click += new System.EventHandler(this.outputDirectoryButton_Click);
            // 
            // Titre
            // 
            this.Titre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(304, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(204, 43);
            this.Titre.TabIndex = 3;
            this.Titre.Text = "XMLExtractor";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Mode1Button
            // 
            this.Mode1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mode1Button.BackColor = System.Drawing.Color.Black;
            this.Mode1Button.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Mode1Button.FlatAppearance.BorderSize = 3;
            this.Mode1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode1Button.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode1Button.Location = new System.Drawing.Point(52, 338);
            this.Mode1Button.Name = "Mode1Button";
            this.Mode1Button.Size = new System.Drawing.Size(73, 36);
            this.Mode1Button.TabIndex = 5;
            this.Mode1Button.Text = "Mode 1";
            this.Mode1Button.UseVisualStyleBackColor = false;
            this.Mode1Button.Click += new System.EventHandler(this.Mode1Button_Click);
            // 
            // Mode2Button
            // 
            this.Mode2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mode2Button.BackColor = System.Drawing.Color.Black;
            this.Mode2Button.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.Mode2Button.FlatAppearance.BorderSize = 3;
            this.Mode2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode2Button.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode2Button.Location = new System.Drawing.Point(151, 338);
            this.Mode2Button.Name = "Mode2Button";
            this.Mode2Button.Size = new System.Drawing.Size(73, 36);
            this.Mode2Button.TabIndex = 6;
            this.Mode2Button.Text = "Mode 2";
            this.Mode2Button.UseVisualStyleBackColor = false;
            this.Mode2Button.Click += new System.EventHandler(this.Mode2Button_Click);
            // 
            // Mode1Text
            // 
            this.Mode1Text.AutoSize = true;
            this.Mode1Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode1Text.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode1Text.Location = new System.Drawing.Point(12, 52);
            this.Mode1Text.Name = "Mode1Text";
            this.Mode1Text.Size = new System.Drawing.Size(373, 18);
            this.Mode1Text.TabIndex = 7;
            this.Mode1Text.Text = "Mode 1 : split a file in multiple files of specified number of line";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(233, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mode 2 : extract node which specific condition";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conditionTextBox.BackColor = System.Drawing.Color.Black;
            this.conditionTextBox.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextBox.ForeColor = System.Drawing.Color.Aqua;
            this.conditionTextBox.Location = new System.Drawing.Point(573, 181);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(237, 27);
            this.conditionTextBox.TabIndex = 10;
            this.conditionTextBox.Text = "Condition";
            this.conditionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conditionTextBox.Visible = false;
            this.conditionTextBox.Click += new System.EventHandler(this.nbLineTextBox_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(822, 426);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.UploadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nbLineTextBox);
            this.Controls.Add(this.Mode1Text);
            this.Controls.Add(this.GOButton);
            this.Controls.Add(this.Mode2Button);
            this.Controls.Add(this.Mode1Button);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.OutputDirectoryButton);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Name = "MainWindows";
            this.Text = "XMLExtractor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public int? Progress
        {
            get
            {
                if (this.progressBar1.Style == ProgressBarStyle.Marquee)
                {
                    return null;
                }
                else
                {
                    return progressBar1.Value;
                }
            }

            set
            {
                if (value == null)
                {
                     progressBar1.BeginInvoke(
                     new Action(() =>
                           {
                            progressBar1.Style = ProgressBarStyle.Marquee;
                            progressBar1.Value = 100;
                            progressBar1.Visible = false;
                           }
                      ));
                }
                else
                {
                    progressBar1.BeginInvoke(
                     new Action(() =>
                           {
                               progressBar1.Style = ProgressBarStyle.Continuous;
                               progressBar1.Value = value.Value;
                               progressBar1.Visible = true;
                           }
                      ));

                    GOButton.BeginInvoke(
                         new Action(() =>
                         {
                             GOButton.Text = string.Format("{0}%", value);
                         }
                      ));
                    
                }
            }
        }

        #endregion

        private System.Windows.Forms.Button GOButton;
        private System.Windows.Forms.Button UploadFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.TextBox nbLineTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Mode1Button;
        private System.Windows.Forms.Button Mode2Button;
        private System.Windows.Forms.Label Mode1Text;
        private System.Windows.Forms.Button OutputDirectoryButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Label label1;
        private TextBox conditionTextBox;
    }
}

