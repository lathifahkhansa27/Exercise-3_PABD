
namespace Exercise_3
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDGview = new System.Windows.Forms.Button();
            this.buttonBnavigasi = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            // 
            // buttonDGview
            // 
            this.buttonDGview.BackColor = System.Drawing.Color.Thistle;
            this.buttonDGview.Location = new System.Drawing.Point(85, 221);
            this.buttonDGview.Name = "buttonDGview";
            this.buttonDGview.Size = new System.Drawing.Size(176, 33);
            this.buttonDGview.TabIndex = 3;
            this.buttonDGview.Text = "DataGrid View";
            this.buttonDGview.UseVisualStyleBackColor = false;
            this.buttonDGview.Click += new System.EventHandler(this.buttonDGview_Click);
            // 
            // buttonBnavigasi
            // 
            this.buttonBnavigasi.BackColor = System.Drawing.Color.Thistle;
            this.buttonBnavigasi.Location = new System.Drawing.Point(322, 221);
            this.buttonBnavigasi.Name = "buttonBnavigasi";
            this.buttonBnavigasi.Size = new System.Drawing.Size(196, 33);
            this.buttonBnavigasi.TabIndex = 4;
            this.buttonBnavigasi.Text = "Binding Navigation";
            this.buttonBnavigasi.UseVisualStyleBackColor = false;
            this.buttonBnavigasi.Click += new System.EventHandler(this.buttonBnavigasi_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.Thistle;
            this.buttonKembali.Location = new System.Drawing.Point(509, 369);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(89, 30);
            this.buttonKembali.TabIndex = 6;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Exercise_3.Properties.Resources._7625563;
            this.pictureBox3.Location = new System.Drawing.Point(528, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exercise_3.Properties.Resources._2096803;
            this.pictureBox2.Location = new System.Drawing.Point(370, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise_3.Properties.Resources._4598376;
            this.pictureBox1.Location = new System.Drawing.Point(121, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonBnavigasi);
            this.Controls.Add(this.buttonDGview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDGview;
        private System.Windows.Forms.Button buttonBnavigasi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonKembali;
    }
}