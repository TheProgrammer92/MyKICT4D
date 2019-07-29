using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSidebar.Salles.components.smallComponents
{
    public partial class ModalDeleteclass : Form
    {
        public ModalDeleteclass(string _message)
        {
            InitializeComponent();

            lblMsg.Text = _message;
        }

        
        private void ModalDeleteclass_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void icon_delay_Tick(object sender, EventArgs e)
        {

            icon_delay.Stop();
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowDialog(string message)
        {
            ModalDeleteclass md = new ModalDeleteclass(message);

            md.ShowDialog();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnNoDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYesDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseModalDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
