using System;
using System.Collections.Generic;
using System.Text;

namespace IIB1_UE1_Gruppe12_Klassen
{
    [Serializable]
    public class Feuerloescher
    {
        //Attribute
        public string Identity { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public double Kapazitaet { get; set; }
        public double Preis { get; set; }

        public List<string> BrandklasseL = new List<string>();
        public string BrandklasseS { get; set; }


        public Feuerloescher()
        { }

        public Feuerloescher(string name, List<string> brandklasse)
        {
            this.Name = name;
            this.BrandklasseL = brandklasse;
        }

        public string ListtoString (List<string> BrandklasseL)
        {
            this.BrandklasseL = BrandklasseL;
            StringBuilder sb = new StringBuilder();

            foreach (string c in BrandklasseL)
            {
                sb.Append(c + ", ");
            }

            this.BrandklasseS = sb.ToString();
            return this.BrandklasseS;
        }

        public List<string> StringtoList(string BrandklasseS)
        {
            string[] strs = new string[4];
            strs = BrandklasseS.Split(',');

            foreach(string s in strs)
            {
                this.BrandklasseL.Add(s.Trim());
            }
            return this.BrandklasseL;
        }

        public override string ToString()
        {
            return this.Name +" "+ this.ID;
        }
    }
}
