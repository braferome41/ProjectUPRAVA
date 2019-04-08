namespace ProyectoUprava.Vista
{
    partial class frmDatosReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosReserva));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtOcCancel = new System.Windows.Forms.RadioButton();
            this.rbtResCancel = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoCancel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxDarSalida = new System.Windows.Forms.GroupBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocSalid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListarReser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtOcupar = new System.Windows.Forms.RadioButton();
            this.rbtReservar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.txtFechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtFechaLlegada = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.gbxDarSalida.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.rbtOcCancel);
            this.groupBox2.Controls.Add(this.rbtResCancel);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDoCancel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(580, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 199);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // rbtOcCancel
            // 
            this.rbtOcCancel.AutoSize = true;
            this.rbtOcCancel.Location = new System.Drawing.Point(87, 97);
            this.rbtOcCancel.Name = "rbtOcCancel";
            this.rbtOcCancel.Size = new System.Drawing.Size(103, 24);
            this.rbtOcCancel.TabIndex = 16;
            this.rbtOcCancel.TabStop = true;
            this.rbtOcCancel.Text = "Ocupacion";
            this.rbtOcCancel.UseVisualStyleBackColor = true;
            // 
            // rbtResCancel
            // 
            this.rbtResCancel.AutoSize = true;
            this.rbtResCancel.Location = new System.Drawing.Point(87, 123);
            this.rbtResCancel.Name = "rbtResCancel";
            this.rbtResCancel.Size = new System.Drawing.Size(86, 24);
            this.rbtResCancel.TabIndex = 15;
            this.rbtResCancel.TabStop = true;
            this.rbtResCancel.Text = "Reserva";
            this.rbtResCancel.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cancelacion";
            // 
            // txtDoCancel
            // 
            this.txtDoCancel.Location = new System.Drawing.Point(58, 69);
            this.txtDoCancel.Name = "txtDoCancel";
            this.txtDoCancel.Size = new System.Drawing.Size(155, 26);
            this.txtDoCancel.TabIndex = 9;
            this.txtDoCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDatosReserva_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Documento";
            // 
            // gbxDarSalida
            // 
            this.gbxDarSalida.BackColor = System.Drawing.Color.White;
            this.gbxDarSalida.Controls.Add(this.btnSalida);
            this.gbxDarSalida.Controls.Add(this.label2);
            this.gbxDarSalida.Controls.Add(this.txtDocSalid);
            this.gbxDarSalida.Controls.Add(this.label1);
            this.gbxDarSalida.Location = new System.Drawing.Point(286, 279);
            this.gbxDarSalida.Name = "gbxDarSalida";
            this.gbxDarSalida.Size = new System.Drawing.Size(241, 199);
            this.gbxDarSalida.TabIndex = 26;
            this.gbxDarSalida.TabStop = false;
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(69, 153);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(99, 33);
            this.btnSalida.TabIndex = 13;
            this.btnSalida.Text = "Dar Salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dar Salida";
            // 
            // txtDocSalid
            // 
            this.txtDocSalid.Location = new System.Drawing.Point(39, 97);
            this.txtDocSalid.Name = "txtDocSalid";
            this.txtDocSalid.Size = new System.Drawing.Size(155, 26);
            this.txtDocSalid.TabIndex = 9;
            this.txtDocSalid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDatosReserva_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Documento";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(859, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(497, 243);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 26);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "...........";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Listar Habitaciones Ocupadas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnListarReser
            // 
            this.btnListarReser.Location = new System.Drawing.Point(310, 593);
            this.btnListarReser.Name = "btnListarReser";
            this.btnListarReser.Size = new System.Drawing.Size(170, 33);
            this.btnListarReser.TabIndex = 22;
            this.btnListarReser.Text = "Listar Reservas";
            this.btnListarReser.UseVisualStyleBackColor = true;
            this.btnListarReser.Click += new System.EventHandler(this.btnListarReser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtOcupar);
            this.groupBox1.Controls.Add(this.rbtReservar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.btnAsignar);
            this.groupBox1.Controls.Add(this.txtFechaSalida);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.txtFechaLlegada);
            this.groupBox1.Controls.Add(this.lblFechaLlegada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 389);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rbtOcupar
            // 
            this.rbtOcupar.AutoSize = true;
            this.rbtOcupar.Location = new System.Drawing.Point(54, 65);
            this.rbtOcupar.Name = "rbtOcupar";
            this.rbtOcupar.Size = new System.Drawing.Size(79, 24);
            this.rbtOcupar.TabIndex = 12;
            this.rbtOcupar.TabStop = true;
            this.rbtOcupar.Text = "Ocupar";
            this.rbtOcupar.UseVisualStyleBackColor = true;
            this.rbtOcupar.CheckedChanged += new System.EventHandler(this.rbtOcupar_CheckedChanged);
            // 
            // rbtReservar
            // 
            this.rbtReservar.AutoSize = true;
            this.rbtReservar.Location = new System.Drawing.Point(54, 44);
            this.rbtReservar.Name = "rbtReservar";
            this.rbtReservar.Size = new System.Drawing.Size(91, 24);
            this.rbtReservar.TabIndex = 11;
            this.rbtReservar.TabStop = true;
            this.rbtReservar.Text = "Reservar";
            this.rbtReservar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(21, 167);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(155, 73);
            this.txtObservaciones.TabIndex = 9;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(54, 350);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(99, 33);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(27, 318);
            this.txtFechaSalida.Mask = "00/00/0000 00:00";
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(149, 26);
            this.txtFechaSalida.TabIndex = 4;
            this.txtFechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(27, 115);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(155, 26);
            this.txtDocumento.TabIndex = 7;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDatosReserva_KeyPress);
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(27, 266);
            this.txtFechaLlegada.Mask = "00/00/0000 00:00";
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(149, 26);
            this.txtFechaLlegada.TabIndex = 0;
            this.txtFechaLlegada.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(39, 243);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(115, 20);
            this.lblFechaLlegada.TabIndex = 2;
            this.lblFechaLlegada.Text = "Fecha Llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(52, 295);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(102, 20);
            this.lblFechaSalida.TabIndex = 3;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asignar Habitacion";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(397, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatosReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(918, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxDarSalida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarReser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatosReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatosReserva";
            this.Load += new System.EventHandler(this.frmDatosReserva_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDatosReserva_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxDarSalida.ResumeLayout(false);
            this.gbxDarSalida.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtOcCancel;
        private System.Windows.Forms.RadioButton rbtResCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxDarSalida;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocSalid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListarReser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtOcupar;
        private System.Windows.Forms.RadioButton rbtReservar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.MaskedTextBox txtFechaSalida;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.MaskedTextBox txtFechaLlegada;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}