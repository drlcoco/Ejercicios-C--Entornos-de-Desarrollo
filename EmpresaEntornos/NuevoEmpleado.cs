using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    //creo La clase NuevoEmpleado que hereda de Form y declaro las variables de referencia a las clases que quiero usar
    public partial class NuevoEmpleado : Form
    {
        Cualificados cualificado;
        Becarios becario;
        JefeDepart jd;
        Obreros ob;
        ListView lista;
        
        /*Creo un Setter para la variable Listview, ya que aunque la he declarado como protected 
         * y la clase NuevoEmpleado hereda de Form, no puedo acceder a ella.
         */
        public void SetLista(ListView lista)
        {
            this.lista = lista;
        }

        public NuevoEmpleado()
        {
            InitializeComponent();
            // creo el objeto Listview
            lista = new ListView();
           
        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {
            /* Asigno la máscara y eventHandler a los MaskedTextBox.
             */
            this.mtb_sueldoB1.ValidatingType = typeof(double);
            this.mtb_sueldoB1.Mask = "###00,00€"; 
            mtb_sueldoB1.TypeValidationCompleted += new TypeValidationEventHandler(mtb_sueldoB1_TypeValidationCompleted);

            this.mtb_dni.ValidatingType = typeof(String);
            this.mtb_dni.Mask = "00000000-L";
            mtb_dni.TypeValidationCompleted += new TypeValidationEventHandler(mtb_dni_TypeValidationCompleted);

            this.mtb_precioHE.ValidatingType = typeof(double);
            this.mtb_precioHE.Mask = "##0,00€";
            mtb_precioHE.TypeValidationCompleted += new TypeValidationEventHandler(mtb_precioHE_TypeValidationCompleted);

            this.mtb_plus.ValidatingType = typeof(double);
            this.mtb_plus.Mask = "###0,00€";
            mtb_plus.TypeValidationCompleted += new TypeValidationEventHandler(mtb_plus_TypeValidationCompleted);

            this.mtb_plusJ.ValidatingType = typeof(double);
            this.mtb_plusJ.Mask = "###0,00€";
            mtb_plusJ.TypeValidationCompleted += new TypeValidationEventHandler(mtb_plusJ_TypeValidationCompleted);
        }

        private void mtb_sueldoB1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            // Valido los datos
            this.mtb_sueldoB1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtb_sueldoB1.Text == "" || mtb_sueldoB1.Text == null)
            {
                MessageBox.Show("Inserta sueldo.");
                // no he puesto e.Cancel==true, ya que no quiero que bloquee el form
            }
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.mtb_sueldoB1, "Formato incorrecto.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void mtb_dni_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.mtb_dni.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtb_dni.Text == "" || mtb_dni.Text == null)
            {
                MessageBox.Show("Inserta dni.");
            }
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.mtb_dni, "Formato incorrecto.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void mtb_precioHE_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            this.mtb_precioHE.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtb_precioHE.Text == "" || mtb_precioHE.Text == null)
            {
                MessageBox.Show("Inserta precio de hora extra.");
            }
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.mtb_precioHE, "Formato incorrecto.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void mtb_plus_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.mtb_plus.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtb_plus.Text == "" || mtb_plus.Text == null)
            {
                MessageBox.Show("Inserta plus.");
            }
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.mtb_plus, "Formato incorrecto.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void mtb_plusJ_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            this.mtb_plusJ.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtb_plusJ.Text == "" || mtb_plusJ.Text == null)
            {
                MessageBox.Show("Inserta plus.");
            }
            if (!e.IsValidInput)
            {
                this.errorProvider1.SetError(this.mtb_plusJ, "Formato incorrecto.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        // Segun el RadioButton seleccionado habilito y deshabilito las zonas del Form a rellenar
        private void rb_cualificados_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cualificados.Checked == true)
            {
                txt_departamentoC.ReadOnly = false;
                txt_titulacion.ReadOnly = false;
                mtb_plus.ReadOnly = false;
                txt_destino.ReadOnly = true;
                txt_HE.ReadOnly = true;
                mtb_precioHE.ReadOnly = true;
                txt_carrera.ReadOnly = true;
                txt_deptB.ReadOnly = true;
                txt_nota1.ReadOnly = true;
                txt_nota2.ReadOnly = true;
                txt_nota3.ReadOnly = true;
                txt_destino.Text="";
                txt_HE.Text="";
                mtb_precioHE.Text="";
                txt_carrera.Text="";
                txt_deptB.Text="";
                nm_curso.Value = 1;
                txt_nota1.Text="";
                txt_nota2.Text="";
                txt_nota3.Text="";
                txt_trabCargo.ReadOnly = true;
                txt_proyectos.ReadOnly = true;
                mtb_plusJ.ReadOnly = true;
                chb_jefe.Checked = false;
            }
        }

        private void rb_obreros_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_obreros.Checked == true)
            {
                txt_departamentoC.ReadOnly = true;
                txt_titulacion.ReadOnly = true;
                mtb_plus.ReadOnly = true;
                txt_destino.ReadOnly = false;
                txt_HE.ReadOnly = false;
                mtb_precioHE.ReadOnly = false;
                txt_carrera.ReadOnly = true;
                txt_deptB.ReadOnly = true;
                txt_nota1.ReadOnly = true;
                txt_nota2.ReadOnly = true;
                txt_nota3.ReadOnly = true;
                txt_trabCargo.ReadOnly = true;
                txt_proyectos.ReadOnly = true;
                mtb_plusJ.ReadOnly = true;
                chb_jefe.Checked = false;

                txt_departamentoC.Text = "";
                txt_titulacion.Text = "";
                mtb_plus.Text = "";
                txt_carrera.Text = "";
                txt_deptB.Text = "";
                nm_curso.Value = 1;
                txt_nota1.Text = "";
                txt_nota2.Text = "";
                txt_nota3.Text = "";
                txt_trabCargo.Text="";
                txt_proyectos.Text="";
                mtb_plusJ.Text="";
                cb_universidad.SelectedIndex = -1;
            }
        }

        private void rb_becarios_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_becarios.Checked == true)
            {
                txt_departamentoC.ReadOnly = true;
                txt_titulacion.ReadOnly = true;
                mtb_plus.ReadOnly = true;
                txt_destino.ReadOnly = true;
                txt_HE.ReadOnly = true;
                mtb_precioHE.ReadOnly = true;
                txt_carrera.ReadOnly = false;
                txt_deptB.ReadOnly = false;
                txt_nota1.ReadOnly = false;
                txt_nota2.ReadOnly = false;
                txt_nota3.ReadOnly = false;
                txt_trabCargo.ReadOnly = true;
                txt_proyectos.ReadOnly = true;
                mtb_plusJ.ReadOnly = true;
                chb_jefe.Checked = false;

                txt_departamentoC.Text = "";
                txt_titulacion.Text = "";
                mtb_plus.Text = "";
                txt_destino.Text = "";
                txt_HE.Text = "";
                mtb_precioHE.Text = "";
                txt_trabCargo.Text = "";
                txt_proyectos.Text = "";
                mtb_plusJ.Text = "";
            }
        }
        // habilito los campos propios del jefe de departamento
        private void chb_jefe_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_jefe.Checked == true && rb_cualificados.Checked==true)
            {
                txt_trabCargo.ReadOnly = false;
                txt_proyectos.ReadOnly = false;
                mtb_plusJ.ReadOnly = false;
            }
            else
            {
                txt_trabCargo.ReadOnly = true;
                txt_proyectos.ReadOnly = true;
                mtb_plusJ.ReadOnly = true;
                txt_trabCargo.Text = "";
                txt_proyectos.Text = "";
                mtb_plusJ.Text = "";
                cb_universidad.SelectedIndex = -1;
            }
        }
        // borro los datos en el formulario
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
            chb_jefe.Checked = false;
            rb_cualificados.Checked = true;
            txt_nombre.Text = "";
            txt_Apellidos.Text = "";
            mtb_dni.Text = "";
            mtb_sueldoB1.Text = "";
            txt_departamentoC.Text = "";
            txt_titulacion.Text = "";
            mtb_plus.Text = "";
            cb_universidad.SelectedIndex = -1;
            nm_curso.Value = 1;
            errorProvider1.Clear();

            // me gustaría limpiar también los errorProvider, pero no lo consigo. 
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            // limpio los errorProviders, llamo al ListView y cierro la ventana
            errorProvider1.Clear(); 
            lista.Show();
            Close();
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //compruebo los datos en los campos comunes
            if (txt_nombre.Text.Equals("") || txt_Apellidos.Text.Equals("")|| mtb_dni.Text.Equals("") || mtb_sueldoB1.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // según el radiobutton elegido compruebo los campos correspondientes
                if (rb_cualificados.Checked == true)
                {
                    if (txt_departamentoC.Text.Equals("") || txt_titulacion.Text.Equals("") || mtb_plus.Text.Equals(""))
                    {
                        MessageBox.Show("Faltan datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        /*si el Checkbox está seleccionado, creo un objeto tipo JefeDepart y asigno los campos al item y a los subitems del Listview. Después borro los campos.
                         */
                        if (chb_jefe.Checked == true)
                        {
                            if (txt_trabCargo.Text.Equals("") || txt_proyectos.Text.Equals("") || mtb_plusJ.Text.Equals(""))
                            {
                                MessageBox.Show("Faltan datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                //uso el bloque try/catch para capturar las excepciones.
                                try
                                {
                                    jd = new JefeDepart(txt_nombre.Text, txt_Apellidos.Text, mtb_dni.Text, Convert.ToSingle(mtb_sueldoB1.Text), txt_titulacion.Text, txt_departamentoC.Text, Convert.ToSingle(mtb_plus.Text), Convert.ToInt32(txt_trabCargo.Text), txt_proyectos.Text, Convert.ToSingle(mtb_plusJ.Text));

                                    ListViewItem jefe = new ListViewItem("Jefe de departamento");
                                    jefe.SubItems.Add(txt_nombre.Text);
                                    jefe.SubItems.Add(txt_Apellidos.Text);
                                    jefe.SubItems.Add(mtb_dni.Text);
                                    jefe.SubItems.Add(jd.CalculaSueldo().ToString());
                                    jefe.SubItems.Add(jd.Informacion());
                                    lista.Items.Add(jefe);

                                    /*después de crear el objeto limpio los campos y aviso de que se ha creado el empleado
                                     */
                                    chb_jefe.Checked = false;
                                    rb_cualificados.Checked = true;
                                    txt_nombre.Text = "";
                                    txt_Apellidos.Text = "";
                                    mtb_dni.Text = "";
                                    mtb_sueldoB1.Text = "";
                                    txt_departamentoC.Text = "";
                                    txt_titulacion.Text = "";
                                    mtb_plus.Text = "";
                                    cb_universidad.SelectedIndex = -1;
                                    nm_curso.Value = 1;
                                    errorProvider1.Clear();
                                    MessageBox.Show("Empleado añadido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Datos no válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }

                            }
                        }
                        else
                        {
                            try
                            {
                                /*creo un objeto tipo Cualificados y asigno los campos al item y a los subitems del Listview. Después borro los campos.
                                 * uso el bloque Try/Catch para capturar las excepciones por culpa de datos no válidos
                        */
                                cualificado = new Cualificados(txt_nombre.Text, txt_Apellidos.Text, mtb_dni.Text, Convert.ToSingle(mtb_sueldoB1.Text), txt_titulacion.Text, txt_departamentoC.Text, Convert.ToSingle(mtb_plus.Text));
                               
                                ListViewItem cual = new ListViewItem("Cualificado");
                                cual.SubItems.Add(txt_nombre.Text);
                                cual.SubItems.Add(txt_Apellidos.Text);
                                cual.SubItems.Add(mtb_dni.Text);
                                cual.SubItems.Add(cualificado.CalculaSueldo().ToString());
                                cual.SubItems.Add(cualificado.Informacion());
                                lista.Items.Add(cual);

                                chb_jefe.Checked = false;
                                rb_cualificados.Checked = true;
                                txt_nombre.Text = "";
                                txt_Apellidos.Text = "";
                                mtb_dni.Text = "";
                                mtb_sueldoB1.Text = "";
                                txt_departamentoC.Text = "";
                                txt_titulacion.Text = "";
                                mtb_plus.Text = "";
                                cb_universidad.SelectedIndex = -1;
                                nm_curso.Value = 1;
                                errorProvider1.Clear();
                                MessageBox.Show("Empleado añadido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }catch ( Exception ex)
                            {
                                MessageBox.Show("Datos no válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }

                }else if (rb_obreros.Checked == true)
                {
                    if (txt_destino.Text.Equals("") || mtb_precioHE.Text.Equals("") || txt_HE.Text.Equals(""))
                    {
                        MessageBox.Show("Faltan datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            /*creo un objeto tipo Obreros y asigno los campos al item y a los subitems del Listview. Después borro los campos.
                                * uso el bloque Try/Catch para capturar las excepciones por culpa de datos no válidos
                       */
                            ob = new Obreros(txt_nombre.Text, txt_Apellidos.Text, mtb_dni.Text, Convert.ToSingle(mtb_sueldoB1.Text), txt_destino.Text, Convert.ToSingle(mtb_precioHE.Text), Convert.ToSingle(txt_HE.Text));
                            
                            ListViewItem obrero = new ListViewItem("Obrero");
                            obrero.SubItems.Add(txt_nombre.Text);
                            obrero.SubItems.Add(txt_Apellidos.Text);
                            obrero.SubItems.Add(mtb_dni.Text);
                            obrero.SubItems.Add(ob.CalculaSueldo().ToString());
                            obrero.SubItems.Add(ob.Informacion());
                            lista.Items.Add(obrero);

                            chb_jefe.Checked = false;
                            rb_cualificados.Checked = true;
                            txt_nombre.Text = "";
                            txt_Apellidos.Text = "";
                            mtb_dni.Text = "";
                            mtb_sueldoB1.Text = "";
                            txt_departamentoC.Text = "";
                            txt_titulacion.Text = "";
                            mtb_plus.Text = "";
                            cb_universidad.SelectedIndex = -1;
                            nm_curso.Value = 1;
                            errorProvider1.Clear();
                            MessageBox.Show("Empleado añadido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Datos no válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                    }
                } else if(rb_becarios.Checked==true)
                {
                    if(txt_carrera.Text.Equals("")||txt_deptB.Equals("")|| cb_universidad.SelectedIndex==-1||txt_nota1.Text.Equals("")||txt_nota2.Text.Equals("")||txt_nota2.Text.Equals(""))
                    {
                        MessageBox.Show("Faltan datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            /*creo un objeto tipo Becarios y asigno los campos al item y a los subitems del Listview. Después borro los campos.
                                * uso el bloque Try/Catch para capturar las excepciones por culpa de datos no válidos
                       */
                            becario = new Becarios(txt_nombre.Text, txt_Apellidos.Text, mtb_dni.Text, Convert.ToSingle(mtb_sueldoB1.Text), txt_carrera.Text, nm_curso.Value.ToString(), txt_deptB.Text, cb_universidad.SelectedItem.ToString(), Convert.ToInt32(txt_nota1.Text), Convert.ToInt32(txt_nota2.Text), Convert.ToInt32(txt_nota3.Text));
                            
                            ListViewItem bc = new ListViewItem("Becario");
                            bc.SubItems.Add(txt_nombre.Text);
                            bc.SubItems.Add(txt_Apellidos.Text);
                            bc.SubItems.Add(mtb_dni.Text);
                            bc.SubItems.Add(becario.CalculaSueldo().ToString());
                            bc.SubItems.Add(becario.Informacion());
                            lista.Items.Add(bc);


                            chb_jefe.Checked = false;
                            rb_cualificados.Checked = true;
                            txt_nombre.Text = "";
                            txt_Apellidos.Text = "";
                            mtb_dni.Text = "";
                            mtb_sueldoB1.Text = "";
                            txt_departamentoC.Text = "";
                            txt_titulacion.Text = "";
                            mtb_plus.Text = "";
                            cb_universidad.SelectedIndex = -1;
                            nm_curso.Value = 1;
                            errorProvider1.Clear();
                            MessageBox.Show("Empleado añadido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Datos no válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                       
                    }
                }
            }
            
        }

        private void txt_deptB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
