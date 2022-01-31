
namespace ConnectGiris
{
    partial class Form1
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
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kutle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.nudKutle = new System.Windows.Forms.NumericUpDown();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.lblHayvanSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHayvanlar
            // 
            this.dgvHayvanlar.AllowUserToAddRows = false;
            this.dgvHayvanlar.AllowUserToDeleteRows = false;
            this.dgvHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHayvanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHayvanlar.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHayvanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Cinsiyet,
            this.DogumTarihi,
            this.Kutle,
            this.Tur,
            this.Yas,
            this.Sil,
            this.Guncelle});
            this.dgvHayvanlar.Location = new System.Drawing.Point(426, 8);
            this.dgvHayvanlar.MultiSelect = false;
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.ReadOnly = true;
            this.dgvHayvanlar.RowHeadersVisible = false;
            this.dgvHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanlar.Size = new System.Drawing.Size(782, 508);
            this.dgvHayvanlar.TabIndex = 0;
            this.dgvHayvanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHayvanlar_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.ReadOnly = true;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.HeaderText = "Dogum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.ReadOnly = true;
            // 
            // Kutle
            // 
            this.Kutle.HeaderText = "Kütle";
            this.Kutle.Name = "Kutle";
            this.Kutle.ReadOnly = true;
            // 
            // Tur
            // 
            this.Tur.HeaderText = "Tür";
            this.Tur.Name = "Tur";
            this.Tur.ReadOnly = true;
            // 
            // Yas
            // 
            this.Yas.HeaderText = "Yaş";
            this.Yas.Name = "Yas";
            this.Yas.ReadOnly = true;
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            this.Sil.ReadOnly = true;
            // 
            // Guncelle
            // 
            this.Guncelle.HeaderText = "Guncelle";
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kütle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dogum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tür";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(216, 38);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 26);
            this.txtAd.TabIndex = 2;
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.Location = new System.Drawing.Point(226, 207);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 26);
            this.txtTur.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(176, 162);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpDogumTarihi.TabIndex = 3;
            // 
            // nudKutle
            // 
            this.nudKutle.DecimalPlaces = 2;
            this.nudKutle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudKutle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudKutle.Location = new System.Drawing.Point(216, 117);
            this.nudKutle.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudKutle.Name = "nudKutle";
            this.nudKutle.Size = new System.Drawing.Size(120, 26);
            this.nudKutle.TabIndex = 4;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Beliritlmedi",
            "Dişi",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(216, 77);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Tan;
            this.btnekle.Location = new System.Drawing.Point(216, 253);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(120, 49);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // lblHayvanSayisi
            // 
            this.lblHayvanSayisi.AutoSize = true;
            this.lblHayvanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHayvanSayisi.Location = new System.Drawing.Point(162, 360);
            this.lblHayvanSayisi.Name = "lblHayvanSayisi";
            this.lblHayvanSayisi.Size = new System.Drawing.Size(164, 25);
            this.lblHayvanSayisi.TabIndex = 7;
            this.lblHayvanSayisi.Text = "Hayvan sayısı 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1220, 528);
            this.Controls.Add(this.lblHayvanSayisi);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.nudKutle);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHayvanlar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvanlar create read update delete with adon.net connected architecture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.NumericUpDown nudKutle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label lblHayvanSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kutle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yas;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.DataGridViewButtonColumn Guncelle;
    }
}

