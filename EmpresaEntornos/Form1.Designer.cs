
namespace Empresa
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
            this.lstv_nombre = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btn_añadir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_sueldo = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstv_nombre
            // 
            this.lstv_nombre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstv_nombre.FullRowSelect = true;
            this.lstv_nombre.HideSelection = false;
            this.lstv_nombre.Location = new System.Drawing.Point(39, 43);
            this.lstv_nombre.MultiSelect = false;
            this.lstv_nombre.Name = "lstv_nombre";
            this.lstv_nombre.Size = new System.Drawing.Size(330, 227);
            this.lstv_nombre.TabIndex = 0;
            this.lstv_nombre.UseCompatibleStateImageBehavior = false;
            this.lstv_nombre.View = System.Windows.Forms.View.Details;
            this.lstv_nombre.SelectedIndexChanged += new System.EventHandler(this.lstv_nombre_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 110;
            // 
            // btn_añadir
            // 
            this.btn_añadir.BackColor = System.Drawing.Color.Blue;
            this.btn_añadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_añadir.ForeColor = System.Drawing.Color.White;
            this.btn_añadir.Location = new System.Drawing.Point(39, 311);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(137, 40);
            this.btn_añadir.TabIndex = 1;
            this.btn_añadir.Text = "Añadir empleado";
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Blue;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(228, 311);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(137, 40);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar empleado";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(447, 46);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 15);
            this.lbl_dni.TabIndex = 5;
            this.lbl_dni.Text = "DNI:";
            // 
            // lbl_sueldo
            // 
            this.lbl_sueldo.AutoSize = true;
            this.lbl_sueldo.Location = new System.Drawing.Point(404, 106);
            this.lbl_sueldo.Name = "lbl_sueldo";
            this.lbl_sueldo.Size = new System.Drawing.Size(73, 15);
            this.lbl_sueldo.TabIndex = 6;
            this.lbl_sueldo.Text = "Sueldo total:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(402, 172);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(75, 15);
            this.lbl_info.TabIndex = 7;
            this.lbl_info.Text = "Información:";
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.Color.White;
            this.txt_dni.Location = new System.Drawing.Point(511, 43);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.ReadOnly = true;
            this.txt_dni.Size = new System.Drawing.Size(170, 23);
            this.txt_dni.TabIndex = 8;
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.BackColor = System.Drawing.Color.White;
            this.txt_sueldo.Location = new System.Drawing.Point(511, 103);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.ReadOnly = true;
            this.txt_sueldo.Size = new System.Drawing.Size(170, 23);
            this.txt_sueldo.TabIndex = 9;
            // 
            // txt_info
            // 
            this.txt_info.BackColor = System.Drawing.Color.White;
            this.txt_info.Location = new System.Drawing.Point(511, 169);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(170, 182);
            this.txt_info.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(734, 403);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_sueldo);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_añadir);
            this.Controls.Add(this.lstv_nombre);
            this.Name = "Form1";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_añadir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_sueldo;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        protected System.Windows.Forms.ListView lstv_nombre;
    }
}

