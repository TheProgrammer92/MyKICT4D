using DesignSidebar.Entities.Salles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSidebar.Salles
{


    class SallesEntitie
    {
        public string _batiment;
        public string _id;
        public string _nbrePrise;
        public string _nbrPlace;
        public string _nom;
        public string _type;

        public string batiment
        {

            get
            {

                return this._batiment;
            }
            set
            {
                this._batiment = value;
            }
        }



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


        public string nbrePrise
        {

            get
            {

                return this._nbrePrise;
            }
            set
            {
                this._nbrePrise = value;
            }
        }


        public string nbrPlace
        {

            get
            {

                return this._nbrPlace;
            }
            set
            {
                this._nbrPlace = value;
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

        public string type
        {

            get
            {

                return this._type;
            }
            set
            {
                this._type = value;
            }
        }


    }
}
