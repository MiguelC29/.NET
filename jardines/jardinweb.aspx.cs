using jardines.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jardines
{
    public partial class jardinweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            JardinDAO jardinDAO = new JardinDAO();
            Jardines jardin = new Jardines();
            jardin.idJardin = int.Parse(txtIdJardin.Text);
            jardin.nombre = txtNombre.Text;
            jardin.direccion = txtDireccion.Text;
            jardin.estado = ddlEstado.Text;

            jardinDAO.registrar(jardin);
            cargarDatos();
            visibilidadPaneles(false, true);
            limpiarCampos();
        }

        public void cargarDatos()
        {
            JardinDAO jardinDAO = new JardinDAO();
            gdvJardines.DataSource = jardinDAO.consultarTodos();
            gdvJardines.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            visibilidadPaneles(true, false);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            visibilidadPaneles(false, true);
            limpiarCampos();
        }

        public void visibilidadPaneles(bool panelRegistro, bool panelConsulta)
        {
            PanelRegistro.Visible = panelRegistro;
            PanelConsulta.Visible = panelConsulta;
        }

        public void limpiarCampos()
        {
            txtIdJardin.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlEstado.SelectedIndex = 0;
        }
    }
}