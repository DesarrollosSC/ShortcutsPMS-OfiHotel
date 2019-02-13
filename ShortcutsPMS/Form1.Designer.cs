namespace ShortcutsPMS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scvShortcutsPMSDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioSinIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scvShortcutsPMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shortcutsPOSDataSet = new ShortcutsPMS.ShortcutsPOSDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCargarVentas = new System.Windows.Forms.Button();
            this.lblTitol = new System.Windows.Forms.Label();
            this.btnEnviarVenta = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.scvShortcutsPMSTableAdapter = new ShortcutsPMS.ShortcutsPOSDataSetTableAdapters.scvShortcutsPMSTableAdapter();
            this.tableAdapterManager = new ShortcutsPMS.ShortcutsPOSDataSetTableAdapters.TableAdapterManager();
            this.historysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historysTableAdapter = new ShortcutsPMS.ShortcutsPOSDataSetTableAdapters.historysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scvShortcutsPMSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scvShortcutsPMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsPOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scvShortcutsPMSDataGridView
            // 
            this.scvShortcutsPMSDataGridView.AllowUserToAddRows = false;
            this.scvShortcutsPMSDataGridView.AllowUserToDeleteRows = false;
            this.scvShortcutsPMSDataGridView.AutoGenerateColumns = false;
            this.scvShortcutsPMSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scvShortcutsPMSDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scvShortcutsPMSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.scvShortcutsPMSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scvShortcutsPMSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.habDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.precioSinIvaDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.scvShortcutsPMSDataGridView.DataSource = this.scvShortcutsPMSBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scvShortcutsPMSDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.scvShortcutsPMSDataGridView.Location = new System.Drawing.Point(20, 139);
            this.scvShortcutsPMSDataGridView.Name = "scvShortcutsPMSDataGridView";
            this.scvShortcutsPMSDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scvShortcutsPMSDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.scvShortcutsPMSDataGridView.RowHeadersVisible = false;
            this.scvShortcutsPMSDataGridView.Size = new System.Drawing.Size(545, 220);
            this.scvShortcutsPMSDataGridView.TabIndex = 1;
            this.scvShortcutsPMSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scvShortcutsPMSDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SaleID";
            this.Column1.HeaderText = "Ticket";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // habDataGridViewTextBoxColumn
            // 
            this.habDataGridViewTextBoxColumn.DataPropertyName = "Hab";
            this.habDataGridViewTextBoxColumn.HeaderText = "Hab.";
            this.habDataGridViewTextBoxColumn.Name = "habDataGridViewTextBoxColumn";
            this.habDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle9.NullValue = null;
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.timeDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioSinIvaDataGridViewTextBoxColumn
            // 
            this.precioSinIvaDataGridViewTextBoxColumn.DataPropertyName = "PrecioSinIva";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.precioSinIvaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.precioSinIvaDataGridViewTextBoxColumn.HeaderText = "Base";
            this.precioSinIvaDataGridViewTextBoxColumn.Name = "precioSinIvaDataGridViewTextBoxColumn";
            this.precioSinIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "Iva";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.ivaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.ivaDataGridViewTextBoxColumn.HeaderText = "Iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            this.ivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scvShortcutsPMSBindingSource
            // 
            this.scvShortcutsPMSBindingSource.DataMember = "scvShortcutsPMS";
            this.scvShortcutsPMSBindingSource.DataSource = this.shortcutsPOSDataSet;
            // 
            // shortcutsPOSDataSet
            // 
            this.shortcutsPOSDataSet.DataSetName = "ShortcutsPOSDataSet";
            this.shortcutsPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Shortcuts PMS";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnCargarVentas
            // 
            this.btnCargarVentas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCargarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVentas.Location = new System.Drawing.Point(384, 76);
            this.btnCargarVentas.Name = "btnCargarVentas";
            this.btnCargarVentas.Size = new System.Drawing.Size(134, 41);
            this.btnCargarVentas.TabIndex = 3;
            this.btnCargarVentas.Text = "Cargar Ventas";
            this.btnCargarVentas.UseVisualStyleBackColor = false;
            this.btnCargarVentas.Click += new System.EventHandler(this.btnCargarVentas_Click);
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.ForeColor = System.Drawing.Color.Black;
            this.lblTitol.Location = new System.Drawing.Point(23, 18);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(215, 36);
            this.lblTitol.TabIndex = 4;
            this.lblTitol.Text = "Shortcuts PMS";
            // 
            // btnEnviarVenta
            // 
            this.btnEnviarVenta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnviarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarVenta.Location = new System.Drawing.Point(39, 373);
            this.btnEnviarVenta.Name = "btnEnviarVenta";
            this.btnEnviarVenta.Size = new System.Drawing.Size(112, 42);
            this.btnEnviarVenta.TabIndex = 5;
            this.btnEnviarVenta.Text = "Enviar Venta";
            this.btnEnviarVenta.UseVisualStyleBackColor = false;
            this.btnEnviarVenta.Click += new System.EventHandler(this.btnEnviarVenta_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Image = global::ShortcutsPMS.Properties.Resources.config;
            this.btnConfig.Location = new System.Drawing.Point(510, 373);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(42, 42);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // scvShortcutsPMSTableAdapter
            // 
            this.scvShortcutsPMSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = ShortcutsPMS.ShortcutsPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // historysBindingSource
            // 
            this.historysBindingSource.DataMember = "historys";
            this.historysBindingSource.DataSource = this.shortcutsPOSDataSet;
            // 
            // historysTableAdapter
            // 
            this.historysTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(587, 434);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnEnviarVenta);
            this.Controls.Add(this.lblTitol);
            this.Controls.Add(this.btnCargarVentas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.scvShortcutsPMSDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shortcuts PMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.scvShortcutsPMSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scvShortcutsPMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsPOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShortcutsPOSDataSet shortcutsPOSDataSet;
        private System.Windows.Forms.BindingSource scvShortcutsPMSBindingSource;
        private ShortcutsPOSDataSetTableAdapters.scvShortcutsPMSTableAdapter scvShortcutsPMSTableAdapter;
        private ShortcutsPOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView scvShortcutsPMSDataGridView;

        public string UltimaSaleID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.Button btnEnviarVenta;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn habDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioSinIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historysBindingSource;
        private ShortcutsPOSDataSetTableAdapters.historysTableAdapter historysTableAdapter;
    }
}

