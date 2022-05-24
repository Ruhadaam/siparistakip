namespace siparistakip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tarih = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.odememiktari = new System.Windows.Forms.RadioButton();
            this.odemetamami = new System.Windows.Forms.RadioButton();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odememiktartxt = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargodurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elbiseSiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elbiseSiparisDataSet1 = new siparistakip.ElbiseSiparisDataSet1();
            this.elbiseSiparisDataSet = new siparistakip.ElbiseSiparisDataSet();
            this.elbiseSiparisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elbiseSiparisTableAdapter = new siparistakip.ElbiseSiparisDataSet1TableAdapters.ElbiseSiparisTableAdapter();
            this.elbiseSiparisDataSet2 = new siparistakip.ElbiseSiparisDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.odememiktari);
            this.groupBox1.Controls.Add(this.odemetamami);
            this.groupBox1.Controls.Add(this.guncelle);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.kaydet);
            this.groupBox1.Controls.Add(this.fiyat);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.soyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.odememiktartxt);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(960, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(715, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alıcı Ödemeli",
            "Satıcı Ödemeli"});
            this.comboBox1.Location = new System.Drawing.Point(135, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(135, 188);
            this.tarih.Mask = "00/00/0000";
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(146, 22);
            this.tarih.TabIndex = 7;
            this.tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "Kargo Durumu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alınan Ödeme:";
            // 
            // odememiktari
            // 
            this.odememiktari.AutoSize = true;
            this.odememiktari.Location = new System.Drawing.Point(226, 160);
            this.odememiktari.Name = "odememiktari";
            this.odememiktari.Size = new System.Drawing.Size(70, 20);
            this.odememiktari.TabIndex = 5;
            this.odememiktari.TabStop = true;
            this.odememiktari.Text = "Miktarı";
            this.odememiktari.UseVisualStyleBackColor = true;
            this.odememiktari.CheckedChanged += new System.EventHandler(this.odememiktari_CheckedChanged);
            // 
            // odemetamami
            // 
            this.odemetamami.AutoSize = true;
            this.odemetamami.Location = new System.Drawing.Point(142, 159);
            this.odemetamami.Name = "odemetamami";
            this.odemetamami.Size = new System.Drawing.Size(75, 20);
            this.odemetamami.TabIndex = 4;
            this.odemetamami.TabStop = true;
            this.odemetamami.Text = "Tamamı";
            this.odemetamami.UseVisualStyleBackColor = true;
            this.odemetamami.CheckedChanged += new System.EventHandler(this.odemetamami_CheckedChanged);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(414, 255);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(81, 31);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(338, 255);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(70, 31);
            this.sil.TabIndex = 10;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(257, 255);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 31);
            this.kaydet.TabIndex = 9;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(135, 126);
            this.fiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(146, 22);
            this.fiyat.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(90, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Fiyat:";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(135, 95);
            this.soyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(146, 22);
            this.soyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // odememiktartxt
            // 
            this.odememiktartxt.Location = new System.Drawing.Point(352, 155);
            this.odememiktartxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.odememiktartxt.Name = "odememiktartxt";
            this.odememiktartxt.Size = new System.Drawing.Size(106, 22);
            this.odememiktartxt.TabIndex = 6;
            this.odememiktartxt.TextChanged += new System.EventHandler(this.odememiktartxt_TextChanged);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(135, 64);
            this.ad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(146, 22);
            this.ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(135, 33);
            this.id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(146, 22);
            this.id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(16, 330);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(960, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.odemeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.kargodurumuDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.elbiseSiparisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // siparisidDataGridViewTextBoxColumn
            // 
            this.siparisidDataGridViewTextBoxColumn.DataPropertyName = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.HeaderText = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.Name = "siparisidDataGridViewTextBoxColumn";
            this.siparisidDataGridViewTextBoxColumn.ReadOnly = true;
            this.siparisidDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odemeDataGridViewTextBoxColumn
            // 
            this.odemeDataGridViewTextBoxColumn.DataPropertyName = "odeme";
            this.odemeDataGridViewTextBoxColumn.HeaderText = "Alınacak Ödeme";
            this.odemeDataGridViewTextBoxColumn.Name = "odemeDataGridViewTextBoxColumn";
            this.odemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kargodurumuDataGridViewTextBoxColumn
            // 
            this.kargodurumuDataGridViewTextBoxColumn.DataPropertyName = "kargodurumu";
            this.kargodurumuDataGridViewTextBoxColumn.HeaderText = "Kargo Durumu";
            this.kargodurumuDataGridViewTextBoxColumn.Name = "kargodurumuDataGridViewTextBoxColumn";
            this.kargodurumuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimDataGridViewTextBoxColumn.Visible = false;
            // 
            // elbiseSiparisBindingSource
            // 
            this.elbiseSiparisBindingSource.DataMember = "ElbiseSiparis";
            this.elbiseSiparisBindingSource.DataSource = this.elbiseSiparisDataSet1;
            // 
            // elbiseSiparisDataSet1
            // 
            this.elbiseSiparisDataSet1.DataSetName = "ElbiseSiparisDataSet1";
            this.elbiseSiparisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elbiseSiparisDataSet
            // 
            this.elbiseSiparisDataSet.DataSetName = "ElbiseSiparisDataSet";
            this.elbiseSiparisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elbiseSiparisDataSetBindingSource
            // 
            this.elbiseSiparisDataSetBindingSource.DataSource = this.elbiseSiparisDataSet;
            this.elbiseSiparisDataSetBindingSource.Position = 0;
            // 
            // elbiseSiparisTableAdapter
            // 
            this.elbiseSiparisTableAdapter.ClearBeforeFill = true;
            // 
            // elbiseSiparisDataSet2
            // 
            this.elbiseSiparisDataSet2.DataSetName = "ElbiseSiparisDataSet";
            this.elbiseSiparisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Siparişi Tamamla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tamamlanan Siparişler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 714);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Takip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox tarih;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton odememiktari;
        private System.Windows.Forms.RadioButton odemetamami;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox odememiktartxt;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource elbiseSiparisDataSetBindingSource;
        private ElbiseSiparisDataSet elbiseSiparisDataSet;
        private ElbiseSiparisDataSet1 elbiseSiparisDataSet1;
        private System.Windows.Forms.BindingSource elbiseSiparisBindingSource;
        private ElbiseSiparisDataSet1TableAdapters.ElbiseSiparisTableAdapter elbiseSiparisTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private ElbiseSiparisDataSet elbiseSiparisDataSet2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargodurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
    }
}

