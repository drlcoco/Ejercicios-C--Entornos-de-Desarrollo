
namespace Empresa
{
    partial class NuevoEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.gb_grupo = new System.Windows.Forms.GroupBox();
            this.rb_becarios = new System.Windows.Forms.RadioButton();
            this.rb_obreros = new System.Windows.Forms.RadioButton();
            this.rb_cualificados = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_plus = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtb_plusJ = new System.Windows.Forms.MaskedTextBox();
            this.txt_trabCargo = new System.Windows.Forms.TextBox();
            this.txt_proyectos = new System.Windows.Forms.TextBox();
            this.lbl_plusJ = new System.Windows.Forms.Label();
            this.chb_jefe = new System.Windows.Forms.CheckBox();
            this.lbl_proyectos = new System.Windows.Forms.Label();
            this.lbl_trabCargo = new System.Windows.Forms.Label();
            this.txt_departamentoC = new System.Windows.Forms.TextBox();
            this.txt_titulacion = new System.Windows.Forms.TextBox();
            this.lbl_plusC = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_titulacion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtb_sueldoB1 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_dni = new System.Windows.Forms.MaskedTextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_sueldoBase = new System.Windows.Forms.Label();
            this.lbl_dniE = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.gb_obreros = new System.Windows.Forms.GroupBox();
            this.mtb_precioHE = new System.Windows.Forms.MaskedTextBox();
            this.txt_HE = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.lbl_precioHE = new System.Windows.Forms.Label();
            this.lbl_HE = new System.Windows.Forms.Label();
            this.lbl_destinoT = new System.Windows.Forms.Label();
            this.gb_becarios = new System.Windows.Forms.GroupBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.cb_universidad = new System.Windows.Forms.ComboBox();
            this.txt_carrera = new System.Windows.Forms.TextBox();
            this.txt_deptB = new System.Windows.Forms.TextBox();
            this.lbl_carrera = new System.Windows.Forms.Label();
            this.lbl_notas = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.lbl_universidad = new System.Windows.Forms.Label();
            this.lbl_depBec = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nm_curso = new System.Windows.Forms.NumericUpDown();
            this.gb_grupo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_obreros.SuspendLayout();
            this.gb_becarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_curso)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_grupo
            // 
            this.gb_grupo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_grupo.Controls.Add(this.rb_becarios);
            this.gb_grupo.Controls.Add(this.rb_obreros);
            this.gb_grupo.Controls.Add(this.rb_cualificados);
            this.gb_grupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_grupo.Location = new System.Drawing.Point(28, 23);
            this.gb_grupo.Name = "gb_grupo";
            this.gb_grupo.Size = new System.Drawing.Size(139, 152);
            this.gb_grupo.TabIndex = 0;
            this.gb_grupo.TabStop = false;
            this.gb_grupo.Text = "Grupo de empleado:";
            // 
            // rb_becarios
            // 
            this.rb_becarios.AutoSize = true;
            this.rb_becarios.Location = new System.Drawing.Point(20, 116);
            this.rb_becarios.Name = "rb_becarios";
            this.rb_becarios.Size = new System.Drawing.Size(69, 19);
            this.rb_becarios.TabIndex = 2;
            this.rb_becarios.Text = "Becarios";
            this.rb_becarios.UseVisualStyleBackColor = true;
            this.rb_becarios.CheckedChanged += new System.EventHandler(this.rb_becarios_CheckedChanged);
            // 
            // rb_obreros
            // 
            this.rb_obreros.AutoSize = true;
            this.rb_obreros.Location = new System.Drawing.Point(20, 67);
            this.rb_obreros.Name = "rb_obreros";
            this.rb_obreros.Size = new System.Drawing.Size(67, 19);
            this.rb_obreros.TabIndex = 1;
            this.rb_obreros.Text = "Obreros";
            this.rb_obreros.UseVisualStyleBackColor = true;
            this.rb_obreros.CheckedChanged += new System.EventHandler(this.rb_obreros_CheckedChanged);
            // 
            // rb_cualificados
            // 
            this.rb_cualificados.AutoSize = true;
            this.rb_cualificados.Checked = true;
            this.rb_cualificados.Location = new System.Drawing.Point(20, 23);
            this.rb_cualificados.Name = "rb_cualificados";
            this.rb_cualificados.Size = new System.Drawing.Size(90, 19);
            this.rb_cualificados.TabIndex = 0;
            this.rb_cualificados.TabStop = true;
            this.rb_cualificados.Text = "Cualificados";
            this.rb_cualificados.UseVisualStyleBackColor = true;
            this.rb_cualificados.CheckedChanged += new System.EventHandler(this.rb_cualificados_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.mtb_plus);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_departamentoC);
            this.groupBox1.Controls.Add(this.txt_titulacion);
            this.groupBox1.Controls.Add(this.lbl_plusC);
            this.groupBox1.Controls.Add(this.lbl_departamento);
            this.groupBox1.Controls.Add(this.lbl_titulacion);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(28, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cualificados:";
            // 
            // mtb_plus
            // 
            this.mtb_plus.Location = new System.Drawing.Point(95, 128);
            this.mtb_plus.Name = "mtb_plus";
            this.mtb_plus.Size = new System.Drawing.Size(100, 23);
            this.mtb_plus.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.mtb_plusJ);
            this.panel1.Controls.Add(this.txt_trabCargo);
            this.panel1.Controls.Add(this.txt_proyectos);
            this.panel1.Controls.Add(this.lbl_plusJ);
            this.panel1.Controls.Add(this.chb_jefe);
            this.panel1.Controls.Add(this.lbl_proyectos);
            this.panel1.Controls.Add(this.lbl_trabCargo);
            this.panel1.Location = new System.Drawing.Point(236, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 150);
            this.panel1.TabIndex = 6;
            // 
            // mtb_plusJ
            // 
            this.mtb_plusJ.Location = new System.Drawing.Point(83, 114);
            this.mtb_plusJ.Name = "mtb_plusJ";
            this.mtb_plusJ.ReadOnly = true;
            this.mtb_plusJ.Size = new System.Drawing.Size(100, 23);
            this.mtb_plusJ.TabIndex = 10;
            // 
            // txt_trabCargo
            // 
            this.txt_trabCargo.Location = new System.Drawing.Point(133, 40);
            this.txt_trabCargo.Name = "txt_trabCargo";
            this.txt_trabCargo.ReadOnly = true;
            this.txt_trabCargo.Size = new System.Drawing.Size(66, 23);
            this.txt_trabCargo.TabIndex = 8;
            // 
            // txt_proyectos
            // 
            this.txt_proyectos.Location = new System.Drawing.Point(83, 76);
            this.txt_proyectos.Name = "txt_proyectos";
            this.txt_proyectos.ReadOnly = true;
            this.txt_proyectos.Size = new System.Drawing.Size(116, 23);
            this.txt_proyectos.TabIndex = 9;
            // 
            // lbl_plusJ
            // 
            this.lbl_plusJ.AutoSize = true;
            this.lbl_plusJ.Location = new System.Drawing.Point(45, 117);
            this.lbl_plusJ.Name = "lbl_plusJ";
            this.lbl_plusJ.Size = new System.Drawing.Size(32, 15);
            this.lbl_plusJ.TabIndex = 9;
            this.lbl_plusJ.Text = "Plus:";
            // 
            // chb_jefe
            // 
            this.chb_jefe.AutoSize = true;
            this.chb_jefe.Location = new System.Drawing.Point(15, 8);
            this.chb_jefe.Name = "chb_jefe";
            this.chb_jefe.Size = new System.Drawing.Size(140, 19);
            this.chb_jefe.TabIndex = 7;
            this.chb_jefe.Text = "Jefe de departamento";
            this.chb_jefe.UseVisualStyleBackColor = true;
            this.chb_jefe.CheckedChanged += new System.EventHandler(this.chb_jefe_CheckedChanged);
            // 
            // lbl_proyectos
            // 
            this.lbl_proyectos.AutoSize = true;
            this.lbl_proyectos.Location = new System.Drawing.Point(15, 79);
            this.lbl_proyectos.Name = "lbl_proyectos";
            this.lbl_proyectos.Size = new System.Drawing.Size(62, 15);
            this.lbl_proyectos.TabIndex = 8;
            this.lbl_proyectos.Text = "Proyectos:";
            // 
            // lbl_trabCargo
            // 
            this.lbl_trabCargo.AutoSize = true;
            this.lbl_trabCargo.Location = new System.Drawing.Point(15, 43);
            this.lbl_trabCargo.Name = "lbl_trabCargo";
            this.lbl_trabCargo.Size = new System.Drawing.Size(118, 15);
            this.lbl_trabCargo.TabIndex = 7;
            this.lbl_trabCargo.Text = "Trabajadores a cargo:";
            // 
            // txt_departamentoC
            // 
            this.txt_departamentoC.Location = new System.Drawing.Point(95, 85);
            this.txt_departamentoC.Name = "txt_departamentoC";
            this.txt_departamentoC.Size = new System.Drawing.Size(100, 23);
            this.txt_departamentoC.TabIndex = 5;
            // 
            // txt_titulacion
            // 
            this.txt_titulacion.Location = new System.Drawing.Point(95, 40);
            this.txt_titulacion.Name = "txt_titulacion";
            this.txt_titulacion.Size = new System.Drawing.Size(100, 23);
            this.txt_titulacion.TabIndex = 4;
            // 
            // lbl_plusC
            // 
            this.lbl_plusC.AutoSize = true;
            this.lbl_plusC.Location = new System.Drawing.Point(55, 131);
            this.lbl_plusC.Name = "lbl_plusC";
            this.lbl_plusC.Size = new System.Drawing.Size(32, 15);
            this.lbl_plusC.TabIndex = 2;
            this.lbl_plusC.Text = "Plus:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(3, 88);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(86, 15);
            this.lbl_departamento.TabIndex = 1;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // lbl_titulacion
            // 
            this.lbl_titulacion.AutoSize = true;
            this.lbl_titulacion.Location = new System.Drawing.Point(27, 43);
            this.lbl_titulacion.Name = "lbl_titulacion";
            this.lbl_titulacion.Size = new System.Drawing.Size(62, 15);
            this.lbl_titulacion.TabIndex = 0;
            this.lbl_titulacion.Text = "Titulación:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.mtb_sueldoB1);
            this.groupBox2.Controls.Add(this.mtb_dni);
            this.groupBox2.Controls.Add(this.txt_Apellidos);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.lbl_sueldoBase);
            this.groupBox2.Controls.Add(this.lbl_dniE);
            this.groupBox2.Controls.Add(this.lbl_apellidos);
            this.groupBox2.Controls.Add(this.lbl_nombre);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(186, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos:";
            // 
            // mtb_sueldoB1
            // 
            this.mtb_sueldoB1.Location = new System.Drawing.Point(97, 110);
            this.mtb_sueldoB1.Name = "mtb_sueldoB1";
            this.mtb_sueldoB1.Size = new System.Drawing.Size(118, 23);
            this.mtb_sueldoB1.TabIndex = 3;
            // 
            // mtb_dni
            // 
            this.mtb_dni.Location = new System.Drawing.Point(97, 78);
            this.mtb_dni.Name = "mtb_dni";
            this.mtb_dni.Size = new System.Drawing.Size(118, 23);
            this.mtb_dni.TabIndex = 2;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(97, 47);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(195, 23);
            this.txt_Apellidos.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(97, 17);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(195, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_sueldoBase
            // 
            this.lbl_sueldoBase.AutoSize = true;
            this.lbl_sueldoBase.Location = new System.Drawing.Point(18, 113);
            this.lbl_sueldoBase.Name = "lbl_sueldoBase";
            this.lbl_sueldoBase.Size = new System.Drawing.Size(73, 15);
            this.lbl_sueldoBase.TabIndex = 3;
            this.lbl_sueldoBase.Text = "Sueldo base:";
            // 
            // lbl_dniE
            // 
            this.lbl_dniE.AutoSize = true;
            this.lbl_dniE.Location = new System.Drawing.Point(60, 81);
            this.lbl_dniE.Name = "lbl_dniE";
            this.lbl_dniE.Size = new System.Drawing.Size(30, 15);
            this.lbl_dniE.TabIndex = 2;
            this.lbl_dniE.Text = "DNI:";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(32, 50);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(59, 15);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 20);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // gb_obreros
            // 
            this.gb_obreros.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_obreros.Controls.Add(this.mtb_precioHE);
            this.gb_obreros.Controls.Add(this.txt_HE);
            this.gb_obreros.Controls.Add(this.txt_destino);
            this.gb_obreros.Controls.Add(this.lbl_precioHE);
            this.gb_obreros.Controls.Add(this.lbl_HE);
            this.gb_obreros.Controls.Add(this.lbl_destinoT);
            this.gb_obreros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_obreros.Location = new System.Drawing.Point(503, 23);
            this.gb_obreros.Name = "gb_obreros";
            this.gb_obreros.Size = new System.Drawing.Size(253, 152);
            this.gb_obreros.TabIndex = 3;
            this.gb_obreros.TabStop = false;
            this.gb_obreros.Text = "Obreros:";
            // 
            // mtb_precioHE
            // 
            this.mtb_precioHE.Location = new System.Drawing.Point(138, 110);
            this.mtb_precioHE.Name = "mtb_precioHE";
            this.mtb_precioHE.ReadOnly = true;
            this.mtb_precioHE.Size = new System.Drawing.Size(100, 23);
            this.mtb_precioHE.TabIndex = 13;
            // 
            // txt_HE
            // 
            this.txt_HE.Location = new System.Drawing.Point(138, 78);
            this.txt_HE.Name = "txt_HE";
            this.txt_HE.ReadOnly = true;
            this.txt_HE.Size = new System.Drawing.Size(100, 23);
            this.txt_HE.TabIndex = 12;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(18, 46);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.ReadOnly = true;
            this.txt_destino.Size = new System.Drawing.Size(220, 23);
            this.txt_destino.TabIndex = 11;
            // 
            // lbl_precioHE
            // 
            this.lbl_precioHE.AutoSize = true;
            this.lbl_precioHE.Location = new System.Drawing.Point(18, 118);
            this.lbl_precioHE.Name = "lbl_precioHE";
            this.lbl_precioHE.Size = new System.Drawing.Size(99, 15);
            this.lbl_precioHE.TabIndex = 2;
            this.lbl_precioHE.Text = "Precio hora extra:";
            // 
            // lbl_HE
            // 
            this.lbl_HE.AutoSize = true;
            this.lbl_HE.Location = new System.Drawing.Point(18, 86);
            this.lbl_HE.Name = "lbl_HE";
            this.lbl_HE.Size = new System.Drawing.Size(70, 15);
            this.lbl_HE.TabIndex = 1;
            this.lbl_HE.Text = "Horas Extra:";
            // 
            // lbl_destinoT
            // 
            this.lbl_destinoT.AutoSize = true;
            this.lbl_destinoT.Location = new System.Drawing.Point(18, 20);
            this.lbl_destinoT.Name = "lbl_destinoT";
            this.lbl_destinoT.Size = new System.Drawing.Size(106, 15);
            this.lbl_destinoT.TabIndex = 0;
            this.lbl_destinoT.Text = "Destino de trabajo:";
            // 
            // gb_becarios
            // 
            this.gb_becarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_becarios.Controls.Add(this.nm_curso);
            this.gb_becarios.Controls.Add(this.txt_nota3);
            this.gb_becarios.Controls.Add(this.txt_nota2);
            this.gb_becarios.Controls.Add(this.txt_nota1);
            this.gb_becarios.Controls.Add(this.cb_universidad);
            this.gb_becarios.Controls.Add(this.txt_carrera);
            this.gb_becarios.Controls.Add(this.txt_deptB);
            this.gb_becarios.Controls.Add(this.lbl_carrera);
            this.gb_becarios.Controls.Add(this.lbl_notas);
            this.gb_becarios.Controls.Add(this.lbl_curso);
            this.gb_becarios.Controls.Add(this.lbl_universidad);
            this.gb_becarios.Controls.Add(this.lbl_depBec);
            this.gb_becarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_becarios.Location = new System.Drawing.Point(503, 200);
            this.gb_becarios.Name = "gb_becarios";
            this.gb_becarios.Size = new System.Drawing.Size(253, 223);
            this.gb_becarios.TabIndex = 4;
            this.gb_becarios.TabStop = false;
            this.gb_becarios.Text = "Becarios:";
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(204, 184);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.ReadOnly = true;
            this.txt_nota3.Size = new System.Drawing.Size(38, 23);
            this.txt_nota3.TabIndex = 20;
            this.txt_nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(147, 184);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.ReadOnly = true;
            this.txt_nota2.Size = new System.Drawing.Size(38, 23);
            this.txt_nota2.TabIndex = 19;
            this.txt_nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(86, 184);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.ReadOnly = true;
            this.txt_nota1.Size = new System.Drawing.Size(38, 23);
            this.txt_nota1.TabIndex = 18;
            this.txt_nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_universidad
            // 
            this.cb_universidad.FormattingEnabled = true;
            this.cb_universidad.Items.AddRange(new object[] {
            "Alicante (UA)",
            "Elche (UMH)",
            "Valencia (UV)",
            "Valencia (UPV)",
            "Valencia (UIMP)",
            "Valencia (CEU)",
            "Uned"});
            this.cb_universidad.Location = new System.Drawing.Point(104, 110);
            this.cb_universidad.Name = "cb_universidad";
            this.cb_universidad.Size = new System.Drawing.Size(134, 23);
            this.cb_universidad.TabIndex = 16;
            // 
            // txt_carrera
            // 
            this.txt_carrera.Location = new System.Drawing.Point(104, 70);
            this.txt_carrera.Name = "txt_carrera";
            this.txt_carrera.ReadOnly = true;
            this.txt_carrera.Size = new System.Drawing.Size(134, 23);
            this.txt_carrera.TabIndex = 15;
            // 
            // txt_deptB
            // 
            this.txt_deptB.Location = new System.Drawing.Point(104, 37);
            this.txt_deptB.Name = "txt_deptB";
            this.txt_deptB.ReadOnly = true;
            this.txt_deptB.Size = new System.Drawing.Size(134, 23);
            this.txt_deptB.TabIndex = 14;
            this.txt_deptB.TextChanged += new System.EventHandler(this.txt_deptB_TextChanged);
            // 
            // lbl_carrera
            // 
            this.lbl_carrera.AutoSize = true;
            this.lbl_carrera.Location = new System.Drawing.Point(50, 73);
            this.lbl_carrera.Name = "lbl_carrera";
            this.lbl_carrera.Size = new System.Drawing.Size(48, 15);
            this.lbl_carrera.TabIndex = 4;
            this.lbl_carrera.Text = "Carrera:";
            // 
            // lbl_notas
            // 
            this.lbl_notas.AutoSize = true;
            this.lbl_notas.Location = new System.Drawing.Point(26, 187);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(41, 15);
            this.lbl_notas.TabIndex = 3;
            this.lbl_notas.Text = "Notas:";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(57, 149);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(41, 15);
            this.lbl_curso.TabIndex = 2;
            this.lbl_curso.Text = "Curso:";
            // 
            // lbl_universidad
            // 
            this.lbl_universidad.AutoSize = true;
            this.lbl_universidad.Location = new System.Drawing.Point(26, 110);
            this.lbl_universidad.Name = "lbl_universidad";
            this.lbl_universidad.Size = new System.Drawing.Size(72, 15);
            this.lbl_universidad.TabIndex = 1;
            this.lbl_universidad.Text = "Universidad:";
            // 
            // lbl_depBec
            // 
            this.lbl_depBec.AutoSize = true;
            this.lbl_depBec.Location = new System.Drawing.Point(12, 40);
            this.lbl_depBec.Name = "lbl_depBec";
            this.lbl_depBec.Size = new System.Drawing.Size(86, 15);
            this.lbl_depBec.TabIndex = 0;
            this.lbl_depBec.Text = "Departamento:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Blue;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(86, 387);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(84, 36);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Blue;
            this.btn_borrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_borrar.ForeColor = System.Drawing.Color.White;
            this.btn_borrar.Location = new System.Drawing.Point(204, 387);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(84, 36);
            this.btn_borrar.TabIndex = 6;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Blue;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(317, 387);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(84, 36);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nm_curso
            // 
            this.nm_curso.BackColor = System.Drawing.Color.White;
            this.nm_curso.Location = new System.Drawing.Point(104, 147);
            this.nm_curso.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nm_curso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_curso.Name = "nm_curso";
            this.nm_curso.ReadOnly = true;
            this.nm_curso.Size = new System.Drawing.Size(68, 23);
            this.nm_curso.TabIndex = 21;
            this.nm_curso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nm_curso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.gb_becarios);
            this.Controls.Add(this.gb_obreros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_grupo);
            this.Name = "NuevoEmpleado";
            this.Text = "NuevoEmpleado";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            this.gb_grupo.ResumeLayout(false);
            this.gb_grupo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_obreros.ResumeLayout(false);
            this.gb_obreros.PerformLayout();
            this.gb_becarios.ResumeLayout(false);
            this.gb_becarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_curso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_grupo;
        private System.Windows.Forms.RadioButton rb_becarios;
        private System.Windows.Forms.RadioButton rb_obreros;
        private System.Windows.Forms.RadioButton rb_cualificados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtb_sueldoB1;
        private System.Windows.Forms.MaskedTextBox mtb_dni;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_sueldoBase;
        private System.Windows.Forms.Label lbl_dniE;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.GroupBox gb_obreros;
        private System.Windows.Forms.Label lbl_precioHE;
        private System.Windows.Forms.Label lbl_HE;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.TextBox txt_HE;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label lbl_destinoT;
        private System.Windows.Forms.GroupBox gb_becarios;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_departamentoC;
        private System.Windows.Forms.TextBox txt_titulacion;
        private System.Windows.Forms.Label lbl_plusC;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_titulacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_proyectos;
        private System.Windows.Forms.Label lbl_plusJ;
        private System.Windows.Forms.CheckBox chb_jefe;
        private System.Windows.Forms.Label lbl_proyectos;
        private System.Windows.Forms.Label lbl_trabCargo;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.ComboBox cb_universidad;
        private System.Windows.Forms.TextBox txt_carrera;
        private System.Windows.Forms.TextBox txt_deptB;
        private System.Windows.Forms.Label lbl_carrera;
        private System.Windows.Forms.Label lbl_notas;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.Label lbl_universidad;
        private System.Windows.Forms.Label lbl_depBec;
        private System.Windows.Forms.TextBox txt_trabCargo;
        private System.Windows.Forms.MaskedTextBox mtb_plus;
        private System.Windows.Forms.MaskedTextBox mtb_plusJ;
        private System.Windows.Forms.MaskedTextBox mtb_precioHE;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nm_curso;
    }
}