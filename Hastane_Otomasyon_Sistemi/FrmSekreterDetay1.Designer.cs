
namespace Hastane_Otomasyon_Sistemi
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chkdurum = new System.Windows.Forms.CheckBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbranş = new System.Windows.Forms.ComboBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuruOlustur = new System.Windows.Forms.Button();
            this.rchduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnliste = new System.Windows.Forms.Button();
            this.btnbranşpanel = new System.Windows.Forms.Button();
            this.btndoktorpanel = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKaydet);
            this.groupBox4.Controls.Add(this.chkdurum);
            this.groupBox4.Controls.Add(this.mskTc);
            this.groupBox4.Controls.Add(this.cmbdoktor);
            this.groupBox4.Controls.Add(this.cmbbranş);
            this.groupBox4.Controls.Add(this.msksaat);
            this.groupBox4.Controls.Add(this.msktarih);
            this.groupBox4.Controls.Add(this.txtıd);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(436, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 503);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(130, 431);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 45);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chkdurum
            // 
            this.chkdurum.AutoSize = true;
            this.chkdurum.Location = new System.Drawing.Point(130, 392);
            this.chkdurum.Name = "chkdurum";
            this.chkdurum.Size = new System.Drawing.Size(106, 33);
            this.chkdurum.TabIndex = 13;
            this.chkdurum.Text = "Durum";
            this.chkdurum.UseVisualStyleBackColor = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(130, 333);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(183, 34);
            this.mskTc.TabIndex = 12;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(130, 279);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(183, 37);
            this.cmbdoktor.TabIndex = 11;
            // 
            // cmbbranş
            // 
            this.cmbbranş.FormattingEnabled = true;
            this.cmbbranş.Location = new System.Drawing.Point(130, 232);
            this.cmbbranş.Name = "cmbbranş";
            this.cmbbranş.Size = new System.Drawing.Size(183, 37);
            this.cmbbranş.TabIndex = 10;
            this.cmbbranş.SelectedIndexChanged += new System.EventHandler(this.cmbbranş_SelectedIndexChanged);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(130, 180);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(183, 34);
            this.msksaat.TabIndex = 9;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(130, 124);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(183, 34);
            this.msktarih.TabIndex = 8;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(130, 69);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(183, 34);
            this.txtıd.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(842, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 243);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(387, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnduyuruOlustur);
            this.groupBox2.Controls.Add(this.rchduyuru);
            this.groupBox2.Location = new System.Drawing.Point(31, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 279);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnduyuruOlustur
            // 
            this.btnduyuruOlustur.Location = new System.Drawing.Point(28, 208);
            this.btnduyuruOlustur.Name = "btnduyuruOlustur";
            this.btnduyuruOlustur.Size = new System.Drawing.Size(332, 45);
            this.btnduyuruOlustur.TabIndex = 1;
            this.btnduyuruOlustur.Text = "Oluştur";
            this.btnduyuruOlustur.UseVisualStyleBackColor = true;
            this.btnduyuruOlustur.Click += new System.EventHandler(this.btnduyuruOlustur_Click);
            // 
            // rchduyuru
            // 
            this.rchduyuru.Location = new System.Drawing.Point(28, 60);
            this.rchduyuru.Name = "rchduyuru";
            this.rchduyuru.Size = new System.Drawing.Size(332, 128);
            this.rchduyuru.TabIndex = 0;
            this.rchduyuru.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 192);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdsoyad
            // 
            this.lblAdsoyad.AutoSize = true;
            this.lblAdsoyad.Location = new System.Drawing.Point(127, 101);
            this.lblAdsoyad.Name = "lblAdsoyad";
            this.lblAdsoyad.Size = new System.Drawing.Size(105, 29);
            this.lblAdsoyad.TabIndex = 13;
            this.lblAdsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(127, 51);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(156, 29);
            this.lblTC.TabIndex = 11;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC NO:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(839, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(393, 243);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(387, 210);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyuru);
            this.groupBox6.Controls.Add(this.btnliste);
            this.groupBox6.Controls.Add(this.btnbranşpanel);
            this.groupBox6.Controls.Add(this.btndoktorpanel);
            this.groupBox6.Location = new System.Drawing.Point(31, 537);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(772, 138);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Duyuru Oluştur";
            // 
            // btnliste
            // 
            this.btnliste.Location = new System.Drawing.Point(360, 51);
            this.btnliste.Name = "btnliste";
            this.btnliste.Size = new System.Drawing.Size(218, 45);
            this.btnliste.TabIndex = 3;
            this.btnliste.Text = "Randevu Listesi";
            this.btnliste.UseVisualStyleBackColor = true;
            this.btnliste.Click += new System.EventHandler(this.btnliste_Click);
            // 
            // btnbranşpanel
            // 
            this.btnbranşpanel.Location = new System.Drawing.Point(183, 51);
            this.btnbranşpanel.Name = "btnbranşpanel";
            this.btnbranşpanel.Size = new System.Drawing.Size(171, 45);
            this.btnbranşpanel.TabIndex = 2;
            this.btnbranşpanel.Text = "Branş Paneli";
            this.btnbranşpanel.UseVisualStyleBackColor = true;
            this.btnbranşpanel.Click += new System.EventHandler(this.btnbranşpanel_Click);
            // 
            // btndoktorpanel
            // 
            this.btndoktorpanel.Location = new System.Drawing.Point(6, 51);
            this.btndoktorpanel.Name = "btndoktorpanel";
            this.btndoktorpanel.Size = new System.Drawing.Size(171, 45);
            this.btndoktorpanel.TabIndex = 1;
            this.btndoktorpanel.Text = "Doktor Paneli";
            this.btndoktorpanel.UseVisualStyleBackColor = true;
            this.btndoktorpanel.Click += new System.EventHandler(this.btndoktorpanel_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(584, 51);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(171, 45);
            this.btnDuyuru.TabIndex = 4;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1280, 691);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnduyuruOlustur;
        private System.Windows.Forms.RichTextBox rchduyuru;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.CheckBox chkdurum;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbranş;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnliste;
        private System.Windows.Forms.Button btnbranşpanel;
        private System.Windows.Forms.Button btndoktorpanel;
        private System.Windows.Forms.Button btnDuyuru;
    }
}