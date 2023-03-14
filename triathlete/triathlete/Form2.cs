using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triathlete.Models;

namespace triathlete
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bdearchambaud1Context cnx = new Bdearchambaud1Context();
            cb_choisir_club.DataSource = cnx.Clubs.OrderBy(x => x.ClubNom).ToList();
            cb_choisir_club.DisplayMember = "ClubNom";
            cb_choisir_club.ValueMember = "ClubId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void cb_choisir_club_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
