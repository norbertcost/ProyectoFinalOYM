namespace Automoviles
{
    partial class Carro
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
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label potenciaLabel;
            System.Windows.Forms.Label clilindroLabel;
            System.Windows.Forms.Label equipamientoLabel;
            System.Windows.Forms.Label extraLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carro));
            this.automovilesDataSet = new Automoviles.AutomovilesDataSet();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.CarroTableAdapter();
            this.tableAdapterManager = new Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager();
            this.marcaTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.MarcaTableAdapter();
            this.modelosTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.ModelosTableAdapter();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.detalle_completoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.potenciaTextBox = new System.Windows.Forms.TextBox();
            this.cilindroTextBox = new System.Windows.Forms.TextBox();
            this.equipamientoTextBox = new System.Windows.Forms.TextBox();
            this.extraTextBox = new System.Windows.Forms.TextBox();
            this.modelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalle_completoTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.Detalle_completoTableAdapter();
            this.detalle_completoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcacombox = new System.Windows.Forms.ComboBox();
            this.modelocomboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.IDCARRO = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            serieLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            descuentoLabel = new System.Windows.Forms.Label();
            potenciaLabel = new System.Windows.Forms.Label();
            clilindroLabel = new System.Windows.Forms.Label();
            equipamientoLabel = new System.Windows.Forms.Label();
            extraLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_completoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_completoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Location = new System.Drawing.Point(36, 84);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(45, 17);
            serieLabel.TabIndex = 2;
            serieLabel.Text = "Serie:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(36, 112);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(52, 17);
            precioLabel.TabIndex = 4;
            precioLabel.Text = "Precio:";
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(354, 28);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(80, 17);
            descuentoLabel.TabIndex = 6;
            descuentoLabel.Text = "Descuento:";
            // 
            // potenciaLabel
            // 
            potenciaLabel.AutoSize = true;
            potenciaLabel.Location = new System.Drawing.Point(354, 56);
            potenciaLabel.Name = "potenciaLabel";
            potenciaLabel.Size = new System.Drawing.Size(67, 17);
            potenciaLabel.TabIndex = 8;
            potenciaLabel.Text = "Potencia:";
            // 
            // clilindroLabel
            // 
            clilindroLabel.AutoSize = true;
            clilindroLabel.Location = new System.Drawing.Point(354, 83);
            clilindroLabel.Name = "clilindroLabel";
            clilindroLabel.Size = new System.Drawing.Size(60, 17);
            clilindroLabel.TabIndex = 10;
            clilindroLabel.Text = "clilindro:";
            // 
            // equipamientoLabel
            // 
            equipamientoLabel.AutoSize = true;
            equipamientoLabel.Location = new System.Drawing.Point(354, 109);
            equipamientoLabel.Name = "equipamientoLabel";
            equipamientoLabel.Size = new System.Drawing.Size(98, 17);
            equipamientoLabel.TabIndex = 12;
            equipamientoLabel.Text = "Equipamiento:";
            // 
            // extraLabel
            // 
            extraLabel.AutoSize = true;
            extraLabel.Location = new System.Drawing.Point(613, 83);
            extraLabel.Name = "extraLabel";
            extraLabel.Size = new System.Drawing.Size(44, 17);
            extraLabel.TabIndex = 14;
            extraLabel.Text = "Extra:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(36, 23);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 15;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(36, 56);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 17;
            modeloLabel.Text = "Modelo:";
            // 
            // automovilesDataSet
            // 
            this.automovilesDataSet.DataSetName = "AutomovilesDataSet";
            this.automovilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "Carro";
            this.carroBindingSource.DataSource = this.automovilesDataSet;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = this.carroTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = this.marcaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendedorTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // modelosTableAdapter
            // 
            this.modelosTableAdapter.ClearBeforeFill = true;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.automovilesDataSet;
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "Serie", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.serieTextBox.Location = new System.Drawing.Point(109, 81);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(121, 22);
            this.serieTextBox.TabIndex = 3;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "Precio", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.precioTextBox.Location = new System.Drawing.Point(109, 109);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 22);
            this.precioTextBox.TabIndex = 5;
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "descuento", true, System.Windows.Forms.DataSourceUpdateMode.Never, "Ninguno"));
            this.descuentoTextBox.Location = new System.Drawing.Point(470, 25);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(123, 22);
            this.descuentoTextBox.TabIndex = 7;
            // 
            // detalle_completoBindingSource
            // 
            this.detalle_completoBindingSource.DataMember = "Detalle_completo";
            this.detalle_completoBindingSource.DataSource = this.automovilesDataSet;
            // 
            // potenciaTextBox
            // 
            this.potenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "potencia", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.potenciaTextBox.Location = new System.Drawing.Point(470, 53);
            this.potenciaTextBox.Name = "potenciaTextBox";
            this.potenciaTextBox.Size = new System.Drawing.Size(123, 22);
            this.potenciaTextBox.TabIndex = 9;
            // 
            // cilindroTextBox
            // 
            this.cilindroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "clilindro", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cilindroTextBox.Location = new System.Drawing.Point(470, 80);
            this.cilindroTextBox.Name = "cilindroTextBox";
            this.cilindroTextBox.Size = new System.Drawing.Size(123, 22);
            this.cilindroTextBox.TabIndex = 11;
            this.cilindroTextBox.TextChanged += new System.EventHandler(this.clilindroTextBox_TextChanged);
            // 
            // equipamientoTextBox
            // 
            this.equipamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "Equipamiento", true, System.Windows.Forms.DataSourceUpdateMode.Never, "Ninguno"));
            this.equipamientoTextBox.Location = new System.Drawing.Point(470, 109);
            this.equipamientoTextBox.Name = "equipamientoTextBox";
            this.equipamientoTextBox.Size = new System.Drawing.Size(376, 22);
            this.equipamientoTextBox.TabIndex = 13;
            // 
            // extraTextBox
            // 
            this.extraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "Extra", true, System.Windows.Forms.DataSourceUpdateMode.Never, "Ninguno"));
            this.extraTextBox.Location = new System.Drawing.Point(663, 80);
            this.extraTextBox.Name = "extraTextBox";
            this.extraTextBox.Size = new System.Drawing.Size(187, 22);
            this.extraTextBox.TabIndex = 15;
            // 
            // modelosBindingSource
            // 
            this.modelosBindingSource.DataMember = "Modelos";
            this.modelosBindingSource.DataSource = this.automovilesDataSet;
            // 
            // detalle_completoTableAdapter
            // 
            this.detalle_completoTableAdapter.ClearBeforeFill = true;
            // 
            // detalle_completoDataGridView
            // 
            this.detalle_completoDataGridView.AllowUserToAddRows = false;
            this.detalle_completoDataGridView.AllowUserToDeleteRows = false;
            this.detalle_completoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_completoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detalle_completoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_completoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.descuento,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.detalle_completoDataGridView.DataSource = this.detalle_completoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalle_completoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalle_completoDataGridView.Location = new System.Drawing.Point(12, 159);
            this.detalle_completoDataGridView.Name = "detalle_completoDataGridView";
            this.detalle_completoDataGridView.ReadOnly = true;
            this.detalle_completoDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.detalle_completoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.detalle_completoDataGridView.RowTemplate.Height = 24;
            this.detalle_completoDataGridView.Size = new System.Drawing.Size(1111, 305);
            this.detalle_completoDataGridView.TabIndex = 18;
            this.detalle_completoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detalle_completoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn3.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 77;
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.descuento.DataPropertyName = "descuento";
            this.descuento.HeaderText = "Descuento";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 105;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "potencia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Potencia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "clilindro";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cilindro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Equipamiento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Equipamiento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 123;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Extra";
            this.dataGridViewTextBoxColumn9.HeaderText = "Extra";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // marcacombox
            // 
            this.marcacombox.DataSource = this.marcaBindingSource;
            this.marcacombox.DisplayMember = "Marca";
            this.marcacombox.FormattingEnabled = true;
            this.marcacombox.Location = new System.Drawing.Point(109, 21);
            this.marcacombox.Name = "marcacombox";
            this.marcacombox.Size = new System.Drawing.Size(121, 24);
            this.marcacombox.TabIndex = 19;
            this.marcacombox.ValueMember = "Marca";
            this.marcacombox.SelectedIndexChanged += new System.EventHandler(this.marcacombox_SelectedIndexChanged);
            // 
            // modelocomboBox2
            // 
            this.modelocomboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "Modelo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.modelocomboBox2.DataSource = this.modelosBindingSource;
            this.modelocomboBox2.DisplayMember = "Modelo";
            this.modelocomboBox2.FormattingEnabled = true;
            this.modelocomboBox2.Location = new System.Drawing.Point(109, 51);
            this.modelocomboBox2.Name = "modelocomboBox2";
            this.modelocomboBox2.Size = new System.Drawing.Size(121, 24);
            this.modelocomboBox2.TabIndex = 20;
            this.modelocomboBox2.ValueMember = "ID";
            this.modelocomboBox2.SelectedIndexChanged += new System.EventHandler(this.marcacomboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(236, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 44);
            this.button3.TabIndex = 25;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(919, 109);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 44);
            this.button4.TabIndex = 24;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(919, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 44);
            this.button5.TabIndex = 23;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // IDCARRO
            // 
            this.IDCARRO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_completoBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.IDCARRO.Location = new System.Drawing.Point(12, 442);
            this.IDCARRO.Name = "IDCARRO";
            this.IDCARRO.Size = new System.Drawing.Size(25, 22);
            this.IDCARRO.TabIndex = 26;
            this.IDCARRO.TextChanged += new System.EventHandler(this.IDCARRO_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(704, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 44);
            this.button6.TabIndex = 27;
            this.button6.Text = "Limpiar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 470);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modelocomboBox2);
            this.Controls.Add(this.marcacombox);
            this.Controls.Add(this.detalle_completoDataGridView);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(serieLabel);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(potenciaLabel);
            this.Controls.Add(this.potenciaTextBox);
            this.Controls.Add(clilindroLabel);
            this.Controls.Add(this.cilindroTextBox);
            this.Controls.Add(equipamientoLabel);
            this.Controls.Add(this.equipamientoTextBox);
            this.Controls.Add(extraLabel);
            this.Controls.Add(this.extraTextBox);
            this.Controls.Add(this.IDCARRO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de carro";
            this.Load += new System.EventHandler(this.Carro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_completoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_completoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomovilesDataSet automovilesDataSet;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private AutomovilesDataSetTableAdapters.CarroTableAdapter carroTableAdapter;
        private AutomovilesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutomovilesDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.TextBox potenciaTextBox;
        private System.Windows.Forms.TextBox cilindroTextBox;
        private System.Windows.Forms.TextBox equipamientoTextBox;
        private System.Windows.Forms.TextBox extraTextBox;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private AutomovilesDataSetTableAdapters.ModelosTableAdapter modelosTableAdapter;
        private System.Windows.Forms.BindingSource modelosBindingSource;
        private AutomovilesDataSetTableAdapters.Detalle_completoTableAdapter detalle_completoTableAdapter;
        private System.Windows.Forms.DataGridView detalle_completoDataGridView;
        private System.Windows.Forms.ComboBox marcacombox;
        private System.Windows.Forms.ComboBox modelocomboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
  
        private System.Windows.Forms.TextBox IDCARRO;
        private System.Windows.Forms.BindingSource detalle_completoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button6;
    }
}