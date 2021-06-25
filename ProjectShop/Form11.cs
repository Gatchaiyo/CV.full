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

    public partial class Form11 : Form
    {
        List<bill> allbill = new List<bill>();
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

        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        private void Form11_Load(object sender, EventArgs e)
        {
            showBasket();
            showuser();
            price();
            allbill.Clear();

        }

        private void compbut_Click(object sender, EventArgs e)
        {

        }

        private void showbill()
        {

            MySqlConnection conn = databaseConnection();
            MySqlCommand bnn = new MySqlCommand("SELECT * FROM basket ", conn);
            conn.Open();
            MySqlDataReader adapter = bnn.ExecuteReader();
            while (adapter.Read())
            {

                Program.Name_product = adapter.GetString("Name").ToString();
                Program.Price_product = adapter.GetString("Price").ToString();
                Program.Amount_product = adapter.GetString("Amount").ToString();
                Program.Total_product = adapter.GetString("Sum").ToString();
                bill item = new bill()
                {
                    Name_product = Program.Name_product,
                    Price_product = Program.Price_product,
                    Amount_product = Program.Total_product,
                    Total_product = Program.Total_product,
                };
                allbill.Add(item);
            }
            conn.Close();
        }
        private void price()
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
        private void calcuBut_Click(object sender, EventArgs e)
        {
            if (addmoney.Text == "")
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน");
            }
            else
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


                    double money = double.Parse(addmoney.Text);
                    if (money >= all) ///program.cs
                    {
                        string date = System.DateTime.Now.ToString("yyyy-MM-dd"); // เข้าdata ชื่อว่า data
                        string time = System.DateTime.Now.ToString("HH:mm");   // เข้า database ชื่อว่า time
                        showbill(); ///เรียกใช้
                        totolbox.Text = Convert.ToString(money - all);
                        MySqlConnection conn = databaseConnection();
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM basket ";
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {

                                MySqlConnection conn2 = databaseConnection();
                                conn2.Open();

                                string sql = $"INSERT INTO history (Name,Amount,Price,Sum,customer_name,Name_admin,Phone,Adress,Date) VALUES (\"{ dr.GetValue(1).ToString()} \",\"{ dr.GetValue(2).ToString()}\",\"{ dr.GetValue(3).ToString()}\",\"{ dr.GetValue(4).ToString()}\",'" + customBux.Text + "','" + userbox.Text + "','" + phone.Text + "','" + address.Text + "','" + date + "')";
                                MySqlCommand cmd2 = new MySqlCommand(sql, conn2);
                                cmd2.ExecuteNonQuery();

                            }


                            MessageBox.Show("สั่งสินค้าสำเร็จ");
                            MySqlConnection conn3 = databaseConnection();
                            conn3.Open();
                            MySqlCommand cmd3 = conn3.CreateCommand();
                            cmd3.CommandText = "TRUNCATE TABLE basket"; /// TRUNCATE คือ delete เเเต่เร็วกว่า
                            cmd3.ExecuteNonQuery();
                            showBasket();
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                            allbill.Clear();
                            addmoney.Clear();
                            totolbox.Clear();
                        }
                    }
                    else if (money < all)
                    {
                        MessageBox.Show("จำนวนเงินไม่พอ");
                    }
                }
            }

        }
        
        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบเสร็จ", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(400, 50));
            e.Graphics.DrawString("SINGH GENERAL STORE ", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(255, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            e.Graphics.DrawString("ข้อมูลร้าน :เกศไชโย  โสสระเกษ  0959548358", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 150));
            e.Graphics.DrawString("              47 หมู่ที่ 5 บ้านหินเงิ้ม (ทรงไทยหลังใหญ่ๆ) ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            e.Graphics.DrawString("              ตำบลดอนยาวใหญ่ อำเภอโนนแดง จังหวัดนครราชสีมา 30360", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ          ชื่อเมนู                      ราคา(บาท)        จำนวน       ราคารวม(บาท)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int number = 1;
            int y = 345;
            foreach (var i in allbill)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.Name_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                e.Graphics.DrawString("   " + i.Price_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(400, y));
                e.Graphics.DrawString("   " + i.Amount_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(560, y));
                e.Graphics.DrawString("   " + i.Total_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(650, y));
                number = number + 1;

            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
            e.Graphics.DrawString("รวมทั้งสิ้น           " + priceBox.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (y + 30) + 45));
            e.Graphics.DrawString("ชื่อผู้ให้บริการ        " + userbox.Text + " ", new Font("supermarket", 16, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
            e.Graphics.DrawString("รับเงิน             " + addmoney.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, ((y + 30) + 45) + 45));
            e.Graphics.DrawString("เงินทอน            " + totolbox.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (((y + 30) + 45) + 45) + 45));

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

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1 && phone.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
        
    
}
