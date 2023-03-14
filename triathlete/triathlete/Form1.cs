using triathlete.Models;

namespace triathlete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bdearchambaud1Context cnx = new Bdearchambaud1Context();
            dgv_club.DataSource = cnx.Clubs.ToList();
        }
    }
}