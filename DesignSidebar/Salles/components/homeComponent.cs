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
    }
}
