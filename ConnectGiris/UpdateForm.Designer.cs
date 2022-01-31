
namespace ConnectGiris
{
    partial class UpdateForm
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
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.nudKutle = new System.Windows.Forms.NumericUpDown();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).BeginInit();
            this.SuspendLayout();
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
            this.cmbCinsiyet.Location = new System.Drawing.Point(234, 67);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbCinsiyet.TabIndex = 16;
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
            this.nudKutle.Location = new System.Drawing.Point(234, 107);
            this.nudKutle.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudKutle.Name = "nudKutle";
            this.nudKutle.Size = new System.Drawing.Size(120, 26);
            this.nudKutle.TabIndex = 15;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(194, 152);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 26);
            this.dtpDogumTarihi.TabIndex = 14;
            // 
            // txtTur
            // 
            this.txtTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTur.Location = new System.Drawing.Point(244, 197);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 26);
            this.txtTur.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(234, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(120, 26);
            this.txtAd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dogum Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kütle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cinsiyet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Tan;
            this.btnGuncelle.Location = new System.Drawing.Point(234, 243);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 49);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(453, 323);
            this.Controls.Add(this.btnGuncelle);
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
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudKutle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.NumericUpDown nudKutle;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
    }
}