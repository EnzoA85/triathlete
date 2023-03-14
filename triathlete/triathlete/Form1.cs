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

        private void btn_add_edit_delete_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}