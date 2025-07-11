namespace ej1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            tbIngresoNumero = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lbValorABuscar = new Label();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnMaximoMinimo = new Button();
            lbMinimo = new Label();
            lbMaximo = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox4 = new GroupBox();
            btnPromedio = new Button();
            lbPromedio = new Label();
            label5 = new Label();
            groupBox5 = new GroupBox();
            btnCantidad = new Button();
            lbCantidadIngreso = new Label();
            label6 = new Label();
            groupBox6 = new GroupBox();
            btnListaSuperiorAlPromedio = new Button();
            btnMostrarListaOrdenada = new Button();
            lsbMostrarIngresados = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbIngresoNumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar un número";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(122, 90);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(193, 52);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar número";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbIngresoNumero
            // 
            tbIngresoNumero.Location = new Point(202, 36);
            tbIngresoNumero.Name = "tbIngresoNumero";
            tbIngresoNumero.Size = new Size(142, 34);
            tbIngresoNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 39);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbValorABuscar);
            groupBox2.Controls.Add(tbBuscar);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(513, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar valor";
            // 
            // lbValorABuscar
            // 
            lbValorABuscar.BackColor = SystemColors.ActiveCaption;
            lbValorABuscar.Location = new Point(184, 88);
            lbValorABuscar.Name = "lbValorABuscar";
            lbValorABuscar.Size = new Size(47, 34);
            lbValorABuscar.TabIndex = 3;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(166, 36);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(83, 34);
            tbBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(278, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 47);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 0;
            label2.Text = "Valor a buscar:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMaximoMinimo);
            groupBox3.Controls.Add(lbMinimo);
            groupBox3.Controls.Add(lbMaximo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(12, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 147);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar máximo y mínimo";
            // 
            // btnMaximoMinimo
            // 
            btnMaximoMinimo.Location = new Point(275, 61);
            btnMaximoMinimo.Name = "btnMaximoMinimo";
            btnMaximoMinimo.Size = new Size(149, 45);
            btnMaximoMinimo.TabIndex = 4;
            btnMaximoMinimo.Text = "Actualizar";
            btnMaximoMinimo.UseVisualStyleBackColor = true;
            btnMaximoMinimo.Click += btnMaximoMinimo_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.BackColor = SystemColors.ActiveCaption;
            lbMinimo.Location = new Point(159, 97);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(70, 28);
            lbMinimo.TabIndex = 3;
            // 
            // lbMaximo
            // 
            lbMaximo.BackColor = SystemColors.ActiveCaption;
            lbMaximo.Location = new Point(159, 49);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(70, 28);
            lbMaximo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 97);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 1;
            label4.Text = "Valor mínimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 49);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 0;
            label3.Text = "Valor máximo:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnPromedio);
            groupBox4.Controls.Add(lbPromedio);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(12, 378);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(468, 107);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Procesar promedio";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(275, 37);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(149, 45);
            btnPromedio.TabIndex = 5;
            btnPromedio.Text = "Actualizar";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(159, 45);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(70, 28);
            lbPromedio.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 45);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 0;
            label5.Text = "Promedio:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnCantidad);
            groupBox5.Controls.Add(lbCantidadIngreso);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(12, 509);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(468, 100);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mostrar cantidad de ingresados";
            // 
            // btnCantidad
            // 
            btnCantidad.Location = new Point(275, 38);
            btnCantidad.Name = "btnCantidad";
            btnCantidad.Size = new Size(149, 45);
            btnCantidad.TabIndex = 6;
            btnCantidad.Text = "Actualizar";
            btnCantidad.UseVisualStyleBackColor = true;
            btnCantidad.Click += btnCantidad_Click;
            // 
            // lbCantidadIngreso
            // 
            lbCantidadIngreso.BackColor = SystemColors.ActiveCaption;
            lbCantidadIngreso.Location = new Point(159, 46);
            lbCantidadIngreso.Name = "lbCantidadIngreso";
            lbCantidadIngreso.Size = new Size(70, 28);
            lbCantidadIngreso.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 46);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 5;
            label6.Text = "Cantidad:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnListaSuperiorAlPromedio);
            groupBox6.Controls.Add(btnMostrarListaOrdenada);
            groupBox6.Controls.Add(lsbMostrarIngresados);
            groupBox6.Location = new Point(513, 208);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(397, 401);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mostrar cantidad de ingresados";
            // 
            // btnListaSuperiorAlPromedio
            // 
            btnListaSuperiorAlPromedio.Location = new Point(268, 156);
            btnListaSuperiorAlPromedio.Name = "btnListaSuperiorAlPromedio";
            btnListaSuperiorAlPromedio.Size = new Size(123, 121);
            btnListaSuperiorAlPromedio.TabIndex = 2;
            btnListaSuperiorAlPromedio.Text = "Mostrar lista superior al promedio";
            btnListaSuperiorAlPromedio.UseVisualStyleBackColor = true;
            btnListaSuperiorAlPromedio.Click += btnListaSuperiorAlPromedio_Click;
            // 
            // btnMostrarListaOrdenada
            // 
            btnMostrarListaOrdenada.Location = new Point(268, 37);
            btnMostrarListaOrdenada.Name = "btnMostrarListaOrdenada";
            btnMostrarListaOrdenada.Size = new Size(123, 96);
            btnMostrarListaOrdenada.TabIndex = 1;
            btnMostrarListaOrdenada.Text = "Mostrar lista ordenada";
            btnMostrarListaOrdenada.UseVisualStyleBackColor = true;
            btnMostrarListaOrdenada.Click += btnMostrarListaOrdenada_Click;
            // 
            // lsbMostrarIngresados
            // 
            lsbMostrarIngresados.FormattingEnabled = true;
            lsbMostrarIngresados.ItemHeight = 28;
            lsbMostrarIngresados.Location = new Point(22, 37);
            lsbMostrarIngresados.Name = "lsbMostrarIngresados";
            lsbMostrarIngresados.Size = new Size(227, 340);
            lsbMostrarIngresados.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 621);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Ejercicio 1. Introducción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox tbIngresoNumero;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnBuscar;
        private Label label2;
        private Label lbValorABuscar;
        private TextBox tbBuscar;
        private GroupBox groupBox3;
        private Button btnMaximoMinimo;
        private Label lbMinimo;
        private Label lbMaximo;
        private Label label4;
        private Label label3;
        private GroupBox groupBox4;
        private Button btnPromedio;
        private Label lbPromedio;
        private Label label5;
        private GroupBox groupBox5;
        private Button btnCantidad;
        private Label lbCantidadIngreso;
        private Label label6;
        private GroupBox groupBox6;
        private Button btnMostrarListaOrdenada;
        private ListBox lsbMostrarIngresados;
        private Button btnListaSuperiorAlPromedio;
    }
}
