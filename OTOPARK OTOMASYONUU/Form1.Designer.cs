namespace OTOPARK_OTOMASYONUU
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtotoparkadı = new System.Windows.Forms.TextBox();
            this.txtkapasite = new System.Windows.Forms.TextBox();
            this.btncreateotapark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntstgrs = new System.Windows.Forms.Button();
            this.btntstcks = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnkzncsorgla = new System.Windows.Forms.Button();
            this.btnotprkyersorgula = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btncreateotapark);
            this.groupBox1.Controls.Add(this.txtkapasite);
            this.groupBox1.Controls.Add(this.txtotoparkadı);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otopark Oluşturma Sekmesi";
            // 
            // txtotoparkadı
            // 
            this.txtotoparkadı.Location = new System.Drawing.Point(186, 38);
            this.txtotoparkadı.Name = "txtotoparkadı";
            this.txtotoparkadı.Size = new System.Drawing.Size(208, 22);
            this.txtotoparkadı.TabIndex = 3;
            // 
            // txtkapasite
            // 
            this.txtkapasite.Location = new System.Drawing.Point(186, 78);
            this.txtkapasite.Name = "txtkapasite";
            this.txtkapasite.Size = new System.Drawing.Size(208, 22);
            this.txtkapasite.TabIndex = 3;
            // 
            // btncreateotapark
            // 
            this.btncreateotapark.Location = new System.Drawing.Point(440, 38);
            this.btncreateotapark.Name = "btncreateotapark";
            this.btncreateotapark.Size = new System.Drawing.Size(251, 62);
            this.btncreateotapark.TabIndex = 4;
            this.btncreateotapark.Text = "Otopark Oluştur";
            this.btncreateotapark.UseVisualStyleBackColor = true;
            this.btncreateotapark.Click += new System.EventHandler(this.btncreateotapark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otopark Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Araç Kapasitesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.btntstcks);
            this.groupBox2.Controls.Add(this.btntstgrs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(25, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otopark Taşıt Giriş-Çıkış";
            // 
            // btntstgrs
            // 
            this.btntstgrs.Location = new System.Drawing.Point(6, 87);
            this.btntstgrs.Name = "btntstgrs";
            this.btntstgrs.Size = new System.Drawing.Size(155, 116);
            this.btntstgrs.TabIndex = 0;
            this.btntstgrs.Text = "Otopark Taşıt Giriş";
            this.btntstgrs.UseVisualStyleBackColor = true;
            this.btntstgrs.Click += new System.EventHandler(this.btntstgrs_Click);
            // 
            // btntstcks
            // 
            this.btntstcks.Location = new System.Drawing.Point(199, 87);
            this.btntstcks.Name = "btntstcks";
            this.btntstcks.Size = new System.Drawing.Size(157, 116);
            this.btntstcks.TabIndex = 0;
            this.btntstcks.Text = "Otopark Taşıt Çıkış";
            this.btntstcks.UseVisualStyleBackColor = true;
            this.btntstcks.Click += new System.EventHandler(this.btntstcks_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(116, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Otomobil-Motosiklet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnotprkyersorgula);
            this.groupBox3.Controls.Add(this.btnkzncsorgla);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(425, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otopark Rapor";
            // 
            // btnkzncsorgla
            // 
            this.btnkzncsorgla.Location = new System.Drawing.Point(16, 72);
            this.btnkzncsorgla.Name = "btnkzncsorgla";
            this.btnkzncsorgla.Size = new System.Drawing.Size(140, 116);
            this.btnkzncsorgla.TabIndex = 0;
            this.btnkzncsorgla.Text = "Otopark Kazanç Sorgula";
            this.btnkzncsorgla.UseVisualStyleBackColor = true;
            this.btnkzncsorgla.Click += new System.EventHandler(this.btnkzncsorgla_Click);
            // 
            // btnotprkyersorgula
            // 
            this.btnotprkyersorgula.Location = new System.Drawing.Point(180, 72);
            this.btnotprkyersorgula.Name = "btnotprkyersorgula";
            this.btnotprkyersorgula.Size = new System.Drawing.Size(125, 116);
            this.btnotprkyersorgula.TabIndex = 0;
            this.btnotprkyersorgula.Text = "Otopark Kalan Yer Sorgula";
            this.btnotprkyersorgula.UseVisualStyleBackColor = true;
            this.btnotprkyersorgula.Click += new System.EventHandler(this.btnotprkyersorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreateotapark;
        private System.Windows.Forms.TextBox txtkapasite;
        private System.Windows.Forms.TextBox txtotoparkadı;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btntstcks;
        private System.Windows.Forms.Button btntstgrs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnotprkyersorgula;
        private System.Windows.Forms.Button btnkzncsorgla;
    }
}

