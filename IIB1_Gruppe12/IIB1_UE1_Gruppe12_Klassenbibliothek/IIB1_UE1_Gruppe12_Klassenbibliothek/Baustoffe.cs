using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB1_UE1_Gruppe12_Klassen
{
    [Serializable]
    public class Baustoffe
    {
        //Attribute
        public double Ms { get; set; }
        public double Brandlast { get; set; }
        public string Name { get; set; }
        public bool geschutzt { get; set; }
        public double H { get; set; }
        public double M { get; set; }



        public Dictionary<string, double> heizwert_db = new Dictionary<string, double>();
        public Dictionary<string, double> abbrandfaktor_db = new Dictionary<string, double>();

        //Baustoffe mit die Eigenschaften eingeben
        public Baustoffe()
        {
            heizwert_db.Add("Holz", 4.8);
            heizwert_db.Add("Papier", 4.02);
            heizwert_db.Add("Textile", 6.51);
            heizwert_db.Add("Kunststoffe", 8.35);
            heizwert_db.Add("Feste Brennstoffe", 6.93);
            heizwert_db.Add("Brennbare Flüssigkeiten", 9.77);
            heizwert_db.Add("Gummi", 9.45);
            heizwert_db.Add("Nahrungsmittel", 6.6);
            heizwert_db.Add("Elektronik", 5);
            heizwert_db.Add("Sonstige", 5.28);

            abbrandfaktor_db.Add("Holz", 0.63);
            abbrandfaktor_db.Add("Papier", 0.77);
            abbrandfaktor_db.Add("Textile", 0.64);
            abbrandfaktor_db.Add("Kunststoffe", 0.82);
            abbrandfaktor_db.Add("Feste Brennstoffe", 0.23);
            abbrandfaktor_db.Add("Brennbare Flüssigkeiten", 0.95);
            abbrandfaktor_db.Add("Gummi", 0.52);
            abbrandfaktor_db.Add("Nahrungsmittel", 0.75);
            abbrandfaktor_db.Add("Elektronik", 0.5);
            abbrandfaktor_db.Add("Sonstige", 0.69);

        }

        //Rechnungmethode für Brandlast
        public double getBrandlast(double ms, bool g, double h, double m, double A)
        {
            double y = 0.55;
            
            if (g)
            {
                this.Brandlast = ms * h * m * y / A;

            }
            else
            {
                this.Brandlast = ms * h * m / A;
            }
            return this.Brandlast;

        }

        public override string ToString()
        {
            return this.Name + "  " + this.Ms.ToString();
        }
    }




}