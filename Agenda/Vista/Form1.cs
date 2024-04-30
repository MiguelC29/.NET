using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClsCiudad ciudad = new ClsCiudad();
            cmbCiudades.DataSource = ciudad.consultarCiudades().ToList();
            cmbCiudades.ValueMember = "idCiudad";
            cmbCiudades.DisplayMember = "nombreCiudad";

            mostrarPersonas();

        }

        private void mostrarPersonas()
        {
            ClsPersona persona = new ClsPersona();
            dgvPersonas.DataSource = (from p in persona.consultarPersona()
                                      select new
                                      {
                                          id = p.IdPersona,
                                          nombre = p.NombrePersona,
                                          apellido = p.ApellidoPersona,
                                          correo = p.CorreoPersona,
                                          telefono = p.TelefonoPersona,
                                          ciudad = p.Ciudad.NombreCiudad
                                      }).ToList();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            persona.IdPersona = int.Parse(txtIdPersona.Text);
            persona.NombrePersona = txtNombreP.Text;
            persona.ApellidoPersona = txtApellidoP.Text;
            persona.CorreoPersona = txtCorreoP.Text;
            persona.TelefonoPersona = long.Parse(txtTelefonoP.Text);
            persona.Ciudad = new ClsCiudad(int.Parse(cmbCiudades.SelectedValue.ToString()), cmbCiudades.Text);
            persona.registrarPersona(persona);
            mostrarPersonas();
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtIdPersona.Clear();
            txtNombreP.Clear();
            txtApellidoP.Clear();
            txtCorreoP.Clear();
            txtTelefonoP.Clear();
            cmbCiudades.SelectedIndex = 0;
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtIdPersona.Text = dgvPersonas.Rows[index].Cells[1].Value.ToString();
            txtNombreP.Text = dgvPersonas.Rows[index].Cells[2].Value.ToString();
            txtApellidoP.Text = dgvPersonas.Rows[index].Cells[3].Value.ToString();
            txtCorreoP.Text = dgvPersonas.Rows[index].Cells[4].Value.ToString();
            txtTelefonoP.Text = dgvPersonas.Rows[index].Cells[5].Value.ToString();
            cmbCiudades.Text = dgvPersonas.Rows[index].Cells[6].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            persona.IdPersona = int.Parse(txtIdPersona.Text);
            persona.NombrePersona = txtNombreP.Text;
            persona.ApellidoPersona = txtApellidoP.Text;
            persona.CorreoPersona = txtCorreoP.Text;
            persona.TelefonoPersona = long.Parse(txtTelefonoP.Text);
            persona.Ciudad = new ClsCiudad(int.Parse(cmbCiudades.SelectedValue.ToString()), cmbCiudades.Text);
            persona.editarPersona(persona);
            mostrarPersonas();
            limpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            int idPersona = int.Parse(txtIdPersona.Text);
            persona.eliminarPersona(idPersona);
            mostrarPersonas();
            limpiarCampos();
        }
    }
}
