namespace IIB1_UE1_Gruppe12_GUI
{
    partial class ALTERROOM
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
            this.combobox_material = new System.Windows.Forms.ComboBox();
            this.textbox_masse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_heizwert = new System.Windows.Forms.Label();
            this.label_abbrandfaktor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.checkbox_gechuetzt = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // combobox_material
            // 
            this.combobox_material.FormattingEnabled = true;
            this.combobox_material.Items.AddRange(new object[] {
            "Holz",
            "Papier",
            "Textile",
            "Kunststoffe",
            "Feste Brennstoffe",
            "Brennbare Flüssigkeiten",
            "Gummi",
            "Nahrungsmittel",
            "Elektronik",
            "Sonstige"});
            this.combobox_material.Location = new System.Drawing.Point(515, 124);
            this.combobox_material.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combobox_material.Name = "combobox_material";
            this.combobox_material.Size = new System.Drawing.Size(180, 28);
            this.combobox_material.TabIndex = 0;
            this.combobox_material.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textbox_masse
            // 
            this.textbox_masse.Location = new System.Drawing.Point(528, 238);
            this.textbox_masse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_masse.Name = "textbox_masse";
            this.textbox_masse.Size = new System.Drawing.Size(148, 26);
            this.textbox_masse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heizwert H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abbrandfaktor M:";
            // 
            // label_heizwert
            // 
            this.label_heizwert.AutoSize = true;
            this.label_heizwert.Location = new System.Drawing.Point(687, 325);
            this.label_heizwert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_heizwert.Name = "label_heizwert";
            this.label_heizwert.Size = new System.Drawing.Size(0, 20);
            this.label_heizwert.TabIndex = 4;
            // 
            // label_abbrandfaktor
            // 
            this.label_abbrandfaktor.AutoSize = true;
            this.label_abbrandfaktor.Location = new System.Drawing.Point(687, 385);
            this.label_abbrandfaktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_abbrandfaktor.Name = "label_abbrandfaktor";
            this.label_abbrandfaktor.Size = new System.Drawing.Size(0, 20);
            this.label_abbrandfaktor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Masse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "kg";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(346, 252);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 35);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // checkbox_gechuetzt
            // 
            this.checkbox_gechuetzt.AutoSize = true;
            this.checkbox_gechuetzt.Location = new System.Drawing.Point(595, 166);
            this.checkbox_gechuetzt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkbox_gechuetzt.Name = "checkbox_gechuetzt";
            this.checkbox_gechuetzt.Size = new System.Drawing.Size(105, 24);
            this.checkbox_gechuetzt.TabIndex = 11;
            this.checkbox_gechuetzt.Text = "geschützt";
            this.checkbox_gechuetzt.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 444);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Raum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bestimmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Entfernen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(481, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 381);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varianten";
            // 
            // ALTERROOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkbox_gechuetzt);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_abbrandfaktor);
            this.Controls.Add(this.label_heizwert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_masse);
            this.Controls.Add(this.combobox_material);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ALTERROOM";
            this.Text = "Baustoff Verwalten";
            this.Load += new System.EventHandler(this.ALTERROOM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_material;
        private System.Windows.Forms.TextBox textbox_masse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_heizwert;
        private System.Windows.Forms.Label label_abbrandfaktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.CheckBox checkbox_gechuetzt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}