
namespace ConnectGiris
{
    partial class HayvanlYiyecekForm
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
            this.lblYiyecek = new System.Windows.Forms.Label();
            this.dgvHayvanlar = new System.Windows.Forms.DataGridView();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kutle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYiyecek
            // 
            this.lblYiyecek.AutoSize = true;
            this.lblYiyecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYiyecek.Location = new System.Drawing.Point(263, 22);
            this.lblYiyecek.Name = "lblYiyecek";
            this.lblYiyecek.Size = new System.Drawing.Size(51, 20);
            this.lblYiyecek.TabIndex = 0;
            this.lblYiyecek.Text = "label1";
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
            this.Ad,
            this.Cinsiyet,
            this.DogumTarihi,
            this.Kutle,
            this.Tur});
            this.dgvHayvanlar.Location = new System.Drawing.Point(12, 67);
            this.dgvHayvanlar.MultiSelect = false;
            this.dgvHayvanlar.Name = "dgvHayvanlar";
            this.dgvHayvanlar.ReadOnly = true;
            this.dgvHayvanlar.RowHeadersVisible = false;
            this.dgvHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHayvanlar.Size = new System.Drawing.Size(639, 386);
            this.dgvHayvanlar.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Favori Yiyeceği :";
            // 
            // HayvanlYiyecekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHayvanlar);
            this.Controls.Add(this.lblYiyecek);
            this.Name = "HayvanlYiyecekForm";
            this.Text = "HayvanlYiyecekForm";
            this.Load += new System.EventHandler(this.HayvanlYiyecekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHayvanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYiyecek;
        private System.Windows.Forms.DataGridView dgvHayvanlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kutle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.Label label1;
    }
}