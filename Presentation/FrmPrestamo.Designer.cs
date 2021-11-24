
namespace Presentation
{
    partial class FrmPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblTerminos = new System.Windows.Forms.Label();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.txtTerminos = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBusquedaEstado = new System.Windows.Forms.Button();
            this.btnBusquedaTotalPrincipal = new System.Windows.Forms.Button();
            this.btnBusquedaInteres = new System.Windows.Forms.Button();
            this.nudInteres = new System.Windows.Forms.NumericUpDown();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMontoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMontoPorPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblPrincipal";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(60, 82);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(42, 13);
            this.lblInteres.TabIndex = 1;
            this.lblInteres.Text = "Interes:";
            // 
            // lblTerminos
            // 
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Location = new System.Drawing.Point(60, 113);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(53, 13);
            this.lblTerminos.TabIndex = 2;
            this.lblTerminos.Text = "Terminos:";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnEstado,
            this.columnMontoPrestamo,
            this.columnInteres,
            this.columnFechaPago,
            this.columnFechaVencimiento,
            this.columnMontoPorPagar});
            this.dgvPrestamo.Location = new System.Drawing.Point(7, 143);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(781, 227);
            this.dgvPrestamo.TabIndex = 3;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(125, 38);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(121, 20);
            this.txtPrestamo.TabIndex = 5;
            // 
            // txtTerminos
            // 
            this.txtTerminos.Location = new System.Drawing.Point(125, 106);
            this.txtTerminos.Name = "txtTerminos";
            this.txtTerminos.Size = new System.Drawing.Size(121, 20);
            this.txtTerminos.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaEstado);
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaTotalPrincipal);
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaInteres);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(539, 376);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 62);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(293, 61);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 45);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaEstado
            // 
            this.btnBusquedaEstado.Location = new System.Drawing.Point(3, 3);
            this.btnBusquedaEstado.Name = "btnBusquedaEstado";
            this.btnBusquedaEstado.Size = new System.Drawing.Size(75, 53);
            this.btnBusquedaEstado.TabIndex = 9;
            this.btnBusquedaEstado.Text = "Busqueda Por Estado";
            this.btnBusquedaEstado.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaTotalPrincipal
            // 
            this.btnBusquedaTotalPrincipal.Location = new System.Drawing.Point(84, 3);
            this.btnBusquedaTotalPrincipal.Name = "btnBusquedaTotalPrincipal";
            this.btnBusquedaTotalPrincipal.Size = new System.Drawing.Size(75, 53);
            this.btnBusquedaTotalPrincipal.TabIndex = 10;
            this.btnBusquedaTotalPrincipal.Text = "Busqueda por total principal";
            this.btnBusquedaTotalPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnBusquedaInteres
            // 
            this.btnBusquedaInteres.Location = new System.Drawing.Point(165, 3);
            this.btnBusquedaInteres.Name = "btnBusquedaInteres";
            this.btnBusquedaInteres.Size = new System.Drawing.Size(75, 53);
            this.btnBusquedaInteres.TabIndex = 11;
            this.btnBusquedaInteres.Text = "Busqueda por total de interes";
            this.btnBusquedaInteres.UseVisualStyleBackColor = true;
            // 
            // nudInteres
            // 
            this.nudInteres.Location = new System.Drawing.Point(126, 75);
            this.nudInteres.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudInteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInteres.Name = "nudInteres";
            this.nudInteres.Size = new System.Drawing.Size(120, 20);
            this.nudInteres.TabIndex = 9;
            this.nudInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            // 
            // columnEstado
            // 
            this.columnEstado.HeaderText = "Estado";
            this.columnEstado.Name = "columnEstado";
            // 
            // columnMontoPrestamo
            // 
            this.columnMontoPrestamo.HeaderText = "Monto del prestamo";
            this.columnMontoPrestamo.Name = "columnMontoPrestamo";
            // 
            // columnInteres
            // 
            this.columnInteres.HeaderText = "Interes";
            this.columnInteres.Name = "columnInteres";
            // 
            // columnFechaPago
            // 
            this.columnFechaPago.HeaderText = "Fecha de pago";
            this.columnFechaPago.Name = "columnFechaPago";
            // 
            // columnFechaVencimiento
            // 
            this.columnFechaVencimiento.HeaderText = "Fecha de vencimiento";
            this.columnFechaVencimiento.Name = "columnFechaVencimiento";
            // 
            // columnMontoPorPagar
            // 
            this.columnMontoPorPagar.HeaderText = "Monto por pagar";
            this.columnMontoPorPagar.Name = "columnMontoPorPagar";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudInteres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtTerminos);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.lblTerminos);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTerminos;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.TextBox txtTerminos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBusquedaEstado;
        private System.Windows.Forms.Button btnBusquedaTotalPrincipal;
        private System.Windows.Forms.Button btnBusquedaInteres;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMontoPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMontoPorPagar;
    }
}