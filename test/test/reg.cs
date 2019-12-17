using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void reg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bdDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.bdDataSet.data);

        }
    }
}
