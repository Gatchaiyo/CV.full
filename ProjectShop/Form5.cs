using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProjectShop
{
    public partial class Form5 : Form
    {
        List<bill> showbillstock = new List<bill>();
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showStorck()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id ,Name ,Amount,Price,Type FROM stock";
            printstock = "SELECT Id ,Name ,Amount,Price,Type FROM stock";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            showdataanimal.DataSource = ds.Tables[0].DefaultView;

        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showStorck();
            showType();
            showuser();
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
        public int sum;
        public string printstock;
        private void addBut_Click(object sender, EventArgs e)
        {
            showbillstock.Clear();
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            if (type == "แสดงสินค้าทั้งหมด")
            {
                if (nameBox.Text =="")
                {
                    cmd.CommandText = $"SELECT * FROM stock ";
                    printstock = $"SELECT * FROM stock ";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM stock WHERE Name like  '%" + nameBox.Text + "%' ";
                    printstock = $"SELECT * FROM stock WHERE Name like '%" + nameBox.Text + "%' ";
                }
                
            }
            else
            {
                if (nameBox.Text == "")
                {
                    cmd.CommandText = $"SELECT * FROM stock WHERE Type like '%" + type + "%'";
                    printstock = $"SELECT * FROM stock WHERE Type like '%" + type + "%' ";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM stock WHERE Name like '%" + nameBox.Text + "%' AND Type like '%" + type + "%'";
                    printstock = $"SELECT * FROM stock WHERE Name like '%" + nameBox.Text + "%' AND Type like '%" + type + "%' ";
                }
                
            }


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            MySqlDataReader read = cmd.ExecuteReader();
            sum = 0;
            while (read.Read())
            {
                sum = sum + int.Parse(read.GetString(2));

            }
            numberbox.Text = $"{sum}";
            conn.Close();
            showdataanimal.DataSource = ds.Tables[0].DefaultView;
            billstock();
            
        }

        private void billstock()
        {

            MySqlConnection conn = databaseConnection();
            
            
            MySqlCommand bnn = new MySqlCommand(printstock, conn); //printhistory ปริ้นให้เหมือนกับ ค้นหา
            conn.Open();

            MySqlDataReader adapter = bnn.ExecuteReader();
            while (adapter.Read())
            {

                Program.Name_product = adapter.GetString("Name").ToString();
                Program.Amount_product = adapter.GetString("Amount").ToString();


                bill item = new bill()
                {
                    Name_product = Program.Name_product,
                    Amount_product = Program.Amount_product,

                };
                showbillstock.Add(item);

            }
            conn.Close();

        }
        public string type;
        private void showType()
        {
            showbillstock.Clear();
            checktype();
            
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();
            if (type=="แสดงสินค้าทั้งหมด")
            {
                cmd.CommandText = "SELECT * FROM stock ";
                printstock = "SELECT * FROM stock ";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM stock WHERE Type = '" + type + "'";
                printstock = "SELECT * FROM stock WHERE Type = '" + type + "'";
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            MySqlDataReader read = cmd.ExecuteReader();
            sum = 0;
            while (read.Read())
            {
                sum = sum + int.Parse(read.GetString(2));

            }
            numberbox.Text = $"{sum}";
            
            conn.Close();

            showdataanimal.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
            billstock();
        }
        private void checktype()
        {
            if (radioButton1.Checked)
            {
                type = "แสดงสินค้าทั้งหมด";
            }
            if (seedbut.Checked)
            {
                type = "เมล็ดพืช";
            }
            if (animalbut.Checked)
            {
                type = "สัตว์";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบแสดงจำนวนสินค้า", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("SINGH GENERAL STORE", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(255, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(450, 150));


            if (nameBox.Text == "")
            {
                e.Graphics.DrawString("ชื่อ " + "รายการสินค้า", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }
            else
            {
                e.Graphics.DrawString("ชื่อ " + nameBox.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ          ชื่อสินค้า                                                            จำนวน (ชิ้น)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int number = 1;
            int y = 345;

            foreach (var i in showbillstock)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.Name_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                e.Graphics.DrawString("   " + i.Amount_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(650, y));

                number = number + 1;
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));

            e.Graphics.DrawString("จำนวนสินค้าที่เหลือ         " + numberbox.Text + " ชิ้น", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, ((y + 30) + 45) + 45));



        }

        private void seedbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void animalbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void printbut_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; //ปริ้น
            printPreviewDialog1.ShowDialog();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showStorck();
            nameBox.Clear();
            radioButton1.Checked = true;
        }
    }

        

        
    
}
