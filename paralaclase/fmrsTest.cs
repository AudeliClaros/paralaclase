using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace paralaclase
{
    public partial class fmrsTest : Form
    {
        public fmrsTest()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            // prueba de conexión a base de datos
            
            string connectionString = ""; MySqlConnection conn;
            
            try 
            
            {
                connectionString = @ "Server = localhost; Database = smis099121; Uid = root; Pwd = usbw; Modo SSL = Ninguno"; 
                conn = new MySqlConnection (connectionString); conn.Open ();
                
                MetroFramework.MetroMessageBox.Show (this, "Se establecio conexion!",
                    "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            catch (Exception Ex) 
            {
                MetroFramework.MetroMessageBox.Show (this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }
    }
}
