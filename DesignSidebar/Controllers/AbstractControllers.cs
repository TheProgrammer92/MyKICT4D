using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignSidebar.Controllers
{
   public abstract  class AbstractControllers<T>
    {

         T selected;

        List<String> entetes;
        List<T> data= new List<T>();
        private int i = 0;
        //chargement des donnée
        public bool LoadData(String path)
        {
            bool ok = false;
            // permet d'afficher une ligne


            String ligne = null;
            // compteur permettant, de savoir, a quelle ligne on est
           

            StreamReader fichier = new StreamReader(path);


            while ((ligne=fichier.ReadLine())!= null)
            {

              
              
                if (i ==0)
                {

                    // si on es a la premiere ligne

                    this.entetes = ligne.Split(new char[]
                    {
                    ';',','}).ToList();

                    i++;
                    ok = true;

                }

                else {
               



                    // on generate un objet qui appelle une methode mermettant de contruire l'object
                    this.selected = ContructObject(ligne.Split(new char[]{';',','  }));
                   

                    // si la ligne selectionné, est different de null
                    if (this.selected!= null)
                    {

                        if (this.data == null)
                        {

                            this.data = new List<T>();
                            this.data.Add(this.selected);

                        }

                        else
                        {
                            this.data.Add(this.selected);


                        }

                    }
                    
                }

              

            }

            fichier.Close();
            return ok;
           

          

        }


        // toute les classe vont devoir implementer cette methode pour contruire l'object
        public abstract T ContructObject(String[] values);

        public T _selected
        {


            set
            {
                this.selected = value;
            }
        }


        public List<String> _entete
        {

            set
            {
                this.entetes = value;
                
            }

            get {

                return this.entetes;
            }
        }


        public List<T> _data
        {

            set
            {

                this.data = value;
            }
             get
            {

                return this.data;
            }
        }
    }
}