using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class issueditemU : Form
    {
        public issueditemU()
        {
            InitializeComponent();
        }

        private void issueditemU_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into issued values (@Item_Code,@Item_Name,@Quntity,@Tooked_Date,@Receive_Date,@Employee_Name,@Employee_Telephone)", con);
            cmd.Parameters.AddWithValue("@Item_Code", textBox1.Text);
            cmd.Parameters.AddWithValue("@Item_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Quntity", textBox3.Text);
            cmd.Parameters.AddWithValue("@Tooked_Date", dateTimePicker1.Value.ToString());
            cmd.Parameters.AddWithValue("@Receive_Date", dateTimePicker2.Value.ToString());
            cmd.Parameters.AddWithValue("@Employee_Name", textBox5.Text);
            cmd.Parameters.AddWithValue("@Employee_Telephone", textBox4.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("insert success!");
            vender_Load();
        }


        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  issued", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
