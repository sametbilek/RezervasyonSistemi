namespace RezervasyonSistemi
{
    partial class FormUser
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
            this.comboBoxKalkis = new System.Windows.Forms.ComboBox();
            this.comboBoxVaris = new System.Windows.Forms.ComboBox();
            this.comboBoxTarih = new System.Windows.Forms.ComboBox();
            this.comboBoxYolcuSayisi = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSeferBul = new System.Windows.Forms.Button();
            this.listBoxUygunSeferler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxKalkis
            // 
            this.comboBoxKalkis.FormattingEnabled = true;
            this.comboBoxKalkis.Location = new System.Drawing.Point(834, 295);
            this.comboBoxKalkis.Name = "comboBoxKalkis";
            this.comboBoxKalkis.Size = new System.Drawing.Size(143, 24);
            this.comboBoxKalkis.TabIndex = 0;
            // 
            // comboBoxVaris
            // 
            this.comboBoxVaris.FormattingEnabled = true;
            this.comboBoxVaris.Location = new System.Drawing.Point(834, 347);
            this.comboBoxVaris.Name = "comboBoxVaris";
            this.comboBoxVaris.Size = new System.Drawing.Size(143, 24);
            this.comboBoxVaris.TabIndex = 2;
            // 
            // comboBoxTarih
            // 
            this.comboBoxTarih.FormatString = "d";
            this.comboBoxTarih.FormattingEnabled = true;
            this.comboBoxTarih.Location = new System.Drawing.Point(834, 398);
            this.comboBoxTarih.Name = "comboBoxTarih";
            this.comboBoxTarih.Size = new System.Drawing.Size(143, 24);
            this.comboBoxTarih.TabIndex = 3;
            // 
            // comboBoxYolcuSayisi
            // 
            this.comboBoxYolcuSayisi.FormattingEnabled = true;
            this.comboBoxYolcuSayisi.Location = new System.Drawing.Point(440, 181);
            this.comboBoxYolcuSayisi.Name = "comboBoxYolcuSayisi";
            this.comboBoxYolcuSayisi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYolcuSayisi.TabIndex = 5;
            this.comboBoxYolcuSayisi.SelectedIndexChanged += new System.EventHandler(this.comboBoxYolcuSayisi_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Aotobüs1",
            "Aotobüs2",
            "Botobüs1",
            "Botobüs2",
            "Cotobüs1",
            "Cuçak1",
            "Cuçak2",
            "Dtren1",
            "Dtren2",
            "Dtren3",
            "Fuçak1",
            "Fuçak2",
            "",
            ""});
            this.comboBox5.Location = new System.Drawing.Point(440, 60);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(447, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Araç Seçiniz";
            // 
            // flowLayoutPanelKoltuklar
            // 
            this.flowLayoutPanelKoltuklar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelKoltuklar.Name = "flowLayoutPanelKoltuklar";
            this.flowLayoutPanelKoltuklar.Size = new System.Drawing.Size(419, 492);
            this.flowLayoutPanelKoltuklar.TabIndex = 19;
            // 
            // buttonSeferBul
            // 
            this.buttonSeferBul.Location = new System.Drawing.Point(859, 439);
            this.buttonSeferBul.Name = "buttonSeferBul";
            this.buttonSeferBul.Size = new System.Drawing.Size(97, 32);
            this.buttonSeferBul.TabIndex = 21;
            this.buttonSeferBul.Text = "Sefer Bul";
            this.buttonSeferBul.UseVisualStyleBackColor = true;
            this.buttonSeferBul.Click += new System.EventHandler(this.buttonSeferBul_Click);
            // 
            // listBoxUygunSeferler
            // 
            this.listBoxUygunSeferler.FormattingEnabled = true;
            this.listBoxUygunSeferler.ItemHeight = 16;
            this.listBoxUygunSeferler.Location = new System.Drawing.Point(88, 523);
            this.listBoxUygunSeferler.Name = "listBoxUygunSeferler";
            this.listBoxUygunSeferler.Size = new System.Drawing.Size(979, 196);
            this.listBoxUygunSeferler.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(437, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Yolcu Sayısı Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(743, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nereden:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(753, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nereye:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(768, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tarih:";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1082, 745);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxUygunSeferler);
            this.Controls.Add(this.buttonSeferBul);
            this.Controls.Add(this.flowLayoutPanelKoltuklar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBoxYolcuSayisi);
            this.Controls.Add(this.comboBoxTarih);
            this.Controls.Add(this.comboBoxVaris);
            this.Controls.Add(this.comboBoxKalkis);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKalkis;
        private System.Windows.Forms.ComboBox comboBoxVaris;
        private System.Windows.Forms.ComboBox comboBoxTarih;
        private System.Windows.Forms.ComboBox comboBoxYolcuSayisi;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKoltuklar;
        private System.Windows.Forms.Button buttonSeferBul;
        private System.Windows.Forms.ListBox listBoxUygunSeferler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}