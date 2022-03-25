namespace IIB1_UE1_Gruppe12_GUI
{
    partial class Feuerlöscher_verwalten
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_ausgewaehlt = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_f = new System.Windows.Forms.CheckBox();
            this.checkBox_c = new System.Windows.Forms.CheckBox();
            this.checkBox_b = new System.Windows.Forms.CheckBox();
            this.checkBox_a = new System.Windows.Forms.CheckBox();
            this.textBox_Preis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Kap = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.radioButton_a = new System.Windows.Forms.RadioButton();
            this.radioButton_b = new System.Windows.Forms.RadioButton();
            this.radioButton_c = new System.Windows.Forms.RadioButton();
            this.radioButton_f = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.button_fe_plazieren = new System.Windows.Forms.Button();
            this.button_fe_speichern = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brandlast: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // listBox_ausgewaehlt
            // 
            this.listBox_ausgewaehlt.FormattingEnabled = true;
            this.listBox_ausgewaehlt.ItemHeight = 20;
            this.listBox_ausgewaehlt.Location = new System.Drawing.Point(36, 60);
            this.listBox_ausgewaehlt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_ausgewaehlt.Name = "listBox_ausgewaehlt";
            this.listBox_ausgewaehlt.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_ausgewaehlt.Size = new System.Drawing.Size(360, 424);
            this.listBox_ausgewaehlt.TabIndex = 2;
            this.listBox_ausgewaehlt.SelectedIndexChanged += new System.EventHandler(this.listBox_ausgewaehlt_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_f);
            this.groupBox1.Controls.Add(this.checkBox_c);
            this.groupBox1.Controls.Add(this.checkBox_b);
            this.groupBox1.Controls.Add(this.checkBox_a);
            this.groupBox1.Controls.Add(this.textBox_Preis);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_Kap);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(565, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(538, 371);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feuerlöscher Informationen";
            // 
            // checkBox_f
            // 
            this.checkBox_f.AutoSize = true;
            this.checkBox_f.Location = new System.Drawing.Point(397, 180);
            this.checkBox_f.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_f.Name = "checkBox_f";
            this.checkBox_f.Size = new System.Drawing.Size(45, 24);
            this.checkBox_f.TabIndex = 21;
            this.checkBox_f.Text = "F";
            this.checkBox_f.UseVisualStyleBackColor = true;
            // 
            // checkBox_c
            // 
            this.checkBox_c.AutoSize = true;
            this.checkBox_c.Location = new System.Drawing.Point(345, 181);
            this.checkBox_c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_c.Name = "checkBox_c";
            this.checkBox_c.Size = new System.Drawing.Size(46, 24);
            this.checkBox_c.TabIndex = 20;
            this.checkBox_c.Text = "C";
            this.checkBox_c.UseVisualStyleBackColor = true;
            // 
            // checkBox_b
            // 
            this.checkBox_b.AutoSize = true;
            this.checkBox_b.Location = new System.Drawing.Point(283, 181);
            this.checkBox_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_b.Name = "checkBox_b";
            this.checkBox_b.Size = new System.Drawing.Size(46, 24);
            this.checkBox_b.TabIndex = 19;
            this.checkBox_b.Text = "B";
            this.checkBox_b.UseVisualStyleBackColor = true;
            // 
            // checkBox_a
            // 
            this.checkBox_a.AutoSize = true;
            this.checkBox_a.Location = new System.Drawing.Point(219, 181);
            this.checkBox_a.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_a.Name = "checkBox_a";
            this.checkBox_a.Size = new System.Drawing.Size(46, 24);
            this.checkBox_a.TabIndex = 18;
            this.checkBox_a.Text = "A";
            this.checkBox_a.UseVisualStyleBackColor = true;
            // 
            // textBox_Preis
            // 
            this.textBox_Preis.Location = new System.Drawing.Point(213, 265);
            this.textBox_Preis.Name = "textBox_Preis";
            this.textBox_Preis.Size = new System.Drawing.Size(229, 26);
            this.textBox_Preis.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 265);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Preis (€):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Brandklasse:";
            // 
            // textBox_Kap
            // 
            this.textBox_Kap.Location = new System.Drawing.Point(213, 125);
            this.textBox_Kap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Kap.Name = "textBox_Kap";
            this.textBox_Kap.Size = new System.Drawing.Size(229, 26);
            this.textBox_Kap.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(213, 55);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(229, 26);
            this.textBox_Name.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Löschmitteleinheit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(737, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Feuerlöscher:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "LE_Summe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 569);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 609);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gesamtkosten (€):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 583);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Hinweis:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(561, 583);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 609);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(173, 529);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 18;
            this.label15.Text = "Gesamtanzahl:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(324, 529);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 20);
            this.label16.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(351, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "LE";
            // 
            // radioButton_a
            // 
            this.radioButton_a.AutoSize = true;
            this.radioButton_a.Location = new System.Drawing.Point(744, 12);
            this.radioButton_a.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_a.Name = "radioButton_a";
            this.radioButton_a.Size = new System.Drawing.Size(45, 24);
            this.radioButton_a.TabIndex = 21;
            this.radioButton_a.TabStop = true;
            this.radioButton_a.Text = "A";
            this.radioButton_a.UseVisualStyleBackColor = true;
            this.radioButton_a.CheckedChanged += new System.EventHandler(this.radioButton_a_CheckedChanged);
            // 
            // radioButton_b
            // 
            this.radioButton_b.AutoSize = true;
            this.radioButton_b.Location = new System.Drawing.Point(791, 12);
            this.radioButton_b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_b.Name = "radioButton_b";
            this.radioButton_b.Size = new System.Drawing.Size(45, 24);
            this.radioButton_b.TabIndex = 22;
            this.radioButton_b.TabStop = true;
            this.radioButton_b.Text = "B";
            this.radioButton_b.UseVisualStyleBackColor = true;
            this.radioButton_b.CheckedChanged += new System.EventHandler(this.radioButton_b_CheckedChanged);
            // 
            // radioButton_c
            // 
            this.radioButton_c.AutoSize = true;
            this.radioButton_c.Location = new System.Drawing.Point(838, 12);
            this.radioButton_c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_c.Name = "radioButton_c";
            this.radioButton_c.Size = new System.Drawing.Size(45, 24);
            this.radioButton_c.TabIndex = 23;
            this.radioButton_c.TabStop = true;
            this.radioButton_c.Text = "C";
            this.radioButton_c.UseVisualStyleBackColor = true;
            this.radioButton_c.CheckedChanged += new System.EventHandler(this.radioButton_c_CheckedChanged);
            // 
            // radioButton_f
            // 
            this.radioButton_f.AutoSize = true;
            this.radioButton_f.Location = new System.Drawing.Point(886, 12);
            this.radioButton_f.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_f.Name = "radioButton_f";
            this.radioButton_f.Size = new System.Drawing.Size(44, 24);
            this.radioButton_f.TabIndex = 24;
            this.radioButton_f.TabStop = true;
            this.radioButton_f.Text = "F";
            this.radioButton_f.UseVisualStyleBackColor = true;
            this.radioButton_f.CheckedChanged += new System.EventHandler(this.radioButton_f_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(575, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 20);
            this.label18.TabIndex = 25;
            this.label18.Text = "Brandklassen";
            // 
            // button_fe_plazieren
            // 
            this.button_fe_plazieren.Location = new System.Drawing.Point(1047, 597);
            this.button_fe_plazieren.Name = "button_fe_plazieren";
            this.button_fe_plazieren.Size = new System.Drawing.Size(185, 43);
            this.button_fe_plazieren.TabIndex = 26;
            this.button_fe_plazieren.Text = "Feuerlöscher platzieren";
            this.button_fe_plazieren.UseVisualStyleBackColor = true;
            this.button_fe_plazieren.Click += new System.EventHandler(this.button_fe_plazieren_Click);
            // 
            // button_fe_speichern
            // 
            this.button_fe_speichern.Location = new System.Drawing.Point(1047, 529);
            this.button_fe_speichern.Name = "button_fe_speichern";
            this.button_fe_speichern.Size = new System.Drawing.Size(185, 40);
            this.button_fe_speichern.TabIndex = 27;
            this.button_fe_speichern.Text = "Speichern im Revit";
            this.button_fe_speichern.UseVisualStyleBackColor = true;
            this.button_fe_speichern.Click += new System.EventHandler(this.button_fe_speichern_Click);
            // 
            // Feuerlöscher_verwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 658);
            this.Controls.Add(this.button_fe_speichern);
            this.Controls.Add(this.button_fe_plazieren);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.radioButton_f);
            this.Controls.Add(this.radioButton_c);
            this.Controls.Add(this.radioButton_b);
            this.Controls.Add(this.radioButton_a);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_ausgewaehlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Feuerlöscher_verwalten";
            this.Text = "Feuerlöscher Verwalten";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBox_ausgewaehlt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Preis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Kap;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radioButton_a;
        private System.Windows.Forms.RadioButton radioButton_b;
        private System.Windows.Forms.RadioButton radioButton_c;
        private System.Windows.Forms.RadioButton radioButton_f;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox_f;
        private System.Windows.Forms.CheckBox checkBox_c;
        private System.Windows.Forms.CheckBox checkBox_b;
        private System.Windows.Forms.CheckBox checkBox_a;
        private System.Windows.Forms.Button button_fe_plazieren;
        private System.Windows.Forms.Button button_fe_speichern;
    }
}

