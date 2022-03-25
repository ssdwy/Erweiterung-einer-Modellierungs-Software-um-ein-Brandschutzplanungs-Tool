using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIB1_UE1_Gruppe12_Klassen
{
    [Serializable]
    public class Stockwerk
    {
        private List<Raum> raumliste = new List<Raum>();

        public List<Raum> Raumliste { get => raumliste; set => raumliste = value; }

        public string Identity { get; set; }
        public string Bezeichnung { get; set; }
        public string Ebene { get; set; }

        public Stockwerk(string bezeichnung)
        {
            this.Bezeichnung = bezeichnung;
        }

        public Stockwerk (string bezeichnung, List<Raum> raumliste)
        {
            this.Bezeichnung = bezeichnung;
            this.Raumliste = raumliste;
        }

        public override string ToString()
        {
            return this.Bezeichnung;
        }
    }

}
