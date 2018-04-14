namespace Automoviles
{
    partial class Vendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Edadtext = new System.Windows.Forms.TextBox();
            this.cedulatex = new System.Windows.Forms.TextBox();
            this.Nombretex = new System.Windows.Forms.TextBox();
            this.vendedorDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cargotex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.idnombre = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automovilesDataSet = new Automoviles.AutomovilesDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorTableAdapter = new Automoviles.AutomovilesDataSetTableAdapters.VendedorTableAdapter();
            this.tableAdapterManager = new Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nif o cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edadtext
            // 
            this.Edadtext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "edad", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Edadtext.Location = new System.Drawing.Point(57, 193);
            this.Edadtext.Name = "Edadtext";
            this.Edadtext.Size = new System.Drawing.Size(158, 22);
            this.Edadtext.TabIndex = 14;
            this.Edadtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cedulatex
            // 
            this.cedulatex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "Nif_cedula", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cedulatex.Location = new System.Drawing.Point(57, 127);
            this.cedulatex.Name = "cedulatex";
            this.cedulatex.Size = new System.Drawing.Size(158, 22);
            this.cedulatex.TabIndex = 13;
            this.cedulatex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nombretex
            // 
            this.Nombretex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "ID_Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.Nombretex.Location = new System.Drawing.Point(57, 60);
            this.Nombretex.Name = "Nombretex";
            this.Nombretex.Size = new System.Drawing.Size(158, 22);
            this.Nombretex.TabIndex = 12;
            this.Nombretex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vendedorDataGridView
            // 
            this.vendedorDataGridView.AllowUserToAddRows = false;
            this.vendedorDataGridView.AllowUserToDeleteRows = false;
            this.vendedorDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendedorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vendedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.vendedorDataGridView.DataSource = this.vendedorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendedorDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.vendedorDataGridView.Location = new System.Drawing.Point(302, 29);
            this.vendedorDataGridView.Name = "vendedorDataGridView";
            this.vendedorDataGridView.ReadOnly = true;
            this.vendedorDataGridView.RowHeadersVisible = false;
            this.vendedorDataGridView.RowTemplate.Height = 24;
            this.vendedorDataGridView.Size = new System.Drawing.Size(563, 565);
            this.vendedorDataGridView.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cargo";
            // 
            // cargotex
            // 
            this.cargotex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "Cargo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cargotex.Location = new System.Drawing.Point(57, 257);
            this.cargotex.Name = "cargotex";
            this.cargotex.Size = new System.Drawing.Size(158, 22);
            this.cargotex.TabIndex = 22;
            this.cargotex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pass";
            // 
            // passtext
            // 
            this.passtext.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "pass", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.passtext.DataBindings.Add(new System.Windows.Forms.Binding("PasswordChar", this.vendedorBindingSource, "pass", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.passtext.Location = new System.Drawing.Point(57, 327);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '$';
            this.passtext.Size = new System.Drawing.Size(158, 22);
            this.passtext.TabIndex = 24;
            this.passtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passtext.UseSystemPasswordChar = true;
            // 
            // idnombre
            // 
            this.idnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendedorBindingSource, "ID_Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.idnombre.Location = new System.Drawing.Point(302, 572);
            this.idnombre.Name = "idnombre";
            this.idnombre.Size = new System.Drawing.Size(64, 22);
            this.idnombre.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.automovilesDataSet;
            // 
            // automovilesDataSet
            // 
            this.automovilesDataSet.DataSetName = "AutomovilesDataSet";
            this.automovilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nif_cedula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nif o cedula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pass";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Automoviles.AutomovilesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendedorTableAdapter = this.vendedorTableAdapter;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 597);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cargotex);
            this.Controls.Add(this.vendedorDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Edadtext);
            this.Controls.Add(this.cedulatex);
            this.Controls.Add(this.Nombretex);
            this.Controls.Add(this.idnombre);
            this.MaximizeBox = false;
            this.Name = "Vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.Vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automovilesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Edadtext;
        private System.Windows.Forms.TextBox cedulatex;
        private System.Windows.Forms.TextBox Nombretex;
        private AutomovilesDataSet automovilesDataSet;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private AutomovilesDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private AutomovilesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vendedorDataGridView;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cargotex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.TextBox idnombre;
        private System.Windows.Forms.Button button4;
    }
}