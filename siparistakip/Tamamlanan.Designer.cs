namespace siparistakip
{
    partial class Tamamlanan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.elbiseSiparisDataSet2 = new siparistakip.ElbiseSiparisDataSet2();
            this.tamamlanansiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamamlanansiparisTableAdapter = new siparistakip.ElbiseSiparisDataSet2TableAdapters.tamamlanansiparisTableAdapter();
            this.tamamlanansiparisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kargodurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlanansiparisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tamamlanansiparisDataGridViewTextBoxColumn,
            this.siparisidDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.kargodurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tamamlanansiparisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // elbiseSiparisDataSet2
            // 
            this.elbiseSiparisDataSet2.DataSetName = "ElbiseSiparisDataSet2";
            this.elbiseSiparisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamamlanansiparisBindingSource
            // 
            this.tamamlanansiparisBindingSource.DataMember = "tamamlanansiparis";
            this.tamamlanansiparisBindingSource.DataSource = this.elbiseSiparisDataSet2;
            // 
            // tamamlanansiparisTableAdapter
            // 
            this.tamamlanansiparisTableAdapter.ClearBeforeFill = true;
            // 
            // tamamlanansiparisDataGridViewTextBoxColumn
            // 
            this.tamamlanansiparisDataGridViewTextBoxColumn.DataPropertyName = "tamamlanansiparis";
            this.tamamlanansiparisDataGridViewTextBoxColumn.HeaderText = "tamamlanansiparis";
            this.tamamlanansiparisDataGridViewTextBoxColumn.Name = "tamamlanansiparisDataGridViewTextBoxColumn";
            this.tamamlanansiparisDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamamlanansiparisDataGridViewTextBoxColumn.Visible = false;
            // 
            // siparisidDataGridViewTextBoxColumn
            // 
            this.siparisidDataGridViewTextBoxColumn.DataPropertyName = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.HeaderText = "siparisid";
            this.siparisidDataGridViewTextBoxColumn.Name = "siparisidDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // kargodurumuDataGridViewTextBoxColumn
            // 
            this.kargodurumuDataGridViewTextBoxColumn.DataPropertyName = "kargodurumu";
            this.kargodurumuDataGridViewTextBoxColumn.HeaderText = "kargodurumu";
            this.kargodurumuDataGridViewTextBoxColumn.Name = "kargodurumuDataGridViewTextBoxColumn";
            // 
            // Tamamlanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tamamlanan";
            this.Text = "Tamamlanan";
            this.Load += new System.EventHandler(this.Tamamlanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elbiseSiparisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlanansiparisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ElbiseSiparisDataSet2 elbiseSiparisDataSet2;
        private System.Windows.Forms.BindingSource tamamlanansiparisBindingSource;
        private ElbiseSiparisDataSet2TableAdapters.tamamlanansiparisTableAdapter tamamlanansiparisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamamlanansiparisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kargodurumuDataGridViewTextBoxColumn;
    }
}