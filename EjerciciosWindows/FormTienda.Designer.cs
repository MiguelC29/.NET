namespace EjerciciosWindows
{
    partial class FormTienda
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTienda = new System.Windows.Forms.ComboBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtVCompra = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienda1 = new System.Windows.Forms.TextBox();
            this.txtTienda2 = new System.Windows.Forms.TextBox();
            this.txtTienda3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtArticulo3 = new System.Windows.Forms.TextBox();
            this.txtArticulo2 = new System.Windows.Forms.TextBox();
            this.txtArticulo1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtVentasTotales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjerciciosWindows.Properties.Resources.tienda;
            this.pictureBox1.Location = new System.Drawing.Point(36, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.txtVCompra);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.cmbArticulo);
            this.groupBox1.Controls.Add(this.cmbTienda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprar Artículos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARTÍCULO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VALOR COMPRA";
            // 
            // cmbTienda
            // 
            this.cmbTienda.FormattingEnabled = true;
            this.cmbTienda.Items.AddRange(new object[] {
            "Tienda 1",
            "Tienda 2",
            "Tienda 3"});
            this.cmbTienda.Location = new System.Drawing.Point(138, 38);
            this.cmbTienda.Name = "cmbTienda";
            this.cmbTienda.Size = new System.Drawing.Size(121, 21);
            this.cmbTienda.TabIndex = 4;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Items.AddRange(new object[] {
            "Artículo 1",
            "Artículo 2",
            "Artículo 3"});
            this.cmbArticulo.Location = new System.Drawing.Point(138, 73);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(121, 21);
            this.cmbArticulo.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(138, 109);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtVCompra
            // 
            this.txtVCompra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVCompra.Location = new System.Drawing.Point(138, 146);
            this.txtVCompra.Name = "txtVCompra";
            this.txtVCompra.ReadOnly = true;
            this.txtVCompra.Size = new System.Drawing.Size(121, 20);
            this.txtVCompra.TabIndex = 7;
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(101, 200);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 30);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.txtTienda3);
            this.groupBox2.Controls.Add(this.txtTienda2);
            this.groupBox2.Controls.Add(this.txtTienda1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(354, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas Tienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tienda 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tienda 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tienda 3";
            // 
            // txtTienda1
            // 
            this.txtTienda1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTienda1.Location = new System.Drawing.Point(85, 31);
            this.txtTienda1.Name = "txtTienda1";
            this.txtTienda1.ReadOnly = true;
            this.txtTienda1.Size = new System.Drawing.Size(100, 20);
            this.txtTienda1.TabIndex = 3;
            // 
            // txtTienda2
            // 
            this.txtTienda2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTienda2.Location = new System.Drawing.Point(85, 58);
            this.txtTienda2.Name = "txtTienda2";
            this.txtTienda2.ReadOnly = true;
            this.txtTienda2.Size = new System.Drawing.Size(100, 20);
            this.txtTienda2.TabIndex = 4;
            // 
            // txtTienda3
            // 
            this.txtTienda3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTienda3.Location = new System.Drawing.Point(85, 84);
            this.txtTienda3.Name = "txtTienda3";
            this.txtTienda3.ReadOnly = true;
            this.txtTienda3.Size = new System.Drawing.Size(100, 20);
            this.txtTienda3.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.txtArticulo3);
            this.groupBox3.Controls.Add(this.txtArticulo2);
            this.groupBox3.Controls.Add(this.txtArticulo1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(354, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ventas Artículos";
            // 
            // txtArticulo3
            // 
            this.txtArticulo3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtArticulo3.Location = new System.Drawing.Point(85, 84);
            this.txtArticulo3.Name = "txtArticulo3";
            this.txtArticulo3.ReadOnly = true;
            this.txtArticulo3.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo3.TabIndex = 5;
            // 
            // txtArticulo2
            // 
            this.txtArticulo2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtArticulo2.Location = new System.Drawing.Point(85, 58);
            this.txtArticulo2.Name = "txtArticulo2";
            this.txtArticulo2.ReadOnly = true;
            this.txtArticulo2.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo2.TabIndex = 4;
            // 
            // txtArticulo1
            // 
            this.txtArticulo1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtArticulo1.Location = new System.Drawing.Point(85, 31);
            this.txtArticulo1.Name = "txtArticulo1";
            this.txtArticulo1.ReadOnly = true;
            this.txtArticulo1.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Artículo 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Artículo 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Artículo 1";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox4.Controls.Add(this.txtVentasTotales);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(354, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 69);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ventas Totales";
            // 
            // txtVentasTotales
            // 
            this.txtVentasTotales.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVentasTotales.Location = new System.Drawing.Point(94, 28);
            this.txtVentasTotales.Name = "txtVentasTotales";
            this.txtVentasTotales.ReadOnly = true;
            this.txtVentasTotales.Size = new System.Drawing.Size(100, 20);
            this.txtVentasTotales.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ventas totales";
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(294, 519);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(98, 35);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Ir a inicio...";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // FormTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 597);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTienda";
            this.Text = "FormTienda";
            this.Load += new System.EventHandler(this.FormTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtVCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.ComboBox cmbTienda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTienda3;
        private System.Windows.Forms.TextBox txtTienda2;
        private System.Windows.Forms.TextBox txtTienda1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArticulo3;
        private System.Windows.Forms.TextBox txtArticulo2;
        private System.Windows.Forms.TextBox txtArticulo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtVentasTotales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInicio;
    }
}