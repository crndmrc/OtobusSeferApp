namespace OtobusSeferApp.Models
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_anasayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_cikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_YolculukTarihi = new System.Windows.Forms.Label();
            this.cmb_KalkisNoktasi = new System.Windows.Forms.ComboBox();
            this.lbl_kalkisNoktasi = new System.Windows.Forms.Label();
            this.lbl_VarisNoktasi = new System.Windows.Forms.Label();
            this.cmb_VarisNoktasi = new System.Windows.Forms.ComboBox();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.tc_sefer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_Detay = new System.Windows.Forms.DataGridView();
            this.txt_aranacakDegerSefer = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_aranacakDegerBilet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sefer_id = new System.Windows.Forms.TextBox();
            this.txt_username_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_biletNo = new System.Windows.Forms.TextBox();
            this.txt_BiletSahipSoyadi = new System.Windows.Forms.TextBox();
            this.txt_biletSahipCep = new System.Windows.Forms.TextBox();
            this.txt_BiletSahipAdi = new System.Windows.Forms.TextBox();
            this.lbl_biletNo = new System.Windows.Forms.Label();
            this.lbl_biletSahipCep = new System.Windows.Forms.Label();
            this.lbl_biletSahipSoyad = new System.Windows.Forms.Label();
            this.lbl_biletSahipAd = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_aranacakDegerKullanici = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tc_sefer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_anasayfa,
            this.tsm_cikisYap});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsm_anasayfa
            // 
            this.tsm_anasayfa.Name = "tsm_anasayfa";
            this.tsm_anasayfa.Size = new System.Drawing.Size(67, 20);
            this.tsm_anasayfa.Text = "Anasayfa";
            // 
            // tsm_cikisYap
            // 
            this.tsm_cikisYap.Name = "tsm_cikisYap";
            this.tsm_cikisYap.Size = new System.Drawing.Size(66, 20);
            this.tsm_cikisYap.Text = "Çıkış Yap";
            this.tsm_cikisYap.Click += new System.EventHandler(this.tsm_cikisYap_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel.Text = "Durum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lbl_YolculukTarihi
            // 
            this.lbl_YolculukTarihi.AutoSize = true;
            this.lbl_YolculukTarihi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_YolculukTarihi.Location = new System.Drawing.Point(353, 42);
            this.lbl_YolculukTarihi.Name = "lbl_YolculukTarihi";
            this.lbl_YolculukTarihi.Size = new System.Drawing.Size(77, 13);
            this.lbl_YolculukTarihi.TabIndex = 6;
            this.lbl_YolculukTarihi.Text = "Yolculuk Tarihi";
            // 
            // cmb_KalkisNoktasi
            // 
            this.cmb_KalkisNoktasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KalkisNoktasi.FormattingEnabled = true;
            this.cmb_KalkisNoktasi.Items.AddRange(new object[] {
            "İstanbul",
            "Sinop",
            "Konya"});
            this.cmb_KalkisNoktasi.Location = new System.Drawing.Point(82, 37);
            this.cmb_KalkisNoktasi.Name = "cmb_KalkisNoktasi";
            this.cmb_KalkisNoktasi.Size = new System.Drawing.Size(96, 21);
            this.cmb_KalkisNoktasi.TabIndex = 7;
            // 
            // lbl_kalkisNoktasi
            // 
            this.lbl_kalkisNoktasi.AutoSize = true;
            this.lbl_kalkisNoktasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_kalkisNoktasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kalkisNoktasi.Location = new System.Drawing.Point(2, 42);
            this.lbl_kalkisNoktasi.Name = "lbl_kalkisNoktasi";
            this.lbl_kalkisNoktasi.Size = new System.Drawing.Size(74, 13);
            this.lbl_kalkisNoktasi.TabIndex = 8;
            this.lbl_kalkisNoktasi.Text = "Kalkış Noktası";
            // 
            // lbl_VarisNoktasi
            // 
            this.lbl_VarisNoktasi.AutoSize = true;
            this.lbl_VarisNoktasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_VarisNoktasi.Location = new System.Drawing.Point(184, 42);
            this.lbl_VarisNoktasi.Name = "lbl_VarisNoktasi";
            this.lbl_VarisNoktasi.Size = new System.Drawing.Size(69, 13);
            this.lbl_VarisNoktasi.TabIndex = 10;
            this.lbl_VarisNoktasi.Text = "Varış Noktası";
            // 
            // cmb_VarisNoktasi
            // 
            this.cmb_VarisNoktasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_VarisNoktasi.FormattingEnabled = true;
            this.cmb_VarisNoktasi.Items.AddRange(new object[] {
            "İstabul",
            "Sinop",
            "Konya"});
            this.cmb_VarisNoktasi.Location = new System.Drawing.Point(259, 37);
            this.cmb_VarisNoktasi.Name = "cmb_VarisNoktasi";
            this.cmb_VarisNoktasi.Size = new System.Drawing.Size(88, 21);
            this.cmb_VarisNoktasi.TabIndex = 9;
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(18, 41);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_bilgi.TabIndex = 11;
            // 
            // tc_sefer
            // 
            this.tc_sefer.Controls.Add(this.tabPage1);
            this.tc_sefer.Controls.Add(this.tabPage2);
            this.tc_sefer.Controls.Add(this.tabPage3);
            this.tc_sefer.Location = new System.Drawing.Point(12, 70);
            this.tc_sefer.Name = "tc_sefer";
            this.tc_sefer.SelectedIndex = 0;
            this.tc_sefer.Size = new System.Drawing.Size(605, 331);
            this.tc_sefer.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_Detay);
            this.tabPage1.Controls.Add(this.txt_aranacakDegerSefer);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.lbl_VarisNoktasi);
            this.tabPage1.Controls.Add(this.lbl_YolculukTarihi);
            this.tabPage1.Controls.Add(this.cmb_VarisNoktasi);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.lbl_kalkisNoktasi);
            this.tabPage1.Controls.Add(this.cmb_KalkisNoktasi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seferler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Detay
            // 
            this.dataGridView_Detay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView_Detay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detay.Location = new System.Drawing.Point(3, 204);
            this.dataGridView_Detay.Name = "dataGridView_Detay";
            this.dataGridView_Detay.Size = new System.Drawing.Size(591, 95);
            this.dataGridView_Detay.TabIndex = 13;
            // 
            // txt_aranacakDegerSefer
            // 
            this.txt_aranacakDegerSefer.Location = new System.Drawing.Point(131, 3);
            this.txt_aranacakDegerSefer.Name = "txt_aranacakDegerSefer";
            this.txt_aranacakDegerSefer.Size = new System.Drawing.Size(132, 20);
            this.txt_aranacakDegerSefer.TabIndex = 11;
            this.txt_aranacakDegerSefer.TextChanged += new System.EventHandler(this.txt_aranacakDegerSefer_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(269, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(322, 20);
            this.progressBar1.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 69);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(591, 129);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "ToolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Listele";
            this.toolStripButton1.ToolTipText = "List";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Ekle";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Değştirme";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Silme";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Arama";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aranacakDegerBilet);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_sefer_id);
            this.tabPage2.Controls.Add(this.txt_username_id);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txt_biletNo);
            this.tabPage2.Controls.Add(this.txt_BiletSahipSoyadi);
            this.tabPage2.Controls.Add(this.txt_biletSahipCep);
            this.tabPage2.Controls.Add(this.txt_BiletSahipAdi);
            this.tabPage2.Controls.Add(this.lbl_biletNo);
            this.tabPage2.Controls.Add(this.lbl_biletSahipCep);
            this.tabPage2.Controls.Add(this.lbl_biletSahipSoyad);
            this.tabPage2.Controls.Add(this.lbl_biletSahipAd);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Biletler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_aranacakDegerBilet
            // 
            this.txt_aranacakDegerBilet.Location = new System.Drawing.Point(130, 3);
            this.txt_aranacakDegerBilet.Name = "txt_aranacakDegerBilet";
            this.txt_aranacakDegerBilet.Size = new System.Drawing.Size(132, 20);
            this.txt_aranacakDegerBilet.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "sefer_id";
            // 
            // txt_sefer_id
            // 
            this.txt_sefer_id.Location = new System.Drawing.Point(491, 70);
            this.txt_sefer_id.Name = "txt_sefer_id";
            this.txt_sefer_id.Size = new System.Drawing.Size(100, 20);
            this.txt_sefer_id.TabIndex = 16;
            // 
            // txt_username_id
            // 
            this.txt_username_id.Location = new System.Drawing.Point(491, 37);
            this.txt_username_id.Name = "txt_username_id";
            this.txt_username_id.Size = new System.Drawing.Size(100, 20);
            this.txt_username_id.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Username_id";
            // 
            // txt_biletNo
            // 
            this.txt_biletNo.Location = new System.Drawing.Point(293, 74);
            this.txt_biletNo.Name = "txt_biletNo";
            this.txt_biletNo.Size = new System.Drawing.Size(100, 20);
            this.txt_biletNo.TabIndex = 13;
            // 
            // txt_BiletSahipSoyadi
            // 
            this.txt_BiletSahipSoyadi.Location = new System.Drawing.Point(293, 41);
            this.txt_BiletSahipSoyadi.Name = "txt_BiletSahipSoyadi";
            this.txt_BiletSahipSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_BiletSahipSoyadi.TabIndex = 12;
            // 
            // txt_biletSahipCep
            // 
            this.txt_biletSahipCep.Location = new System.Drawing.Point(89, 67);
            this.txt_biletSahipCep.Name = "txt_biletSahipCep";
            this.txt_biletSahipCep.Size = new System.Drawing.Size(100, 20);
            this.txt_biletSahipCep.TabIndex = 11;
            // 
            // txt_BiletSahipAdi
            // 
            this.txt_BiletSahipAdi.Location = new System.Drawing.Point(89, 41);
            this.txt_BiletSahipAdi.Name = "txt_BiletSahipAdi";
            this.txt_BiletSahipAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_BiletSahipAdi.TabIndex = 10;
            // 
            // lbl_biletNo
            // 
            this.lbl_biletNo.AutoSize = true;
            this.lbl_biletNo.Location = new System.Drawing.Point(195, 74);
            this.lbl_biletNo.Name = "lbl_biletNo";
            this.lbl_biletNo.Size = new System.Drawing.Size(44, 13);
            this.lbl_biletNo.TabIndex = 9;
            this.lbl_biletNo.Text = "Bilet No";
            // 
            // lbl_biletSahipCep
            // 
            this.lbl_biletSahipCep.AutoSize = true;
            this.lbl_biletSahipCep.Location = new System.Drawing.Point(6, 70);
            this.lbl_biletSahipCep.Name = "lbl_biletSahipCep";
            this.lbl_biletSahipCep.Size = new System.Drawing.Size(79, 13);
            this.lbl_biletSahipCep.TabIndex = 8;
            this.lbl_biletSahipCep.Text = "Bilet Sahip Cep";
            // 
            // lbl_biletSahipSoyad
            // 
            this.lbl_biletSahipSoyad.AutoSize = true;
            this.lbl_biletSahipSoyad.Location = new System.Drawing.Point(195, 44);
            this.lbl_biletSahipSoyad.Name = "lbl_biletSahipSoyad";
            this.lbl_biletSahipSoyad.Size = new System.Drawing.Size(92, 13);
            this.lbl_biletSahipSoyad.TabIndex = 7;
            this.lbl_biletSahipSoyad.Text = "Bilet Sahip Soyadı";
            // 
            // lbl_biletSahipAd
            // 
            this.lbl_biletSahipAd.AutoSize = true;
            this.lbl_biletSahipAd.Location = new System.Drawing.Point(6, 44);
            this.lbl_biletSahipAd.Name = "lbl_biletSahipAd";
            this.lbl_biletSahipAd.Size = new System.Drawing.Size(77, 13);
            this.lbl_biletSahipAd.TabIndex = 6;
            this.lbl_biletSahipAd.Text = "Bilet Sahibi Adı";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(585, 186);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton7});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(591, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "ToolStrip";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Listele";
            this.toolStripButton6.ToolTipText = "List";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Ekle";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Değştirme";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Silme";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Arama";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_aranacakDegerKullanici);
            this.tabPage3.Controls.Add(this.txt_sifre);
            this.tabPage3.Controls.Add(this.txt_kullaniciAdi);
            this.tabPage3.Controls.Add(this.lbl_sifre);
            this.tabPage3.Controls.Add(this.lbl_kullaniciAdi);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(597, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcı Bilgileri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_aranacakDegerKullanici
            // 
            this.txt_aranacakDegerKullanici.Location = new System.Drawing.Point(141, 6);
            this.txt_aranacakDegerKullanici.Name = "txt_aranacakDegerKullanici";
            this.txt_aranacakDegerKullanici.Size = new System.Drawing.Size(132, 20);
            this.txt_aranacakDegerKullanici.TabIndex = 12;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(227, 36);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 10;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(87, 36);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciAdi.TabIndex = 9;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(193, 39);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_sifre.TabIndex = 8;
            this.lbl_sifre.Text = "Şifre";
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(17, 39);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lbl_kullaniciAdi.TabIndex = 6;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 242);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton11,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripButton12});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(591, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "ToolStrip";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Listele";
            this.toolStripButton11.ToolTipText = "List";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Ekle";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Değştirme";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Silme";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Arama";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tc_sefer);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tc_sefer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsm_anasayfa;
        private System.Windows.Forms.ToolStripMenuItem tsm_cikisYap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_YolculukTarihi;
        private System.Windows.Forms.ComboBox cmb_KalkisNoktasi;
        private System.Windows.Forms.Label lbl_kalkisNoktasi;
        private System.Windows.Forms.Label lbl_VarisNoktasi;
        private System.Windows.Forms.ComboBox cmb_VarisNoktasi;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tc_sefer;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_biletNo;
        private System.Windows.Forms.TextBox txt_BiletSahipSoyadi;
        private System.Windows.Forms.TextBox txt_biletSahipCep;
        private System.Windows.Forms.TextBox txt_BiletSahipAdi;
        private System.Windows.Forms.Label lbl_biletNo;
        private System.Windows.Forms.Label lbl_biletSahipCep;
        private System.Windows.Forms.Label lbl_biletSahipSoyad;
        private System.Windows.Forms.Label lbl_biletSahipAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sefer_id;
        private System.Windows.Forms.TextBox txt_username_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aranacakDegerSefer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_aranacakDegerBilet;
        private System.Windows.Forms.TextBox txt_aranacakDegerKullanici;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView_Detay;
    }
}



