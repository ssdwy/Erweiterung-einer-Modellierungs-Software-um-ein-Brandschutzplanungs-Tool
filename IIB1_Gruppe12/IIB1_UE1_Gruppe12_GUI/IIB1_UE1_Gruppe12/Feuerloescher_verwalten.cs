using IIB1_UE1_Gruppe12_Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace IIB1_UE1_Gruppe12_GUI
{
    public partial class Feuerlöscher_verwalten : System.Windows.Forms.Form
    {
        #region Initialisierung und Instanziierung
        public Raum ra;
        Feuerloescher fl;
        List<Feuerloescher> feuerloeschers = new List<Feuerloescher>();
        #endregion

        #region new Eigenschaften
        private ExternalEvent _updateEventF;
        private ExternalEvent _placeEvent;
        public Feuerloescher _fl;
        public Feuerloescher NewFeuerloescher { get; set; }
        
        public class PlaceData
        {
            public Raum raum;
            public Feuerloescher feuerloescher;
        }

        public PlaceData _cpr;
        #endregion

        #region Konstrukturfunktion und Load
        public Feuerlöscher_verwalten(Raum ra, MAINGUI _parent)
        {
            InitializeComponent();
            this.ra = ra;
            this.Owner = _parent;
        }

        public Feuerlöscher_verwalten(ExternalEvent _updateEventF, ExternalEvent _placeEvent, Raum ra, MAINGUI _parent)
        {
            InitializeComponent();
            this._updateEventF = _updateEventF;
            this._placeEvent = _placeEvent;
            this.ra = ra;
            this.Owner = _parent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> f1 = new List<string>() { "A", "B", "C" };
            List<string> f8 = new List<string>() { "B" };
 

            feuerloeschers.Add(new Feuerloescher("Feuerlöscher Pulver", f1));
            feuerloeschers.Add(new Feuerloescher("Feuerlöscher CO2", f8));


            label2.Text = ra.LE.ToString();

            Feuerloescheranzeigen(feuerloeschers);

            foreach(Feuerloescher fe in ra.feuerloeschers)
            {
                listBox_ausgewaehlt.Items.Add(fe);
            }

            if(listBox_ausgewaehlt.Items.Count == 0)
            {
                button_fe_speichern.Enabled = false;
            }

            ergebnisZeigen();

        }

        public void ergebnisZeigen()
        {
            List<double> ergib = Rechnung(ra.feuerloeschers);
            label6.Text = ergib[0].ToString();
            label8.Text = ergib[1].ToString();
            label16.Text = ra.feuerloeschers.Count.ToString();

            label11.Text = anzahlBerechnung();
        }
        #endregion

        #region Feuerloescher Informationen zeigen
        public void feuerloescherInfoZeigen (Feuerloescher feuerloescher)
        {
            checkBox_a.Checked = false;
            checkBox_b.Checked = false;
            checkBox_c.Checked = false;
            checkBox_f.Checked = false;

            textBox_Name.Text = feuerloescher.Name;

            if (feuerloescher.BrandklasseL != null)
            {
                if (feuerloescher.BrandklasseL.Contains("A"))
                    checkBox_a.Checked = true;
                if (feuerloescher.BrandklasseL.Contains("B"))
                    checkBox_b.Checked = true;
                if (feuerloescher.BrandklasseL.Contains("C"))
                    checkBox_c.Checked = true;
                if (feuerloescher.BrandklasseL.Contains("F"))
                    checkBox_f.Checked = true;
            }
            textBox_Kap.Text = feuerloescher.Kapazitaet.ToString();
            textBox_Preis.Text = feuerloescher.Preis.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Feuerloescher auswaehlen
            fl = (Feuerloescher)comboBox1.SelectedItem;

            if (fl == null)
                MessageBox.Show("Bitte wählen Sie einen Feuerlöscher aus! ");
            else
            {
                feuerloescherInfoZeigen(fl);
                //Feuerloescher anzahl geben
                ergebnisZeigen();
            }
        }
            
        private void listBox_ausgewaehlt_SelectedIndexChanged(object sender, EventArgs e)
        {

            fl = (Feuerloescher)listBox_ausgewaehlt.SelectedItem;
            if (fl == null)
                MessageBox.Show("Bitte wählen Sie zuerst einen Feuerlöscher aus!");
            else
            {
                comboBox1.Text = fl.Name;
                feuerloescherInfoZeigen(fl);
                ergebnisZeigen();
            }
        }
        #endregion

        #region Neuer Feuerloescher erstellen
        public void feuerloescherZuordnung(Feuerloescher nfl)
        {
            nfl.Name = textBox_Name.Text;

            try
            {
                nfl.Kapazitaet = Convert.ToDouble(textBox_Kap.Text);

            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Zahl für Kapazität ein! :( ");
                goto b;
            }


            nfl.BrandklasseL.Clear();
            if (checkBox_a.Checked)
                nfl.BrandklasseL.Add("A");
            if (checkBox_b.Checked)
                nfl.BrandklasseL.Add("B");
            if (checkBox_c.Checked)
                nfl.BrandklasseL.Add("C");
            if (checkBox_f.Checked)
                nfl.BrandklasseL.Add("F");

            try
            {
                nfl.Preis = Convert.ToDouble(textBox_Preis.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie eine Zahl für Preis ein! :( ");
                goto b;
            }

            nfl.BrandklasseS = nfl.ListtoString(nfl.BrandklasseL);

        b:;
        }

        private void Feuerloescheranzeigen(List<Feuerloescher> fls)
        {
            comboBox1.Items.Clear();

            foreach (Feuerloescher fe in fls)
            {
                comboBox1.Items.Add(fe);
            }
        }

        #endregion

        #region Feuerloescher verweisen
        private List<double> Rechnung(List<Feuerloescher> fls)
        {
            //Kapaztitaet rechnen
            List<double> ergib = new List<double>();

            double kap = 0;
            double pre = 0;

            foreach (Feuerloescher fl in fls)
            {
                kap += fl.Kapazitaet;
                pre += fl.Preis;
            }

            ergib.Add(kap);
            ergib.Add(pre);

            return ergib;
        }

        private string anzahlBerechnung()
        {
            string ergebnis = null;
            double LE = ra.LE;
            double summe = 0;
            foreach (Feuerloescher fe in ra.feuerloeschers)
            {
                summe += fe.Kapazitaet;
            }

            Feuerloescher fl1 = comboBox1.SelectedItem as Feuerloescher;
            Feuerloescher fl2 = listBox_ausgewaehlt.SelectedItem as Feuerloescher;

            int anzahl = 0;

            if (fl1 == null && fl2 == null)
                return ergebnis;

            if (fl1 == null)
            {               
                if (fl2.Kapazitaet != 0)
                {
                    anzahl = Convert.ToInt32(Math.Ceiling((LE - summe) / fl2.Kapazitaet));
                    ergebnis = "Sie brauchen noch " + anzahl.ToString() + " " + fl2.Name + " Feuerlöscher";
                }
                else
                    ergebnis = "Achtung! Die Kapazität des Feuerlöschers ist Null!";
            }
            else           
            {
                if (fl1.Kapazitaet != 0)
                {
                    anzahl = Convert.ToInt32(Math.Ceiling((LE - summe) / fl1.Kapazitaet));
                    ergebnis = "Sie brauchen noch " + anzahl.ToString() + " " + fl1.Name + " Feuerlöscher";
                }
                else
                    ergebnis = "Achtung! Die Kapazität des Feuerlöschers ist Null!";
            }

            if (anzahl < 0)
                ergebnis = "Sie brauchen noch 0 " + fl1.Name + " Feuerlöscher";

            return ergebnis;
        }



        #endregion

        #region Die unterschiedlche Feuerlöscher für die unterschiedliche Brandklasse verweisen
        private List<Feuerloescher> flauswaehlen(string ch)
        {
            List<Feuerloescher> flaus = new List<Feuerloescher>();

            foreach(Feuerloescher fe in feuerloeschers)
            {
                if (fe.BrandklasseL.Contains(ch))            
                    flaus.Add(fe);             
            }

            return flaus;
        }
        private void radioButton_a_CheckedChanged(object sender, EventArgs e)
        {
            List<Feuerloescher> fa = new List<Feuerloescher>();

            fa = flauswaehlen("A");

            Feuerloescheranzeigen(fa);
        }

        private void radioButton_b_CheckedChanged(object sender, EventArgs e)
        {
            List<Feuerloescher> fb = new List<Feuerloescher>();

            fb = flauswaehlen("B");

            Feuerloescheranzeigen(fb);
        }

        private void radioButton_c_CheckedChanged(object sender, EventArgs e)
        {
            List<Feuerloescher> fc = new List<Feuerloescher>();

            fc = flauswaehlen("C");

            Feuerloescheranzeigen(fc);
        }

        private void radioButton_f_CheckedChanged(object sender, EventArgs e)
        {
            List<Feuerloescher> ff = new List<Feuerloescher>();

            ff = flauswaehlen("F");

            Feuerloescheranzeigen(ff);
        }

        #endregion

        #region Neue Funktionen mit Revit

        private void button_fe_plazieren_Click(object sender, EventArgs e)
        {

            NewFeuerloescher = new Feuerloescher();
            NewFeuerloescher.Name = textBox_Name.Text;

            if (NewFeuerloescher.Name == "")
            {
                MessageBox.Show("Bitte Sie wählen zuerst ein Typ des Feuerlöschers aus!");
                goto a;
            }

            _cpr = new PlaceData();
            _cpr.raum = ra;
            _cpr.feuerloescher = NewFeuerloescher;
            _placeEvent.Raise();

            this.Close();

        a:;
        }

        private void button_fe_speichern_Click(object sender, EventArgs e)
        {
            _fl = listBox_ausgewaehlt.SelectedItem as Feuerloescher;
            int i = ra.feuerloeschers.IndexOf(_fl);

            feuerloescherZuordnung(_fl);
            ra.feuerloeschers[i] = _fl;

            _updateEventF.Raise();
            MessageBox.Show("Saved successfully!");

            listBox_ausgewaehlt.Items.Clear();
            foreach (Feuerloescher fe in ra.feuerloeschers)
            {
                listBox_ausgewaehlt.Items.Add(fe);
            }

            ergebnisZeigen();           
        }
        #endregion

    }
}
