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
    public partial class Form6 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void addtobasketBut_Click(object sender, EventArgs e)
        {
            shop f = new shop();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            f.ShowDialog();
        }

        private void showbasketBut_Click(object sender, EventArgs e)
        {
            chackbasket();
           
        }

        private void complsBut_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
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
        private void Form6_Load(object sender, EventArgs e)
        {
            showuser();

        }
        private void chackbasket()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM basket WHERE Id= 1 ", conn))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form10 f = new Form10();
                    f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                    f.useradmin = userbox.Text;
                    this.Hide();
                    f.ShowDialog();


                }
                else
                {
                    MessageBox.Show("กรุณาสั่งซื้อสินค้าก่อนเข้าสู่ตะกร้า");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
    }
}
