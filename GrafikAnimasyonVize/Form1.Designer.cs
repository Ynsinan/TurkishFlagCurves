namespace GrafikAnimasyonVize
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ÇİZ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cizim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cizim)).BeginInit();
            this.SuspendLayout();
            // 
            // ÇİZ
            // 
            this.ÇİZ.Location = new System.Drawing.Point(469, 150);
            this.ÇİZ.Name = "ÇİZ";
            this.ÇİZ.Size = new System.Drawing.Size(96, 33);
            this.ÇİZ.TabIndex = 0;
            this.ÇİZ.Text = "ÇİZ";
            this.ÇİZ.UseVisualStyleBackColor = true;
            this.ÇİZ.Click += new System.EventHandler(this.ÇİZ_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "KAPAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cizim
            // 
            this.Cizim.Location = new System.Drawing.Point(12, 12);
            this.Cizim.Name = "Cizim";
            this.Cizim.Size = new System.Drawing.Size(451, 255);
            this.Cizim.TabIndex = 3;
            this.Cizim.TabStop = false;
            this.Cizim.Paint += new System.Windows.Forms.PaintEventHandler(this.Cizim_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 279);
            this.Controls.Add(this.Cizim);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ÇİZ);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Cizim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ÇİZ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox Cizim;
    }
}

