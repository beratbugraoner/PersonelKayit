namespace Personel_Kayit
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personelMaas = new System.Windows.Forms.MaskedTextBox();
            this.bekarButton = new System.Windows.Forms.RadioButton();
            this.evliButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.personelSehir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personelMeslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personelSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personelAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grafiklerButton = new System.Windows.Forms.Button();
            this.istatistikButton = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.güncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.listeleButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kayıtdataGrid = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet1 = new Personel_Kayit.PersonelVeriTabaniDataSet1();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.tbl_PersonelTableAdapter1 = new Personel_Kayit.PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtdataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.personelMaas);
            this.groupBox1.Controls.Add(this.bekarButton);
            this.groupBox1.Controls.Add(this.evliButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.personelSehir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.personelMeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.personelSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.personelAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personelId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Maaş:";
            // 
            // personelMaas
            // 
            this.personelMaas.Location = new System.Drawing.Point(108, 189);
            this.personelMaas.Mask = "0000";
            this.personelMaas.Name = "personelMaas";
            this.personelMaas.Size = new System.Drawing.Size(131, 31);
            this.personelMaas.TabIndex = 5;
            this.personelMaas.ValidatingType = typeof(int);
            // 
            // bekarButton
            // 
            this.bekarButton.AutoSize = true;
            this.bekarButton.Location = new System.Drawing.Point(167, 226);
            this.bekarButton.Name = "bekarButton";
            this.bekarButton.Size = new System.Drawing.Size(72, 27);
            this.bekarButton.TabIndex = 7;
            this.bekarButton.TabStop = true;
            this.bekarButton.Text = "Bekar";
            this.bekarButton.UseVisualStyleBackColor = true;
            // 
            // evliButton
            // 
            this.evliButton.AutoSize = true;
            this.evliButton.Location = new System.Drawing.Point(108, 226);
            this.evliButton.Name = "evliButton";
            this.evliButton.Size = new System.Drawing.Size(55, 27);
            this.evliButton.TabIndex = 6;
            this.evliButton.TabStop = true;
            this.evliButton.Text = "Evli";
            this.evliButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meslek:";
            // 
            // personelSehir
            // 
            this.personelSehir.FormattingEnabled = true;
            this.personelSehir.Location = new System.Drawing.Point(108, 152);
            this.personelSehir.Name = "personelSehir";
            this.personelSehir.Size = new System.Drawing.Size(131, 31);
            this.personelSehir.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum:";
            // 
            // personelMeslek
            // 
            this.personelMeslek.Location = new System.Drawing.Point(108, 259);
            this.personelMeslek.Name = "personelMeslek";
            this.personelMeslek.Size = new System.Drawing.Size(131, 31);
            this.personelMeslek.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir:";
            // 
            // personelSoyad
            // 
            this.personelSoyad.Location = new System.Drawing.Point(108, 115);
            this.personelSoyad.Name = "personelSoyad";
            this.personelSoyad.Size = new System.Drawing.Size(131, 31);
            this.personelSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // personelAd
            // 
            this.personelAd.Location = new System.Drawing.Point(108, 78);
            this.personelAd.Name = "personelAd";
            this.personelAd.Size = new System.Drawing.Size(131, 31);
            this.personelAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Ad";
            // 
            // personelId
            // 
            this.personelId.Location = new System.Drawing.Point(108, 41);
            this.personelId.Name = "personelId";
            this.personelId.Size = new System.Drawing.Size(131, 31);
            this.personelId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personel ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grafiklerButton);
            this.groupBox2.Controls.Add(this.istatistikButton);
            this.groupBox2.Controls.Add(this.temizleButton);
            this.groupBox2.Controls.Add(this.güncelleButton);
            this.groupBox2.Controls.Add(this.silButton);
            this.groupBox2.Controls.Add(this.kaydetButton);
            this.groupBox2.Controls.Add(this.listeleButton);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // grafiklerButton
            // 
            this.grafiklerButton.BackColor = System.Drawing.Color.Ivory;
            this.grafiklerButton.Location = new System.Drawing.Point(25, 248);
            this.grafiklerButton.Name = "grafiklerButton";
            this.grafiklerButton.Size = new System.Drawing.Size(137, 31);
            this.grafiklerButton.TabIndex = 8;
            this.grafiklerButton.Text = "Grafikler";
            this.grafiklerButton.UseVisualStyleBackColor = false;
            this.grafiklerButton.Click += new System.EventHandler(this.grafiklerButton_Click);
            // 
            // istatistikButton
            // 
            this.istatistikButton.BackColor = System.Drawing.Color.Ivory;
            this.istatistikButton.Location = new System.Drawing.Point(25, 210);
            this.istatistikButton.Name = "istatistikButton";
            this.istatistikButton.Size = new System.Drawing.Size(137, 31);
            this.istatistikButton.TabIndex = 7;
            this.istatistikButton.Text = "İstatistik";
            this.istatistikButton.UseVisualStyleBackColor = false;
            this.istatistikButton.Click += new System.EventHandler(this.istatistikButton_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Ivory;
            this.temizleButton.Location = new System.Drawing.Point(25, 173);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(137, 31);
            this.temizleButton.TabIndex = 6;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // güncelleButton
            // 
            this.güncelleButton.BackColor = System.Drawing.Color.Ivory;
            this.güncelleButton.Location = new System.Drawing.Point(25, 136);
            this.güncelleButton.Name = "güncelleButton";
            this.güncelleButton.Size = new System.Drawing.Size(137, 31);
            this.güncelleButton.TabIndex = 5;
            this.güncelleButton.Text = "Güncelle";
            this.güncelleButton.UseVisualStyleBackColor = false;
            this.güncelleButton.Click += new System.EventHandler(this.güncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.BackColor = System.Drawing.Color.Ivory;
            this.silButton.Location = new System.Drawing.Point(25, 99);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(137, 31);
            this.silButton.TabIndex = 4;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = false;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.BackColor = System.Drawing.Color.Ivory;
            this.kaydetButton.Location = new System.Drawing.Point(25, 62);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(137, 31);
            this.kaydetButton.TabIndex = 3;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = false;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // listeleButton
            // 
            this.listeleButton.BackColor = System.Drawing.Color.Ivory;
            this.listeleButton.Location = new System.Drawing.Point(25, 25);
            this.listeleButton.Name = "listeleButton";
            this.listeleButton.Size = new System.Drawing.Size(137, 31);
            this.listeleButton.TabIndex = 2;
            this.listeleButton.Text = "Listele";
            this.listeleButton.UseVisualStyleBackColor = false;
            this.listeleButton.Click += new System.EventHandler(this.listeleButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kayıtdataGrid);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 210);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // kayıtdataGrid
            // 
            this.kayıtdataGrid.AutoGenerateColumns = false;
            this.kayıtdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayıtdataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.kayıtdataGrid.DataSource = this.tblPersonelBindingSource1;
            this.kayıtdataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kayıtdataGrid.Location = new System.Drawing.Point(3, 27);
            this.kayıtdataGrid.Name = "kayıtdataGrid";
            this.kayıtdataGrid.Size = new System.Drawing.Size(753, 180);
            this.kayıtdataGrid.TabIndex = 0;
            this.kayıtdataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kayıtdataGrid_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.personelVeriTabaniDataSet1;
            // 
            // personelVeriTabaniDataSet1
            // 
            this.personelVeriTabaniDataSet1.DataSetName = "PersonelVeriTabaniDataSet1";
            this.personelVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(785, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kayıtdataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox personelMaas;
        private System.Windows.Forms.RadioButton bekarButton;
        private System.Windows.Forms.RadioButton evliButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox personelSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personelMeslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personelSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personelAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button grafiklerButton;
        private System.Windows.Forms.Button istatistikButton;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button güncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button listeleButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView kayıtdataGrid;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private PersonelVeriTabaniDataSet1 personelVeriTabaniDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private PersonelVeriTabaniDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
    }
}

