namespace YarisAti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.pbAt1 = new System.Windows.Forms.PictureBox();
            this.pbAt2 = new System.Windows.Forms.PictureBox();
            this.pbAt3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinish.Location = new System.Drawing.Point(740, 9);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(48, 432);
            this.lblFinish.TabIndex = 0;
            this.lblFinish.Text = "FINISH";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.AutoSize = true;
            this.btnBaslat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBaslat.Location = new System.Drawing.Point(428, 13);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(118, 35);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Tag = "Baslat";
            this.btnBaslat.Text = "Yarişi Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            // 
            // btnSifirla
            // 
            this.btnSifirla.AutoSize = true;
            this.btnSifirla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSifirla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSifirla.Location = new System.Drawing.Point(552, 13);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(118, 35);
            this.btnSifirla.TabIndex = 1;
            this.btnSifirla.Tag = "Sifirla";
            this.btnSifirla.Text = "Yarişi Sifirla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            // 
            // pbAt1
            // 
            this.pbAt1.Image = ((System.Drawing.Image)(resources.GetObject("pbAt1.Image")));
            this.pbAt1.Location = new System.Drawing.Point(15, 74);
            this.pbAt1.Name = "pbAt1";
            this.pbAt1.Size = new System.Drawing.Size(98, 67);
            this.pbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt1.TabIndex = 2;
            this.pbAt1.TabStop = false;
            // 
            // pbAt2
            // 
            this.pbAt2.Image = ((System.Drawing.Image)(resources.GetObject("pbAt2.Image")));
            this.pbAt2.Location = new System.Drawing.Point(15, 203);
            this.pbAt2.Name = "pbAt2";
            this.pbAt2.Size = new System.Drawing.Size(98, 67);
            this.pbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt2.TabIndex = 3;
            this.pbAt2.TabStop = false;
            // 
            // pbAt3
            // 
            this.pbAt3.Image = ((System.Drawing.Image)(resources.GetObject("pbAt3.Image")));
            this.pbAt3.Location = new System.Drawing.Point(15, 351);
            this.pbAt3.Name = "pbAt3";
            this.pbAt3.Size = new System.Drawing.Size(98, 65);
            this.pbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAt3.TabIndex = 4;
            this.pbAt3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBilgi
            // 
            this.lblBilgi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBilgi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBilgi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBilgi.Location = new System.Drawing.Point(12, 24);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(376, 23);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Skor Tablosu";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAt3);
            this.Controls.Add(this.pbAt2);
            this.Controls.Add(this.pbAt1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.PictureBox pbAt1;
        private System.Windows.Forms.PictureBox pbAt2;
        private System.Windows.Forms.PictureBox pbAt3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBilgi;
    }
}

