namespace ProjeÖdevi
{
    partial class Arayüz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arayüz));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bankaProjeDataSet = new ProjeÖdevi.BankaProjeDataSet();
            this.musteriBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriBilgiTableAdapter = new ProjeÖdevi.BankaProjeDataSetTableAdapters.MusteriBilgiTableAdapter();
            this.bankaProjeDataSet1 = new ProjeÖdevi.BankaProjeDataSet();
            this.bankaProjeDataSet11 = new ProjeÖdevi.BankaProjeDataSet1();
            this.musteriBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriBilgiTableAdapter1 = new ProjeÖdevi.BankaProjeDataSet1TableAdapters.MusteriBilgiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paraMiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaProjeDataSet2 = new ProjeÖdevi.BankaProjeDataSet2();
            this.musteriBilgiTableAdapter2 = new ProjeÖdevi.BankaProjeDataSet2TableAdapters.MusteriBilgiTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çıkış Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hesap Özeti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bankaProjeDataSet
            // 
            this.bankaProjeDataSet.DataSetName = "BankaProjeDataSet";
            this.bankaProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBilgiBindingSource
            // 
            this.musteriBilgiBindingSource.DataMember = "MusteriBilgi";
            this.musteriBilgiBindingSource.DataSource = this.bankaProjeDataSet;
            // 
            // musteriBilgiTableAdapter
            // 
            this.musteriBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // bankaProjeDataSet1
            // 
            this.bankaProjeDataSet1.DataSetName = "BankaProjeDataSet";
            this.bankaProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankaProjeDataSet11
            // 
            this.bankaProjeDataSet11.DataSetName = "BankaProjeDataSet1";
            this.bankaProjeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBilgiBindingSource1
            // 
            this.musteriBilgiBindingSource1.DataMember = "MusteriBilgi";
            this.musteriBilgiBindingSource1.DataSource = this.bankaProjeDataSet11;
            // 
            // musteriBilgiTableAdapter1
            // 
            this.musteriBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.hesapNoDataGridViewTextBoxColumn,
            this.paraMiktarıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBilgiBindingSource2;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(217, 206);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(383, 53);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "İsim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            this.isimDataGridViewTextBoxColumn.Width = 75;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.Width = 75;
            // 
            // hesapNoDataGridViewTextBoxColumn
            // 
            this.hesapNoDataGridViewTextBoxColumn.DataPropertyName = "HesapNo";
            this.hesapNoDataGridViewTextBoxColumn.HeaderText = "HesapNo";
            this.hesapNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hesapNoDataGridViewTextBoxColumn.Name = "hesapNoDataGridViewTextBoxColumn";
            this.hesapNoDataGridViewTextBoxColumn.Width = 75;
            // 
            // paraMiktarıDataGridViewTextBoxColumn
            // 
            this.paraMiktarıDataGridViewTextBoxColumn.DataPropertyName = "ParaMiktarı";
            this.paraMiktarıDataGridViewTextBoxColumn.HeaderText = "ParaMiktarı";
            this.paraMiktarıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paraMiktarıDataGridViewTextBoxColumn.Name = "paraMiktarıDataGridViewTextBoxColumn";
            this.paraMiktarıDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriBilgiBindingSource2
            // 
            this.musteriBilgiBindingSource2.DataMember = "MusteriBilgi";
            this.musteriBilgiBindingSource2.DataSource = this.bankaProjeDataSet2;
            // 
            // bankaProjeDataSet2
            // 
            this.bankaProjeDataSet2.DataSetName = "BankaProjeDataSet2";
            this.bankaProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBilgiTableAdapter2
            // 
            this.musteriBilgiTableAdapter2.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hoşgeldiniz!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(643, 386);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(145, 23);
            this.button9.TabIndex = 33;
            this.button9.Text = "Oturumu Kapat";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Arayüz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Arayüz";
            this.Text = "Arayüz";
            this.Load += new System.EventHandler(this.Arayüz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaProjeDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private BankaProjeDataSet bankaProjeDataSet;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource;
        private BankaProjeDataSetTableAdapters.MusteriBilgiTableAdapter musteriBilgiTableAdapter;
        private BankaProjeDataSet bankaProjeDataSet1;
        private BankaProjeDataSet1 bankaProjeDataSet11;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource1;
        private BankaProjeDataSet1TableAdapters.MusteriBilgiTableAdapter musteriBilgiTableAdapter1;
        private BankaProjeDataSet2 bankaProjeDataSet2;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource2;
        private BankaProjeDataSet2TableAdapters.MusteriBilgiTableAdapter musteriBilgiTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paraMiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button9;
    }
}