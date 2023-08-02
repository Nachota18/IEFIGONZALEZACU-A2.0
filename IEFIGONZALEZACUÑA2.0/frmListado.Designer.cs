namespace IEFIGONZALEZACUÑA2._0
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.cmdListado = new System.Windows.Forms.Button();
            this.mrcFiltro = new System.Windows.Forms.GroupBox();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.lstVenta = new System.Windows.Forms.ComboBox();
            this.dtgvListado = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombredeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdFiltrar.Location = new System.Drawing.Point(590, 36);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(93, 32);
            this.cmdFiltrar.TabIndex = 0;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // cmdListado
            // 
            this.cmdListado.Location = new System.Drawing.Point(44, 133);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(111, 34);
            this.cmdListado.TabIndex = 1;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // mrcFiltro
            // 
            this.mrcFiltro.Controls.Add(this.lstVenta);
            this.mrcFiltro.Controls.Add(this.rdbVentas);
            this.mrcFiltro.Controls.Add(this.rdbProducto);
            this.mrcFiltro.Controls.Add(this.cmdFiltrar);
            this.mrcFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcFiltro.Location = new System.Drawing.Point(44, 10);
            this.mrcFiltro.Name = "mrcFiltro";
            this.mrcFiltro.Size = new System.Drawing.Size(712, 105);
            this.mrcFiltro.TabIndex = 2;
            this.mrcFiltro.TabStop = false;
            this.mrcFiltro.Text = "Filtro";
            // 
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Location = new System.Drawing.Point(170, 44);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(68, 17);
            this.rdbProducto.TabIndex = 1;
            this.rdbProducto.Text = "Producto";
            this.rdbProducto.UseVisualStyleBackColor = true;
            // 
            // rdbVentas
            // 
            this.rdbVentas.AutoSize = true;
            this.rdbVentas.Checked = true;
            this.rdbVentas.Location = new System.Drawing.Point(276, 44);
            this.rdbVentas.Name = "rdbVentas";
            this.rdbVentas.Size = new System.Drawing.Size(58, 17);
            this.rdbVentas.TabIndex = 2;
            this.rdbVentas.TabStop = true;
            this.rdbVentas.Text = "Ventas";
            this.rdbVentas.UseVisualStyleBackColor = true;
            this.rdbVentas.CheckedChanged += new System.EventHandler(this.rdbVentas_CheckedChanged);
            // 
            // lstVenta
            // 
            this.lstVenta.FormattingEnabled = true;
            this.lstVenta.Location = new System.Drawing.Point(371, 40);
            this.lstVenta.Name = "lstVenta";
            this.lstVenta.Size = new System.Drawing.Size(134, 21);
            this.lstVenta.TabIndex = 3;
            // 
            // dtgvListado
            // 
            this.dtgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombredeProducto,
            this.Fecha});
            this.dtgvListado.Location = new System.Drawing.Point(44, 186);
            this.dtgvListado.Name = "dtgvListado";
            this.dtgvListado.Size = new System.Drawing.Size(706, 229);
            this.dtgvListado.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NombredeProducto
            // 
            this.NombredeProducto.HeaderText = "Nombre de Producto";
            this.NombredeProducto.Name = "NombredeProducto";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvListado);
            this.Controls.Add(this.mrcFiltro);
            this.Controls.Add(this.cmdListado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.mrcFiltro.ResumeLayout(false);
            this.mrcFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.GroupBox mrcFiltro;
        private System.Windows.Forms.ComboBox lstVenta;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.RadioButton rdbProducto;
        private System.Windows.Forms.DataGridView dtgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombredeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}