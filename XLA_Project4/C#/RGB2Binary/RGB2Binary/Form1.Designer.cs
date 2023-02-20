namespace RGB2Binary
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
            this.picBox_AnhGoc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Binary = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Nguong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_AnhGoc
            // 
            this.picBox_AnhGoc.Location = new System.Drawing.Point(62, 86);
            this.picBox_AnhGoc.Name = "picBox_AnhGoc";
            this.picBox_AnhGoc.Size = new System.Drawing.Size(512, 512);
            this.picBox_AnhGoc.TabIndex = 0;
            this.picBox_AnhGoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anh goc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(776, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binary image";
            // 
            // picBox_Binary
            // 
            this.picBox_Binary.Location = new System.Drawing.Point(641, 86);
            this.picBox_Binary.Name = "picBox_Binary";
            this.picBox_Binary.Size = new System.Drawing.Size(512, 512);
            this.picBox_Binary.TabIndex = 2;
            this.picBox_Binary.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 4;
            // 
            // ScrollBar
            // 
            this.ScrollBar.LargeChange = 30;
            this.ScrollBar.Location = new System.Drawing.Point(1223, 86);
            this.ScrollBar.Maximum = 255;
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(58, 511);
            this.ScrollBar.SmallChange = 10;
            this.ScrollBar.TabIndex = 5;
            this.ScrollBar.ValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1181, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nguong";
            // 
            // lb_Nguong
            // 
            this.lb_Nguong.AutoSize = true;
            this.lb_Nguong.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nguong.Location = new System.Drawing.Point(1284, 121);
            this.lb_Nguong.Name = "lb_Nguong";
            this.lb_Nguong.Size = new System.Drawing.Size(0, 37);
            this.lb_Nguong.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 833);
            this.Controls.Add(this.lb_Nguong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_Binary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_AnhGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Binary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_AnhGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Binary;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar ScrollBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Nguong;
    }
}

