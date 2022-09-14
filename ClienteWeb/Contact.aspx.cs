using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class Contact : Page
    {
        private static ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        private DataSet rsta;
        private void Listar()
        {
            gvCategoria.DataSource = servicio.ListarCategoria().Tables[0];
            gvCategoria.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string CategoryName = txtCategoryName.Text.Trim();
            string Description = txtDescription.Text.Trim();
            rsta = servicio.AgregarCategories(CategoryName, Description);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string CategoryID = txtCategoryID.Text.Trim();
            string CategoryName = txtCategoryName.Text.Trim();
            string Description = txtDescription.Text.Trim();
            rsta = servicio.ActualizarCategories(CategoryID,CategoryName, Description);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string CategoryID = txtCategoryID.Text.Trim();
            rsta = servicio.EliminarCategoria(CategoryID);
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCategoryName.Text.Trim();
            gvCategoria.DataSource = servicio.BuscarCategoria(Buscar).Tables[0];
            gvCategoria.DataBind();
            gvCategoria.Visible = true;
        }
    }
}