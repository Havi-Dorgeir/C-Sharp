using System.Data;
using System.Data.SqlClient;
namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyEmpty = true;
                        break;
                    }

                }
            }
            {
                if (isAnyEmpty)
                {
                    MessageBox.Show("Please, fill the required form.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con = GetConnection();
                    con.Open();
                    string insertQuery = "INSERT INTO crudapp (email," +
                        "name,password,username) " +
                        "VALUES (@email,@name,@password,@username)";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageF(count);


                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                control.Visible = !(control is DataGridView);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            con = GetConnection();
            con.Open();
            string updateQuery = "UPDATE crudapp SET email= @email, " +
                "name= @name," +
                " password=@password, " +
                "username = @username " +
                "WHERE " +
                " id = @id";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@id", numericUpDownID.Value);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            Read_Click(sender, e);
            MessageF(count);

        }

        private void Read_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {

                control.Visible = true;

            }
            con = GetConnection();
            con.Open();
            string readQuery = "SELECT * FROM crudapp";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=crudapp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
        private void MessageF(int count)
        {
            if (count > 0)
            {
                MessageBox.Show("update successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" error in update", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con = GetConnection();
            con.Open();
            string deleteQuery = "DELETE FROM crudapp WHERE id = @id";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@id", numericUpDownID.Value);
            int count = cmd.ExecuteNonQuery();
            Read_Click(sender, e);
            if (count > 0)
            {
                MessageBox.Show("delete successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
