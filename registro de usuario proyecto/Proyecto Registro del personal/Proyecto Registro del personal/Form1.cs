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
namespace Proyecto_Registro_del_personal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Sesion()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=registrodelpersonal";
            string query = "select * from  where user = '" + userTxtBox.Text + "' AND password = '" + pswTxtBox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Hola, bienvenido de nuevo :)");
                }
                else
                {
                    MessageBox.Show("Usuario / Contraseña Incorrecto :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Sesion();
            Form3 registrar = new Form3();
            registrar.Show();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Form2 registrar = new Form2();
            registrar.Show();
        }
    }
}
