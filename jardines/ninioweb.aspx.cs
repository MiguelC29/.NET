using jardines.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jardines
{
    public partial class ninioweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            NinioDAO jardinDAO = new NinioDAO();
            Ninos nino = new Ninos();
            nino.NUIP = long.Parse(txtNIUP.Text);
            nino.tipoSangre = ddlTipoSangre.Text;
            nino.ciudadNacimiento = txtCiudadNacimiento.Text;
            nino.peso = int.Parse(txtPeso.Text);
            nino.estatura = double.Parse(txtEstatura.Text);

            
            /*
            if(jardinDAO.validarNombre(jardin.nombre))
            {
                jardinDAO.registrar(jardin);
                cargarDatos();
                visibilidadPaneles(false, true);
                limpiarCampos();
            } else
            {
                lblMensaje.Text = "El nombre del Jardín ya existe";
            }
             */
        }

        protected void gdvNinos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            visibilidadPaneles(true, false);
            visibilidadBotones(true, false);
            limpiarCampos();
            visibilidadIdJardin(false, false);
            lblTitulo.Text = "Registrar Niño";
            lblMensaje.Text = "";
        }

        public void visibilidadPaneles(bool panelRegistro, bool panelConsulta)
        {
            PanelRegistro.Visible = panelRegistro;
            PanelConsulta.Visible = panelConsulta;
        }

        public void visibilidadBotones(bool btn_Registrar, bool btn_Editar)
        {
            btnRegistrar.Visible = btn_Registrar;
            btnEditar.Visible = btn_Editar;
        }

        public void visibilidadIdJardin(bool lbl_IdNino, bool txt_IdJNino)
        {
            lblIdNino.Visible = lbl_IdNino;
            txtIdNino.Visible = txt_IdJNino;
        }

        public void limpiarCampos()
        {
            txtIdNino.Text = string.Empty;
            txtNIUP.Text = string.Empty;
            txtCiudadNacimiento.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtEstatura.Text = string.Empty;
        }
    }
}