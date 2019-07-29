using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignSidebar.Salles;
namespace DesignSidebar.Controllers.Salles
{
    class SalleControllers : AbstractControllers<SallesEntitie>
    {
        public override SallesEntitie ContructObject(string[] values)
        {

            SallesEntitie sE= new SallesEntitie();

            sE.id =values[0];
            sE.nom = values[1];
            sE.type = values[2];
            sE.batiment = values[3];
            sE.nbrePrise = values[4];
            sE.nbrPlace = values[5];
         


            return sE;
        }
    }
}
