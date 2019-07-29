using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  DesignSidebar.Salles.components.smallComponents;
namespace DesignSidebar.Salles.components
{
    public partial class SearchComponent : UserControl
    {

        private static SearchComponent componentHome;

        public  SearchComponent Instance
        {

            get
            {
                if (componentHome == null)
                {

                    componentHome = new SearchComponent();

                }

                return componentHome;
            }
        }
        public SearchComponent()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuHScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
           Console.WriteLine("je suis cliqué");
         

           


          

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {


            var tableClass = tableLayoutShowClass;
            var tableContainer = tableLayoutContainerClass;



            //tableLayoutContainerClass.Controls.Clear();




            //tableClass.Dock = DockStyle.None;


            //tableLayoutContainerClass.Controls.Add(tableLayoutShowClass);

            //tableLayoutContainerClass.Controls.Add(FormUpdateClasse.Instance);
            //var panel = tableLayoutShowClass;

            //increase panel rows count by one

            //add a new RowStyle as a copy of the previous one
           /* ColumnStyle temp = tableContainer.ColumnStyles[tableContainer.ColumnCount-1];
            
            tableContainer.ColumnStyles.Remove(temp);
            tableContainer.ColumnCount = 2;
            tableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));*/

            //add your three controls
            





            FormUpdateClasse form = FormUpdateClasse.Instance;

            form.Dock = DockStyle.Fill;
            var table = new TableLayoutPanel();
            table.ColumnCount = 2;
            table.RowCount = 1;

            table.Controls.Add(tableClass,0,0);
            table.Controls.Add(form,1,0);
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));

             table.Dock = DockStyle.Fill;
          
            tableLayoutContainerClass.Controls.Clear();
            tableLayoutContainerClass.Controls.Add(table);
           











        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            var modal = new smallComponents.ModalDeleteclass("Voulez vous vraiment supprimer ?");
            modal.ShowDialog();
        }

        private void bunifuImageButton25_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnDeleteClass_Click_1(object sender, EventArgs e)
        {
            var modal = new smallComponents.ModalDeleteclass("Voulez vous vraiment supprimer ?");
            modal.ShowDialog();
        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
