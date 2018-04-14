namespace Automoviles
{
    partial class clienteyarticulo
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nif_cedulaLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.automovilesDataSet = new Automoviles.AutomovilesDataSet();
            this.articulos_ventasTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.Articulos_ventasTableAdapter();
            this.clientecomboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automovilesDataSet1 = new Automoviles.AutomovilesDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.DetalleTableAdapter();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.articulos_ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulos_ventasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDlabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.ClienteTableAdapter();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.nif_cedulaLabel1 = new System.Windows.Forms.Label();
            this.domicilioLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.canitdadlabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nif_cedulaLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ventasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(19, 34);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 17);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // nif_cedulaLabel
            // 
            nif_cedulaLabel.AutoSize = true;
            nif_cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nif_cedulaLabel.Location = new System.Drawing.Point(19, 53);
            nif_cedulaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nif_cedulaLabel.Name = "nif_cedulaLabel";
            nif_cedulaLabel.Size = new System.Drawing.Size(86, 17);
            nif_cedulaLabel.TabIndex = 14;
            nif_cedulaLabel.Text = "Nif cedula:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            domicilioLabel.Location = new System.Drawing.Point(19, 72);
            domicilioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(78, 17);
            domicilioLabel.TabIndex = 16;
            domicilioLabel.Text = "Domicilio:";
            // 
            // automovilesDataSet
            // 
            this.automovilesDataSet.DataSetName = "AutomovilesDataSet";
            this.automovilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articulos_ventasTableAdapter
            // 
            this.articulos_ventasTableAdapter.ClearBeforeFill = true;
            // 
            // clientecomboBox1
            // 
            this.clientecomboBox1.DataSource = this.clienteBindingSource;
            this.clientecomboBox1.DisplayMember = "Nombre";
            this.clientecomboBox1.FormattingEnabled = true;
            this.clientecomboBox1.Location = new System.Drawing.Point(370, 34);
            this.clientecomboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientecomboBox1.Name = "clientecomboBox1";
            this.clientecomboBox1.Size = new System.Drawing.Size(138, 21);
            this.clientecomboBox1.TabIndex = 7;
            this.clientecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.automovilesDataSet1;
            // 
            // automovilesDataSet1
            // 
            this.automovilesDataSet1.DataSetName = "AutomovilesDataSet";
            this.automovilesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar cliente";
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "Detalle";
            this.detalleBindingSource.DataSource = this.automovilesDataSet;
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.AllowUserToAddRows = false;
            this.detalleDataGridView.AllowUserToDeleteRows = false;
            this.detalleDataGridView.AutoGenerateColumns = false;
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.detalleDataGridView.DataSource = this.detalleBindingSource;
            this.detalleDataGridView.Location = new System.Drawing.Point(9, 103);
            this.detalleDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.ReadOnly = true;
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.Size = new System.Drawing.Size(806, 179);
            this.detalleDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "vendedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "vendedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn5.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 56;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Forma_pago";
            this.dataGridViewTextBoxColumn8.HeaderText = "Forma pago";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Total_con_articulos";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total con articulos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 109;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fecha_venta";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha venta";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 85;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha_entrega";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha entrega";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecione el carro con articulo comprado y  luego boton aceptar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // articulos_ventasBindingSource
            // 
            this.articulos_ventasBindingSource.DataMember = "Articulos_ventas";
            this.articulos_ventasBindingSource.DataSource = this.automovilesDataSet;
            // 
            // articulos_ventasDataGridView
            // 
            this.articulos_ventasDataGridView.AllowUserToAddRows = false;
            this.articulos_ventasDataGridView.AllowUserToDeleteRows = false;
            this.articulos_ventasDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articulos_ventasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articulos_ventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulos_ventasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.articulos_ventasDataGridView.DataSource = this.articulos_ventasBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articulos_ventasDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.articulos_ventasDataGridView.Enabled = false;
            this.articulos_ventasDataGridView.Location = new System.Drawing.Point(611, 287);
            this.articulos_ventasDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.articulos_ventasDataGridView.Name = "articulos_ventasDataGridView";
            this.articulos_ventasDataGridView.ReadOnly = true;
            this.articulos_ventasDataGridView.RowHeadersVisible = false;
            this.articulos_ventasDataGridView.RowTemplate.Height = 24;
            this.articulos_ventasDataGridView.Size = new System.Drawing.Size(203, 179);
            this.articulos_ventasDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Articulo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleBindingSource, "ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.IDlabel.Location = new System.Drawing.Point(9, 287);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 12;
            this.IDlabel.Text = "ID";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Articulos_ventasTableAdapter = null;
            this.tableAdapterManager.ArticulosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.codigoTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendedorTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.automovilesDataSet;
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Nombre", true));
            this.nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel1.Location = new System.Drawing.Point(94, 34);
            this.nombreLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(75, 19);
            this.nombreLabel1.TabIndex = 13;
            // 
            // nif_cedulaLabel1
            // 
            this.nif_cedulaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Nif_cedula", true));
            this.nif_cedulaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nif_cedulaLabel1.Location = new System.Drawing.Point(94, 53);
            this.nif_cedulaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nif_cedulaLabel1.Name = "nif_cedulaLabel1";
            this.nif_cedulaLabel1.Size = new System.Drawing.Size(75, 19);
            this.nif_cedulaLabel1.TabIndex = 15;
            // 
            // domicilioLabel1
            // 
            this.domicilioLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "Domicilio", true));
            this.domicilioLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioLabel1.Location = new System.Drawing.Point(94, 72);
            this.domicilioLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.domicilioLabel1.Name = "domicilioLabel1";
            this.domicilioLabel1.Size = new System.Drawing.Size(75, 19);
            this.domicilioLabel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 468);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // canitdadlabel
            // 
            this.canitdadlabel.AutoSize = true;
            this.canitdadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canitdadlabel.Location = new System.Drawing.Point(704, 468);
            this.canitdadlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.canitdadlabel.Name = "canitdadlabel";
            this.canitdadlabel.Size = new System.Drawing.Size(0, 17);
            this.canitdadlabel.TabIndex = 19;
            // 
            // clienteyarticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 487);
            this.Controls.Add(this.canitdadlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(nif_cedulaLabel);
            this.Controls.Add(this.nif_cedulaLabel1);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioLabel1);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.articulos_ventasDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detalleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientecomboBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "clienteyarticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cliente y articulo";
            this.Load += new System.EventHandler(this.clienteyarticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ventasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutomovilesDataSet automovilesDataSet;
        private System.Windows.Forms.ComboBox clientecomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private AutomovilesDataSetTableAdapters.DetalleTableAdapter detalleTableAdapter;
        private AutomovilesDataSetTableAdapters.Articulos_ventasTableAdapter articulos_ventasTableAdapter;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource articulos_ventasBindingSource;
        private System.Windows.Forms.DataGridView articulos_ventasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label IDlabel;
        private AutomovilesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutomovilesDataSet automovilesDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private AutomovilesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.Label nif_cedulaLabel1;
        private System.Windows.Forms.Label domicilioLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label canitdadlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}