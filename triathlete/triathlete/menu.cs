using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triathlete
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_club_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
