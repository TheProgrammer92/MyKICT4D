using DesignSidebar.Entities.Salles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSidebar.Controllers.Salles
{
    class NiveauControllers : AbstractControllers<NiveauEntitie>
    {

        public override NiveauEntitie ContructObject(string[] values)
        {
            NiveauEntitie sE = new NiveauEntitie();

            sE.id = values[0];
            sE.nom = values[1];
            sE.specialite = values[2];
            sE.nombre_ensegnant = values[3];
            sE.nbre_ue = values[4];
            sE.nbrEtudiant = values[4];
            sE.annee_scolaire = values[5];


            return sE;
        }
    }
}
