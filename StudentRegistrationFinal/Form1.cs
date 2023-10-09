using System.Data.SqlClient;

namespace StudentRegistrationFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-LLPI03G\\SQLEXPRESS; Initial Catalog=Student Registration; Integrated Security=True"); // User id=DESKTOP-LLPI03G\tyler;
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string id;
        bool Mode = true;
        string sql;


        public void load()
        {
            try
            {
                sql = "select * from Student Registration";
                cmd = new SqlCommand(sql, con);
                con.Open();
                read = cmd.ExecuteReader();
                drr = new SqlDataAdapter(sql, con);
                dataGridView1.Rows.Clear();


                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void getID(String id)
        {
            sql = "select * from Student Registration where id = '" + id + "' ";

            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                TBSTudentName.Text = read[1].ToString();
                TBCourse.Text = read[2].ToString();
                TBFee.Text = read[3].ToString();
            }
            con.Close();
        }




        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBSTudentName.Clear();
            TBCourse.Clear();
            TBFee.Clear();
            TBSTudentName.Focus();
            Save.Text = "Save";
            Mode = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = TBSTudentName.Text;
            string course = TBCourse.Text;
            string fee = TBFee.Text;

            if (Mode == true)
            {
                sql = "insert into Student(StudentName, Course, Fee) values(@StudentName, @Course, @Fee)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@Fee", fee);
                MessageBox.Show("Record Added");
                cmd.ExecuteNonQuery();

                TBSTudentName.Clear();
                TBCourse.Clear();
                TBFee.Clear();
                TBSTudentName.Focus();

            }
            else
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update Student set StudentName = @StudentName, Course = @Course, Fee = @Fee where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@Fee", fee);
                cmd.Parameters.AddWithValue("@id", id);
                MessageBox.Show("Record Updated");
                cmd.ExecuteNonQuery();

                TBSTudentName.Clear();
                TBCourse.Clear();
                TBFee.Clear();
                TBSTudentName.Focus();
                Save.Text = "Save";
                Mode = true;
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                Save.Text = "Edit";
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from Student where id = @id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();

            }



        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
