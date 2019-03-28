namespace ProyectoUprava.Vista
{
    partial class frmVehiculo
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
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDocRegis = new System.Windows.Forms.TextBox();
            this.btnRegisVehi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtElimPlac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxRegistro = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListarVehiculos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.gbxRegistro.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(23, 290);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.Size = new System.Drawing.Size(693, 212);
            this.dgvVehiculo.TabIndex = 0;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(87, 175);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(151, 26);
            this.txtPlaca.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Placa: ";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(87, 143);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(151, 26);
            this.txtMarca.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Marca: ";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(87, 111);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(151, 26);
            this.txtTipo.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tipo: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Registrar Vehiculo";
            // 
            // txtDocRegis
            // 
            this.txtDocRegis.Location = new System.Drawing.Point(243, 62);
            this.txtDocRegis.Name = "txtDocRegis";
            this.txtDocRegis.Size = new System.Drawing.Size(151, 26);
            this.txtDocRegis.TabIndex = 18;
            // 
            // btnRegisVehi
            // 
            this.btnRegisVehi.Location = new System.Drawing.Point(260, 124);
            this.btnRegisVehi.Name = "btnRegisVehi";
            this.btnRegisVehi.Size = new System.Drawing.Size(146, 31);
            this.btnRegisVehi.TabIndex = 18;
            this.btnRegisVehi.Text = "Registrar ";
            this.btnRegisVehi.UseVisualStyleBackColor = true;
            this.btnRegisVehi.Click += new System.EventHandler(this.btnRegisVehi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Documento del Propietario: ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(260, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(146, 31);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Eliminar Vehiculo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 31);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtElimPlac
            // 
            this.txtElimPlac.Location = new System.Drawing.Point(86, 91);
            this.txtElimPlac.Name = "txtElimPlac";
            this.txtElimPlac.Size = new System.Drawing.Size(151, 26);
            this.txtElimPlac.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Placa: ";
            // 
            // gbxRegistro
            // 
            this.gbxRegistro.Controls.Add(this.btnActualizar);
            this.gbxRegistro.Controls.Add(this.txtPlaca);
            this.gbxRegistro.Controls.Add(this.label14);
            this.gbxRegistro.Controls.Add(this.txtMarca);
            this.gbxRegistro.Controls.Add(this.label10);
            this.gbxRegistro.Controls.Add(this.label13);
            this.gbxRegistro.Controls.Add(this.label11);
            this.gbxRegistro.Controls.Add(this.txtTipo);
            this.gbxRegistro.Controls.Add(this.btnRegisVehi);
            this.gbxRegistro.Controls.Add(this.label12);
            this.gbxRegistro.Controls.Add(this.txtDocRegis);
            this.gbxRegistro.Location = new System.Drawing.Point(11, 14);
            this.gbxRegistro.Name = "gbxRegistro";
            this.gbxRegistro.Size = new System.Drawing.Size(426, 217);
            this.gbxRegistro.TabIndex = 35;
            this.gbxRegistro.TabStop = false;
            this.gbxRegistro.Text = "Registro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.txtElimPlac);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(445, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 217);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(142, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 31);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListarVehiculos
            // 
            this.btnListarVehiculos.Location = new System.Drawing.Point(271, 247);
            this.btnListarVehiculos.Name = "btnListarVehiculos";
            this.btnListarVehiculos.Size = new System.Drawing.Size(208, 37);
            this.btnListarVehiculos.TabIndex = 26;
            this.btnListarVehiculos.Text = "ListarVehiculos";
            this.btnListarVehiculos.UseVisualStyleBackColor = true;
            this.btnListarVehiculos.Click += new System.EventHandler(this.btnListarVehiculos_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 514);
            this.Controls.Add(this.btnListarVehiculos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxRegistro);
            this.Controls.Add(this.dgvVehiculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVehiculo";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.gbxRegistro.ResumeLayout(false);
            this.gbxRegistro.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDocRegis;
        private System.Windows.Forms.Button btnRegisVehi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtElimPlac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxRegistro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListarVehiculos;
        private System.Windows.Forms.Button btnBuscar;
    }
}