
namespace taskManager
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
            this.components = new System.ComponentModel.Container();
            this.proseslerlistesi = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.threadSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullandığıBellekMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullandığıİşlemciYüzdesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öldürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secilenProses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uyarı = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proseslerlistesi
            // 
            this.proseslerlistesi.ContextMenuStrip = this.contextMenuStrip1;
            this.proseslerlistesi.FormattingEnabled = true;
            this.proseslerlistesi.ItemHeight = 16;
            this.proseslerlistesi.Location = new System.Drawing.Point(30, 48);
            this.proseslerlistesi.Name = "proseslerlistesi";
            this.proseslerlistesi.Size = new System.Drawing.Size(430, 404);
            this.proseslerlistesi.TabIndex = 0;
            this.proseslerlistesi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadSayısıToolStripMenuItem,
            this.kullandığıBellekMiktarıToolStripMenuItem,
            this.kullandığıİşlemciYüzdesiToolStripMenuItem,
            this.öldürToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 100);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // threadSayısıToolStripMenuItem
            // 
            this.threadSayısıToolStripMenuItem.Name = "threadSayısıToolStripMenuItem";
            this.threadSayısıToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.threadSayısıToolStripMenuItem.Text = "Thread Sayısı";
            this.threadSayısıToolStripMenuItem.Click += new System.EventHandler(this.threadSayısıToolStripMenuItem_Click);
            // 
            // kullandığıBellekMiktarıToolStripMenuItem
            // 
            this.kullandığıBellekMiktarıToolStripMenuItem.Name = "kullandığıBellekMiktarıToolStripMenuItem";
            this.kullandığıBellekMiktarıToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.kullandığıBellekMiktarıToolStripMenuItem.Text = "Kullandığı Bellek Miktarı";
            this.kullandığıBellekMiktarıToolStripMenuItem.Click += new System.EventHandler(this.kullandığıBellekMiktarıToolStripMenuItem_Click);
            // 
            // kullandığıİşlemciYüzdesiToolStripMenuItem
            // 
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Name = "kullandığıİşlemciYüzdesiToolStripMenuItem";
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Text = "Kullandığı İşlemci Yüzdesi";
            this.kullandığıİşlemciYüzdesiToolStripMenuItem.Click += new System.EventHandler(this.kullandığıİşlemciYüzdesiToolStripMenuItem_Click);
            // 
            // öldürToolStripMenuItem
            // 
            this.öldürToolStripMenuItem.Name = "öldürToolStripMenuItem";
            this.öldürToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.öldürToolStripMenuItem.Text = "Öldür";
            this.öldürToolStripMenuItem.Click += new System.EventHandler(this.öldürToolStripMenuItem_Click);
            // 
            // secilenProses
            // 
            this.secilenProses.Location = new System.Drawing.Point(168, 493);
            this.secilenProses.Multiline = true;
            this.secilenProses.Name = "secilenProses";
            this.secilenProses.Size = new System.Drawing.Size(186, 22);
            this.secilenProses.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seçilen Proses";
            // 
            // uyarı
            // 
            this.uyarı.AutoSize = true;
            this.uyarı.Location = new System.Drawing.Point(205, 18);
            this.uyarı.Name = "uyarı";
            this.uyarı.Size = new System.Drawing.Size(221, 17);
            this.uyarı.TabIndex = 4;
            this.uyarı.Text = "CPU KULLANIMI HESAPLANIYOR";
            this.uyarı.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 559);
            this.Controls.Add(this.uyarı);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secilenProses);
            this.Controls.Add(this.proseslerlistesi);
            this.Name = "Form1";
            this.Text = "Görev Yöneticisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox proseslerlistesi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem threadSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullandığıBellekMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullandığıİşlemciYüzdesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öldürToolStripMenuItem;
        private System.Windows.Forms.TextBox secilenProses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uyarı;
    }
}

