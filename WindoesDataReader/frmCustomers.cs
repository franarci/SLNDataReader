using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindoesDataReader
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            cargarCustomers();
        }

        private void cargarCustomers()
        {
            string consulta = "SELECT CustomerID,CompanyName,ContactName,ContactTitle,Address,City ,Region,PostalCode,Country,Phone,Fax FROM dbo.Customers";
            SqlConnection conexion = AdminDB.ConectarBase();

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader lector = comando.ExecuteReader();

            List<Customer> customers = new List<Customer>();
            while (lector.Read())
            {
                customers.Add(new Customer()
                {
                    CompanyName = lector["CompanyName"].ToString(),
                    ContactName = lector["ContactName"].ToString(),
                    ContactTitle = lector["ContactTitle"].ToString(),
                    Address = lector["Address"].ToString(),
                    City = lector["City"].ToString(),
                    Region = lector["Region"].ToString(),
                    PostalCode = lector["PostalCode"].ToString(),
                    Country = lector["Country"].ToString(),
                    Phone = lector["Phone"].ToString(),
                    Fax = lector["Fax"].ToString()
                });
            }

            grdCstomers.DataSource = customers;
        }
    }
}
