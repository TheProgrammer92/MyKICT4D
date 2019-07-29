using Bunifu.Framework.UI;
using DesignSidebar.Salles;
using DesignSidebar.Salles.components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignSidebar.Controllers.Salles
{
    class GenerateSalleController
    {
        private SearchComponent searchComponent;

        public GenerateSalleController(SearchComponent searchComponents)
        {
            this.searchComponent = searchComponents;

        }

        public FlowLayoutPanel GenerateTextForNiveau(SallesEntitie item)
        {

            FontFamily fontFTitle = new FontFamily("Microsoft Sans Serif");
            Font font = new Font(
               fontFTitle,
               12,
               FontStyle.Bold,
               GraphicsUnit.Point);

            FontFamily fontFItem = new FontFamily("Microsoft Sans Serif");
            Font fontItem = new Font(
               fontFItem,
               9,
               FontStyle.Regular,
               GraphicsUnit.Point);

            BunifuCustomLabel nom = new BunifuCustomLabel();
            nom.Text = "  Nom :  " + item.nom;
            nom.Font = font;

            BunifuCustomLabel batiment = new BunifuCustomLabel();
            batiment.Text = "    Batiment :  " + item.batiment;
            batiment.Font = fontItem;

            BunifuCustomLabel nbrePrise = new BunifuCustomLabel();
            nbrePrise.Text = "    Nombre de prise :  " + item.nbrePrise;
            nbrePrise.Font = fontItem;


            FlowLayoutPanel flowLayout = new FlowLayoutPanel();

            flowLayout.Controls.Add(nom);
            flowLayout.Controls.Add(batiment);
            flowLayout.Controls.Add(nbrePrise);

            return flowLayout;
        }
    }
}
