namespace IEFIGONZALEZACUÑA2._0
{
    partial class frmResgistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResgistros));
            this.mrcCargadeProducto = new System.Windows.Forms.GroupBox();
            this.mrcListadodeProducto = new System.Windows.Forms.GroupBox();
            this.cmdListado = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechadeRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombredeProducto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.mrcCargadeProducto.SuspendLayout();
            this.mrcListadodeProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCargadeProducto
            // 
            this.mrcCargadeProducto.Controls.Add(this.cmdGuardar);
            this.mrcCargadeProducto.Controls.Add(this.dtpFecha);
            this.mrcCargadeProducto.Controls.Add(this.txtID);
            this.mrcCargadeProducto.Controls.Add(this.txtNombredeProducto);
            this.mrcCargadeProducto.Controls.Add(this.label3);
            this.mrcCargadeProducto.Controls.Add(this.label2);
            this.mrcCargadeProducto.Controls.Add(this.label1);
            this.mrcCargadeProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcCargadeProducto.Location = new System.Drawing.Point(21, 22);
            this.mrcCargadeProducto.Name = "mrcCargadeProducto";
            this.mrcCargadeProducto.Size = new System.Drawing.Size(572, 174);
            this.mrcCargadeProducto.TabIndex = 0;
            this.mrcCargadeProducto.TabStop = false;
            this.mrcCargadeProducto.Text = "Carga de Producto";
            this.mrcCargadeProducto.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mrcListadodeProducto
            // 
            this.mrcListadodeProducto.Controls.Add(this.dtgvRegistro);
            this.mrcListadodeProducto.Controls.Add(this.cmdListado);
            this.mrcListadodeProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mrcListadodeProducto.Location = new System.Drawing.Point(21, 202);
            this.mrcListadodeProducto.Name = "mrcListadodeProducto";
            this.mrcListadodeProducto.Size = new System.Drawing.Size(572, 208);
            this.mrcListadodeProducto.TabIndex = 0;
            this.mrcListadodeProducto.TabStop = false;
            this.mrcListadodeProducto.Text = "Listado de Producto";
            this.mrcListadodeProducto.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdListado
            // 
            this.cmdListado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListado.Location = new System.Drawing.Point(475, 163);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(76, 29);
            this.cmdListado.TabIndex = 0;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = true;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVolver.Location = new System.Drawing.Point(37, 427);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(82, 29);
            this.cmdVolver.TabIndex = 1;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.FechadeRegistro});
            this.dtgvRegistro.Location = new System.Drawing.Point(16, 19);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.Size = new System.Drawing.Size(535, 138);
            this.dtgvRegistro.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechadeRegistro
            // 
            this.FechadeRegistro.HeaderText = "Fecha de Registro";
            this.FechadeRegistro.Name = "FechadeRegistro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Registro:";
            // 
            // txtNombredeProducto
            // 
            this.txtNombredeProducto.Location = new System.Drawing.Point(16, 91);
            this.txtNombredeProducto.Name = "txtNombredeProducto";
            this.txtNombredeProducto.Size = new System.Drawing.Size(244, 20);
            this.txtNombredeProducto.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 20);
            this.txtID.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 141);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(244, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdGuardar.Location = new System.Drawing.Point(417, 75);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(99, 36);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // frmResgistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(617, 479);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcListadodeProducto);
            this.Controls.Add(this.mrcCargadeProducto);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResgistros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.frmResgistros_Load);
            this.mrcCargadeProducto.ResumeLayout(false);
            this.mrcCargadeProducto.PerformLayout();
            this.mrcListadodeProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCargadeProducto;
        private System.Windows.Forms.GroupBox mrcListadodeProducto;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechadeRegistro;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombredeProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}