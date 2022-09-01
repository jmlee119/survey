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
    
    public partial class Form9 : Form
    {
        State state;
        public Form9(State state)
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
            Form8 showForm8 = new Form8(state);
            showForm8.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "급여")
                state.four_1 = checkBox1.Checked;
            if (cb.Text == "업 직종")
                state.four_2 = checkBox2.Checked;
            if (cb.Text == "근무 시간, 요일")
                state.four_3 = checkBox3.Checked;
            if (cb.Text == "근접성")
                state.four_4 = checkBox4.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Result result = new Result(state);
            result.Show();
        }
    }
}
