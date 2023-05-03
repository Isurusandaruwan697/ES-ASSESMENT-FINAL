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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminD obj = new AdminD();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into vender12 values (@Id,@Name,@Telephone,@Address,@Email)", con);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Telephone", textBox2.Text);
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Id", textBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            vender_Load();


            MessageBox.Show("Insert Success!");

        }

        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  vender12", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Telephone"].Value.ToString();
                textBox3.Text = row.Cells["Address"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
                textBox5.Text = row.Cells["Id"].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string name = textBox1.Text;
            string tele = textBox2.Text;
            string add = textBox3.Text;
            string email = textBox4.Text;
            int id = int.Parse(textBox5.Text);

            string Query = "DELETE FROM vender12 WHERE Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("deleted success!");
            vender_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string name = textBox1.Text;
            string tele = textBox2.Text;
            string add = textBox3.Text;
            string email = textBox4.Text;
            int id = int.Parse(textBox5.Text);

            string Query = "UPDATE vender12 SET Name='" + name + "', Telephone='" + tele + "',Address='" + add + "',Email='" + email + "' WHERE Id='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            MessageBox.Show("update Succesful!");
            vender_Load();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            vender_Load();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Supplyers obj = new Supplyers();
            this.Hide();
            obj.Show();

        }
        
       private void button7_Click(object sender, EventArgs e)
        {
            Stock obj=new Stock();
            this.Hide();
            obj.Show();
        }
    }
}
