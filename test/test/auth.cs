using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                if(textBox2.Text == "admin")
                {
                    reg a = new reg();
                    a.Show();
                    this.Hide();
                }
            }
        }
    }
}
