namespace Control_de_registro_de_evaluaciones
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtEva4 = new System.Windows.Forms.TextBox();
            this.txtEva3 = new System.Windows.Forms.TextBox();
            this.txtEva2 = new System.Windows.Forms.TextBox();
            this.txtEva1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.Alumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.E1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.E2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.E3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.E4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MENOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROMEDIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CONDICION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.controlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTROL DE REGISTRO DE EVALUACIONES";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(27, 97);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(258, 22);
            this.txtAlumno.TabIndex = 3;
            this.txtAlumno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAlumno.Validated += new System.EventHandler(this.txtAlumno_Validated);
            // 
            // txtEva4
            // 
            this.txtEva4.Location = new System.Drawing.Point(251, 43);
            this.txtEva4.Name = "txtEva4";
            this.txtEva4.Size = new System.Drawing.Size(45, 22);
            this.txtEva4.TabIndex = 5;
            this.txtEva4.TextChanged += new System.EventHandler(this.txtEva4_TextChanged);
            // 
            // txtEva3
            // 
            this.txtEva3.Location = new System.Drawing.Point(182, 43);
            this.txtEva3.Name = "txtEva3";
            this.txtEva3.Size = new System.Drawing.Size(42, 22);
            this.txtEva3.TabIndex = 6;
            this.txtEva3.TextChanged += new System.EventHandler(this.txtEva3_TextChanged);
            // 
            // txtEva2
            // 
            this.txtEva2.Location = new System.Drawing.Point(99, 43);
            this.txtEva2.Name = "txtEva2";
            this.txtEva2.Size = new System.Drawing.Size(47, 22);
            this.txtEva2.TabIndex = 7;
            this.txtEva2.TextChanged += new System.EventHandler(this.txtEva2_TextChanged);
            // 
            // txtEva1
            // 
            this.txtEva1.Location = new System.Drawing.Point(6, 43);
            this.txtEva1.Name = "txtEva1";
            this.txtEva1.Size = new System.Drawing.Size(47, 22);
            this.txtEva1.TabIndex = 8;
            this.txtEva1.TextChanged += new System.EventHandler(this.txtEva1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Eval. 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eval. 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Eval. 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Eval . 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(134, 161);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(99, 31);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEva1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEva2);
            this.groupBox1.Controls.Add(this.txtEva4);
            this.groupBox1.Controls.Add(this.txtEva3);
            this.groupBox1.Location = new System.Drawing.Point(351, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 76);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(19, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 31);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Alumno,
            this.E1,
            this.E2,
            this.E3,
            this.E4,
            this.MENOR,
            this.PROMEDIO,
            this.CONDICION});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(19, 210);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(718, 162);
            this.lvRegistro.TabIndex = 18;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            this.lvRegistro.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Alumno
            // 
            this.Alumno.Text = "ALUMNO";
            this.Alumno.Width = 79;
            // 
            // E1
            // 
            this.E1.Text = "E1";
            // 
            // E2
            // 
            this.E2.Text = "E2";
            // 
            // E3
            // 
            this.E3.Text = "E3";
            // 
            // E4
            // 
            this.E4.Text = "E4";
            // 
            // MENOR
            // 
            this.MENOR.Text = "MENOR";
            this.MENOR.Width = 102;
            // 
            // PROMEDIO
            // 
            this.PROMEDIO.Text = "PROMEDIO";
            this.PROMEDIO.Width = 110;
            // 
            // CONDICION
            // 
            this.CONDICION.Text = "CONDICION";
            this.CONDICION.Width = 241;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alumno";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // controlErrores
            // 
            this.controlErrores.ContainerControl = this;
            this.controlErrores.RightToLeftChanged += new System.EventHandler(this.EpErrors);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Control de registro de evaluaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtEva4;
        private System.Windows.Forms.TextBox txtEva3;
        private System.Windows.Forms.TextBox txtEva2;
        private System.Windows.Forms.TextBox txtEva1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader Alumno;
        private System.Windows.Forms.ColumnHeader E1;
        private System.Windows.Forms.ColumnHeader E2;
        private System.Windows.Forms.ColumnHeader E3;
        private System.Windows.Forms.ColumnHeader E4;
        private System.Windows.Forms.ColumnHeader MENOR;
        private System.Windows.Forms.ColumnHeader PROMEDIO;
        private System.Windows.Forms.ColumnHeader CONDICION;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider controlErrores;
    }
}

