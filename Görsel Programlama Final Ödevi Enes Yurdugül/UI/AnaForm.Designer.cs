namespace Görsel_Programlama_Final_Ödevi_Enes_Yurdugül
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtnOtobusEkle = new System.Windows.Forms.ToolStripButton();
            this.BtnOtobusGuncelle = new System.Windows.Forms.ToolStripButton();
            this.BtnOtobusSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnOtobusBul = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSoforEkle = new System.Windows.Forms.ToolStripButton();
            this.BtnSoforGuncelle = new System.Windows.Forms.ToolStripButton();
            this.BtnSoforSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.BtnSoforBul = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 291);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Otobüsler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnOtobusEkle,
            this.BtnOtobusGuncelle,
            this.BtnOtobusSil,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.BtnOtobusBul});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(571, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtnOtobusEkle
            // 
            this.BtnOtobusEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnOtobusEkle.Image")));
            this.BtnOtobusEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOtobusEkle.Name = "BtnOtobusEkle";
            this.BtnOtobusEkle.Size = new System.Drawing.Size(48, 22);
            this.BtnOtobusEkle.Text = "Ekle";
            this.BtnOtobusEkle.Click += new System.EventHandler(this.BtnOtobusEkle_Click);
            // 
            // BtnOtobusGuncelle
            // 
            this.BtnOtobusGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnOtobusGuncelle.Image")));
            this.BtnOtobusGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOtobusGuncelle.Name = "BtnOtobusGuncelle";
            this.BtnOtobusGuncelle.Size = new System.Drawing.Size(73, 22);
            this.BtnOtobusGuncelle.Text = "Güncelle";
            this.BtnOtobusGuncelle.Click += new System.EventHandler(this.BtnOtobusGuncelle_Click);
            // 
            // BtnOtobusSil
            // 
            this.BtnOtobusSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnOtobusSil.Image")));
            this.BtnOtobusSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOtobusSil.Name = "BtnOtobusSil";
            this.BtnOtobusSil.Size = new System.Drawing.Size(39, 22);
            this.BtnOtobusSil.Text = "Sil";
            this.BtnOtobusSil.Click += new System.EventHandler(this.BtnOtobusSil_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 25);
            // 
            // BtnOtobusBul
            // 
            this.BtnOtobusBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOtobusBul.Name = "BtnOtobusBul";
            this.BtnOtobusBul.Size = new System.Drawing.Size(28, 22);
            this.BtnOtobusBul.Text = "Bul";
            this.BtnOtobusBul.Click += new System.EventHandler(this.BtnOtobusBul_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şoförler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(571, 234);
            this.dataGridView2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSoforEkle,
            this.BtnSoforGuncelle,
            this.BtnSoforSil,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.BtnSoforBul});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnSoforEkle
            // 
            this.BtnSoforEkle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSoforEkle.Image")));
            this.BtnSoforEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSoforEkle.Name = "BtnSoforEkle";
            this.BtnSoforEkle.Size = new System.Drawing.Size(48, 22);
            this.BtnSoforEkle.Text = "Ekle";
            this.BtnSoforEkle.Click += new System.EventHandler(this.BtnSoforEkle_Click);
            // 
            // BtnSoforGuncelle
            // 
            this.BtnSoforGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("BtnSoforGuncelle.Image")));
            this.BtnSoforGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSoforGuncelle.Name = "BtnSoforGuncelle";
            this.BtnSoforGuncelle.Size = new System.Drawing.Size(73, 22);
            this.BtnSoforGuncelle.Text = "Güncelle";
            this.BtnSoforGuncelle.Click += new System.EventHandler(this.BtnSoforGuncelle_Click);
            // 
            // BtnSoforSil
            // 
            this.BtnSoforSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSoforSil.Image")));
            this.BtnSoforSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSoforSil.Name = "BtnSoforSil";
            this.BtnSoforSil.Size = new System.Drawing.Size(39, 22);
            this.BtnSoforSil.Text = "Sil";
            this.BtnSoforSil.Click += new System.EventHandler(this.BtnSoforSil_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(150, 25);
            // 
            // BtnSoforBul
            // 
            this.BtnSoforBul.Image = global::Görsel_Programlama_Final_Ödevi_Enes_Yurdugül.Properties.Resources.people_customer_man_search;
            this.BtnSoforBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSoforBul.Name = "BtnSoforBul";
            this.BtnSoforBul.Size = new System.Drawing.Size(44, 22);
            this.BtnSoforBul.Text = "Bul";
            this.BtnSoforBul.Click += new System.EventHandler(this.BtnSoforBul_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(585, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 291);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.Text = "Otobüs Firması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtnOtobusEkle;
        private System.Windows.Forms.ToolStripButton BtnOtobusGuncelle;
        private System.Windows.Forms.ToolStripButton BtnOtobusSil;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSoforEkle;
        private System.Windows.Forms.ToolStripButton BtnSoforGuncelle;
        private System.Windows.Forms.ToolStripButton BtnSoforSil;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton BtnOtobusBul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton BtnSoforBul;
    }
}

