namespace App_Examen_Practico_RA2
{
    partial class FormEstudiante
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.lbl_Seccion = new System.Windows.Forms.Label();
            this.lbl_AreaTecnica = new System.Windows.Forms.Label();
            this.lbl_MaestroTitular = new System.Windows.Forms.Label();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_MaestroTitular = new System.Windows.Forms.TextBox();
            this.cmb_Curso = new System.Windows.Forms.ComboBox();
            this.cmb_Seccion = new System.Windows.Forms.ComboBox();
            this.cmb_AreaTecnica = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dtg_EstudianteMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_EstudianteCuso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_EstudianteSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_EstudianteAreaTecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_EstudianteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.MintCream;
            this.btn_Guardar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(826, 335);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(98, 46);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.MintCream;
            this.btn_Agregar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(826, 413);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 46);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.MintCream;
            this.btn_Eliminar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(826, 494);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(98, 46);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.MintCream;
            this.btn_Nuevo.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(826, 254);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(98, 46);
            this.btn_Nuevo.TabIndex = 3;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 4;
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricula.Location = new System.Drawing.Point(66, 103);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(60, 14);
            this.lbl_Matricula.TabIndex = 5;
            this.lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(66, 141);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(50, 14);
            this.lbl_Nombre.TabIndex = 6;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(66, 179);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(60, 14);
            this.lbl_Direccion.TabIndex = 7;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Genero.Location = new System.Drawing.Point(407, 198);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(46, 14);
            this.lbl_Genero.TabIndex = 8;
            this.lbl_Genero.Text = "Genero";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(66, 215);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 14);
            this.lbl_Email.TabIndex = 9;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curso.Location = new System.Drawing.Point(407, 134);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(39, 14);
            this.lbl_Curso.TabIndex = 10;
            this.lbl_Curso.Text = "Curso";
            // 
            // lbl_Seccion
            // 
            this.lbl_Seccion.AutoSize = true;
            this.lbl_Seccion.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Seccion.Location = new System.Drawing.Point(407, 166);
            this.lbl_Seccion.Name = "lbl_Seccion";
            this.lbl_Seccion.Size = new System.Drawing.Size(50, 14);
            this.lbl_Seccion.TabIndex = 11;
            this.lbl_Seccion.Text = "Seccion";
            // 
            // lbl_AreaTecnica
            // 
            this.lbl_AreaTecnica.AutoSize = true;
            this.lbl_AreaTecnica.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AreaTecnica.Location = new System.Drawing.Point(407, 104);
            this.lbl_AreaTecnica.Name = "lbl_AreaTecnica";
            this.lbl_AreaTecnica.Size = new System.Drawing.Size(78, 14);
            this.lbl_AreaTecnica.TabIndex = 12;
            this.lbl_AreaTecnica.Text = "Area Tecnica";
            // 
            // lbl_MaestroTitular
            // 
            this.lbl_MaestroTitular.AutoSize = true;
            this.lbl_MaestroTitular.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaestroTitular.Location = new System.Drawing.Point(66, 254);
            this.lbl_MaestroTitular.Name = "lbl_MaestroTitular";
            this.lbl_MaestroTitular.Size = new System.Drawing.Size(91, 14);
            this.lbl_MaestroTitular.TabIndex = 13;
            this.lbl_MaestroTitular.Text = "Maestro Titular";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matricula.Location = new System.Drawing.Point(168, 100);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(186, 21);
            this.txt_Matricula.TabIndex = 14;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(168, 138);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(186, 21);
            this.txt_Nombre.TabIndex = 15;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(168, 176);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(186, 21);
            this.txt_Direccion.TabIndex = 16;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(168, 213);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(187, 21);
            this.txt_Email.TabIndex = 18;
            // 
            // txt_MaestroTitular
            // 
            this.txt_MaestroTitular.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaestroTitular.Location = new System.Drawing.Point(168, 252);
            this.txt_MaestroTitular.Name = "txt_MaestroTitular";
            this.txt_MaestroTitular.Size = new System.Drawing.Size(187, 21);
            this.txt_MaestroTitular.TabIndex = 21;
            // 
            // cmb_Curso
            // 
            this.cmb_Curso.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Curso.FormattingEnabled = true;
            this.cmb_Curso.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cmb_Curso.Location = new System.Drawing.Point(509, 132);
            this.cmb_Curso.Name = "cmb_Curso";
            this.cmb_Curso.Size = new System.Drawing.Size(164, 21);
            this.cmb_Curso.TabIndex = 24;
            // 
            // cmb_Seccion
            // 
            this.cmb_Seccion.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Seccion.FormattingEnabled = true;
            this.cmb_Seccion.Items.AddRange(new object[] {
            "D1",
            "D2"});
            this.cmb_Seccion.Location = new System.Drawing.Point(509, 164);
            this.cmb_Seccion.Name = "cmb_Seccion";
            this.cmb_Seccion.Size = new System.Drawing.Size(164, 21);
            this.cmb_Seccion.TabIndex = 25;
            // 
            // cmb_AreaTecnica
            // 
            this.cmb_AreaTecnica.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_AreaTecnica.FormattingEnabled = true;
            this.cmb_AreaTecnica.Items.AddRange(new object[] {
            "DESARROLLO DE APLICACIONES ",
            "BASE DE DATOS",
            "ANALISIS Y DISEÑO DE SISTEMAS INFORMATICOS",
            "ADMINISTRACION DE BASE DE DATOS",
            "ANALISI Y DISEÑO DE PORTALES WEB"});
            this.cmb_AreaTecnica.Location = new System.Drawing.Point(509, 101);
            this.cmb_AreaTecnica.Name = "cmb_AreaTecnica";
            this.cmb_AreaTecnica.Size = new System.Drawing.Size(164, 21);
            this.cmb_AreaTecnica.TabIndex = 26;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtg_EstudianteMatricula,
            this.dtg_EstudianteCuso,
            this.dtg_EstudianteSeccion,
            this.dtg_EstudianteAreaTecnica,
            this.dtg_EstudianteNombre});
            this.dataGridView.Location = new System.Drawing.Point(82, 287);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(658, 253);
            this.dataGridView.TabIndex = 27;
            // 
            // dtg_EstudianteMatricula
            // 
            this.dtg_EstudianteMatricula.HeaderText = "Estudiante.Matricula";
            this.dtg_EstudianteMatricula.Name = "dtg_EstudianteMatricula";
            // 
            // dtg_EstudianteCuso
            // 
            this.dtg_EstudianteCuso.HeaderText = "Estudiante.Curso";
            this.dtg_EstudianteCuso.Name = "dtg_EstudianteCuso";
            // 
            // dtg_EstudianteSeccion
            // 
            this.dtg_EstudianteSeccion.HeaderText = "Estudiante.Seccion";
            this.dtg_EstudianteSeccion.Name = "dtg_EstudianteSeccion";
            // 
            // dtg_EstudianteAreaTecnica
            // 
            this.dtg_EstudianteAreaTecnica.HeaderText = "Estudiante.AreaTecnica";
            this.dtg_EstudianteAreaTecnica.Name = "dtg_EstudianteAreaTecnica";
            // 
            // dtg_EstudianteNombre
            // 
            this.dtg_EstudianteNombre.HeaderText = "Estudiante.Nombre";
            this.dtg_EstudianteNombre.Name = "dtg_EstudianteNombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "Datos del Estudiante";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(509, 198);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Femenino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(600, 198);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1016, 577);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cmb_AreaTecnica);
            this.Controls.Add(this.cmb_Seccion);
            this.Controls.Add(this.cmb_Curso);
            this.Controls.Add(this.txt_MaestroTitular);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.lbl_MaestroTitular);
            this.Controls.Add(this.lbl_AreaTecnica);
            this.Controls.Add(this.lbl_Seccion);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Guardar);
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label lbl_Seccion;
        private System.Windows.Forms.Label lbl_AreaTecnica;
        private System.Windows.Forms.Label lbl_MaestroTitular;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_MaestroTitular;
        private System.Windows.Forms.ComboBox cmb_Curso;
        private System.Windows.Forms.ComboBox cmb_Seccion;
        private System.Windows.Forms.ComboBox cmb_AreaTecnica;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_EstudianteMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_EstudianteCuso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_EstudianteSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_EstudianteAreaTecnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_EstudianteNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

