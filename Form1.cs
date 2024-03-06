using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace App_Examen_Practico_RA2
{
    public partial class FormEstudiante : Form
    {
        private object dataGridViewEstudiante;
        private int Registro;

        public FormEstudiante()
        {
            InitializeComponent();
           
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ActivarControles();
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = true;          
            btn_Agregar.Enabled = true;
            LimpiarCampos();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Eliminar.Enabled = true;
            btn_Agregar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Add(txt_Matricula.Text, txt_Nombre.Text, cmb_Curso.Text, cmb_Seccion.Text, cmb_AreaTecnica.Text);
            // Limpiar los campos después de agregarlos al DataGridView
            LimpiarCampos();             

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este registro?",
                                                        "Eliminar Registro",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(Registro);
                    MessageBox.Show("Registro eliminado");
                }
            }
        }

        private void FormRegistroEstudiantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Preguntar al usuario antes de salir de la aplicación
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?",
                                                  "Salir",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ActivarControles()
        {            
            txt_Matricula.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Direccion.Enabled = true;            
            txt_Email.Enabled = true;
            txt_MaestroTitular.Enabled = true;
            cmb_Curso.Enabled = true;
            cmb_Seccion.Enabled = true;
            cmb_AreaTecnica.Enabled = true;
        }

        private void DesactivarControles()
        {
            txt_Matricula.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Direccion.Enabled = false;
            txt_Email.Enabled = false;
            txt_MaestroTitular.Enabled = false;
            cmb_Curso.Enabled = false;
            cmb_Seccion.Enabled = false;
            cmb_AreaTecnica.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txt_Matricula.Text = "";
            txt_Nombre.Text = "";
            txt_Direccion.Text = "";
            txt_Email.Text = "";
            txt_MaestroTitular.Text = "";
            cmb_Curso.SelectedIndex = -1;
            cmb_Seccion.SelectedIndex = -1;
            cmb_AreaTecnica.SelectedIndex = -1;
        }       

        private void GuardarArchivoTexto()
        {
            using (StreamWriter writer = new StreamWriter("estudiantes.txt"))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    writer.WriteLine($"{row.Cells["Matricula"].Value},{row.Cells["Nombre"].Value}," +
                                     $"{row.Cells["Curso"].Value},{row.Cells["Seccion"].Value}," +
                                     $"{row.Cells["AreaTecnica"].Value}");

                }
            }
        }
    }

   

}
