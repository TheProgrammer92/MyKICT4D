using DesignSidebar.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSidebar.Entities.Salles
{

    class NiveauEntitie { 

        public string _id;
        public string _nom;
        public string _specialite;
        public string _nbre_ue;
        public string _nombre_enseignant;
        public string _nbrEtudiant;
        public string _annee_scolaire;



        public string id
        {

            get
            {

                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string nom
        {

            get
            {

                return this._nom;
            }
            set
            {
                this._nom = value;
            }
        }

        public string specialite
        {

            get
            {

                return this._specialite;
            }
            set
            {
                this._specialite = value;
            }
        }

        public string nbre_ue
        {

            get
            {

                return this._nbre_ue;
            }
            set
            {
                this._nbre_ue = value;
            }
        }


        public string nombre_ensegnant
        {

            get
            {

                return this._nombre_enseignant;
            }
            set
            {
                this._nombre_enseignant = value;
            }
        }


        public string nbrEtudiant
        {

            get
            {

                return this._nbrEtudiant;
            }
            set
            {
                this._nbrEtudiant = value;
            }
        }

        public string annee_scolaire
        {

            get
            {

                return this._annee_scolaire;
            }
            set
            {
                this._annee_scolaire = value;
            }
        }


    }
}

