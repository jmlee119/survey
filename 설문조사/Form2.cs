using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 설문조사
{
    public partial class Form2 : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public Form2()
        {
            InitializeComponent(); 
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);
            listView1_load();

        }
        private void listView1_load()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("SELECT * FROM survey_table");

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listView1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["grade"].ToString());
                        item.SubItems.Add(table["one"].ToString());
                        item.SubItems.Add(table["one_one"].ToString());
                        item.SubItems.Add(table["one_two"].ToString());
                        item.SubItems.Add(table["two"].ToString());
                        item.SubItems.Add(table["three"].ToString());
                        item.SubItems.Add(table["four"].ToString());

                        listView1.Items.Add(item);
                    }
                    table.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }
    }
}
