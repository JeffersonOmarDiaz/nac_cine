namespace cine_presentacion_windows.FormularioTicket
{
    partial class FrmTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEstadoTicket = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCompra = new System.Windows.Forms.ComboBox();
            this.cmbProgramacion = new System.Windows.Forms.ComboBox();
            this.cmbTaquilla = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblProgramacion = new System.Windows.Forms.Label();
            this.lblTaquilla = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstadoTicket);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cmbCompra);
            this.groupBox1.Controls.Add(this.cmbProgramacion);
            this.groupBox1.Controls.Add(this.cmbTaquilla);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblCompra);
            this.groupBox1.Controls.Add(this.lblProgramacion);
            this.groupBox1.Controls.Add(this.lblTaquilla);
            this.groupBox1.Location = new System.Drawing.Point(36, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkEstadoTicket
            // 
            this.chkEstadoTicket.AutoSize = true;
            this.chkEstadoTicket.Location = new System.Drawing.Point(131, 185);
            this.chkEstadoTicket.Name = "chkEstadoTicket";
            this.chkEstadoTicket.Size = new System.Drawing.Size(15, 14);
            this.chkEstadoTicket.TabIndex = 9;
            this.chkEstadoTicket.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(131, 149);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(240, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // cmbCompra
            // 
            this.cmbCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompra.FormattingEnabled = true;
            this.cmbCompra.Location = new System.Drawing.Point(131, 113);
            this.cmbCompra.Name = "cmbCompra";
            this.cmbCompra.Size = new System.Drawing.Size(179, 21);
            this.cmbCompra.TabIndex = 7;
            // 
            // cmbProgramacion
            // 
            this.cmbProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgramacion.FormattingEnabled = true;
            this.cmbProgramacion.Location = new System.Drawing.Point(131, 72);
            this.cmbProgramacion.Name = "cmbProgramacion";
            this.cmbProgramacion.Size = new System.Drawing.Size(179, 21);
            this.cmbProgramacion.TabIndex = 6;
            // 
            // cmbTaquilla
            // 
            this.cmbTaquilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaquilla.FormattingEnabled = true;
            this.cmbTaquilla.Location = new System.Drawing.Point(131, 33);
            this.cmbTaquilla.Name = "cmbTaquilla";
            this.cmbTaquilla.Size = new System.Drawing.Size(179, 21);
            this.cmbTaquilla.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(43, 186);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 152);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(43, 116);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(43, 13);
            this.lblCompra.TabIndex = 2;
            this.lblCompra.Text = "Compra";
            // 
            // lblProgramacion
            // 
            this.lblProgramacion.AutoSize = true;
            this.lblProgramacion.Location = new System.Drawing.Point(43, 75);
            this.lblProgramacion.Name = "lblProgramacion";
            this.lblProgramacion.Size = new System.Drawing.Size(72, 13);
            this.lblProgramacion.TabIndex = 1;
            this.lblProgramacion.Text = "Programación";
            // 
            // lblTaquilla
            // 
            this.lblTaquilla.AutoSize = true;
            this.lblTaquilla.Location = new System.Drawing.Point(43, 36);
            this.lblTaquilla.Name = "lblTaquilla";
            this.lblTaquilla.Size = new System.Drawing.Size(61, 13);
            this.lblTaquilla.TabIndex = 0;
            this.lblTaquilla.Text = "No Taquilla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(551, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(72, 162);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(72, 107);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(72, 52);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(39, 278);
            this.dgvTicket.MultiSelect = false;
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.ReadOnly = true;
            this.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTicket.Size = new System.Drawing.Size(730, 161);
            this.dgvTicket.TabIndex = 2;
            this.dgvTicket.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTicket_CellMouseClick);
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Ticket";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblProgramacion;
        private System.Windows.Forms.Label lblTaquilla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEstadoTicket;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbCompra;
        private System.Windows.Forms.ComboBox cmbProgramacion;
        private System.Windows.Forms.ComboBox cmbTaquilla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTicket;
    }
}