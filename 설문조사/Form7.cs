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
    public partial class Form7 : Form
    {
        State state;
        public Form7(State state)
        {
            this.state = state;
            InitializeComponent(); 
            this.checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            this.checkBox4.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 showForm6 = new Form6(state);
            showForm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 showForm8 = new Form8(state);
            showForm8.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "서비스직")
                state.two_1 = checkBox1.Checked;
            if (cb.Text == "사무직")
                state.two_2 = checkBox2.Checked;
            if (cb.Text == "건설직")
                state.two_3 = checkBox3.Checked;
            if (cb.Text == "운전, 배달")
                state.two_4 = checkBox4.Checked;
        }
    }
}
