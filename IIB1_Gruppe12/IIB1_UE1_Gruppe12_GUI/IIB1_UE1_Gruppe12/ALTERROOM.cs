using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IIB1_UE1_Gruppe12_Klassen;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace IIB1_UE1_Gruppe12_GUI
{
    public partial class ALTERROOM : System.Windows.Forms.Form
    {
        Raum raum;
        Baustoffe baustoffe;
        double brandlast;
        public ALTERROOM(Raum raum, MAINGUI _parent)
        {
            InitializeComponent();
            this.raum = raum;
            this.Owner = _parent;
        }

        private void ALTERROOM_Load(object sender, EventArgs e)
        {
            baustoffe = new Baustoffe();

            combobox_material.Items.Clear();
            label4.Text = raum.Raum_bezeichnung;

            foreach (string key in baustoffe.heizwert_db.Keys)
            {
                combobox_material.Items.Add(key);
            }

            foreach(Baustoffe ba in raum.Baustoffliste)
            {
                listBox1.Items.Add(ba);
            }
        }

        #region Die Eigenschaften der Baustoffe zeigen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Baustoffe baustoffes = new Baustoffe();

            baustoffes.Name = combobox_material.SelectedItem.ToString();

            foreach (string keys in baustoffes.heizwert_db.Keys)
            {
                if (keys == baustoffes.Name)
                    label_heizwert.Text = baustoffes.heizwert_db[keys].ToString();
            }

            foreach (string keys in baustoffes.abbrandfaktor_db.Keys)
            {
                if (keys == baustoffes.Name)
                    label_abbrandfaktor.Text = baustoffes.abbrandfaktor_db[keys].ToString();
            }

            checkbox_gechuetzt.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baustoffe = listBox1.SelectedItem as Baustoffe;

            if (baustoffe == null)
                MessageBox.Show("Bitte wählen Sie einen Baustoff aus!");
            else
            {
                combobox_material.Text = baustoffe.Name;
                textbox_masse.Text = baustoffe.Ms.ToString();
                if (baustoffe.geschutzt)
                    checkbox_gechuetzt.Checked = true;
            }
        }
        #endregion

        #region Eine Baustoffe in einem Raum hinzufügen und löschen
        //Button "Add"
        private void button_add_Click(object sender, EventArgs e)
        {
            baustoffe = new Baustoffe();

            try
            {
                Convert.ToDouble(textbox_masse.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ungültige Benutzereingabe\nBitte alle Textfelder ausfüllen", "Ungültige Benutzereingabe");
                goto a;
            }

            baustoffe.Name = combobox_material.SelectedItem.ToString();
            baustoffe.Ms = Convert.ToDouble(textbox_masse.Text);
            baustoffe.H = Convert.ToDouble(label_heizwert.Text);
            baustoffe.M = Convert.ToDouble(label_abbrandfaktor.Text);

            if (checkbox_gechuetzt.Checked)
                baustoffe.geschutzt = true;

            raum.Baustoffliste.Add(baustoffe);
            Baustoff_anzeigen(raum.Baustoffliste);
        a:;
        }

        //Button "Entfernen"
        private void button2_Click(object sender, EventArgs e)
        {
            baustoffe = listBox1.SelectedItem as Baustoffe;

            raum.Baustoffliste.Remove(baustoffe);
            Baustoff_anzeigen(raum.Baustoffliste);
        }

        private void Baustoff_anzeigen(List<Baustoffe> baustoffes)
        {
            listBox1.Items.Clear();

            foreach (Baustoffe baus in baustoffes)
            {
                listBox1.Items.Add(baus);
            }
        }
        #endregion

        #region Brandlast bekommen und den Wert zu MainGui übergeben
        private double bekommenBrandlast()
        {
            foreach (Baustoffe baus in raum.Baustoffliste)
            {
                brandlast += baus.getBrandlast(baus.Ms,baus.geschutzt,baus.H,baus.M,raum.Flaeche);
            }
            return brandlast;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAINGUI main = (MAINGUI)this.Owner;
            main.ra.Brandlast = bekommenBrandlast();
            this.Close();
        }

        #endregion
    }







}

