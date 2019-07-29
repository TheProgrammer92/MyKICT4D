using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignSidebar.Salles.components;
namespace DesignSidebar.Controllers.Salles
{
    class FileController
    {

        public bool insertFile(string path, string liness, string entete ="")
        {

            //recuperation du dernier id
           

            StreamReader fichier = new StreamReader(path);

         



            int id = 0;
            string ligne;
                while ((ligne = fichier.ReadLine()) != null)
                {
                    id++;
                }
            fichier.Close();



            // s'il y'a pas de ligne

            string line = id + ";" + liness;


            if (id == 0)
            {
                // on ecrit aussi l'entete
                string[] lines = { entete };
                string[] lineT = { line };


                File.AppendAllLines(path, lines);
                File.AppendAllLines(path, lines);

                var modal = new DesignSidebar.Salles.components.smallComponents.ModalDeleteclass("oups !!   L'insertion s'est Bien passé!!!!!! ", false);
                modal.ShowDialog();

                return true;




            }

            else
            {

                string[] lines = { line };



                File.AppendAllLines(path, lines);
                var modal = new DesignSidebar.Salles.components.smallComponents.ModalDeleteclass("Merci d'avoir fait une insertion !!", false);
                modal.ShowDialog();


                return true;



            }
            return true;



        }

        public bool deleteData(string path , int id)
        {

            StreamReader sr = new StreamReader(path);
            String ligne = null;
            int i = 0;
            String content = null;
            string temp_line = null;
            while ((ligne = sr.ReadLine()) != null)
            {
                if (i != id + 1)
                {
                    if (temp_line != null)
                        content += temp_line + "\n";
                    temp_line = ligne;
                }
                i++;

            }//while
            content += temp_line;
            sr.Close();

            StreamWriter sw = null;
            try
            {

                sw = new StreamWriter(path);
                sw.WriteLine(content);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                sw.Close();
            }

            return true;
        }
    }
}
