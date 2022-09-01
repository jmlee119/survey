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
    public partial class Form3 : Form
    {
        State state = new State();
        public Form3()
        {
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "1학년")
                state.grade_1 = checkBox1.Checked;
            if (cb.Text == "2학년")
                state.grade_2 = checkBox2.Checked;
            if (cb.Text == "3학년")
                state.grade_3 = checkBox3.Checked;
            if (cb.Text == "4학년")
                state.grade_4 = checkBox4.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 showForm4= new Form4(state);
            showForm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            시작화면 showForm1 = new 시작화면();
            showForm1.Show();
        }
    }
}
