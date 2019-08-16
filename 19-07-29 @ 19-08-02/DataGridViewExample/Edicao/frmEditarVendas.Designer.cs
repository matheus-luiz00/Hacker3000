namespace DataGridViewExample.Edicao
{
    partial class frmEditarVendas
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.selectComInnerJoinToolStrip = new System.Windows.Forms.ToolStrip();
            this.selectComInnerJoinToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseGiomarDataSet1 = new DataGridViewExample.DatabaseGiomarDataSet1();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendasTableAdapter = new DataGridViewExample.DatabaseGiomarDataSet1TableAdapters.VendasTableAdapter();
            this.vendasTableAdapter1 = new DataGridViewExample.DatabaseGiomarDataSet1TableAdapters.VendasTableAdapter();
            this.dataTable2TableAdapter = new DataGridViewExample.DatabaseGiomarDataSet1TableAdapters.DataTable2TableAdapter();
            this.databaseGiomarDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseGiomarDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new DataGridViewExample.DatabaseGiomarDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.selectComInnerJoinToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carrosBindingSource;
            this.comboBox1.DisplayMember = "Modelo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(103, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = " Valor:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendasBindingSource, "Valor", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.textBox1.Location = new System.Drawing.Point(103, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 7;
            // 
            // selectComInnerJoinToolStrip
            // 
            this.selectComInnerJoinToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.selectComInnerJoinToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectComInnerJoinToolStripButton});
            this.selectComInnerJoinToolStrip.Location = new System.Drawing.Point(0, 0);
            this.selectComInnerJoinToolStrip.Name = "selectComInnerJoinToolStrip";
            this.selectComInnerJoinToolStrip.Size = new System.Drawing.Size(405, 27);
            this.selectComInnerJoinToolStrip.TabIndex = 8;
            this.selectComInnerJoinToolStrip.Text = "selectComInnerJoinToolStrip";
            // 
            // selectComInnerJoinToolStripButton
            // 
            this.selectComInnerJoinToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectComInnerJoinToolStripButton.Name = "selectComInnerJoinToolStripButton";
            this.selectComInnerJoinToolStripButton.Size = new System.Drawing.Size(143, 24);
            this.selectComInnerJoinToolStripButton.Text = "SelectComInnerJoin";
            this.selectComInnerJoinToolStripButton.Click += new System.EventHandler(this.SelectComInnerJoinToolStripButton_Click);
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.databaseGiomarDataSet1;
            // 
            // databaseGiomarDataSet1
            // 
            this.databaseGiomarDataSet1.DataSetName = "DatabaseGiomarDataSet1";
            this.databaseGiomarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.databaseGiomarDataSet1;
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.databaseGiomarDataSet1;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // vendasTableAdapter1
            // 
            this.vendasTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // databaseGiomarDataSet1BindingSource
            // 
            this.databaseGiomarDataSet1BindingSource.DataSource = this.databaseGiomarDataSet1;
            this.databaseGiomarDataSet1BindingSource.Position = 0;
            // 
            // databaseGiomarDataSet1BindingSource1
            // 
            this.databaseGiomarDataSet1BindingSource1.DataSource = this.databaseGiomarDataSet1;
            this.databaseGiomarDataSet1BindingSource1.Position = 0;
            // 
            // vendasBindingSource1
            // 
            this.vendasBindingSource1.DataMember = "Vendas";
            this.vendasBindingSource1.DataSource = this.databaseGiomarDataSet1;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.databaseGiomarDataSet1;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 216);
            this.Controls.Add(this.selectComInnerJoinToolStrip);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmEditarVendas";
            this.Text = "frmEditarVendas";
            this.Load += new System.EventHandler(this.FrmEditarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.selectComInnerJoinToolStrip.ResumeLayout(false);
            this.selectComInnerJoinToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGiomarDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DatabaseGiomarDataSet1 databaseGiomarDataSet1;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private DatabaseGiomarDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private DatabaseGiomarDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DatabaseGiomarDataSet1TableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private System.Windows.Forms.BindingSource databaseGiomarDataSet1BindingSource;
        private System.Windows.Forms.BindingSource databaseGiomarDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource vendasBindingSource1;
        private System.Windows.Forms.ToolStrip selectComInnerJoinToolStrip;
        private System.Windows.Forms.ToolStripButton selectComInnerJoinToolStripButton;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private DatabaseGiomarDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
    }
}