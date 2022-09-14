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
    public partial class Shippers : Form
    {
        public Shippers()
        {
            InitializeComponent();
        }
        private static ServiceReference1.WebService1SoapClient servicio;
        private DataSet rpta;
        private void Shippers_Load(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.WebService1SoapClient();
            gvShippers.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string CompanyName = txtCompanyName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.AgregarShippers(CompanyName, Phone);
            gvShippers.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string ShipperID = txtShipperID.Text.Trim();
            string CompanyName = txtCompanyName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.ActualizarShippers(ShipperID, CompanyName, Phone);
            gvShippers.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ShippersID = txtShipperID.Text.Trim();
            servicio = new ServiceReference1.WebService1SoapClient();
            rpta = servicio.EliminarShippers(ShippersID);
            gvShippers.DataSource = servicio.ListarShippers().Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Buscar = txtCompanyName.Text.Trim();
            gvShippers.DataSource = servicio.BuscarShippers(Buscar).Tables[0];
        }
    }
}
