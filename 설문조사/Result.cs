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

namespace 설문조사
{
    public partial class Result : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        State state;
        public Result(State state)
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);
            this.state = state;
            //form3
            if (this.state.grade_1 == true)
                학년.Text = "1학년";
            if (this.state.grade_2 == true)
                학년.Text = "2학년";
            if (this.state.grade_3 == true)
                학년.Text = "3학년";
            if (this.state.grade_4 == true)
                학년.Text = "4학년";
            //form4
            if (this.state.one_1 == true)
                일번답.Text = "하는 중 이다.";
            if (this.state.one_2 == true)
                일번답.Text = "과거엔 했으나 현재는 하지 않는다.";
            if (this.state.one_3 == true)
                일번답.Text = "한번도 안 해보았다.";
            //from5
            if (this.state.one_one_1 || this.state.one_one_2 || this.state.one_one_3 || this.state.one_one_4 ==false)
                일다시일답.Text = " ";
            if (this.state.one_one_1 == true)
                일다시일답.Text = "개인적인 목돈 마련";
            if (this.state.one_one_2 == true)
                일다시일답.Text = "생계 유지";
            if (this.state.one_one_3 == true)
                일다시일답.Text = "학비 마련";
            if (this.state.one_one_4 == true)
                일다시일답.Text = "사회 경험 쌓기";
            //form6
            if (this.state.one_two_1 || this.state.one_two_2 || this.state.one_two_3==false)
                일다시이답.Text = " ";
            if (this.state.one_two_1 == true)
                일다시이답.Text = "시간이 부족해서";
            if(this.state.one_two_2 == true)
                일다시이답.Text = "대인관계 (사장님 혹은 타 직원과의 관계)";
            if(this.state.one_two_3 == true)
                일다시이답.Text = "급여가 적어서";

            //form7
            if (this.state.two_1 || this.state.two_2 || this.state.two_3==false)
                이번답.Text = " ";
            if (this.state.two_1 == true)
                이번답.Text = "서비스직";
            if (this.state.two_2 == true)
                이번답.Text = "사무직";
            if (this.state.two_3 == true)
                이번답.Text = "건설직";
            if (this.state.two_4 == true)
                이번답.Text = "운전, 배달";
            //form8
            if (this.state.three_1 == true)
                삼번답.Text = "서비스직";
            if (this.state.three_2 == true)
                삼번답.Text = "사무직";
            if (this.state.three_3 == true)
                삼번답.Text = "건설직";
            if (this.state.three_4 == true)
                삼번답.Text = "운전, 배달";
            //form9
            if (this.state.four_1 == true)
                사번답.Text = "급여";
            if (this.state.four_2 == true)
                사번답.Text = "업 직종";
            if (this.state.four_3 == true)
                사번답.Text = "근무 시간, 요일";
            if (this.state.four_4 == true)
                사번답.Text = "근접성";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO survey_table (grade,one, one_one,one_two,two,three,four) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}');", 학년.Text, 일번답.Text, 일다시일답.Text, 일다시이답.Text, 이번답.Text, 삼번답.Text, 사번답.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.Hide();
            시작화면 showform1 = new 시작화면();
            showform1.Show();
        }
    }
}
