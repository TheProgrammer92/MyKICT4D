using System;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DesignSidebar.Controllers.Salles;
using DesignSidebar.Entities.Salles;

namespace DesignSidebar.Salles.components
{
    public partial class SearchComponent : UserControl
    {

        private static SearchComponent componentHome;

        private SalleControllers controller;

        private NiveauControllers N_controller;
        private int clickNiveau = 0;
        private int clickSalle = 0;
        private bool whatLevel = true;
        private string pathImg =@"../../resources/img/";
        private string pathIcon = @"../../resources/img/icon/";
        private string pathSalle = @"../../resources/fichier/Salles.csv";
        private string pathNiveau = @"../../resources/fichier/Niveau.csv";


        private BunifuCustomLabel labelEx;
        private BunifuCustomLabel labelEx2;

        String[,] tabs;


        private int widthBloc = 226;
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


            this.labelEx = LabelExample;
            this.labelEx2 = labelExample2;
          

        }
        // la fonction qui va update le dataGrid en fonction du boutton activé
        public void updateGrid()
        {

            if (btnNiveau.Enabled)
            {
                // update des  salle
                this.UpdateDataGrid();
            }
            else
            {
                this.UpdateDataGridNiveau();
            }

        }

        public void UpdateDataGrid()
        {
            this.controller = new SalleControllers();
            this.controller.LoadData(pathSalle);
            flowLayoutShowClass.Controls.Clear();
            foreach (SallesEntitie item in this.controller._data)
            {
                string[,] tab = this.createTab(1, item, null);

                generateSalleOrNiveau(tab);
                


            }
        }

        public void UpdateDataGridNiveau()
        {



            this.N_controller = new NiveauControllers();

            this.N_controller.LoadData(pathNiveau);

            flowLayoutShowClass.Controls.Clear();

            foreach (Entities.Salles.NiveauEntitie item in this.N_controller._data)
            {

                string[,] tab = this.createTab(0, null, item);


                generateSalleOrNiveau(tab);

            }
        }

        private string[,]  createTab(int whatLevel , SallesEntitie salle = null, NiveauEntitie niveau = null)
        {

            // si on est sur niveau
           
            if (whatLevel == 0)
            {
                

                string[,] tab =
                    {
                        {niveau.nom, niveau.specialite, niveau.nombre_ensegnant, niveau.nbre_ue, niveau.annee_scolaire, niveau.id},
                        {"Nom : "," Specilite : "," Enseignant : "," Nombre d'ue : "," Annee Scolaire : ", "id :"}
                    };
                this.tabs = tab;
                return tab;
            }

            else
            {
                string[,] tab = {
                   { salle.nom, salle.type, salle.batiment, salle.nbrePrise,salle.nbrPlace ,salle.id},
                    {"Nom ", "Type :", "Batiment : ", "Nombre de prise : ", "Nombre de place  : ", "id :" }

                };
                this.tabs = tab;

                return tab;
            }


           
        }

    
        private void generateSalleOrNiveau(String[,] tab)
        {
          
            Panel panel = new Panel();
            Color color = Color.FromName("white");
            panel.BackColor = color;
            panel.Margin = new System.Windows.Forms.Padding(10);

            panel.Width = widthBloc;
            panel.Height = 360;

            PictureBox pictureBox = new PictureBox();
            Image newImage = Image.FromFile(pathImg + "ecole.png");
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox.Image = newImage;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Width = widthBloc;
            pictureBox.Height =180;
            panel.Controls.Add(pictureBox);


            Panel panelBtnDelete = new Panel();
            string urlImg = pathIcon + "delete3.png";
            Point location = new Point
            {
                X = 0,
                Y = -50
            };

            panelBtnDelete = this.generateBtn(urlImg, location);


            panelBtnDelete.Dock = DockStyle.None;
            panel.Controls.Add(panelBtnDelete);
            panelBtnDelete.BringToFront();
  
           

            Panel panelBottom = new Panel();


            FlowLayoutPanel flowLayout = generateText(tab);

            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Width = widthBloc;
            panelBottom.Height = 170;
            flowLayout.Dock = DockStyle.Fill;
           
            panelBottom.Controls.Add(flowLayout);
            flowLayout.BringToFront();


            panel.Controls.Add(panelBottom);
            flowLayoutShowClass.Controls.Add(panel);
        }


