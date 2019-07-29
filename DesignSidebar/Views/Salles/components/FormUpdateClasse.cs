using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DesignSidebar.Controllers.Salles;

namespace DesignSidebar.Salles.components
{
    public partial class FormUpdateClasse : UserControl
    {

        private SearchComponent search;
        private string path="../../resources/fichier/Salles.csv";
        private bool whatLevel = true;
        public FormUpdateClasse(SearchComponent searchs, string paths, bool whatLevel)
        {
            this.path = paths;
            this.whatLevel = whatLevel;
            this.search = searchs;
            InitializeComponent();
            this.titleFormUpdate.Text = this.whatLevel ? "Ajouter une classe" : "Ajouter un niveau";

            if (!this.whatLevel)
            {

            this.attributeText();
            }
        }

        private void attributeText()
        {
            
            name_salle.Text = "specialité";
            type_salle.Text = "Nombre d'ue";
            Batiment_salle.Text = " nombre enseignant";
            Nombre_de_place_salle.Text = "Nombre place";
            Nombre_de_prises_salle.Text = "Nombre de prises";
        }

        private static FormUpdateClasse componentSearch;

        public static FormUpdateClasse Instance(SearchComponent search, string paths, bool whatLevel)
        {
            
                componentSearch = new FormUpdateClasse(search, paths, whatLevel);
            
                return componentSearch;
            
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox5_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void Nombre_de_place_salle_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateClasse_Click(object sender, EventArgs e)
        {
            String nom = name_salle.Text;
            String type = type_salle.Text;
            String batiment = Batiment_salle.Text;
            String nombre_place = Nombre_de_place_salle.Text;
            String nombre_prise = Nombre_de_prises_salle.Text;


          

            if (nom =="" || type =="" || batiment =="" || nombre_place =="" || nombre_prise =="" )
            {
                LabelError.Visible = true;
                LabelError.Text = "Vous devez remplir tous les champs";
            }
            else
            {

                FileController fileController = new FileController();
                string entitie;


                if (this.whatLevel)
                {
                    entitie = "id" + ";" + "nom" + ";" + "type " + ";" + "batiment " + ";" + "nombre place " + ";" + "nombre prise";

                }
                else
                {
                     entitie = "id" + ";" + "specialité" + ";" + "nombre ue " + ";" + "nombre enseignant" + ";" + "nombre etudiant" + ";" + "nombre etude" +";" + "annee scolaire";

                }
                string line = nom + ";" + type + ";" + batiment + ";" + nombre_place + "; " + nombre_prise;


                
              bool f =  fileController.insertFile(this.path, line, entitie);



                if (f)
                {
                    this.search.updateGrid();
                }

            }

        }
    }
}
