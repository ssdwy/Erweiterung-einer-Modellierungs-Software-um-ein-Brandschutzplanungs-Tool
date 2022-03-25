using IIB1_UE1_Gruppe12_Klassen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace IIB1_UE1_Gruppe12_GUI
{
    public partial class MAINGUI : System.Windows.Forms.Form
    {
        #region Initialisierung und Instanziierung
        Gebaeude ge;
        Stockwerk st;
        public Raum ra;
         
        public double Brandlast { get; set; }

        List<string> Raumtyp = new List<string>() 
        { "1-Wohnen und Aufenthalt",
          "2-Büroarbeit",
          "3-Produktion/Hand-Maschinenarbeit/Experimente",
          "4-Lagern/Verteilen/Verkaufen",
          "5-Bildung/Kultur/Unterricht", 
          "6-Heilen/Pflegen", 
          "7-Sonstige Nutzflächen", 
          "8-Technische Anlagen",
          "9-Verkehrserschl./sicherung" 
        };

        List<Gebaeude> Gebaeudeliste = new List<Gebaeude>();
        #endregion

        #region New Attributes & Properties
        Feuerlöscher_verwalten feu;
        private ExternalEvent _updateEventR;
        private ExternalEvent _updateEventF;
        private ExternalEvent _placeEvent;

        public Feuerlöscher_verwalten Feu { get => feu; set => feu = value; }
        #endregion

        #region Konstrukturfunktion und Load
        public MAINGUI()
        {
            InitializeComponent();
        }

        public MAINGUI(List<Gebaeude> gebaeudeliste)
        {
            InitializeComponent();
            this.Gebaeudeliste = gebaeudeliste;
        }

        public MAINGUI(ExternalEvent updateEventR, ExternalEvent updateEventF, ExternalEvent placeEvent, List<Gebaeude> gebaeudeliste)
        {
            InitializeComponent();
            this._updateEventR = updateEventR;
            this._updateEventF = updateEventF;
            this._placeEvent = placeEvent;
            this.Gebaeudeliste = gebaeudeliste;
        }

        private void MAINGUI_Load(object sender, EventArgs e)
        {
            foreach (string str in Raumtyp)
            {
                comboBox_r_typ.Items.Add(str);
            }

            foreach (Gebaeude ge in Gebaeudeliste)
            {
                listbox_gebaeude.Items.Add(ge);
            }

        }
        #endregion

        #region Gebäude verwalten
        //hinzufügen die Gebäude in listBox
        private void gebaeude_anzeigen(List<Gebaeude> ges)
        {
            listbox_gebaeude.Items.Clear();

            foreach(Gebaeude gea in ges)
            {
                listbox_gebaeude.Items.Add(gea);
            }
        }

        //Button "Gebäude Hinzufügen"
        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_g_bezeichnung.Text))
            {
                MessageBox.Show("Bitte eine Gebäudebezeichnung eintragen", "Fehlermeldung");
            }
            else
            {
                Gebaeude neuesgebaeude = new Gebaeude(textbox_g_bezeichnung.Text);
                Gebaeudeliste.Add(neuesgebaeude);
            }

            gebaeude_anzeigen(Gebaeudeliste);

            button_s_add.Enabled = false;
            textbox_g_bezeichnung.Clear();
        }

        //Button "Gebäude Löschen"
        private void Button2_Click(object sender, EventArgs e)
        {
            Gebaeude aktuellesgebaeude = listbox_gebaeude.SelectedItem as Gebaeude;
            Gebaeudeliste.Remove(aktuellesgebaeude);

            if (Gebaeudeliste.Count == 0)
                button_g_delete.Enabled = false;

            gebaeude_anzeigen(Gebaeudeliste);
        }

        //Eigenschaften der Gebäude zeigen, wenn man die unterschiedliche Gebäude auswählt
        private void Listbox_gebaeude_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_g_delete.Enabled = true;
            textbox_s_bezeichnung.Enabled = true;
            textbox_s_ebene.Enabled = true;
            button_s_add.Enabled = true;
            button_exportieren.Enabled = true;
            button_laden.Enabled = true;

            ge = listbox_gebaeude.SelectedItem as Gebaeude;

            if(ge == null)
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Gebäude aus! :)");
            }
            else
            {
                textbox_g_bezeichnung.Text = ge.Gebaeude_bezeichnung;
                Stockwerkefuellen(ge);
            }


        }
        #endregion

        #region Stockwerk verwalten
        //hinzufügen das Stockwerk in listBox
        public void Stockwerkefuellen(Gebaeude gebaeude)
        {
            listbox_stockwerk.Items.Clear();

            if (gebaeude.Stockwerkliste.Count == 0)
            {
                ;
            }
            else
            {
                foreach (Stockwerk stockwerk in gebaeude.Stockwerkliste)
                {
                    listbox_stockwerk.Items.Add(stockwerk);
                }
            }

        }

        //Button "Stockwerk hinzufügen"
        private void Button_s_add_Click(object sender, EventArgs e)
        {
            int ebene;
            ge = listbox_gebaeude.SelectedItem as Gebaeude;

            bool success_ebene = Int32.TryParse(textbox_s_ebene.Text, out ebene);
            if ((String.IsNullOrEmpty(textbox_s_bezeichnung.Text)) || (String.IsNullOrEmpty(textbox_s_ebene.Text)))
            {
                MessageBox.Show("Bitte ein Stockwerk und die entsprechende Ebene eintragen", "Fehlermeldung");
            }
            else if (!success_ebene)
            {
                MessageBox.Show("Bitte nur ganze Zahlen für die Ebene eintragen", "Fehlermeldung");
            }
            else
            {
                st = new Stockwerk(textbox_s_bezeichnung.Text);
                ge.Stockwerkliste.Add(st);
                Stockwerkefuellen(ge);

                textbox_s_bezeichnung.Clear();
                textbox_s_ebene.Clear();
            }

            button_r_add.Enabled = false;
        }

        //Button "Stockwerk löschen"
        private void Button_s_delete_Click(object sender, EventArgs e)
        {
            ge = listbox_gebaeude.SelectedItem as Gebaeude;

            st = listbox_stockwerk.SelectedItem as Stockwerk;
            ge.Stockwerkliste.Remove(st);

            listbox_stockwerk.Items.Clear();
            foreach (Stockwerk sto in ge.Stockwerkliste)
            {
                listbox_stockwerk.Items.Add(sto);
            }

            if (ge.Stockwerkliste.Count == 0)
                button_s_delete.Enabled = false;
        }

        //Eigenschaften des Stockwerks zeigen, wenn man die unterschiedliche Gebäude auswählt
        private void Listbox_stockwerk_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_r_add.Enabled = true;
            button_s_delete.Enabled = true;
            textbox_r_bezeichnung.Enabled = true;
            textbox_r_flaeche.Enabled = true;

            st = listbox_stockwerk.SelectedItem as Stockwerk;
            if (st == null)
                MessageBox.Show("Bitte wählen Sie zuerst ein Stockwerk aus! :)");
            else
            {
                textbox_s_bezeichnung.Text = st.Bezeichnung;
                textbox_s_ebene.Text = st.Ebene;

                Raumfuellen(st);
            }
        }

        #endregion

        #region Raum verwalten
        //hinzufügen den Raum in listBox
        private void Raumfuellen(Stockwerk stock)
        {
            listbox_raum.Items.Clear();

            if (stock.Raumliste.Count == 0)
            {
                ;
            }
            else
            {
                foreach (Raum raum in stock.Raumliste)
                {
                    listbox_raum.Items.Add(raum);
                }
            }

        }

        //Button "Raum Hinzufügen"
        private void Button_r_add_Click(object sender, EventArgs e)
        {
            st = listbox_stockwerk.SelectedItem as Stockwerk;

            double flaeche;
            bool success_flaeche = Double.TryParse(textbox_r_flaeche.Text, out flaeche);

            if ((String.IsNullOrEmpty(textbox_r_bezeichnung.Text)) || (String.IsNullOrEmpty(textbox_r_flaeche.Text)))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.", "Fehlermeldung");
            }
            else if (!success_flaeche)
            {
                MessageBox.Show("Bitte nur positive Zahlen für Fläche eingeben", "Fehlermeldung");
            }
            else
            {
                ra = new Raum(textbox_r_bezeichnung.Text, comboBox_r_typ.SelectedItem.ToString());
                st.Raumliste.Add(ra);
                Raumfuellen(st);

                textbox_r_bezeichnung.Clear();
                textbox_r_flaeche.Clear();
                comboBox_r_typ.Text = null;
            }
        }

        //Button "Raum Löschen"
        private void button_r_delete_Click_1(object sender, EventArgs e)
        {
            //Durch den Click auf den Button wird der aktuelle Raum im Textfeld und in der Raumliste gelöscht

            st = listbox_stockwerk.SelectedItem as Stockwerk;
            ra = listbox_raum.SelectedItem as Raum;

            st.Raumliste.Remove(ra);

            listbox_raum.Items.Clear();
            foreach (Raum rau in st.Raumliste)
            {
                listbox_raum.Items.Add(rau);
            }

            if (st.Raumliste.Count == 0)
            {
                button_r_delete.Enabled = false;
                button_alterroom.Enabled = false;
            }

            textbox_r_bezeichnung.Text = null;
            textbox_r_flaeche.Text = null;
            comboBox_r_typ.Text = null;
            label_r_brandlastberechnung.Text = null;
            label_r_LEberechnen.Text = null;
        }

        //Eigenschaften des Raums zeigen, wenn man die unterschiedliche Gebäude auswählt
        private void Listbox_raum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;

            if (ra == null)
                MessageBox.Show("Bitte wählen Sie zuerst einen Raum aus! :)");
            else
            {
                textbox_r_bezeichnung.Text = ra.Raum_bezeichnung;
                textbox_r_flaeche.Text = ra.Flaeche.ToString() + " " + "m²";
                foreach(string str in Raumtyp)
                {
                    if (str.Equals(ra.Typ))
                        comboBox_r_typ.SelectedIndex = Raumtyp.IndexOf(str);

                }

                label_r_brandlastberechnung.Text = ra.Brandlast.ToString("0.00");
                label_r_LEberechnen.Text = ra.LE.ToString();

                button_alterroom.Enabled = true;
                button_r_delete.Enabled = true;
                button_speichern.Enabled = true;
            }
        }

        #endregion

        #region Die Baustoffe für einen Raum verweisen und Brandlast und LE berechnen
        //Form "ALTERROOM" eröffnen um die Baustoffe hinzuzufügen
        private void button_alterRoom_Click(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;

            if (ra == null)
                MessageBox.Show("Bitte wählen Sie einen Raum aus! :(");
            else
            {
                ALTERROOM alt = new ALTERROOM(ra, this);
                alt.ShowDialog(this);
            }

        }

        //Brandlast bekommen
        private void button_brandlast_Click(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;
            if (ra == null)
                MessageBox.Show("Bitte wählen Sie zuerst einen Raum aus! :)");
            else
            {
                label_r_brandlastberechnung.Text = ra.Brandlast.ToString("0.00");
            }
        }

        //LE bekommen
        private void button1_Click_1(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;
            if (ra == null)
                MessageBox.Show("Bitte wählen Sie zuerst einen Raum aus! :)");
            else
            {
                ra.LE = loeschmitteleinheiten(ra.Flaeche, Brandlast);
                label_r_LEberechnen.Text = ra.LE.ToString();
            }
        }

        //Berechnungsmethode für LE
        public int loeschmitteleinheiten(double flaeche, double brandlast)
        {
            int LE = 0;
            if (brandlast <= 1000)
            {
                LE = 9;
                for (int i = 0; i < 11; i++)
                {
                    if (flaeche <= 50)
                    {
                        LE = 6;
                        break;
                    }

                    else if (flaeche - 100 > 0)
                        LE = LE + 3;
                    else
                        break;
                    flaeche = flaeche - 100;
                }
            }
            else if (brandlast > 1000 && brandlast <= 5000)
            {
                LE = 18;
                for (int i = 0; i < 11; i++)
                {
                    if (flaeche <= 50)
                    {
                        LE = 12;
                        break;
                    }

                    else if (flaeche - 100 > 0)
                        LE = LE + 6;
                    else
                        break;
                    flaeche = flaeche - 100;
                }
            }
            else if (brandlast > 5000)
            {
                LE = 27;
                for (int i = 0; i < 11; i++)
                {
                    if (flaeche <= 50)
                    {
                        LE = 18;
                        break;
                    }

                    else if (flaeche - 100 > 0)
                        LE = LE + 9;
                    else
                        break;
                    flaeche = flaeche - 100;
                }
            }
            return LE;
        }
        #endregion

        #region Feuerlöscher für einen Raum verweisen
        //Form "Feuerloescher_verwalten" eröffnen um die Feuerlöscher zu verweisen
        private void button_addFeuerloescher_Click(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;
            
            if (ra == null)
                MessageBox.Show("Bitte wählen Sie einen Raum zuerst aus! :(");
            else
            {
                ra.LE = loeschmitteleinheiten(ra.Flaeche, Brandlast);
                Feuerlöscher_verwalten fv = new Feuerlöscher_verwalten(_updateEventF, _placeEvent, ra, this);
                Feu = fv;
                fv.ShowDialog();                       
            }
        }
        #endregion

        #region Serialisierung

        private void button2_Click_1(object sender, EventArgs e)
        {
            speicherToFile();
        }

        private void speicherToFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Gebaeudeliste);
                fs.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Gebaeudeliste = (List<Gebaeude>)bf.Deserialize(fs);
                fs.Close();
                gebaeude_anzeigen(Gebaeudeliste);
            }
        }
        #endregion

        #region Neue Funktionen mit Revit

        private void button4_Click(object sender, EventArgs e)
        {
            ra = listbox_raum.SelectedItem as Raum;
            st = listbox_stockwerk.SelectedItem as Stockwerk;
            int i = st.Raumliste.IndexOf(ra);

            ra.Raum_bezeichnung = textbox_r_bezeichnung.Text;
            string str = textbox_r_flaeche.Text;
            string[] strs = str.Split(' ');
            ra.Flaeche = Convert.ToDouble(strs[0]);
            ra.Typ = comboBox_r_typ.SelectedItem.ToString();
            ra.Brandlast = Convert.ToDouble(label_r_brandlastberechnung.Text);
            ra.LE = Convert.ToInt32(label_r_LEberechnen.Text);

            st.Raumliste[i] = ra;
            Raumfuellen(st);

            _updateEventR.Raise();
            MessageBox.Show("Saved successfully!");
        }
        #endregion

    }
}
