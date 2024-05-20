namespace data_pembayaran
{
    partial class Form_jenis_pembayaran
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKodePembayaran = new System.Windows.Forms.TextBox();
            this.txtNamaPembayaran = new System.Windows.Forms.TextBox();
            this.txtJumlahPembayaran = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgPembayaran = new System.Windows.Forms.DataGridView();
            this.kodejenispembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahpembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenispembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbAdmSekolahDataSet = new data_pembayaran.dbAdmSekolahDataSet();
            this.jenis_pembayaranTableAdapter = new data_pembayaran.dbAdmSekolahDataSetTableAdapters.jenis_pembayaranTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgPembayaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenispembayaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA JENIS PEMBAYARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pembayaran";
            // 
            // txtKodePembayaran
            // 
            this.txtKodePembayaran.Location = new System.Drawing.Point(250, 103);
            this.txtKodePembayaran.Name = "txtKodePembayaran";
            this.txtKodePembayaran.Size = new System.Drawing.Size(277, 26);
            this.txtKodePembayaran.TabIndex = 4;
            // 
            // txtNamaPembayaran
            // 
            this.txtNamaPembayaran.Location = new System.Drawing.Point(250, 149);
            this.txtNamaPembayaran.Name = "txtNamaPembayaran";
            this.txtNamaPembayaran.Size = new System.Drawing.Size(277, 26);
            this.txtNamaPembayaran.TabIndex = 5;
            // 
            // txtJumlahPembayaran
            // 
            this.txtJumlahPembayaran.Location = new System.Drawing.Point(250, 198);
            this.txtJumlahPembayaran.Name = "txtJumlahPembayaran";
            this.txtJumlahPembayaran.Size = new System.Drawing.Size(277, 26);
            this.txtJumlahPembayaran.TabIndex = 6;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(37, 265);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(99, 40);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(168, 265);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(99, 40);
            this.btnUbah.TabIndex = 8;
            this.btnUbah.Text = "UBAH";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(298, 265);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(99, 40);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgPembayaran
            // 
            this.dgPembayaran.AutoGenerateColumns = false;
            this.dgPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPembayaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodejenispembayaranDataGridViewTextBoxColumn,
            this.namapembayaranDataGridViewTextBoxColumn,
            this.jumlahpembayaranDataGridViewTextBoxColumn});
            this.dgPembayaran.DataSource = this.jenispembayaranBindingSource;
            this.dgPembayaran.Location = new System.Drawing.Point(12, 337);
            this.dgPembayaran.Name = "dgPembayaran";
            this.dgPembayaran.RowHeadersWidth = 62;
            this.dgPembayaran.RowTemplate.Height = 28;
            this.dgPembayaran.Size = new System.Drawing.Size(579, 334);
            this.dgPembayaran.TabIndex = 11;
            // 
            // kodejenispembayaranDataGridViewTextBoxColumn
            // 
            this.kodejenispembayaranDataGridViewTextBoxColumn.DataPropertyName = "kode_jenispembayaran";
            this.kodejenispembayaranDataGridViewTextBoxColumn.HeaderText = "kode_jenispembayaran";
            this.kodejenispembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kodejenispembayaranDataGridViewTextBoxColumn.Name = "kodejenispembayaranDataGridViewTextBoxColumn";
            this.kodejenispembayaranDataGridViewTextBoxColumn.Width = 150;
            // 
            // namapembayaranDataGridViewTextBoxColumn
            // 
            this.namapembayaranDataGridViewTextBoxColumn.DataPropertyName = "nama_pembayaran";
            this.namapembayaranDataGridViewTextBoxColumn.HeaderText = "nama_pembayaran";
            this.namapembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namapembayaranDataGridViewTextBoxColumn.Name = "namapembayaranDataGridViewTextBoxColumn";
            this.namapembayaranDataGridViewTextBoxColumn.Width = 150;
            // 
            // jumlahpembayaranDataGridViewTextBoxColumn
            // 
            this.jumlahpembayaranDataGridViewTextBoxColumn.DataPropertyName = "jumlah_pembayaran";
            this.jumlahpembayaranDataGridViewTextBoxColumn.HeaderText = "jumlah_pembayaran";
            this.jumlahpembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jumlahpembayaranDataGridViewTextBoxColumn.Name = "jumlahpembayaranDataGridViewTextBoxColumn";
            this.jumlahpembayaranDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenispembayaranBindingSource
            // 
            this.jenispembayaranBindingSource.DataMember = "jenis_pembayaran";
            this.jenispembayaranBindingSource.DataSource = this.dbAdmSekolahDataSet;
            // 
            // dbAdmSekolahDataSet
            // 
            this.dbAdmSekolahDataSet.DataSetName = "dbAdmSekolahDataSet";
            this.dbAdmSekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenis_pembayaranTableAdapter
            // 
            this.jenis_pembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // Form_jenis_pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 683);
            this.Controls.Add(this.dgPembayaran);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtJumlahPembayaran);
            this.Controls.Add(this.txtNamaPembayaran);
            this.Controls.Add(this.txtKodePembayaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_jenis_pembayaran";
            this.Text = "Form jenis pembayaran";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPembayaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenispembayaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKodePembayaran;
        private System.Windows.Forms.TextBox txtNamaPembayaran;
        private System.Windows.Forms.TextBox txtJumlahPembayaran;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgPembayaran;
        private dbAdmSekolahDataSet dbAdmSekolahDataSet;
        private System.Windows.Forms.BindingSource jenispembayaranBindingSource;
        private dbAdmSekolahDataSetTableAdapters.jenis_pembayaranTableAdapter jenis_pembayaranTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodejenispembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahpembayaranDataGridViewTextBoxColumn;
    }
}

