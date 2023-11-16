namespace DosyaKopyala
{
    partial class kopyalaFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.kaynaktxt = new System.Windows.Forms.TextBox();
            this.kaynaksecbtn = new System.Windows.Forms.Button();
            this.hedefsecbtn = new System.Windows.Forms.Button();
            this.hedeftxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.durumPb = new System.Windows.Forms.ProgressBar();
            this.kopyalabtn = new System.Windows.Forms.Button();
            this.hakkindabtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.durumlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaynak";
            // 
            // kaynaktxt
            // 
            this.kaynaktxt.Location = new System.Drawing.Point(114, 33);
            this.kaynaktxt.Name = "kaynaktxt";
            this.kaynaktxt.Size = new System.Drawing.Size(268, 22);
            this.kaynaktxt.TabIndex = 1;
            this.kaynaktxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kaynaktxt_MouseClick);
            // 
            // kaynaksecbtn
            // 
            this.kaynaksecbtn.Location = new System.Drawing.Point(398, 33);
            this.kaynaksecbtn.Name = "kaynaksecbtn";
            this.kaynaksecbtn.Size = new System.Drawing.Size(107, 23);
            this.kaynaksecbtn.TabIndex = 2;
            this.kaynaksecbtn.Text = "Kaynağı Seç";
            this.kaynaksecbtn.UseVisualStyleBackColor = true;
            this.kaynaksecbtn.Click += new System.EventHandler(this.kaynaksecbtn_Click);
            // 
            // hedefsecbtn
            // 
            this.hedefsecbtn.Location = new System.Drawing.Point(398, 61);
            this.hedefsecbtn.Name = "hedefsecbtn";
            this.hedefsecbtn.Size = new System.Drawing.Size(107, 23);
            this.hedefsecbtn.TabIndex = 5;
            this.hedefsecbtn.Text = "Hedefi Seç";
            this.hedefsecbtn.UseVisualStyleBackColor = true;
            this.hedefsecbtn.Click += new System.EventHandler(this.hedefsecbtn_Click);
            // 
            // hedeftxt
            // 
            this.hedeftxt.Location = new System.Drawing.Point(114, 61);
            this.hedeftxt.Name = "hedeftxt";
            this.hedeftxt.Size = new System.Drawing.Size(268, 22);
            this.hedeftxt.TabIndex = 4;
            this.hedeftxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hedeftxt_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hedef";
            // 
            // durumPb
            // 
            this.durumPb.Location = new System.Drawing.Point(114, 89);
            this.durumPb.Name = "durumPb";
            this.durumPb.Size = new System.Drawing.Size(268, 23);
            this.durumPb.TabIndex = 6;
            // 
            // kopyalabtn
            // 
            this.kopyalabtn.Location = new System.Drawing.Point(398, 90);
            this.kopyalabtn.Name = "kopyalabtn";
            this.kopyalabtn.Size = new System.Drawing.Size(107, 23);
            this.kopyalabtn.TabIndex = 7;
            this.kopyalabtn.Text = "Kopyala";
            this.kopyalabtn.UseVisualStyleBackColor = true;
            this.kopyalabtn.Click += new System.EventHandler(this.kopyalabtn_Click);
            // 
            // hakkindabtn
            // 
            this.hakkindabtn.Location = new System.Drawing.Point(12, 174);
            this.hakkindabtn.Name = "hakkindabtn";
            this.hakkindabtn.Size = new System.Drawing.Size(116, 38);
            this.hakkindabtn.TabIndex = 8;
            this.hakkindabtn.Text = "Hakkında";
            this.hakkindabtn.UseVisualStyleBackColor = true;
            this.hakkindabtn.Click += new System.EventHandler(this.hakkindabtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dosya:";
            // 
            // durumlbl
            // 
            this.durumlbl.AutoSize = true;
            this.durumlbl.Location = new System.Drawing.Point(111, 121);
            this.durumlbl.Name = "durumlbl";
            this.durumlbl.Size = new System.Drawing.Size(0, 16);
            this.durumlbl.TabIndex = 10;
            // 
            // kopyalaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 224);
            this.Controls.Add(this.durumlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hakkindabtn);
            this.Controls.Add(this.kopyalabtn);
            this.Controls.Add(this.durumPb);
            this.Controls.Add(this.hedefsecbtn);
            this.Controls.Add(this.hedeftxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaynaksecbtn);
            this.Controls.Add(this.kaynaktxt);
            this.Controls.Add(this.label1);
            this.Name = "kopyalaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Kopyala V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kaynaktxt;
        private System.Windows.Forms.Button kaynaksecbtn;
        private System.Windows.Forms.Button hedefsecbtn;
        private System.Windows.Forms.TextBox hedeftxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar durumPb;
        private System.Windows.Forms.Button kopyalabtn;
        private System.Windows.Forms.Button hakkindabtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durumlbl;
    }
}

