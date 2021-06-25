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
using System.IO;
namespace ProjectShop
{
    public partial class Form8 : Form
    {
        int Amount;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showStorck()
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id ,Name ,Amount,Price,Image FROM stock";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);

                conn.Close();

                showdataseed.DataSource = ds.Tables[0].DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public Form8()
        {
            InitializeComponent();
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
        private void Form8_Load(object sender, EventArgs e)
        {
            showStorck();
            showuser();
            showType();


        }
        public string type;
        private void showType()
        {
            if (radioButton1.Checked)
            {
                showStorck();
            }
            else
            {
                checktype(); //เช็ค
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM stock WHERE Type = '" + type + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();

                showdataseed.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
            }
        }
        private void checktype()
        {
            if (seedbut.Checked)
            {
                type = "เมล็ดพืช";
            }
            if (animalbut.Checked)
            {
                type = "สัตว์";
            }
        }
        
        private void showdataseed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showdataseed.CurrentRow.Selected = true;
            string numberstock = showdataseed.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
            if(numberstock == "0")
            {
                MessageBox.Show("จำนวนสินค้าไม่เพียงพอ");
            }
            else
            {
                
                nameBox.Text = showdataseed.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                priceBox.Text = showdataseed.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                Amountbox.Text = showdataseed.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();

                showdataseed.CurrentRow.Selected = true;
                int selectedRow = showdataseed.CurrentCell.RowIndex;
                string name = Convert.ToString(showdataseed.Rows[selectedRow].Cells["Name"].Value); ///สร้างตัวแปร

                MySqlConnection con = databaseConnection();
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "SELECT Image FROM stock WHERE Name = '" + name + "'  ";
                showdataseed.CurrentRow.Selected = true;

                Amount = Convert.ToInt32(showdataseed.Rows[selectedRow].Cells["Amount"].Value);
                numberBox.Text = Amount.ToString();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pictureBox1.Image = new Bitmap(ms);
                }
            }
            

        }
        int numberstocker;
        private void addBut_Click(object sender, EventArgs e)
        {
            if (numberBox.Text!="")
            {
                
                int newnum = int.Parse(numberBox.Text);
                if (numberstocker>=newnum)
                {
                    showdataseed.CurrentRow.Selected = true;
                    int selectedRow = showdataseed.CurrentCell.RowIndex;
                    string Price = Convert.ToString(showdataseed.Rows[selectedRow].Cells["Price"].Value);
                    MySqlConnection conn = databaseConnection();
                    String sql = "INSERT INTO basket SET Name = '" + nameBox.Text + "' ,Amount = '" + numberBox.Text + "',Price = '" + priceBox.Text + "',Sum = '" + numberBox.Text + "' * '" + Price + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("เพิ่มสินค้าลงในตะกร้าสำเร็จ");
                        showStorck();
                        delstork();
                    }
                }
                else
                {
                    MessageBox.Show("สินค้าในร้านไม่เพียงพอ");
                }
                
            }
            else
            {
                MessageBox.Show("กรุณากรอกจำนวนสินค้า");
            }
            
        }
        private void delstork()
        {
            Amount -= Convert.ToInt32(numberBox.Text);
            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE stock SET Amount = '" + Amount + "' WHERE Name = '" + nameBox.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            showStorck();
        }
        private void backBut_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void showdataseed_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void seedbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void animalbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }
    }
}
