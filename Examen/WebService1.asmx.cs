using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Examen
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod(Description = "ListarCategories")]
        public DataSet ListarCategoria()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarCategoria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "ListarCustomers")]
        public DataSet ListarCustomers()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarCustomers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "ListarShippers")]
        public DataSet ListarShippers()
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ListarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adaptador.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Agregar Categories")]
        public DataSet AgregarCategories(string CategoryName, string Description)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_AgregarCategoria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CategoryName", CategoryName);
                comando.Parameters.AddWithValue("@Description", Description);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Agregar Customers")]
        public DataSet AgregarCustomers(string CustomerID, string CompanyName, string ContactName,string ContactTitle, 
            string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_AgregarCustomers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CustomerID", CustomerID);
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@ContactName", ContactName);
                comando.Parameters.AddWithValue("@ContactTitle", ContactTitle);
                comando.Parameters.AddWithValue("@Address", Address);
                comando.Parameters.AddWithValue("@City", City);
                comando.Parameters.AddWithValue("@Region", Region);
                comando.Parameters.AddWithValue("@PostalCode", PostalCode);
                comando.Parameters.AddWithValue("@Country", Country);
                comando.Parameters.AddWithValue("@Phone", Phone);
                comando.Parameters.AddWithValue("@Fax", Fax);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Agregar Shippers")]
        public DataSet AgregarShippers(string CompanyName, string Phone)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_AgregarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@Phone", Phone);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Buscar Shippers")]
        public DataSet BuscarShippers(string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_BuscarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Buscar Customers")]
        public DataSet BuscarCustomers(string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_BuscarCustomers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Buscar Categoria")]
        public DataSet BuscarCategoria(string criterio)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_BuscarCategoria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Criterio", criterio);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Actualizar Customers")]
        public DataSet ActualizarCustomers(string CustomerID, string CompanyName, string ContactName, string ContactTitle,
         string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ActualizarCustomers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CustomerID", CustomerID);
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@ContactName", ContactName);
                comando.Parameters.AddWithValue("@ContactTitle", ContactTitle);
                comando.Parameters.AddWithValue("@Address", Address);
                comando.Parameters.AddWithValue("@City", City);
                comando.Parameters.AddWithValue("@Region", Region);
                comando.Parameters.AddWithValue("@PostalCode", PostalCode);
                comando.Parameters.AddWithValue("@Country", Country);
                comando.Parameters.AddWithValue("@Phone", Phone);
                comando.Parameters.AddWithValue("@Fax", Fax);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Actualizar Shippers")]
        public DataSet ActualizarShippers(string ShipperID,string CompanyName, string Phone)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ActualizarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ShipperID", ShipperID);
                comando.Parameters.AddWithValue("@CompanyName", CompanyName);
                comando.Parameters.AddWithValue("@Phone", Phone);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Actualizar Categories")]
        public DataSet ActualizarCategories(string CategoryID,string CategoryName, string Description)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_ActualizarCategoria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CategoryID", CategoryID);
                comando.Parameters.AddWithValue("@CategoryName", CategoryName);
                comando.Parameters.AddWithValue("@Description", Description);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Eliminar Customers")]
        public DataSet EliminarCustomers(string CustomerID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_EliminarCustomers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CustomerID", CustomerID);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Eliminar Categoria")]
        public DataSet EliminarCategoria(string CategoryID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_EliminarCategoria", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CategoryID", CategoryID);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
        [WebMethod(Description = "Eliminar Shippers")]
        public DataSet EliminarShippers(string ShipperID)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand("sp_EliminarShippers", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ShipperID", ShipperID);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }
    }
}
