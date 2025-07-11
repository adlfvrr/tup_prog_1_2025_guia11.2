namespace ej2
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
            tbNota = new TextBox();
            tbNombres = new TextBox();
            tbLibreta = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnMayorAlPromedio = new Button();
            btnListaOrdenada = new Button();
            btnPromedio = new Button();
            btnCantidad = new Button();
            btnMayorYMenor = new Button();
            lsbResultados = new ListBox();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbNota);
            groupBox1.Controls.Add(tbNombres);
            groupBox1.Controls.Add(tbLibreta);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de alumno";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(489, 72);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(161, 60);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbNota
            // 
            tbNota.Location = new Point(137, 126);
            tbNota.Name = "tbNota";
            tbNota.Size = new Size(66, 34);
            tbNota.TabIndex = 5;
            // 
            // tbNombres
            // 
            tbNombres.Location = new Point(137, 85);
            tbNombres.Name = "tbNombres";
            tbNombres.Size = new Size(324, 34);
            tbNombres.TabIndex = 4;
            // 
            // tbLibreta
            // 
            tbLibreta.Location = new Point(137, 47);
            tbLibreta.Name = "tbLibreta";
            tbLibreta.Size = new Size(66, 34);
            tbLibreta.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 129);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Nota:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 88);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 50);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 0;
            label1.Text = "Libreta:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMayorAlPromedio);
            groupBox2.Controls.Add(btnListaOrdenada);
            groupBox2.Controls.Add(btnPromedio);
            groupBox2.Controls.Add(btnCantidad);
            groupBox2.Controls.Add(btnMayorYMenor);
            groupBox2.Controls.Add(lsbResultados);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(tbBuscar);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(671, 529);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alumno con la mayor y Alumno con la menor nota";
            // 
            // btnMayorAlPromedio
            // 
            btnMayorAlPromedio.Location = new Point(451, 409);
            btnMayorAlPromedio.Name = "btnMayorAlPromedio";
            btnMayorAlPromedio.Size = new Size(199, 96);
            btnMayorAlPromedio.TabIndex = 13;
            btnMayorAlPromedio.Text = "Mostrar lista superior al promedio";
            btnMayorAlPromedio.UseVisualStyleBackColor = true;
            btnMayorAlPromedio.Click += btnMayorAlPromedio_Click;
            // 
            // btnListaOrdenada
            // 
            btnListaOrdenada.Location = new Point(451, 334);
            btnListaOrdenada.Name = "btnListaOrdenada";
            btnListaOrdenada.Size = new Size(199, 69);
            btnListaOrdenada.TabIndex = 12;
            btnListaOrdenada.Text = "Mostrar lista ordenada";
            btnListaOrdenada.UseVisualStyleBackColor = true;
            btnListaOrdenada.Click += btnListaOrdenada_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(451, 259);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(199, 69);
            btnPromedio.TabIndex = 11;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnCantidad
            // 
            btnCantidad.Location = new Point(451, 184);
            btnCantidad.Name = "btnCantidad";
            btnCantidad.Size = new Size(199, 69);
            btnCantidad.TabIndex = 10;
            btnCantidad.Text = "Cantidad de Alumnos";
            btnCantidad.UseVisualStyleBackColor = true;
            btnCantidad.Click += btnCantidad_Click;
            // 
            // btnMayorYMenor
            // 
            btnMayorYMenor.Location = new Point(451, 109);
            btnMayorYMenor.Name = "btnMayorYMenor";
            btnMayorYMenor.Size = new Size(199, 69);
            btnMayorYMenor.TabIndex = 9;
            btnMayorYMenor.Text = "Alumno mayor y menor nota";
            btnMayorYMenor.UseVisualStyleBackColor = true;
            btnMayorYMenor.Click += btnMayorYMenor_Click;
            // 
            // lsbResultados
            // 
            lsbResultados.FormattingEnabled = true;
            lsbResultados.ItemHeight = 28;
            lsbResultados.Location = new Point(38, 109);
            lsbResultados.Name = "lsbResultados";
            lsbResultados.Size = new Size(391, 396);
            lsbResultados.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(300, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 48);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(137, 41);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(135, 34);
            tbBuscar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 44);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 7;
            label4.Text = "Libreta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 826);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Ejercicio 2. Arreglos con índice compartido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private TextBox tbNota;
        private TextBox tbNombres;
        private TextBox tbLibreta;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnMayorYMenor;
        private ListBox lsbResultados;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Label label4;
        private Button btnMayorAlPromedio;
        private Button btnListaOrdenada;
        private Button btnPromedio;
        private Button btnCantidad;
    }
}
