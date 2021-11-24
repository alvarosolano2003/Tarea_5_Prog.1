
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudInteres = new System.Windows.Forms.NumericUpDown();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrestamo = new System.Windows.Forms.NumericUpDown();
            this.nudTerminos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpPago = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCPagada = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPagada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblPrincipal";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(111, 33);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(59, 13);
            this.lblInteres.TabIndex = 1;
            this.lblInteres.Text = "Interes (%):";
            // 
            // lblTerminos
            // 
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.Location = new System.Drawing.Point(191, 33);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(86, 13);
            this.lblTerminos.TabIndex = 2;
            this.lblTerminos.Text = "Terminos (Años):";
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(7, 143);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(781, 227);
            this.dgvPrestamo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(654, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 27);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudInteres
            // 
            this.nudInteres.Location = new System.Drawing.Point(104, 51);
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
            this.nudInteres.Size = new System.Drawing.Size(75, 20);
            this.nudInteres.TabIndex = 9;
            this.nudInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(117, 23);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vencimiento";
            // 
            // nudPrestamo
            // 
            this.nudPrestamo.Location = new System.Drawing.Point(14, 51);
            this.nudPrestamo.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudPrestamo.Name = "nudPrestamo";
            this.nudPrestamo.Size = new System.Drawing.Size(75, 20);
            this.nudPrestamo.TabIndex = 12;
            // 
            // nudTerminos
            // 
            this.nudTerminos.Location = new System.Drawing.Point(194, 51);
            this.nudTerminos.Name = "nudTerminos";
            this.nudTerminos.Size = new System.Drawing.Size(75, 20);
            this.nudTerminos.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCPagada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudTerminos);
            this.groupBox1.Controls.Add(this.nudPrestamo);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Controls.Add(this.nudInteres);
            this.groupBox1.Controls.Add(this.lblTerminos);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 132);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Prestamo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpPago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpVencimiento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(287, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechas";
            // 
            // dtpPago
            // 
            this.dtpPago.Location = new System.Drawing.Point(117, 56);
            this.dtpPago.Name = "dtpPago";
            this.dtpPago.Size = new System.Drawing.Size(200, 20);
            this.dtpPago.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pago";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(655, 56);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(133, 23);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "Filtrar por:";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Pendiente",
            "Pagado",
            "Eliminado"});
            this.cmbSelect.Location = new System.Drawing.Point(655, 86);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(133, 21);
            this.cmbSelect.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cuota pagada:";
            // 
            // nudCPagada
            // 
            this.nudCPagada.Location = new System.Drawing.Point(104, 99);
            this.nudCPagada.Name = "nudCPagada";
            this.nudCPagada.Size = new System.Drawing.Size(75, 20);
            this.nudCPagada.TabIndex = 16;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvPrestamo);
            this.Name = "FrmPrestamo";
            this.Text = "Formulario de Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCPagada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTerminos;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudInteres;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrestamo;
        private System.Windows.Forms.NumericUpDown nudTerminos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.NumericUpDown nudCPagada;
        private System.Windows.Forms.Label label4;
    }
}