using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSidebar.Salles.components
{
    public partial class RootLoader : UserControl
    {
        public RootLoader()
        {
            InitializeComponent();
        }

        int dir = -1;

        private void loaderHome_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value ==80)
            {

                dir = -1;

                bunifuCircleProgressbar1.animationIterval = 4;

            }

            else if (bunifuCircleProgressbar1.Value == 20)
            {

                dir++;
                bunifuCircleProgressbar1.animationIterval = 1;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
