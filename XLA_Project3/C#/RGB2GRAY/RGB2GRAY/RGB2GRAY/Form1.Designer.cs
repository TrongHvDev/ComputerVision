namespace RGB2GRAY
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
            this.picBox_HinhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Avg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Light = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Luminance = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Avg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Light)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_HinhGoc
            // 
            this.picBox_HinhGoc.Location = new System.Drawing.Point(57, 99);
            this.picBox_HinhGoc.Name = "picBox_HinhGoc";
            this.picBox_HinhGoc.Size = new System.Drawing.Size(500, 381);
            this.picBox_HinhGoc.TabIndex = 0;
            this.picBox_HinhGoc.TabStop = false;
            this.picBox_HinhGoc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ảnh Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picBox_Avg
            // 
            this.picBox_Avg.Location = new System.Drawing.Point(626, 99);
            this.picBox_Avg.Name = "picBox_Avg";
            this.picBox_Avg.Size = new System.Drawing.Size(500, 381);
            this.picBox_Avg.TabIndex = 2;
            this.picBox_Avg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lightness";
            // 
            // picBox_Light
            // 
            this.picBox_Light.Location = new System.Drawing.Point(57, 568);
            this.picBox_Light.Name = "picBox_Light";
            this.picBox_Light.Size = new System.Drawing.Size(500, 381);
            this.picBox_Light.TabIndex = 4;
            this.picBox_Light.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(639, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Luminance";
            // 
            // picBox_Luminance
            // 
            this.picBox_Luminance.Location = new System.Drawing.Point(626, 568);
            this.picBox_Luminance.Name = "picBox_Luminance";
            this.picBox_Luminance.Size = new System.Drawing.Size(500, 381);
            this.picBox_Luminance.TabIndex = 6;
            this.picBox_Luminance.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 1061);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Luminance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picBox_Light);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Avg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_HinhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HinhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Avg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Light)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Luminance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_HinhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Avg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Light;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBox_Luminance;
    }
}

