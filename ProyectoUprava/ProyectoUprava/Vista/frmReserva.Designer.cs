namespace ProyectoUprava.Vista
{
    partial class frmReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgHabitacion = new System.Windows.Forms.DataGridView();
            this.NumHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHabitacion
            // 
            this.dgHabitacion.AllowUserToAddRows = false;
            this.dgHabitacion.AllowUserToDeleteRows = false;
            this.dgHabitacion.BackgroundColor = System.Drawing.Color.Gray;
            this.dgHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumHabitacion,
            this.Tipo,
            this.Estado,
            this.IdHabitacion});
            this.dgHabitacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHabitacion.GridColor = System.Drawing.Color.Silver;
            this.dgHabitacion.Location = new System.Drawing.Point(0, 0);
            this.dgHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgHabitacion.Name = "dgHabitacion";
            this.dgHabitacion.ReadOnly = true;
            this.dgHabitacion.Size = new System.Drawing.Size(473, 434);
            this.dgHabitacion.TabIndex = 17;
            this.dgHabitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHabitacion_CellClick);
            // 
            // NumHabitacion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.NumHabitacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.NumHabitacion.HeaderText = "Numero Habitacion";
            this.NumHabitacion.Name = "NumHabitacion";
            this.NumHabitacion.ReadOnly = true;
            // 
            // Tipo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // Estado
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 150;
            // 
            // IdHabitacion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.IdHabitacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.IdHabitacion.HeaderText = "IdHabitacion";
            this.IdHabitacion.Name = "IdHabitacion";
            this.IdHabitacion.ReadOnly = true;
            this.IdHabitacion.Visible = false;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 434);
            this.Controls.Add(this.dgHabitacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHabitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHabitacion;
    }
}