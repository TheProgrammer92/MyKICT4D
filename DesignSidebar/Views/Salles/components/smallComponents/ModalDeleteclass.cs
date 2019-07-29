using DesignSidebar.Controllers.Salles;
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

        private SearchComponent searchComponent;
      
        private string path = "../../resources/fichier/Salles.csv";
        string id;


        public ModalDeleteclass(string _message , SearchComponent searchComponents ,string paths, string id)
        {
            this.searchComponent = searchComponents;
            this.path = paths;
            this.id = id;

            InitializeComponent();

            lblMsg.Text = _message;
        }


        public ModalDeleteclass(string _message, bool isShowBtnDelete)
        {
            InitializeComponent();

            if (!isShowBtnDelete)
            {
                this.btnYesDelete.Visible = false;
                this.btnNoDelete.ButtonText = "Ok";
                this.labelConfirm.Text = "Veuillez cliquez sur le boutton Ok";
            }
           

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


          
           
        }

        public static void ShowDialog(string message, SearchComponent search, string path, string id)
        {
            using (ModalDeleteclass md = new ModalDeleteclass(message, search, path,id))
            {
                md.ShowDialog();
            }
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
            FileController fileController = new FileController();


            int id = int.Parse(this.id);

            bool b = fileController.deleteData(this.path, id);

            if (b)
            {
                // il va update en fonction , si on a cliqué sur le niveau ou la salle
                this.searchComponent.updateGrid();
               
                this.Close();
            }
        }

        private void btnCloseModalDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
