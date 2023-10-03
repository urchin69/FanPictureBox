
namespace FanPictureBox
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
            this.pictBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDelPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox1
            // 
            this.pictBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBox1.Location = new System.Drawing.Point(0, 0);
            this.pictBox1.MaximumSize = new System.Drawing.Size(800, 364);
            this.pictBox1.MinimumSize = new System.Drawing.Size(800, 364);
            this.pictBox1.Name = "pictBox1";
            this.pictBox1.Size = new System.Drawing.Size(800, 364);
            this.pictBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox1.TabIndex = 0;
            this.pictBox1.TabStop = false;
            this.pictBox1.WaitOnLoad = true;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(44, 398);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(147, 39);
            this.btnAddPicture.TabIndex = 1;
            this.btnAddPicture.Text = "Dodaj  zdjęcie";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnDelPicture
            // 
            this.btnDelPicture.Location = new System.Drawing.Point(546, 398);
            this.btnDelPicture.Name = "btnDelPicture";
            this.btnDelPicture.Size = new System.Drawing.Size(174, 38);
            this.btnDelPicture.TabIndex = 2;
            this.btnDelPicture.Text = "Usuń zdjęcie";
            this.btnDelPicture.UseVisualStyleBackColor = true;
            this.btnDelPicture.Click += new System.EventHandler(this.btnDelPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelPicture);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pictBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox1;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDelPicture;
    }
}

