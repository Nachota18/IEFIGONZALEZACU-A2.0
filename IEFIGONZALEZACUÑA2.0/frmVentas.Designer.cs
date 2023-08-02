namespace IEFIGONZALEZACUÑA2._0
{
    partial class frmVentas
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
            this.mrcCargarVentas = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mrcRegistrodeVentas = new System.Windows.Forms.GroupBox();
            this.dtgvCargarVentas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Candidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListado = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.mrcCargarVentas.SuspendLayout();
            this.mrcRegistrodeVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargarVentas
            // 
            this.mrcCargarVentas.Controls.Add(this.cmdVolver);
            this.mrcCargarVentas.Controls.Add(this.lblCantidad);
            this.mrcCargarVentas.Controls.Add(this.lblFecha);
            this.mrcCargarVentas.Controls.Add(this.lblProducto);
            this.mrcCargarVentas.Controls.Add(this.lblID);
            this.mrcCargarVentas.Controls.Add(this.cmdCargar);
            this.mrcCargarVentas.Controls.Add(this.txtCantidad);
            this.mrcCargarVentas.Controls.Add(this.txtProducto);
            this.mrcCargarVentas.Controls.Add(this.txtID);
            this.mrcCargarVentas.Controls.Add(this.dtpFecha);
            this.mrcCargarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcCargarVentas.Location = new System.Drawing.Point(31, 34);
            this.mrcCargarVentas.Name = "mrcCargarVentas";
            this.mrcCargarVentas.Size = new System.Drawing.Size(306, 268);
            this.mrcCargarVentas.TabIndex = 0;
            this.mrcCargarVentas.TabStop = false;
            this.mrcCargarVentas.Text = "Cargar Ventas";
            this.mrcCargarVentas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 159);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(23, 111);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(23, 64);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // cmdCargar
            // 
            this.cmdCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCargar.Location = new System.Drawing.Point(170, 225);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(99, 27);
            this.cmdCargar.TabIndex = 1;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(26, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(196, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(26, 80);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(196, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(26, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(26, 127);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(196, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // mrcRegistrodeVentas
            // 
            this.mrcRegistrodeVentas.Controls.Add(this.cmdListado);
            this.mrcRegistrodeVentas.Controls.Add(this.dtgvCargarVentas);
            this.mrcRegistrodeVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcRegistrodeVentas.Location = new System.Drawing.Point(343, 34);
            this.mrcRegistrodeVentas.Name = "mrcRegistrodeVentas";
            this.mrcRegistrodeVentas.Size = new System.Drawing.Size(445, 268);
            this.mrcRegistrodeVentas.TabIndex = 0;
            this.mrcRegistrodeVentas.TabStop = false;
            this.mrcRegistrodeVentas.Text = "Registro de Venta";
            this.mrcRegistrodeVentas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgvCargarVentas
            // 
            this.dtgvCargarVentas.AllowUserToAddRows = false;
            this.dtgvCargarVentas.AllowUserToDeleteRows = false;
            this.dtgvCargarVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCargarVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgvCargarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCargarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.Candidad,
            this.Fecha});
            this.dtgvCargarVentas.Location = new System.Drawing.Point(6, 19);
            this.dtgvCargarVentas.Name = "dtgvCargarVentas";
            this.dtgvCargarVentas.ReadOnly = true;
            this.dtgvCargarVentas.RowHeadersVisible = false;
            this.dtgvCargarVentas.Size = new System.Drawing.Size(433, 198);
            this.dtgvCargarVentas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Candidad
            // 
            this.Candidad.HeaderText = "Cantidad";
            this.Candidad.Name = "Candidad";
            this.Candidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // cmdListado
            // 
            this.cmdListado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListado.Location = new System.Drawing.Point(170, 226);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(105, 26);
            this.cmdListado.TabIndex = 1;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmdVolver
            // 
            this.cmdVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVolver.Location = new System.Drawing.Point(26, 225);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(95, 27);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.mrcRegistrodeVentas);
            this.Controls.Add(this.mrcCargarVentas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.mrcCargarVentas.ResumeLayout(false);
            this.mrcCargarVentas.PerformLayout();
            this.mrcRegistrodeVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCargarVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargarVentas;
        private System.Windows.Forms.GroupBox mrcRegistrodeVentas;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dtgvCargarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.Button cmdVolver;
    }
}