        private FlowLayoutPanel generateText(String[,] tab)
        {

            FontFamily fontFTitle = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(
               fontFTitle,
               12,
               FontStyle.Bold,
               GraphicsUnit.Point, 0, false);


            FontFamily fontFItem = new FontFamily("Microsoft Sans Serif");
            Font fontItem = new Font(
               fontFItem,
               9,
               FontStyle.Regular,
               GraphicsUnit.Point);

            BunifuCustomLabel nom = new BunifuCustomLabel();
            nom.Text = tab[1, 0] + tab[0, 0];
            nom.Font = this.labelEx.Font;
            nom.BackColor = labelEx.BackColor;
            nom.ForeColor = labelEx.ForeColor;
            nom.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            nom.Width = widthBloc;

            BunifuCustomLabel batiment = new BunifuCustomLabel();
            batiment.Text = tab[1, 1] + tab[0, 1];
            batiment.Font = labelEx2.Font;
            batiment.BackColor = labelEx2.BackColor;
            batiment.ForeColor = labelEx2.ForeColor;
            batiment.Location = labelEx2.Location;
            batiment.Width = widthBloc;


            BunifuCustomLabel nbrePrise = new BunifuCustomLabel();
            nbrePrise.Text = tab[1, 2] + tab[0, 2];
            nbrePrise.Font = fontItem;
            nbrePrise.Font = labelEx2.Font;
            nbrePrise.BackColor = labelEx2.BackColor;
            nbrePrise.ForeColor = labelEx2.ForeColor;
            nbrePrise.Width = widthBloc;

            BunifuCustomLabel nbre_ue = new BunifuCustomLabel();
            nbre_ue.Text = tab[1, 3] + tab[0, 3];
            nbre_ue.Font = fontItem;
            nbre_ue.Font = labelEx2.Font;
            nbre_ue.BackColor = labelEx2.BackColor;
            nbre_ue.ForeColor = labelEx2.ForeColor;
            nbre_ue.Width = widthBloc;

            BunifuCustomLabel label5 = new BunifuCustomLabel();
            label5.Text = tab[1, 4] + tab[0, 4];
            label5.Font = fontItem;
            label5.Font = labelEx2.Font;
            label5.BackColor = labelEx2.BackColor;
            label5.ForeColor = labelEx2.ForeColor;
            label5.Width = widthBloc;


            FlowLayoutPanel flowLayout = new FlowLayoutPanel();


            flowLayout.Padding = new System.Windows.Forms.Padding(15);
            flowLayout.Controls.Add(nom);
            flowLayout.Controls.Add(batiment);
            flowLayout.Controls.Add(nbrePrise);
            flowLayout.Controls.Add(nbre_ue);
            flowLayout.Controls.Add(label5);

            return flowLayout;
        }

        
       
        private Panel generateBtn(String urlImage, Point location)
        {


            Panel panelBtnDelete = new Panel();
                PictureBox pictureDelete = new PictureBox();
                Image imgDelete = Image.FromFile(urlImage);
                pictureDelete.SizeMode = PictureBoxSizeMode.Zoom;
                pictureDelete.Location = location;
                pictureDelete.Dock = DockStyle.Right;
            panelBtnDelete.Width = widthBloc;
            panelBtnDelete.Height = 30;
            pictureDelete.Image = imgDelete;

           
            pictureDelete.Click += new System.EventHandler(m_pictureDelete_click);

            void m_pictureDelete_click(object sender, EventArgs e)
            {
                string path;

                path = getPath();
                // appel du modal qui va supprimer en fonction du path
                string str = "ohh pttit !!  Voulez vous vraiment " + this.tabs[0, 5] + " supprimer ? ";
                var modal = new smallComponents.ModalDeleteclass(str, this, path, this.tabs[0, 5]);
                modal.ShowDialog();
            }
            panelBtnDelete.Controls.Add(pictureDelete);

        
            return panelBtnDelete;
            
        }


        /**
         * 
         *la fonction qui va recuperer le path , en fonction du boutton cliqué
             */
        private string getPath()
        {
            string path= "../../resources/fichier/Salles.csv"; ;
            if (btnNiveau.Enabled)
            {
                this.whatLevel = true;
                path = this.pathSalle;
            }

            else
            {
                this.whatLevel = false;
                path = this.pathNiveau;
            }

            return path;
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

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton25_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnDeleteClass_Click_1(object sender, EventArgs e)
        {
      
        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutShowClass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSalles_Click(object sender, EventArgs e)
        {
           
            btnSalles.Enabled = false;

            btnNiveau.Enabled = true;
            this.whatLevel = true;
            
            this.UpdateDataGrid();
        }

        private void btnNiveau_Click(object sender, EventArgs e)
        {
            
            btnNiveau.Enabled = false;
            btnSalles.Enabled = true;
            this.whatLevel = false;
            
            this.UpdateDataGridNiveau();

        }

        private void flowLayoutShowClass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToFile_Click(object sender, EventArgs e)
        {

            var tableClass = tableLayoutShowClass;
            var tableContainer = tableLayoutContainerClass;

            var form = FormUpdateClasse.Instance(this, getPath(), this.whatLevel);

            form.Dock = DockStyle.Fill;
            var table = new TableLayoutPanel();
            table.ColumnCount = 2;
            table.RowCount = 1;

            table.Controls.Add(tableClass, 0, 0);
            table.Controls.Add(form, 1, 0);
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));

            table.Dock = DockStyle.Fill;

            tableLayoutContainerClass.Controls.Clear();
            tableLayoutContainerClass.Controls.Add(table);



        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void LabelExample_Click(object sender, EventArgs e)
        {

        }
    }
}
