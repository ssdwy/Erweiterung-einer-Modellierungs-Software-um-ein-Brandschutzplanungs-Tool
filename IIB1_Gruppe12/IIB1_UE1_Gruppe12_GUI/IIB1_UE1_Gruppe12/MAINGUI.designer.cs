namespace IIB1_UE1_Gruppe12_GUI
{
    partial class MAINGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_r_delete = new System.Windows.Forms.Button();
            this.label_brandlast = new System.Windows.Forms.Label();
            this.label_r_brandlastberechnung = new System.Windows.Forms.Label();
            this.button_addFeuerloescher = new System.Windows.Forms.Button();
            this.button_alterroom = new System.Windows.Forms.Button();
            this.button_r_Brandlastberechnen = new System.Windows.Forms.Button();
            this.label_Brandlast_Einheit = new System.Windows.Forms.Label();
            this.listbox_gebaeude = new System.Windows.Forms.ListBox();
            this.textbox_g_bezeichnung = new System.Windows.Forms.TextBox();
            this.button_g_add = new System.Windows.Forms.Button();
            this.button_g_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listbox_stockwerk = new System.Windows.Forms.ListBox();
            this.textbox_s_bezeichnung = new System.Windows.Forms.TextBox();
            this.textbox_s_ebene = new System.Windows.Forms.TextBox();
            this.button_s_add = new System.Windows.Forms.Button();
            this.button_s_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listbox_raum = new System.Windows.Forms.ListBox();
            this.textbox_r_bezeichnung = new System.Windows.Forms.TextBox();
            this.textbox_r_flaeche = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_r_add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_r_typ = new System.Windows.Forms.ComboBox();
            this.label_LE = new System.Windows.Forms.Label();
            this.button_r_LEberechnen = new System.Windows.Forms.Button();
            this.label_r_LEberechnen = new System.Windows.Forms.Label();
            this.label_LE_Einheit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_laden = new System.Windows.Forms.Button();
            this.button_exportieren = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_speichern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_r_delete
            // 
            this.button_r_delete.Enabled = false;
            this.button_r_delete.Location = new System.Drawing.Point(241, 450);
            this.button_r_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_r_delete.Name = "button_r_delete";
            this.button_r_delete.Size = new System.Drawing.Size(165, 40);
            this.button_r_delete.TabIndex = 3;
            this.button_r_delete.Text = "Raum löschen";
            this.button_r_delete.UseMnemonic = false;
            this.button_r_delete.UseVisualStyleBackColor = true;
            this.button_r_delete.Click += new System.EventHandler(this.button_r_delete_Click_1);
            // 
            // label_brandlast
            // 
            this.label_brandlast.AutoSize = true;
            this.label_brandlast.Location = new System.Drawing.Point(511, 53);
            this.label_brandlast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_brandlast.Name = "label_brandlast";
            this.label_brandlast.Size = new System.Drawing.Size(81, 20);
            this.label_brandlast.TabIndex = 7;
            this.label_brandlast.Text = "Brandlast:";
            // 
            // label_r_brandlastberechnung
            // 
            this.label_r_brandlastberechnung.AutoSize = true;
            this.label_r_brandlastberechnung.Location = new System.Drawing.Point(623, 53);
            this.label_r_brandlastberechnung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_r_brandlastberechnung.Name = "label_r_brandlastberechnung";
            this.label_r_brandlastberechnung.Size = new System.Drawing.Size(0, 20);
            this.label_r_brandlastberechnung.TabIndex = 8;
            // 
            // button_addFeuerloescher
            // 
            this.button_addFeuerloescher.Location = new System.Drawing.Point(573, 425);
            this.button_addFeuerloescher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_addFeuerloescher.Name = "button_addFeuerloescher";
            this.button_addFeuerloescher.Size = new System.Drawing.Size(130, 65);
            this.button_addFeuerloescher.TabIndex = 4;
            this.button_addFeuerloescher.Text = "Feuerlöscher hinzufügen";
            this.button_addFeuerloescher.UseVisualStyleBackColor = true;
            this.button_addFeuerloescher.Click += new System.EventHandler(this.button_addFeuerloescher_Click);
            // 
            // button_alterroom
            // 
            this.button_alterroom.Enabled = false;
            this.button_alterroom.Location = new System.Drawing.Point(435, 425);
            this.button_alterroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_alterroom.Name = "button_alterroom";
            this.button_alterroom.Size = new System.Drawing.Size(130, 65);
            this.button_alterroom.TabIndex = 10;
            this.button_alterroom.Text = "Baustoffe verwalten\r\n\r\n";
            this.button_alterroom.UseVisualStyleBackColor = true;
            this.button_alterroom.Click += new System.EventHandler(this.button_alterRoom_Click);
            // 
            // button_r_Brandlastberechnen
            // 
            this.button_r_Brandlastberechnen.Location = new System.Drawing.Point(515, 101);
            this.button_r_Brandlastberechnen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_r_Brandlastberechnen.Name = "button_r_Brandlastberechnen";
            this.button_r_Brandlastberechnen.Size = new System.Drawing.Size(168, 41);
            this.button_r_Brandlastberechnen.TabIndex = 13;
            this.button_r_Brandlastberechnen.Text = "Brandlast berechnen";
            this.button_r_Brandlastberechnen.UseVisualStyleBackColor = true;
            this.button_r_Brandlastberechnen.Click += new System.EventHandler(this.button_brandlast_Click);
            // 
            // label_Brandlast_Einheit
            // 
            this.label_Brandlast_Einheit.AutoSize = true;
            this.label_Brandlast_Einheit.Location = new System.Drawing.Point(654, 53);
            this.label_Brandlast_Einheit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Brandlast_Einheit.Name = "label_Brandlast_Einheit";
            this.label_Brandlast_Einheit.Size = new System.Drawing.Size(63, 20);
            this.label_Brandlast_Einheit.TabIndex = 16;
            this.label_Brandlast_Einheit.Text = "kWh/m²";
            // 
            // listbox_gebaeude
            // 
            this.listbox_gebaeude.FormattingEnabled = true;
            this.listbox_gebaeude.ItemHeight = 20;
            this.listbox_gebaeude.Location = new System.Drawing.Point(21, 41);
            this.listbox_gebaeude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listbox_gebaeude.Name = "listbox_gebaeude";
            this.listbox_gebaeude.Size = new System.Drawing.Size(178, 224);
            this.listbox_gebaeude.TabIndex = 25;
            this.listbox_gebaeude.SelectedIndexChanged += new System.EventHandler(this.Listbox_gebaeude_SelectedIndexChanged);
            // 
            // textbox_g_bezeichnung
            // 
            this.textbox_g_bezeichnung.Location = new System.Drawing.Point(251, 47);
            this.textbox_g_bezeichnung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_g_bezeichnung.Name = "textbox_g_bezeichnung";
            this.textbox_g_bezeichnung.Size = new System.Drawing.Size(191, 26);
            this.textbox_g_bezeichnung.TabIndex = 26;
            // 
            // button_g_add
            // 
            this.button_g_add.Location = new System.Drawing.Point(222, 101);
            this.button_g_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_g_add.Name = "button_g_add";
            this.button_g_add.Size = new System.Drawing.Size(245, 40);
            this.button_g_add.TabIndex = 27;
            this.button_g_add.Text = "Gebäude hinzufügen\r\n";
            this.button_g_add.UseVisualStyleBackColor = true;
            this.button_g_add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_g_delete
            // 
            this.button_g_delete.Enabled = false;
            this.button_g_delete.Location = new System.Drawing.Point(222, 165);
            this.button_g_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_g_delete.Name = "button_g_delete";
            this.button_g_delete.Size = new System.Drawing.Size(245, 40);
            this.button_g_delete.TabIndex = 28;
            this.button_g_delete.Text = "Gebäude löschen";
            this.button_g_delete.UseVisualStyleBackColor = true;
            this.button_g_delete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Gebäudebezeichnung:";
            // 
            // listbox_stockwerk
            // 
            this.listbox_stockwerk.FormattingEnabled = true;
            this.listbox_stockwerk.ItemHeight = 20;
            this.listbox_stockwerk.Location = new System.Drawing.Point(21, 40);
            this.listbox_stockwerk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listbox_stockwerk.Name = "listbox_stockwerk";
            this.listbox_stockwerk.Size = new System.Drawing.Size(178, 204);
            this.listbox_stockwerk.TabIndex = 30;
            this.listbox_stockwerk.SelectedIndexChanged += new System.EventHandler(this.Listbox_stockwerk_SelectedIndexChanged);
            // 
            // textbox_s_bezeichnung
            // 
            this.textbox_s_bezeichnung.Enabled = false;
            this.textbox_s_bezeichnung.Location = new System.Drawing.Point(225, 87);
            this.textbox_s_bezeichnung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_s_bezeichnung.Name = "textbox_s_bezeichnung";
            this.textbox_s_bezeichnung.Size = new System.Drawing.Size(170, 26);
            this.textbox_s_bezeichnung.TabIndex = 31;
            // 
            // textbox_s_ebene
            // 
            this.textbox_s_ebene.Location = new System.Drawing.Point(412, 87);
            this.textbox_s_ebene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_s_ebene.Name = "textbox_s_ebene";
            this.textbox_s_ebene.ReadOnly = true;
            this.textbox_s_ebene.Size = new System.Drawing.Size(60, 26);
            this.textbox_s_ebene.TabIndex = 32;
            // 
            // button_s_add
            // 
            this.button_s_add.Enabled = false;
            this.button_s_add.Location = new System.Drawing.Point(222, 142);
            this.button_s_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_s_add.Name = "button_s_add";
            this.button_s_add.Size = new System.Drawing.Size(245, 40);
            this.button_s_add.TabIndex = 33;
            this.button_s_add.Text = "Stockwerk hinzufügen";
            this.button_s_add.UseVisualStyleBackColor = true;
            this.button_s_add.Click += new System.EventHandler(this.Button_s_add_Click);
            // 
            // button_s_delete
            // 
            this.button_s_delete.Enabled = false;
            this.button_s_delete.Location = new System.Drawing.Point(222, 204);
            this.button_s_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_s_delete.Name = "button_s_delete";
            this.button_s_delete.Size = new System.Drawing.Size(245, 40);
            this.button_s_delete.TabIndex = 34;
            this.button_s_delete.Text = "Stockwerk löschen\r\n";
            this.button_s_delete.UseVisualStyleBackColor = true;
            this.button_s_delete.Click += new System.EventHandler(this.Button_s_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Stockwerkbezeichnung:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Ebene:";
            // 
            // listbox_raum
            // 
            this.listbox_raum.FormattingEnabled = true;
            this.listbox_raum.ItemHeight = 20;
            this.listbox_raum.Location = new System.Drawing.Point(8, 47);
            this.listbox_raum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listbox_raum.Name = "listbox_raum";
            this.listbox_raum.Size = new System.Drawing.Size(221, 444);
            this.listbox_raum.TabIndex = 37;
            this.listbox_raum.SelectedIndexChanged += new System.EventHandler(this.Listbox_raum_SelectedIndexChanged);
            // 
            // textbox_r_bezeichnung
            // 
            this.textbox_r_bezeichnung.Enabled = false;
            this.textbox_r_bezeichnung.Location = new System.Drawing.Point(237, 74);
            this.textbox_r_bezeichnung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_r_bezeichnung.Name = "textbox_r_bezeichnung";
            this.textbox_r_bezeichnung.Size = new System.Drawing.Size(214, 26);
            this.textbox_r_bezeichnung.TabIndex = 38;
            // 
            // textbox_r_flaeche
            // 
            this.textbox_r_flaeche.Enabled = false;
            this.textbox_r_flaeche.Location = new System.Drawing.Point(237, 261);
            this.textbox_r_flaeche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_r_flaeche.Name = "textbox_r_flaeche";
            this.textbox_r_flaeche.ReadOnly = true;
            this.textbox_r_flaeche.Size = new System.Drawing.Size(214, 26);
            this.textbox_r_flaeche.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Raumbezeichnung:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 222);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Fläche:";
            // 
            // button_r_add
            // 
            this.button_r_add.Enabled = false;
            this.button_r_add.Location = new System.Drawing.Point(241, 390);
            this.button_r_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_r_add.Name = "button_r_add";
            this.button_r_add.Size = new System.Drawing.Size(165, 40);
            this.button_r_add.TabIndex = 44;
            this.button_r_add.Text = "Raum hinzufügen";
            this.button_r_add.UseVisualStyleBackColor = true;
            this.button_r_add.Click += new System.EventHandler(this.Button_r_add_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Typ:";
            // 
            // comboBox_r_typ
            // 
            this.comboBox_r_typ.FormattingEnabled = true;
            this.comboBox_r_typ.Location = new System.Drawing.Point(237, 163);
            this.comboBox_r_typ.Name = "comboBox_r_typ";
            this.comboBox_r_typ.Size = new System.Drawing.Size(214, 28);
            this.comboBox_r_typ.TabIndex = 46;
            // 
            // label_LE
            // 
            this.label_LE.AutoSize = true;
            this.label_LE.Location = new System.Drawing.Point(468, 222);
            this.label_LE.Name = "label_LE";
            this.label_LE.Size = new System.Drawing.Size(141, 20);
            this.label_LE.TabIndex = 47;
            this.label_LE.Text = "Löschmitteleinheit:";
            // 
            // button_r_LEberechnen
            // 
            this.button_r_LEberechnen.Location = new System.Drawing.Point(515, 261);
            this.button_r_LEberechnen.Name = "button_r_LEberechnen";
            this.button_r_LEberechnen.Size = new System.Drawing.Size(168, 41);
            this.button_r_LEberechnen.TabIndex = 48;
            this.button_r_LEberechnen.Text = "LE_Berechnen";
            this.button_r_LEberechnen.UseVisualStyleBackColor = true;
            this.button_r_LEberechnen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_r_LEberechnen
            // 
            this.label_r_LEberechnen.AutoSize = true;
            this.label_r_LEberechnen.Location = new System.Drawing.Point(623, 222);
            this.label_r_LEberechnen.Name = "label_r_LEberechnen";
            this.label_r_LEberechnen.Size = new System.Drawing.Size(0, 20);
            this.label_r_LEberechnen.TabIndex = 49;
            // 
            // label_LE_Einheit
            // 
            this.label_LE_Einheit.AutoSize = true;
            this.label_LE_Einheit.Location = new System.Drawing.Point(654, 222);
            this.label_LE_Einheit.Name = "label_LE_Einheit";
            this.label_LE_Einheit.Size = new System.Drawing.Size(29, 20);
            this.label_LE_Einheit.TabIndex = 50;
            this.label_LE_Einheit.Text = "LE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_laden);
            this.groupBox1.Controls.Add(this.button_exportieren);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textbox_g_bezeichnung);
            this.groupBox1.Controls.Add(this.button_g_add);
            this.groupBox1.Controls.Add(this.button_g_delete);
            this.groupBox1.Controls.Add(this.listbox_gebaeude);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 276);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gebäude";
            // 
            // button_laden
            // 
            this.button_laden.Enabled = false;
            this.button_laden.Location = new System.Drawing.Point(367, 226);
            this.button_laden.Name = "button_laden";
            this.button_laden.Size = new System.Drawing.Size(100, 40);
            this.button_laden.TabIndex = 31;
            this.button_laden.Text = "Laden";
            this.button_laden.UseVisualStyleBackColor = true;
            this.button_laden.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_exportieren
            // 
            this.button_exportieren.Enabled = false;
            this.button_exportieren.Location = new System.Drawing.Point(225, 226);
            this.button_exportieren.Name = "button_exportieren";
            this.button_exportieren.Size = new System.Drawing.Size(100, 40);
            this.button_exportieren.TabIndex = 30;
            this.button_exportieren.Text = "Exportieren";
            this.button_exportieren.UseVisualStyleBackColor = true;
            this.button_exportieren.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_stockwerk);
            this.groupBox2.Controls.Add(this.textbox_s_bezeichnung);
            this.groupBox2.Controls.Add(this.textbox_s_ebene);
            this.groupBox2.Controls.Add(this.button_s_add);
            this.groupBox2.Controls.Add(this.button_s_delete);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 253);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stockwerk";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_alterroom);
            this.groupBox3.Controls.Add(this.listbox_raum);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textbox_r_bezeichnung);
            this.groupBox3.Controls.Add(this.button_addFeuerloescher);
            this.groupBox3.Controls.Add(this.label_LE_Einheit);
            this.groupBox3.Controls.Add(this.label_r_LEberechnen);
            this.groupBox3.Controls.Add(this.textbox_r_flaeche);
            this.groupBox3.Controls.Add(this.button_r_LEberechnen);
            this.groupBox3.Controls.Add(this.label_LE);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label_brandlast);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label_Brandlast_Einheit);
            this.groupBox3.Controls.Add(this.button_r_Brandlastberechnen);
            this.groupBox3.Controls.Add(this.label_r_brandlastberechnung);
            this.groupBox3.Controls.Add(this.comboBox_r_typ);
            this.groupBox3.Controls.Add(this.button_r_add);
            this.groupBox3.Controls.Add(this.button_r_delete);
            this.groupBox3.Location = new System.Drawing.Point(529, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 504);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raum";
            // 
            // button_speichern
            // 
            this.button_speichern.Enabled = false;
            this.button_speichern.Location = new System.Drawing.Point(1044, 522);
            this.button_speichern.Name = "button_speichern";
            this.button_speichern.Size = new System.Drawing.Size(188, 52);
            this.button_speichern.TabIndex = 54;
            this.button_speichern.Text = "Speichern in Revit";
            this.button_speichern.UseVisualStyleBackColor = true;
            this.button_speichern.Click += new System.EventHandler(this.button4_Click);
            // 
            // MAINGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 586);
            this.Controls.Add(this.button_speichern);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MAINGUI";
            this.Text = "Gebäude Verwalten";
            this.Load += new System.EventHandler(this.MAINGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_r_delete;
        private System.Windows.Forms.Label label_brandlast;
        private System.Windows.Forms.Label label_r_brandlastberechnung;
        private System.Windows.Forms.Button button_addFeuerloescher;
        private System.Windows.Forms.Button button_alterroom;
        private System.Windows.Forms.Button button_r_Brandlastberechnen;
        private System.Windows.Forms.Label label_Brandlast_Einheit;
        private System.Windows.Forms.ListBox listbox_gebaeude;
        private System.Windows.Forms.TextBox textbox_g_bezeichnung;
        private System.Windows.Forms.Button button_g_add;
        private System.Windows.Forms.Button button_g_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listbox_stockwerk;
        private System.Windows.Forms.TextBox textbox_s_bezeichnung;
        private System.Windows.Forms.TextBox textbox_s_ebene;
        private System.Windows.Forms.Button button_s_add;
        private System.Windows.Forms.Button button_s_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ListBox listbox_raum;
        private System.Windows.Forms.TextBox textbox_r_bezeichnung;
        private System.Windows.Forms.TextBox textbox_r_flaeche;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_r_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_r_typ;
        private System.Windows.Forms.Label label_LE;
        private System.Windows.Forms.Button button_r_LEberechnen;
        private System.Windows.Forms.Label label_r_LEberechnen;
        private System.Windows.Forms.Label label_LE_Einheit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_laden;
        private System.Windows.Forms.Button button_exportieren;
        private System.Windows.Forms.Button button_speichern;
    }
}