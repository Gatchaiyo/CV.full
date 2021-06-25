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
    public partial class Form13 : Form
    {
        List<bill> reportbill = new List<bill>();
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=projectshop;Allow User Variables = True";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;

        }
       
        public Form13()
        {
            InitializeComponent();
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            if (userbox.Text == "admin")
            {
                Form3 f = new Form3();
                f.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                f.useradmin = userbox.Text;
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                Form6 f = new Form6();
                f.useradmin = userbox.Text;
                this.Hide();
                f.ShowDialog();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
            }
            
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            showuser();
            chackuser();
            
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
        private void chackuser()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            if (userbox.Text == "admin")
            {
                cmd.CommandText = $"SELECT * FROM history";
            }
            else
            {
                cmd.CommandText = $"SELECT * FROM history WHERE Name_admin ='"+ userbox.Text +"'";
            }
            
            

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();
            sum = 0; //ตัวแปรจำนวนเงิน
            num = 0; //ตัวแปรยอดรวมจำนวนสินค้า
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                sum = sum + int.Parse(read["Sum"].ToString());
                num = num + int.Parse(read["Amount"].ToString());
            }
            pricebox.Text = $"{sum}";
            Numbox.Text = $"{num}";
            conn.Close();

            showhistory.DataSource = ds.Tables[0].DefaultView;

        }

        public int sum;
        public int num;
        public string printhistory;
        private void searchbut_Click(object sender, EventArgs e)
        {
            reportbill.Clear();
            if (searchbox.Text != "")
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                if (userbox.Text == "admin") 
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND (Name_admin=@data or Name=@data)";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND (Name_admin=@data or Name=@data)";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Name_admin=@data2 AND Name=@data";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Name_admin=@data2 AND Name=@data";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("yyyy-MM-dd")); //เอาค่าจาก dateTimePicker ไปเก็บที่ parameters @date1
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@data", searchbox.Text);
                da.SelectCommand.Parameters.AddWithValue("@data2", userbox.Text);
                da.Fill(ds);
                conn.Close();
                showhistory.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนเงิน
                num = 0; //ตัวแปรยอดรวมจำนวนสินค้า
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    
                    sum = sum + int.Parse(read["Sum"].ToString());
                    num = num + int.Parse(read["Amount"].ToString());
                }
                pricebox.Text = $"{sum}";
                Numbox.Text = $"{num}";
                conn.Close();
                billHistory();
            }
            else
            {
                MySqlConnection conn = databaseConnection();

                DataSet ds = new DataSet();

                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                if (userbox.Text=="admin")
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2";
                }
                else
                {
                    cmd.CommandText = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Name_admin=@data2 ";
                    printhistory = $"SELECT * FROM history WHERE Date between @date1 and @date2 AND Name_admin = @data2" ;
                }
                

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                da.SelectCommand.Parameters.AddWithValue("@data2", userbox.Text);
                da.Fill(ds);
                conn.Close();
                showhistory.DataSource = ds.Tables[0].DefaultView;
                sum = 0; //ตัวแปรจำนวนยอดเงิน
                num = 0; //ตัวแปรยอดรวมจำนวนสินค้า
                conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    sum = sum + int.Parse(read["Sum"].ToString());
                    num = num + int.Parse(read["Amount"].ToString());
                }
                pricebox.Text = $"{sum}";
                Numbox.Text = $"{num}";
                conn.Close();
                billHistory();
            }
        }

        private void billHistory()
        {

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            MySqlCommand bnn = new MySqlCommand(printhistory, conn); //printhistory ปริ้นให้เหมือนกับ ค้นหา
            MySqlDataAdapter da = new MySqlDataAdapter(bnn);
            conn.Open();
            da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value.ToString("yyyy-MM-dd")); //จากปุ่มค้นหา
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value.ToString("yyyy-MM-dd")); //จากปุ่มค้นหา
            da.SelectCommand.Parameters.AddWithValue("@data", searchbox.Text); //ปุ่มค้นหา
            da.SelectCommand.Parameters.AddWithValue("@data2", userbox.Text);
            da.Fill(ds);

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
                Amount_product = Program.Amount_product,
                Total_product = Program.Total_product,

                };
                reportbill.Add(item);

            }
            conn.Close();
        }
        private void showhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void printbut_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; //ปริ้น
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบสรุปยอดขาย", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(350, 50));
            e.Graphics.DrawString("SINGH GENERAL STORE", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(255, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            if (dateTimePicker1.Text == dateTimePicker2.Text)
            {
                e.Graphics.DrawString("วันที่ " + dateTimePicker1.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            }
            else
            {
                e.Graphics.DrawString("ตั้งแต่ " + dateTimePicker1.Text + "  สิ้นสุด " + dateTimePicker2.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            }

            if (searchbox.Text == "")
            {
                e.Graphics.DrawString("ชื่อ " + "รายการที่ขายได้", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }
            else
            {
                e.Graphics.DrawString("ชื่อ " + searchbox.Text, new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            }

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ          ชื่อสินค้า                                 จำนวน                      ราคา (บาท)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int number = 1;
            int y = 345;

            foreach (var i in reportbill)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.Name_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                e.Graphics.DrawString("   " + i.Amount_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString("   " + i.Total_product, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(720, y));
                number = number + 1;
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));

            e.Graphics.DrawString("จำนวนที่ขายได้         " + Numbox.Text + " ชิ้น", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, ((y + 30) + 45) + 45));
            e.Graphics.DrawString("จำนวนเงินที่ได้รับ       " + pricebox.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(500, (((y + 30) + 45) + 45) + 45));
                                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chackuser();
        }
    }
}
