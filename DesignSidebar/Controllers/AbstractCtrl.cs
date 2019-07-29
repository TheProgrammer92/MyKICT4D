using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyICT4D.Controller
{
    public abstract class AbstractCtrl<T>
    {
        T _selected;
        List<String> _entetes;
        List<String> _modif;
        List<T> _data = new List<T>();
        public bool loadData(String path)
        {

            bool ok = false;
            StreamReader sr = new StreamReader(path);
            String ligne = null;
            int i = 0;
            while ((ligne = sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                    this._entetes = ligne.Split(new char[] { ';', ',' }).ToList();
                    i++;
                    ok = true;
                }
                else
                {
                    this._selected = constructObject(ligne.Split(new char[] { ';', ',' }));
                    if (this._selected != null)
                    {
                        if (this._data == null)
                            this._data = new List<T>();
                        this._data.Add(this._selected);
                    }

                }

            }
            sr.Close();
            return ok;
        }//readData

        public bool insertData(String path, string ligne)
        {


            StreamReader sr = new StreamReader(path);
            String content = null;
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                content += line + "\n";
            }//while
            sr.Close();

            StreamWriter sw = null;
            try
            {

                sw = new StreamWriter(path);
                sw.WriteLine(content + ligne);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                sw.Close();
            }

        }//insertData

        public void updateData(String path, int id, String updated_line)
        {
            StreamReader sr = new StreamReader(path);
            String ligne = null;
            int i = 0;
            String content = null;
            string temp_line = null;
            while ((ligne = sr.ReadLine()) != null)
            {
                
                if (i == id+1)
                {
                    if (temp_line != null)
                        content += temp_line + "\n";
                    temp_line = updated_line;
                }
                else
                {
                    if (temp_line != null)
                        content += temp_line + "\n";
                    temp_line = ligne;
                }//else

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

        }//updateData

        public void deleteData(String path, int id)
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
                    if(temp_line != null)
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

        }//deleteData

        public bool searchData(String path, string search_string)
        {

            bool ok = false;
            StreamReader sr = new StreamReader(path);
            String ligne = null;
            int i = 0;
            while ((ligne = sr.ReadLine()) != null)
            {
                if (i == 0)
                {
                    this._entetes = ligne.Split(new char[] { ';', ',' }).ToList();
                    i++;
                    ok = true;
                }
                else
                {
                    bool reached = search(ligne, search_string);

                    if (reached == true) {
                        this._selected = constructObject(ligne.Split(new char[] { ';', ',' }));
                        if (this._selected != null)
                        {
                            if (this._data == null)
                                this._data = new List<T>();
                            this._data.Add(this._selected);
                        }
                    }

                }

            }
            sr.Close();
            return ok;
        }//searchData

        private bool search(string ligne, string search_string)
        {
            bool state = false;
            List<string> keys = search_string.Split(new char[] {' ', ';', ',', '.', '\'', '%', '?', '|'}).ToList(),
                         elements = ligne.Split(new char[] { ';', ',' }).ToList();

            foreach (string elt in elements) {
                if (state == false)
                {
                    foreach (string key in keys)
                    {
                        if (elt.Contains(key))
                        {
                            state = true;
                            break;
                        }
                    }
                }
            }

            return state;

        }//search

        public abstract T constructObject(string[] values);

        public T selected
        {
            set { this._selected = value; }
            get { return this._selected; }
        }

        public List<string> entetes
        {
            set { this._modif = value; }
            get { return this._modif; }
        }

        public List<T> data
        {
            set { this._data = value; }
            get { return this._data; }
        }
    }
}
