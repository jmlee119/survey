using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 설문조사
{
    public partial class 시작화면 : Form
    {
        public 시작화면()
        {
            InitializeComponent();
        }

        private void 로그인_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\l6877\OneDrive\문서\load.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME = '" + ID.Text + "' and PASSWORD = '" + Password.Text + "'", sql);

            DataTable newTable = new DataTable();
            adapter.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                //로그인 성공인 경우
                this.Hide();

                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                // 로그인 실패시
                MessageBox.Show("아이디와 비밀번호를 확인해 주세요");
            }

        }
    }
}
