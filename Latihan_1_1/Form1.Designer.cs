namespace Latihan_1_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maxteks = new System.Windows.Forms.Label();
            this.minteks = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.vermax = new System.Windows.Forms.VScrollBar();
            this.vermin = new System.Windows.Forms.VScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maxteks);
            this.tabPage1.Controls.Add(this.minteks);
            this.tabPage1.Controls.Add(this.tanggal);
            this.tabPage1.Controls.Add(this.vermax);
            this.tabPage1.Controls.Add(this.vermin);
            this.tabPage1.ImageKey = "play-icon.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab Page 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maxteks
            // 
            this.maxteks.AutoSize = true;
            this.maxteks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxteks.Location = new System.Drawing.Point(319, 304);
            this.maxteks.Name = "maxteks";
            this.maxteks.Size = new System.Drawing.Size(40, 18);
            this.maxteks.TabIndex = 4;
            this.maxteks.Text = "MAX";
            // 
            // minteks
            // 
            this.minteks.AutoSize = true;
            this.minteks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minteks.Location = new System.Drawing.Point(29, 304);
            this.minteks.Name = "minteks";
            this.minteks.Size = new System.Drawing.Size(35, 18);
            this.minteks.TabIndex = 3;
            this.minteks.Text = "MIN";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(98, 46);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(200, 20);
            this.tanggal.TabIndex = 2;
            // 
            // vermax
            // 
            this.vermax.LargeChange = 1;
            this.vermax.Location = new System.Drawing.Point(329, 46);
            this.vermax.Maximum = 10;
            this.vermax.Name = "vermax";
            this.vermax.Size = new System.Drawing.Size(25, 240);
            this.vermax.TabIndex = 1;
            this.vermax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vermax_Scroll);
            // 
            // vermin
            // 
            this.vermin.LargeChange = 1;
            this.vermin.Location = new System.Drawing.Point(38, 46);
            this.vermin.Maximum = 10;
            this.vermin.Name = "vermin";
            this.vermin.Size = new System.Drawing.Size(25, 240);
            this.vermin.TabIndex = 0;
            this.vermin.Value = 10;
            this.vermin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vermin_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "di7o9Er6T.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tab Page 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "play-icon.png");
            this.imageList1.Images.SetKeyName(1, "di7o9Er6T.png");
            this.imageList1.Images.SetKeyName(2, "fav.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 390);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label maxteks;
        private System.Windows.Forms.Label minteks;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.VScrollBar vermax;
        private System.Windows.Forms.VScrollBar vermin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

