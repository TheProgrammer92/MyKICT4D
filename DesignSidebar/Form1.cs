using DesignSidebar.Salles.components;
using DesignSidebar.Salles.components.smallComponents;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DesignSidebar
{
    public partial class Form1 : Form
    {
        private int mov;
        private int movX;
        private int movY;




        private Thread thread;
        public Form1()
        {

            InitializeComponent();
           /*  Thread t = new Thread(new ThreadStart(startForm));
              t.Start();
              Thread.Sleep(5000);

              tableLayoutPanelHome.Controls.Clear();
              using (homeComponent home = new homeComponent())
              {
                  tableLayoutPanelHome.Controls.Add(home.Instance);
                
                  home.Instance.Dock = DockStyle.Fill;
                  home.Instance.BringToFront();
              }


              t.Abort();
             */



        }


        public void startForm()
        {

            Application.Run(new RootLoader());
            



        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            //go to search component
            tableLayoutPanelHome.Controls.Clear();

            using (SearchComponent searchComponent = new SearchComponent())
            {
                tableLayoutPanelHome.Controls.Add(searchComponent.Instance);

                searchComponent.Instance.Dock = DockStyle.Fill;
                searchComponent.Instance.BringToFront();
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void showDrawer()
        {

            this.Show();
        }

        private void hideDrawer()
        {
            this.Hide();

        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {

                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);

            }
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyKICT4D_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {

           

            using (homeComponent home = new homeComponent())
            {
                tableLayoutPanelHome.Visible = false;
                    tableLayoutPanelHome.Controls.Clear();
                 
                    tableLayoutPanelHome.Controls.Add(home.Instance);

                    home.Instance.Dock = DockStyle.Fill;
                    home.Instance.BringToFront();


                tshow.ShowSync(tableLayoutPanelHome);
            }





        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            if (drawer.Visible)
            {   


                thide.HideSync(drawer);

            }

            else
            {

                tshow.ShowSync(drawer);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
