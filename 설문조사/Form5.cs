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
    public partial class Form5 : Form
    {
        State state;
        public Form5(State state)
        {
            InitializeComponent();
            this.state = state;
            this.checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 showForm3 = new Form4(state);
            showForm3.Show();
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
            if (cb.Text == "개인적인 목돈 마련")
                state.one_one_1 = checkBox1.Checked;
            if (cb.Text == "생계 유지")
                state.one_one_2 = checkBox2.Checked;
            if (cb.Text == "학비 마련")
                state.one_one_3 = checkBox3.Checked;
            if (cb.Text == "사회 경험 쌓기")
                state.one_one_4 = checkBox4.Checked;

        }
    }
}
