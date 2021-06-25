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
namespace ProjectShop
{
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;Allow User Variables = True";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void seedBut_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }

        private void animalBut_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Login otherForm = new Login();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void history_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
        public string useradmin;
        private void showuser()
        {
            MySqlConnection con = databaseConnection();
            con.Open();
            string selectU = "select Username from user WHERE Username ='" + useradmin + "'";
            MySqlCommand cmd3 = new MySqlCommand(selectU, con);

            using (MySqlDataReader read = cmd3.ExecuteReader())
            {
                while (read.Read())
                {
                    string user = read["Username"].ToString();
                    userbox.Text = user;
                }
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            showuser();
        }
    }
}
