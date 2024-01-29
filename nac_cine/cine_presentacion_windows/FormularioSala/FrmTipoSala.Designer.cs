namespace cine_presentacion_windows.FormularioSala
{
    partial class FrmTipoSala
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblNombreTipoSala = new System.Windows.Forms.Label();
            this.lblEstadoTipoSala = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.chkEstadoTipoSala = new System.Windows.Forms.CheckBox();
            this.txtNombreTipoSala = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTipoSala = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreTipoSala);
            this.groupBox1.Controls.Add(this.chkEstadoTipoSala);
            this.groupBox1.Controls.Add(this.cmbSala);
            this.groupBox1.Controls.Add(this.lblEstadoTipoSala);
            this.groupBox1.Controls.Add(this.lblNombreTipoSala);
            this.groupBox1.Controls.Add(this.lblSala);
            this.groupBox1.Location = new System.Drawing.Point(27, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(588, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(49, 64);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(28, 13);
            this.lblSala.TabIndex = 0;
            this.lblSala.Text = "Sala";
            // 
            // lblNombreTipoSala
            // 
            this.lblNombreTipoSala.AutoSize = true;
            this.lblNombreTipoSala.Location = new System.Drawing.Point(49, 107);
            this.lblNombreTipoSala.Name = "lblNombreTipoSala";
            this.lblNombreTipoSala.Size = new System.Drawing.Size(44, 13);
            this.lblNombreTipoSala.TabIndex = 1;
            this.lblNombreTipoSala.Text = "Nombre";
            // 
            // lblEstadoTipoSala
            // 
            this.lblEstadoTipoSala.AutoSize = true;
            this.lblEstadoTipoSala.Location = new System.Drawing.Point(49, 150);
            this.lblEstadoTipoSala.Name = "lblEstadoTipoSala";
            this.lblEstadoTipoSala.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoTipoSala.TabIndex = 2;
            this.lblEstadoTipoSala.Text = "Estado";
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(106, 60);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(210, 21);
            this.cmbSala.TabIndex = 3;
            // 
            // chkEstadoTipoSala
            // 
            this.chkEstadoTipoSala.AutoSize = true;
            this.chkEstadoTipoSala.Location = new System.Drawing.Point(106, 150);
            this.chkEstadoTipoSala.Name = "chkEstadoTipoSala";
            this.chkEstadoTipoSala.Size = new System.Drawing.Size(15, 14);
            this.chkEstadoTipoSala.TabIndex = 4;
            this.chkEstadoTipoSala.UseVisualStyleBackColor = true;
            // 
            // txtNombreTipoSala
            // 
            this.txtNombreTipoSala.Location = new System.Drawing.Point(106, 105);
            this.txtNombreTipoSala.Name = "txtNombreTipoSala";
            this.txtNombreTipoSala.Size = new System.Drawing.Size(206, 20);
            this.txtNombreTipoSala.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(60, 47);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(60, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(60, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTipoSala
            // 
            this.dgvTipoSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoSala.Location = new System.Drawing.Point(31, 260);
            this.dgvTipoSala.Name = "dgvTipoSala";
            this.dgvTipoSala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoSala.Size = new System.Drawing.Size(750, 175);
            this.dgvTipoSala.TabIndex = 2;
            this.dgvTipoSala.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoSala_CellMouseClick);
            // 
            // FrmTipoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTipoSala);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTipoSala";
            this.Text = "FrmTipoSala";
            this.Load += new System.EventHandler(this.FrmTipoSala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreTipoSala;
        private System.Windows.Forms.CheckBox chkEstadoTipoSala;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label lblEstadoTipoSala;
        private System.Windows.Forms.Label lblNombreTipoSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvTipoSala;
    }
}