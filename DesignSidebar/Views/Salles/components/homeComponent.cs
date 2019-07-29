using System.Drawing;
using System.Windows.Forms;

namespace DesignSidebar.Salles.components
{
    public partial class homeComponent : UserControl
    {

        private static homeComponent componentHome;

        public  homeComponent Instance
        {
           
            get
            {
                if (componentHome == null)
                {

                    componentHome = new homeComponent();

                }

                return componentHome;
            }
        }
        public homeComponent()
        {

            this.Location = new Point(this.Width / 2 - this.Width / 2, this.Height / 2 - this.Height / 2);
            InitializeComponent();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeComponent_Load(object sender, System.EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, System.EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, System.EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, System.EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
