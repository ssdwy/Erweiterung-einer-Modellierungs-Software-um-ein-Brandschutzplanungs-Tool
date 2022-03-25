using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB1_UE1_Gruppe12_Klassen
{
    [Serializable]
    public class Raum
    {
        //Attribute
        public string Identity { get; set; }
        public string Id { get; set; }
        public string Raum_bezeichnung { get; set; }
        public double Flaeche { get; set; }
        public string Typ { get; set; }
        public double Brandlast { get; set; }
        public int LE { get; set; }

        public List<Baustoffe> Baustoffliste = new List<Baustoffe>();

        public List<Feuerloescher> feuerloeschers = new List<Feuerloescher>();

        public Raum() { }

        public Raum(string raum_bezeichnung, string typ)
        {
            this.Typ = typ;
            this.Raum_bezeichnung = raum_bezeichnung;   
        }

        public override string ToString()
        {
            return this.Raum_bezeichnung + " " + this.Id;
        }
    }
}
