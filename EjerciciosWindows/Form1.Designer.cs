namespace EjerciciosWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComparendo = new System.Windows.Forms.Button();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.comboBoxCuadrante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtC1TotalMul = new System.Windows.Forms.TextBox();
            this.txtC1MultaP = new System.Windows.Forms.TextBox();
            this.txtC1Infracciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtC2TotalMul = new System.Windows.Forms.TextBox();
            this.txtC2MultaP = new System.Windows.Forms.TextBox();
            this.txtC2Infracciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtC3TotalMul = new System.Windows.Forms.TextBox();
            this.txtC3MultaP = new System.Windows.Forms.TextBox();
            this.txtC3Infracciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtC4TotalMul = new System.Windows.Forms.TextBox();
            this.txtC4MultaP = new System.Windows.Forms.TextBox();
            this.txtC4Infracciones = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnComparendo);
            this.groupBox1.Controls.Add(this.txtVelocidad);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.comboBoxCuadrante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Comparendo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "2.000";
            // 
            // btnComparendo
            // 
            this.btnComparendo.Location = new System.Drawing.Point(100, 155);
            this.btnComparendo.Name = "btnComparendo";
            this.btnComparendo.Size = new System.Drawing.Size(75, 23);
            this.btnComparendo.TabIndex = 7;
            this.btnComparendo.Text = "Comparendo";
            this.btnComparendo.UseVisualStyleBackColor = true;
            this.btnComparendo.Click += new System.EventHandler(this.btnComparendo_Click);
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(148, 89);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(121, 20);
            this.txtVelocidad.TabIndex = 6;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(148, 61);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 5;
            // 
            // comboBoxCuadrante
            // 
            this.comboBoxCuadrante.FormattingEnabled = true;
            this.comboBoxCuadrante.Items.AddRange(new object[] {
            "Cuadrante 1",
            "Cuadrante 2",
            "Cuadrante 3",
            "Cuadrante 4"});
            this.comboBoxCuadrante.Location = new System.Drawing.Point(148, 29);
            this.comboBoxCuadrante.Name = "comboBoxCuadrante";
            this.comboBoxCuadrante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCuadrante.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Multa establecida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuadrante:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMultas);
            this.groupBox2.Location = new System.Drawing.Point(324, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver Multas";
            // 
            // dgvMultas
            // 
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Placa,
            this.Velocidad,
            this.VelLimite,
            this.Multa});
            this.dgvMultas.Location = new System.Drawing.Point(15, 19);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.Size = new System.Drawing.Size(443, 150);
            this.dgvMultas.TabIndex = 0;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // Velocidad
            // 
            this.Velocidad.HeaderText = "Velocidad";
            this.Velocidad.Name = "Velocidad";
            // 
            // VelLimite
            // 
            this.VelLimite.HeaderText = "Vel limite";
            this.VelLimite.Name = "VelLimite";
            // 
            // Multa
            // 
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.txtC1TotalMul);
            this.groupBox3.Controls.Add(this.txtC1MultaP);
            this.groupBox3.Controls.Add(this.txtC1Infracciones);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(75, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuadrante 1";
            // 
            // txtC1TotalMul
            // 
            this.txtC1TotalMul.Location = new System.Drawing.Point(139, 110);
            this.txtC1TotalMul.Name = "txtC1TotalMul";
            this.txtC1TotalMul.ReadOnly = true;
            this.txtC1TotalMul.Size = new System.Drawing.Size(100, 20);
            this.txtC1TotalMul.TabIndex = 5;
            // 
            // txtC1MultaP
            // 
            this.txtC1MultaP.Location = new System.Drawing.Point(139, 72);
            this.txtC1MultaP.Name = "txtC1MultaP";
            this.txtC1MultaP.ReadOnly = true;
            this.txtC1MultaP.Size = new System.Drawing.Size(100, 20);
            this.txtC1MultaP.TabIndex = 4;
            // 
            // txtC1Infracciones
            // 
            this.txtC1Infracciones.Location = new System.Drawing.Point(139, 34);
            this.txtC1Infracciones.Name = "txtC1Infracciones";
            this.txtC1Infracciones.ReadOnly = true;
            this.txtC1Infracciones.Size = new System.Drawing.Size(36, 20);
            this.txtC1Infracciones.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Multas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Multa Promedio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Infracciones";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox4.Controls.Add(this.txtC2TotalMul);
            this.groupBox4.Controls.Add(this.txtC2MultaP);
            this.groupBox4.Controls.Add(this.txtC2Infracciones);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(501, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 164);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cuadrante 2";
            // 
            // txtC2TotalMul
            // 
            this.txtC2TotalMul.Location = new System.Drawing.Point(139, 110);
            this.txtC2TotalMul.Name = "txtC2TotalMul";
            this.txtC2TotalMul.ReadOnly = true;
            this.txtC2TotalMul.Size = new System.Drawing.Size(100, 20);
            this.txtC2TotalMul.TabIndex = 5;
            // 
            // txtC2MultaP
            // 
            this.txtC2MultaP.Location = new System.Drawing.Point(139, 72);
            this.txtC2MultaP.Name = "txtC2MultaP";
            this.txtC2MultaP.ReadOnly = true;
            this.txtC2MultaP.Size = new System.Drawing.Size(100, 20);
            this.txtC2MultaP.TabIndex = 4;
            // 
            // txtC2Infracciones
            // 
            this.txtC2Infracciones.Location = new System.Drawing.Point(139, 34);
            this.txtC2Infracciones.Name = "txtC2Infracciones";
            this.txtC2Infracciones.ReadOnly = true;
            this.txtC2Infracciones.Size = new System.Drawing.Size(37, 20);
            this.txtC2Infracciones.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total Multas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Multa Promedio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Infracciones";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox5.Controls.Add(this.txtC3TotalMul);
            this.groupBox5.Controls.Add(this.txtC3MultaP);
            this.groupBox5.Controls.Add(this.txtC3Infracciones);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(75, 441);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(269, 164);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cuadrante 3";
            // 
            // txtC3TotalMul
            // 
            this.txtC3TotalMul.Location = new System.Drawing.Point(139, 110);
            this.txtC3TotalMul.Name = "txtC3TotalMul";
            this.txtC3TotalMul.ReadOnly = true;
            this.txtC3TotalMul.Size = new System.Drawing.Size(100, 20);
            this.txtC3TotalMul.TabIndex = 5;
            // 
            // txtC3MultaP
            // 
            this.txtC3MultaP.Location = new System.Drawing.Point(139, 72);
            this.txtC3MultaP.Name = "txtC3MultaP";
            this.txtC3MultaP.ReadOnly = true;
            this.txtC3MultaP.Size = new System.Drawing.Size(100, 20);
            this.txtC3MultaP.TabIndex = 4;
            // 
            // txtC3Infracciones
            // 
            this.txtC3Infracciones.Location = new System.Drawing.Point(139, 34);
            this.txtC3Infracciones.Name = "txtC3Infracciones";
            this.txtC3Infracciones.ReadOnly = true;
            this.txtC3Infracciones.Size = new System.Drawing.Size(36, 20);
            this.txtC3Infracciones.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total Multas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Multa Promedio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Infracciones";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox6.Controls.Add(this.txtC4TotalMul);
            this.groupBox6.Controls.Add(this.txtC4MultaP);
            this.groupBox6.Controls.Add(this.txtC4Infracciones);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Location = new System.Drawing.Point(501, 441);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(269, 164);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cuadrante 4";
            // 
            // txtC4TotalMul
            // 
            this.txtC4TotalMul.Location = new System.Drawing.Point(139, 110);
            this.txtC4TotalMul.Name = "txtC4TotalMul";
            this.txtC4TotalMul.ReadOnly = true;
            this.txtC4TotalMul.Size = new System.Drawing.Size(100, 20);
            this.txtC4TotalMul.TabIndex = 5;
            // 
            // txtC4MultaP
            // 
            this.txtC4MultaP.Location = new System.Drawing.Point(139, 72);
            this.txtC4MultaP.Name = "txtC4MultaP";
            this.txtC4MultaP.ReadOnly = true;
            this.txtC4MultaP.Size = new System.Drawing.Size(100, 20);
            this.txtC4MultaP.TabIndex = 4;
            // 
            // txtC4Infracciones
            // 
            this.txtC4Infracciones.Location = new System.Drawing.Point(139, 34);
            this.txtC4Infracciones.Name = "txtC4Infracciones";
            this.txtC4Infracciones.ReadOnly = true;
            this.txtC4Infracciones.Size = new System.Drawing.Size(37, 20);
            this.txtC4Infracciones.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total Multas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Multa Promedio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Total Infracciones";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Black;
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReiniciar.Location = new System.Drawing.Point(369, 633);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(812, 685);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Comparendos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComparendo;
        private System.Windows.Forms.TextBox txtVelocidad;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.ComboBox comboBoxCuadrante;
        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtC1TotalMul;
        private System.Windows.Forms.TextBox txtC1MultaP;
        private System.Windows.Forms.TextBox txtC1Infracciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtC2TotalMul;
        private System.Windows.Forms.TextBox txtC2MultaP;
        private System.Windows.Forms.TextBox txtC2Infracciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtC3TotalMul;
        private System.Windows.Forms.TextBox txtC3MultaP;
        private System.Windows.Forms.TextBox txtC3Infracciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtC4TotalMul;
        private System.Windows.Forms.TextBox txtC4MultaP;
        private System.Windows.Forms.TextBox txtC4Infracciones;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

