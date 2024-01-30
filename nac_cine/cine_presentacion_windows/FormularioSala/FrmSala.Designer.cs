namespace cine_presentacion_windows.FormularioSala
{
    partial class FrmSala
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
            this.cmbCine = new System.Windows.Forms.ComboBox();
            this.lblCine = new System.Windows.Forms.Label();
            this.lblEstadoSala = new System.Windows.Forms.Label();
            this.chkEstadoSala = new System.Windows.Forms.CheckBox();
            this.txtNombreSala = new System.Windows.Forms.TextBox();
            this.lblSalaNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvSala = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCine);
            this.groupBox1.Controls.Add(this.lblCine);
            this.groupBox1.Controls.Add(this.lblEstadoSala);
            this.groupBox1.Controls.Add(this.chkEstadoSala);
            this.groupBox1.Controls.Add(this.txtNombreSala);
            this.groupBox1.Controls.Add(this.lblSalaNombre);
            this.groupBox1.Location = new System.Drawing.Point(21, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbCine
            // 
            this.cmbCine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCine.FormattingEnabled = true;
            this.cmbCine.Location = new System.Drawing.Point(97, 38);
            this.cmbCine.Name = "cmbCine";
            this.cmbCine.Size = new System.Drawing.Size(202, 21);
            this.cmbCine.TabIndex = 5;
            // 
            // lblCine
            // 
            this.lblCine.AutoSize = true;
            this.lblCine.Location = new System.Drawing.Point(40, 46);
            this.lblCine.Name = "lblCine";
            this.lblCine.Size = new System.Drawing.Size(28, 13);
            this.lblCine.TabIndex = 4;
            this.lblCine.Text = "Cine";
            // 
            // lblEstadoSala
            // 
            this.lblEstadoSala.AutoSize = true;
            this.lblEstadoSala.Location = new System.Drawing.Point(40, 127);
            this.lblEstadoSala.Name = "lblEstadoSala";
            this.lblEstadoSala.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoSala.TabIndex = 3;
            this.lblEstadoSala.Text = "Estado";
            // 
            // chkEstadoSala
            // 
            this.chkEstadoSala.AutoSize = true;
            this.chkEstadoSala.Location = new System.Drawing.Point(97, 126);
            this.chkEstadoSala.Name = "chkEstadoSala";
            this.chkEstadoSala.Size = new System.Drawing.Size(15, 14);
            this.chkEstadoSala.TabIndex = 2;
            this.chkEstadoSala.UseVisualStyleBackColor = true;
            // 
            // txtNombreSala
            // 
            this.txtNombreSala.Location = new System.Drawing.Point(97, 79);
            this.txtNombreSala.Name = "txtNombreSala";
            this.txtNombreSala.Size = new System.Drawing.Size(203, 20);
            this.txtNombreSala.TabIndex = 1;
            // 
            // lblSalaNombre
            // 
            this.lblSalaNombre.AutoSize = true;
            this.lblSalaNombre.Location = new System.Drawing.Point(40, 83);
            this.lblSalaNombre.Name = "lblSalaNombre";
            this.lblSalaNombre.Size = new System.Drawing.Size(44, 13);
            this.lblSalaNombre.TabIndex = 0;
            this.lblSalaNombre.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(541, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(51, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEliminar.Size = new System.Drawing.Size(89, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(51, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(51, 32);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvSala
            // 
            this.dgvSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSala.Location = new System.Drawing.Point(27, 243);
            this.dgvSala.MultiSelect = false;
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.ReadOnly = true;
            this.dgvSala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSala.Size = new System.Drawing.Size(697, 161);
            this.dgvSala.TabIndex = 2;
            this.dgvSala.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSala_CellMouseClick);
            // 
            // FrmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSala);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Sala";
            this.Load += new System.EventHandler(this.FrmSala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCine;
        private System.Windows.Forms.Label lblEstadoSala;
        private System.Windows.Forms.CheckBox chkEstadoSala;
        private System.Windows.Forms.TextBox txtNombreSala;
        private System.Windows.Forms.Label lblSalaNombre;
        private System.Windows.Forms.ComboBox cmbCine;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvSala;
    }
}