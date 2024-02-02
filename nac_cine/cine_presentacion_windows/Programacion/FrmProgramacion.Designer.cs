namespace cine_presentacion_windows.Programacion
{
    partial class FrmProgramacion
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
            this.lblHorainicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHorafin = new System.Windows.Forms.Label();
            this.lblEstreno = new System.Windows.Forms.Label();
            this.txtEstreno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvprogramacion = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprogramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHorainicio
            // 
            this.lblHorainicio.AutoSize = true;
            this.lblHorainicio.Location = new System.Drawing.Point(23, 93);
            this.lblHorainicio.Name = "lblHorainicio";
            this.lblHorainicio.Size = new System.Drawing.Size(57, 13);
            this.lblHorainicio.TabIndex = 0;
            this.lblHorainicio.Text = "Hora inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Location = new System.Drawing.Point(26, 128);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraInicio.TabIndex = 1;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Location = new System.Drawing.Point(26, 226);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraFin.TabIndex = 3;
            // 
            // lblHorafin
            // 
            this.lblHorafin.AutoSize = true;
            this.lblHorafin.Location = new System.Drawing.Point(23, 175);
            this.lblHorafin.Name = "lblHorafin";
            this.lblHorafin.Size = new System.Drawing.Size(100, 13);
            this.lblHorafin.TabIndex = 2;
            this.lblHorafin.Text = "Hora de finalizacion";
            // 
            // lblEstreno
            // 
            this.lblEstreno.AutoSize = true;
            this.lblEstreno.Location = new System.Drawing.Point(23, 36);
            this.lblEstreno.Name = "lblEstreno";
            this.lblEstreno.Size = new System.Drawing.Size(43, 13);
            this.lblEstreno.TabIndex = 4;
            this.lblEstreno.Text = "Estreno";
            // 
            // txtEstreno
            // 
            this.txtEstreno.Location = new System.Drawing.Point(26, 61);
            this.txtEstreno.Name = "txtEstreno";
            this.txtEstreno.Size = new System.Drawing.Size(200, 20);
            this.txtEstreno.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.txtEstreno);
            this.groupBox1.Controls.Add(this.lblEstreno);
            this.groupBox1.Controls.Add(this.dtpHoraFin);
            this.groupBox1.Controls.Add(this.lblHorafin);
            this.groupBox1.Controls.Add(this.dtpHoraInicio);
            this.groupBox1.Controls.Add(this.lblHorainicio);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(481, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 268);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(55, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 22);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(55, 126);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 22);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(55, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 22);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvprogramacion
            // 
            this.dgvprogramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprogramacion.Location = new System.Drawing.Point(23, 323);
            this.dgvprogramacion.Name = "dgvprogramacion";
            this.dgvprogramacion.Size = new System.Drawing.Size(641, 115);
            this.dgvprogramacion.TabIndex = 8;
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Location = new System.Drawing.Point(20, 307);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(87, 13);
            this.lblListar.TabIndex = 9;
            this.lblListar.Text = "Lista de estrenos";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(281, 61);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // FrmProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.dgvprogramacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProgramacion";
            this.Text = "FrmProgramacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprogramacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorainicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblHorafin;
        private System.Windows.Forms.Label lblEstreno;
        private System.Windows.Forms.TextBox txtEstreno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvprogramacion;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.CheckBox chkEstado;
    }
}