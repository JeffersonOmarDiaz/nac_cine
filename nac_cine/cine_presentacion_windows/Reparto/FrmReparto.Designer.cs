namespace cine_presentacion_windows.Reparto
{
    partial class FrmReparto
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvReparto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPersonaje = new System.Windows.Forms.TextBox();
            this.txtNombreActor = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.lblPersonaje = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(439, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 283);
            this.groupBox2.TabIndex = 8;
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
            // dgvReparto
            // 
            this.dgvReparto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReparto.Location = new System.Drawing.Point(24, 347);
            this.dgvReparto.Name = "dgvReparto";
            this.dgvReparto.Size = new System.Drawing.Size(621, 92);
            this.dgvReparto.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPersonaje);
            this.groupBox1.Controls.Add(this.txtNombreActor);
            this.groupBox1.Controls.Add(this.chkEstado);
            this.groupBox1.Controls.Add(this.lblPersonaje);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(49, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 282);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtPersonaje
            // 
            this.txtPersonaje.Location = new System.Drawing.Point(28, 141);
            this.txtPersonaje.Name = "txtPersonaje";
            this.txtPersonaje.Size = new System.Drawing.Size(240, 20);
            this.txtPersonaje.TabIndex = 4;
            // 
            // txtNombreActor
            // 
            this.txtNombreActor.Location = new System.Drawing.Point(28, 61);
            this.txtNombreActor.Name = "txtNombreActor";
            this.txtNombreActor.Size = new System.Drawing.Size(240, 20);
            this.txtNombreActor.TabIndex = 3;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(28, 217);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblPersonaje
            // 
            this.lblPersonaje.AutoSize = true;
            this.lblPersonaje.Location = new System.Drawing.Point(25, 114);
            this.lblPersonaje.Name = "lblPersonaje";
            this.lblPersonaje.Size = new System.Drawing.Size(54, 13);
            this.lblPersonaje.TabIndex = 1;
            this.lblPersonaje.Text = "Personaje";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.Location = new System.Drawing.Point(21, 331);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(85, 13);
            this.lblReparto.TabIndex = 11;
            this.lblReparto.Text = "Lista de Reparto";
            // 
            // FrmReparto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReparto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReparto);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmReparto";
            this.Text = "FrmReparto";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvReparto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPersonaje;
        private System.Windows.Forms.TextBox txtNombreActor;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label lblPersonaje;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblReparto;
    }
}