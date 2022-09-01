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
    public partial class Form6 : Form
    {
        State state;
        public Form6(State state)
        {
            InitializeComponent();
            this.state = state; 
            this.checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 showForm4 = new Form4(state);
            showForm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 showForm7 = new Form7(state);
            showForm7.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "시간이 부족해서")
                state.one_two_1 = checkBox1.Checked;
            if (cb.Text == "대인관계 (사장님 혹은 타 직원과의 관계)")
                state.one_two_2 = checkBox2.Checked;
            if (cb.Text == "급여가 적어서")
                state.one_two_3 = checkBox3.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
