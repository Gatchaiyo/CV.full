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
    public partial class Form4 : Form
    {
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
            cmd.CommandText = "SELECT Id ,Name ,Amount,Price,Type,Image FROM stock";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            datashowstorck.DataSource = ds.Tables[0].DefaultView;

        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
        private void addBut_Click(object sender, EventArgs e)
        {
            MySqlConnection con = databaseConnection();
            byte[] image = null;
            //pictureBox3.ImageLocation = textLocation.Text;
            string filepath = textBox1.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            string sql2 = $" INSERT INTO stock (Name,Amount,Price,Type,Image) VALUES('" + nameBox.Text + "','" + numberBox.Text + "','" + priceBox.Text + "','" + typebox.Text + "',@Imgg)";
            if (con.State != ConnectionState.Open)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Open();
                MySqlCommand cmd2 = new MySqlCommand(sql2, con);
                cmd2.Parameters.Add(new MySqlParameter("@Imgg", image));
                cmd2.ExecuteNonQuery();
                con.Close();
                showStorck();
                nameBox.Clear();
                numberBox.Clear();
                priceBox.Clear();
                typebox.Clear();
            }
            


        }

        private void delBut_Click(object sender, EventArgs e)
        {
            int selectedRow = datashowstorck.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(datashowstorck.Rows[selectedRow].Cells["Id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM stock WHERE Id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showStorck();
                nameBox.Clear();
                numberBox.Clear();
                priceBox.Clear();
                typebox.Clear();
            }
        }

        private void datashowstorck_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            datashowstorck.CurrentRow.Selected = true;
            nameBox.Text = datashowstorck.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            numberBox.Text = datashowstorck.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
            priceBox.Text = datashowstorck.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
            typebox.Text = datashowstorck.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
            MySqlConnection con = databaseConnection();
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT Image FROM stock WHERE Name = '" + nameBox.Text + "'  ";
            datashowstorck.CurrentRow.Selected = true;
                        

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pictureBox1.Image = new Bitmap(ms);
            }
        }

        private void changeBut_Click(object sender, EventArgs e)
        {
            int selectedRow = datashowstorck.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(datashowstorck.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE stock SET Name = '" + nameBox.Text + "',Amount='" + numberBox.Text + "',Price='" + priceBox.Text + "',Type ='"+typebox.Text+"' WHERE Id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                showStorck();
                nameBox.Clear();
                numberBox.Clear();
                priceBox.Clear();
                typebox.Clear();
            }
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

                datashowstorck.DataSource = ds.Tables[0].DefaultView; //เเสดงตารางในdata1
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
            private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; .bmp; )|.png;*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                textBox1.Text = open.FileName;
            }
        }

        private void seedbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }

        private void animalbut_CheckedChanged(object sender, EventArgs e)
        {
            showType();
        }
        private void datashowstorck_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
