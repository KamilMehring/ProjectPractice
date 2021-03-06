using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;



namespace ListOfWorkers
{

    public partial class Form1 : Form
    {
        //path of data base
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db"; //database creat debug folder


        SQLiteDataReader dr;

        public Form1()

        {
            InitializeComponent();

        }
        //show data in table
        private void data_show(SQLiteDataReader kl = null)
        {
            //if (kl == null)
            //    kl = dr;
            try
            {
                if (kl == null)
                {
                    var con = new SQLiteConnection(cs);

                    con.Open();

                    string stm = "SELECT id , name , surname , pesel , jobTitle , dateEmp, busniessPhone, phone ,adress , salary  FROM test";
                    var cmd = new SQLiteCommand(stm, con);
                    kl = cmd.ExecuteReader();
                }
                dr = kl;

                while (kl.Read())
                {
                    dataGridView1.Rows.Insert(0, kl.GetString(0), kl.GetString(1), kl.GetString(2), kl.GetString(3)
                        , kl.GetString(4), kl.GetString(5), kl.GetString(6), kl.GetString(7), kl.GetString(8), kl.GetString(9));
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }
        //create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection("Data Source=data_table.db"))
                {
                    sqlite.Open();
                    string sql = @"create table test(id integer primay key AUTOINCREMENT,
                                name ,surname , pesel ,   jobTitle 
                             , dateEmp  , busniessPhone ,phone  ,adress  , salary )";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot create");
                return;
            }
        }
        private void addWorker_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);


            try
            {

                cmd.CommandText = "INSERT INTO test(id , name , surname , pesel , jobTitle , dateEmp , busniessPhone , phone , adress , salary ) "
                    + "VALUES(@Id , @Name , @Surname , @Pesel , @JobTitle , @DateEmp , @BusniessPhone , @Phone , @Adress , @Salary  )";

                string ID = id.Text;
                string Name = name.Text;
                string Surname = surname.Text;
                string PESEL = pesel.Text;
                string JoBTitle = jobTitle.Text;
                string DataOfEmp = dateEmp.Text;
                string Bphone = busniessPhone.Text;
                string Phone = phone.Text;
                string Adress = adress.Text;
                string Salary = salary.Text;




                cmd.Parameters.AddWithValue("@Id", ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Pesel", PESEL);
                cmd.Parameters.AddWithValue("@JobTitle", JoBTitle);
                cmd.Parameters.AddWithValue("@DateEmp", DataOfEmp);
                cmd.Parameters.AddWithValue("@BusniessPhone", Bphone);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Adress", Adress);
                cmd.Parameters.AddWithValue("@Salary", Salary);





                dataGridView1.ColumnCount = 10;
                dataGridView1.Columns[0].Name = "id";
                dataGridView1.Columns[1].Name = "name";
                dataGridView1.Columns[2].Name = "surname";
                dataGridView1.Columns[3].Name = "pesel";
                dataGridView1.Columns[4].Name = "jobTitle";
                dataGridView1.Columns[5].Name = "dateEmp";
                dataGridView1.Columns[6].Name = "busniessPhone";
                dataGridView1.Columns[7].Name = "phone";
                dataGridView1.Columns[8].Name = "adress";
                dataGridView1.Columns[9].Name = "salary";



                string[] row = new string[] { ID, Name, Surname, PESEL, JoBTitle, DataOfEmp, Bphone, Phone, Adress, Salary };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }

        }


        private void saveWorker_Click(object sender, EventArgs e)
        {

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);

            try
            {
                //var cmd = con.CreateCommand();
                cmd.CommandText = @"UPDATE test SET name = @Name ,surname = @Surname , pesel=@Pesel ,
                 jobTitle = @JobTitle , dateEmp = @DateEmp , busniessPhone = @BusniessPhone
                 , phone = @Phone , salary = @Salary  where id = @Id";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Id", id.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Surname", surname.Text);
                cmd.Parameters.AddWithValue("@Pesel", pesel.Text);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle.Text);
                cmd.Parameters.AddWithValue("@DateEmp", dateEmp.Text);
                cmd.Parameters.AddWithValue("@BusniessPhone", busniessPhone.Text);
                cmd.Parameters.AddWithValue("@Phone", phone.Text);
                cmd.Parameters.AddWithValue("@Adress", adress.Text);
                cmd.Parameters.AddWithValue("@Salary", salary.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();

            }
            catch (Exception)
            {
                Console.WriteLine("cannot update data");
                return;
            }
        }

        private void delateWorker_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            //var cmd = new SQLiteCommand(con);


            try
            {
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM test where id =@Id";
                //cmd.Prepare();

                cmd.Parameters.AddWithValue("@Id", id.Text);
                cmd.Parameters.AddWithValue("@Name", name.Text);
                cmd.Parameters.AddWithValue("@Surname", surname.Text);
                cmd.Parameters.AddWithValue("@Pesel", pesel.Text);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle.Text);
                cmd.Parameters.AddWithValue("@DateEmp", dateEmp.Text);
                cmd.Parameters.AddWithValue("@BusniessPhone", busniessPhone.Text);
                cmd.Parameters.AddWithValue("@Phone", phone.Text);
                cmd.Parameters.AddWithValue("@Adress", adress.Text);
                cmd.Parameters.AddWithValue("@Salary", salary.Text);

                cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                name.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                surname.Text = dataGridView1.Rows[e.RowIndex].Cells["surname"].FormattedValue.ToString();
                pesel.Text = dataGridView1.Rows[e.RowIndex].Cells["pesel"].FormattedValue.ToString();
                jobTitle.Text = dataGridView1.Rows[e.RowIndex].Cells["jobTitle"].FormattedValue.ToString();
                dateEmp.Text = dataGridView1.Rows[e.RowIndex].Cells["dateEmp"].FormattedValue.ToString();
                busniessPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["busniessPhone"].FormattedValue.ToString();
                phone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                adress.Text = dataGridView1.Rows[e.RowIndex].Cells["adress"].FormattedValue.ToString();
                salary.Text = dataGridView1.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Create_db();
            data_show();

        }

        private void generate_Click(object sender, EventArgs e)
        {
            Random salaryGenerator = new Random();
            int tal = salaryGenerator.Next(2800, 10000);
            salary.Text = tal.ToString() + "zl";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void search_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string keyword = textBoxSearch.Text;
            //keyword  = string.Format("@Keyword", textBoxSearch.Text);
            var sb = new StringBuilder("SELECT name FROM test where ");
            try
            {


                var cmd = con.CreateCommand();
                //cmd.CommandText = "SELECT name FROM test where id like @Keyword ";
                //cmd.Prepare();
                if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
                {
                    //   sb.Append("id like '%@Keyword%' or name like '%@Keyword%'");
                    sb.Append(" id = @Keyword");
                    cmd.CommandText = sb.ToString();
                    cmd.Parameters.AddWithValue("@Keyword", textBoxSearch.Text);
                }
                // cmd.Parameters.AddWithValue("@Id", textBoxSearch.Text);
                // cmd.Parameters.AddWithValue("@Name", name.Text);

                //cmd.Parameters.AddWithValue("@Surname", surname.Text);
                //cmd.Parameters.AddWithValue("@Pesel", pesel.Text);
                //cmd.Parameters.AddWithValue("@JobTitle", jobTitle.Text);
                //cmd.Parameters.AddWithValue("@DateEmp", dateEmp.Text);
                //cmd.Parameters.AddWithValue("@BusniessPhone", busniessPhone.Text);
                //cmd.Parameters.AddWithValue("@Phone", phone.Text);
                //cmd.Parameters.AddWithValue("@Adress", adress.Text);
                //cmd.Parameters.AddWithValue("@Salary", salary.Text);



                var kl = cmd.ExecuteReader();

                // cmd.ExecuteNonQuery();
                dataGridView1.Rows.Clear();
                data_show(kl);

            }
            catch (Exception)
            {
                Console.WriteLine("cannot search data");
                return;
            }
        }



        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }
    }
}