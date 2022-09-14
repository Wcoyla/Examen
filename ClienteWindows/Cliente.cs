using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        private static ServiceReference1.WebService1SoapClient servicio;
        private DataSet rpta;
        private void Cliente_Load(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.WebService1SoapClient();
            gvCliente.DataSource = servicio.ListarCustomers().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string ContactName = txtContactName.Text.Trim();
            string ContactTitle = txtContactTitle.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string Region = txtRegion.Text.Trim();
            string PostalCode = txtPostalCode.Text.Trim();
            string Country = txtCountry.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Fax = txtFax.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.AgregarCustomers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax);
            gvCliente.DataSource = servicio.ListarCustomers().Tables[0];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string ContactName = txtContactName.Text.Trim();
            string ContactTitle = txtContactTitle.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string Region = txtRegion.Text.Trim();
            string PostalCode = txtPostalCode.Text.Trim();
            string Country = txtCountry.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Fax = txtFax.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.ActualizarCustomers(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax);
            gvCliente.DataSource = servicio.ListarCustomers().Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string CustomerID = txtCustomerID.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.EliminarCustomers(CustomerID);
            gvCliente.DataSource = servicio.ListarCustomers().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCompanyName.Text.Trim();
            gvCliente.DataSource = servicio.BuscarCustomers(Buscar).Tables[0];
        }
    }
}
