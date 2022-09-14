using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ClienteWeb
{
    public partial class Shippers : System.Web.UI.Page
    {
        private static ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        private DataSet rsta;
        private void Listar()
        {
            gvShippers.DataSource = servicio.ListarShippers().Tables[0];
            gvShippers.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string CompanyName = txtCompanyName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            rsta = servicio.AgregarShippers(CompanyName, Phone);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string ShipperID = txtShipperID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            rsta = servicio.ActualizarShippers(ShipperID, CompanyName, Phone);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string ShipperID = txtShipperID.Text.Trim();
            rsta = servicio.EliminarShippers(ShipperID);
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCompanyName.Text.Trim();
            gvShippers.DataSource = servicio.BuscarShippers(Buscar).Tables[0];
            gvShippers.DataBind();
            gvShippers.Visible = true;
        }
    }
}