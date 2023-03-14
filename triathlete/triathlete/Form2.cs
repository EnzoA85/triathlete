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
            Bdearchambaud1Context cnx = new Bdearchambaud1Context();
            Club unClub = (Club)cb_choisir_club.SelectedItem;
            tbx_nom.Text = unClub.ClubNom;
            tbx_ville.Text = unClub.ClubVille;
            tbx_cp.Text = unClub.ClubCp;
            tbx_rue.Text = unClub.ClubRue;
            tbx_telephone.Text = unClub.ClubTel;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Bdearchambaud1Context cnx = new Bdearchambaud1Context();
            Club unClub = (Club)cb_choisir_club.SelectedItem;
            unClub.ClubNom = tbx_nom.Text;
            unClub.ClubVille = tbx_ville.Text;
            unClub.ClubCp = tbx_cp.Text;
            unClub.ClubRue = tbx_rue.Text;
            unClub.ClubTel = tbx_telephone.Text;

            cnx.Clubs.Update(unClub);
            cnx.SaveChanges();

            if (cnx.Clubs != null)
            {
                MessageBox.Show("Le club à été modifié");
            }
            else
            {
                MessageBox.Show("Le club n'a pas été modifié, une erreur est survenue");
            }
        }

        private void btn_creer_Click(object sender, EventArgs e)
        {
            Bdearchambaud1Context cnx = new Bdearchambaud1Context();
            Club newClub = new Club()
            {
                ClubNom = tbx_nom.Text,
                ClubVille = tbx_ville.Text,
                ClubRue = tbx_rue.Text,
                ClubCp = tbx_cp.Text,
                ClubTel = tbx_telephone.Text,
            };
            cnx.Clubs.Add(newClub);
            cnx.SaveChanges();
            if (cnx.Clubs != null)
            {
                MessageBox.Show("Le club à été ajouter");
                tbx_nom.Text = "";
                tbx_ville.Text = "";
                tbx_rue.Text = "";
                tbx_cp.Text = "";
                tbx_telephone.Text = "";
            }
            else
            {
                MessageBox.Show("Le club n'a pas été ajouter, une erreur est survenue");
            }
        }
    }
}
