using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class About : Page
    {
        private static ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        private DataSet rsta;
        private void Listar()
        {
            gvCustomers.DataSource = servicio.ListarCustomers().Tables[0];
            gvCustomers.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string ContactName = txtContactName.Text.Trim();
            string ContactTitle = txtContactTitle.Text.Trim();
            string Addres = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string Region = txtRegion.Text.Trim();
            string PostalCode = txtPostalCode.Text.Trim();
            string Country = txtCountry.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Fax = txtFax.Text.Trim();

            rsta = servicio.AgregarCustomers(CustomerID,CompanyName,ContactName,ContactTitle,Addres,City,Region,PostalCode,Country,Phone,Fax);
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string ContactName = txtContactName.Text.Trim();
            string ContactTitle = txtContactTitle.Text.Trim();
            string Addres = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string Region = txtRegion.Text.Trim();
            string PostalCode = txtPostalCode.Text.Trim();
            string Country = txtCountry.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Fax = txtFax.Text.Trim();

            rsta = servicio.ActualizarCustomers(CustomerID, CompanyName, ContactName, ContactTitle, Addres, City, Region, PostalCode, Country, Phone, Fax);
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            rsta = servicio.EliminarCustomers(CustomerID);
            Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCompanyName.Text.Trim();
            gvCustomers.DataSource = servicio.BuscarCustomers(Buscar).Tables[0];
            gvCustomers.DataBind();
            gvCustomers.Visible = true;
        }
    }
}