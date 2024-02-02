namespace cine_presentacion_windows.Pedido
{
    partial class FrmPedido
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
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.lblPedidoValor = new System.Windows.Forms.Label();
            this.txtPedidoValor = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblListar = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.chkEstadoPedido = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvpedido
            // 
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.Location = new System.Drawing.Point(23, 311);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.Size = new System.Drawing.Size(611, 127);
            this.dgvpedido.TabIndex = 0;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(96, 36);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 1;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(-3, 42);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(88, 13);
            this.lblFechaPedido.TabIndex = 3;
            this.lblFechaPedido.Text = "Fecha de Pedido";
            // 
            // lblPedidoValor
            // 
            this.lblPedidoValor.AutoSize = true;
            this.lblPedidoValor.Location = new System.Drawing.Point(2, 135);
            this.lblPedidoValor.Name = "lblPedidoValor";
            this.lblPedidoValor.Size = new System.Drawing.Size(83, 13);
            this.lblPedidoValor.TabIndex = 5;
            this.lblPedidoValor.Text = "Valor del pedido";
            // 
            // txtPedidoValor
            // 
            this.txtPedidoValor.Location = new System.Drawing.Point(91, 135);
            this.txtPedidoValor.Name = "txtPedidoValor";
            this.txtPedidoValor.Size = new System.Drawing.Size(222, 20);
            this.txtPedidoValor.TabIndex = 6;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(332, 138);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(62, 17);
            this.chkEstado.TabIndex = 7;
            this.chkEstado.Text = "Estado ";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(483, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 259);
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
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Location = new System.Drawing.Point(32, 290);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(87, 17);
            this.lblListar.TabIndex = 10;
            this.lblListar.Text = "Lista de pedidos";
            this.lblListar.UseCompatibleTextRendering = true;
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.chkEstadoPedido);
            this.grupo.Controls.Add(this.chkEstado);
            this.grupo.Controls.Add(this.txtPedidoValor);
            this.grupo.Controls.Add(this.lblPedidoValor);
            this.grupo.Controls.Add(this.lblFechaPedido);
            this.grupo.Controls.Add(this.dtpFechaPedido);
            this.grupo.Location = new System.Drawing.Point(23, 28);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(429, 259);
            this.grupo.TabIndex = 11;
            this.grupo.TabStop = false;
            // 
            // chkEstadoPedido
            // 
            this.chkEstadoPedido.AutoSize = true;
            this.chkEstadoPedido.Location = new System.Drawing.Point(323, 39);
            this.chkEstadoPedido.Name = "chkEstadoPedido";
            this.chkEstadoPedido.Size = new System.Drawing.Size(100, 17);
            this.chkEstadoPedido.TabIndex = 8;
            this.chkEstadoPedido.Text = "Esta solicitado?";
            this.chkEstadoPedido.UseVisualStyleBackColor = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvpedido);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.Label lblPedidoValor;
        private System.Windows.Forms.TextBox txtPedidoValor;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.CheckBox chkEstadoPedido;
    }
}