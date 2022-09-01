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
    
    public partial class Form4 : Form
    {
        State state;
        public Form4(State state)
        {
            InitializeComponent();
            this.state = state;
            this.checkBox1.CheckedChanged += CheckBox1_Checked;
            this.checkBox2.CheckedChanged += CheckBox1_Checked;
            this.checkBox3.CheckedChanged += CheckBox1_Checked;
        }

        private void CheckBox1_Checked(object sender, EventArgs e)
        {
            var cb = (CheckBox)sender;
            if (cb.Text == "하는 중 이다.")
                state.one_1 = checkBox1.Checked;
            if (cb.Text == "과거엔 했으나 현재는 하지 않는다.")
                state.one_2 = checkBox2.Checked;
            if (cb.Text == "한번도 안 해보았다.")
                state.one_3 = checkBox3.Checked;
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(state);
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 showForm5 = new Form5(state);
            showForm5.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form6 showForm6 = new Form6(state);
            showForm6.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form8 showForm8 = new Form8(state);
            showForm8.Show();
        }

       
    }
}
