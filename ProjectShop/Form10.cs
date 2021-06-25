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
    public partial class Form10 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showBasket()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM basket";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            databasket.DataSource = ds.Tables[0].DefaultView;


        }
        public Form10()
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
        private void Form10_Load(object sender, EventArgs e)
        {
            showBasket();
            showuser();
            price();
        }
        public string OldNumP;
        public string PriceP;
        private void databasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            databasket.CurrentRow.Selected = true;
            nameBox.Text = databasket.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            numberBox.Text = databasket.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
            OldNumP = databasket.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
            PriceP = databasket.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
        }
        
        private void addBut_Click(object sender, EventArgs e)
        {

            int selectedRow = databasket.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(databasket.Rows[selectedRow].Cells["id"].Value);
            int Oldnumber = int.Parse(OldNumP);
            int Oldprice = int.Parse(PriceP);
            int newnum = int.Parse(numberBox.Text);
            int price_1 = Oldprice / Oldnumber;
            int New_price = price_1 * newnum;

            MySqlConnection conn = databaseConnection();
            conn.Open();
            string selectSql = "select * from stock where Name='" + nameBox.Text + "'";
            MySqlCommand cmd1 = new MySqlCommand(selectSql, conn);
            int old_stock_number;
            using (MySqlDataReader read = cmd1.ExecuteReader())
            {
                read.Read();
                string stock_number = (read["Amount"].ToString());
                int.TryParse(stock_number, out old_stock_number);
                read.Close();
            }
            string sql = "UPDATE basket set Price ='" + New_price + "',Amount = '" + newnum + "'Where id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (Oldnumber > newnum)
            {
                int pass_stock = Oldnumber - newnum;
                int newstock_number = old_stock_number + pass_stock;
                string sql2 = "UPDATE stock set Amount ='" + newstock_number + "'Where Name = '" + nameBox.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                int rows = cmd2.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขรายการเรียบร้อย");
                    showBasket();
                    nameBox.Clear();
                    numberBox.Clear();
                    PriceP = "";
                    OldNumP = "";
                }
            }
            if (newnum > Oldnumber)
            {
                int del_stock = newnum - Oldnumber;
                int newstock_number = old_stock_number - del_stock;
                string sql3 = "UPDATE stock set Amount ='" + newstock_number + "'Where Name = '" + nameBox.Text + "'";
                MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

                int rows2 = cmd3.ExecuteNonQuery();

                conn.Close();

                if (rows2 > 0)
                {
                    MessageBox.Show("แก้ไขรายการเรียบร้อย");
                    showBasket();
                    nameBox.Clear();
                    numberBox.Clear();
                    PriceP = "";
                    OldNumP = "";
                }
            }
            
        }
        

        private void price()
        {
           
            if (databasket.Rows.Count > 0) ///เรียกใช้
            {
                
                int selected = databasket.CurrentCell.RowIndex;
                int all = 0;
                for (int i = 0; i < databasket.Rows.Count; i++)
                {
                    if (databasket.Rows[i].Cells[4].Value != null && databasket.Rows[selected].Cells[4].Value.ToString() != "")
                    {
                        all = all + Convert.ToInt32(databasket.Rows[i].Cells[4].Value.ToString());

                    }

                }
                priceBox.Text = Convert.ToString(all);
                
                
                

            }
            
            
            
        }
        private void delBut_Click(object sender, EventArgs e)
        {
            int selectedRow = databasket.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(databasket.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM basket WHERE id ='" + deleteId + "'";
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = databaseConnection();
            con.Open();

            string selectSql = "select Amount from stock where Name='" + nameBox.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(selectSql, con);
            int old_stock_number;
            using (MySqlDataReader read = cmd3.ExecuteReader())
            {
                read.Read();
                string old_number = read["Amount"].ToString();
                int.TryParse(old_number, out old_stock_number);
                read.Close();
            }

            int old_price_number = int.Parse(OldNumP);
            int newstock_number = old_stock_number + old_price_number;

            string sql4 = "UPDATE stock set Amount ='" + newstock_number + "'Where Name = '" + nameBox.Text + "'";
            MySqlCommand cmd4 = new MySqlCommand(sql4, con);

            int rows = cmd4.ExecuteNonQuery();

            con.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบรายการเรียบร้อย");
                price();
                showBasket();
                nameBox.Clear();
                numberBox.Clear();

            }
            
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

        private void complsBut_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            f.useradmin = userbox.Text;
            this.Hide();
            f.ShowDialog();
        }
    }
}
