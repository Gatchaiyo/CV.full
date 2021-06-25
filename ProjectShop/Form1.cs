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
    public partial class Login : Form
    {
        private MySqlConnection databaseConnetion()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand("SELECT     Username ,Password FROM user WHERE Username='" + Usernamebox.Text + "' AND Password ='" + Passwordbox.Text + "'", conn))
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if(Usernamebox.Text == "admin")
                    {
                        Form3 f = new Form3();
                        f.useradmin = Usernamebox.Text;
                        this.Hide();
                        f.ShowDialog();
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                    }
                    else
                    {
                        Form6 f = new Form6();
                        f.useradmin = Usernamebox.Text;
                        this.Hide();
                        f.ShowDialog();
                        MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                    }
                                       

                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง!!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form12 otherForm = new Form12();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Passwordbox.PasswordChar = checkBox1.Checked ? '\0' : '*';
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}