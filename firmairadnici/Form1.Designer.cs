namespace firmairadnici
{
    partial class Form1
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
            this.firmeListBox = new System.Windows.Forms.ListBox();
            this.radniciListBox = new System.Windows.Forms.ListBox();
            this.firmaIdLabel = new System.Windows.Forms.Label();
            this.radnikIdLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dolazakRadio = new System.Windows.Forms.RadioButton();
            this.odlazakRadio = new System.Windows.Forms.RadioButton();
            this.userTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.testLabel2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.krajPicker2 = new System.Windows.Forms.DateTimePicker();
            this.krajPicker1 = new System.Windows.Forms.DateTimePicker();
            this.pocetakPicker2 = new System.Windows.Forms.DateTimePicker();
            this.pocetakPicker1 = new System.Windows.Forms.DateTimePicker();
            this.dodajFirmuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivFirmeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radnikDodan = new System.Windows.Forms.Label();
            this.dodajKorisnika = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.odabranaFirmaLabel = new System.Windows.Forms.Label();
            this.firmeListBox2 = new System.Windows.Forms.ListBox();
            this.radnaVremenaRadnikListBox = new System.Windows.Forms.ListBox();
            this.satiRadnikaLabel = new System.Windows.Forms.Label();
            this.kojiKasneListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // firmeListBox
            // 
            this.firmeListBox.FormattingEnabled = true;
            this.firmeListBox.ItemHeight = 16;
            this.firmeListBox.Location = new System.Drawing.Point(6, 6);
            this.firmeListBox.Name = "firmeListBox";
            this.firmeListBox.Size = new System.Drawing.Size(194, 132);
            this.firmeListBox.TabIndex = 0;
            this.firmeListBox.SelectedIndexChanged += new System.EventHandler(this.firmeListBox_SelectedIndexChanged);
            // 
            // radniciListBox
            // 
            this.radniciListBox.FormattingEnabled = true;
            this.radniciListBox.ItemHeight = 16;
            this.radniciListBox.Location = new System.Drawing.Point(6, 156);
            this.radniciListBox.Name = "radniciListBox";
            this.radniciListBox.Size = new System.Drawing.Size(194, 276);
            this.radniciListBox.TabIndex = 1;
            this.radniciListBox.SelectedIndexChanged += new System.EventHandler(this.radniciListBox_SelectedIndexChanged);
            // 
            // firmaIdLabel
            // 
            this.firmaIdLabel.AutoSize = true;
            this.firmaIdLabel.Location = new System.Drawing.Point(206, 6);
            this.firmaIdLabel.Name = "firmaIdLabel";
            this.firmaIdLabel.Size = new System.Drawing.Size(44, 16);
            this.firmaIdLabel.TabIndex = 2;
            this.firmaIdLabel.Text = "label1";
            // 
            // radnikIdLabel
            // 
            this.radnikIdLabel.AutoSize = true;
            this.radnikIdLabel.Location = new System.Drawing.Point(206, 156);
            this.radnikIdLabel.Name = "radnikIdLabel";
            this.radnikIdLabel.Size = new System.Drawing.Size(44, 16);
            this.radnikIdLabel.TabIndex = 3;
            this.radnikIdLabel.Text = "label1";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(477, 93);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(112, 22);
            this.userIdTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vaš odabrani ID:";
            // 
            // dolazakRadio
            // 
            this.dolazakRadio.AutoSize = true;
            this.dolazakRadio.Checked = true;
            this.dolazakRadio.Location = new System.Drawing.Point(477, 156);
            this.dolazakRadio.Name = "dolazakRadio";
            this.dolazakRadio.Size = new System.Drawing.Size(89, 20);
            this.dolazakRadio.TabIndex = 6;
            this.dolazakRadio.TabStop = true;
            this.dolazakRadio.Text = "DOLAZAK";
            this.dolazakRadio.UseVisualStyleBackColor = true;
            // 
            // odlazakRadio
            // 
            this.odlazakRadio.AutoSize = true;
            this.odlazakRadio.Location = new System.Drawing.Point(477, 183);
            this.odlazakRadio.Name = "odlazakRadio";
            this.odlazakRadio.Size = new System.Drawing.Size(89, 20);
            this.odlazakRadio.TabIndex = 7;
            this.odlazakRadio.Text = "ODLAZAK";
            this.odlazakRadio.UseVisualStyleBackColor = true;
            // 
            // userTimePicker
            // 
            this.userTimePicker.Location = new System.Drawing.Point(389, 121);
            this.userTimePicker.Name = "userTimePicker";
            this.userTimePicker.Size = new System.Drawing.Size(200, 22);
            this.userTimePicker.TabIndex = 8;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(952, 600);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(44, 16);
            this.labelDateTime.TabIndex = 9;
            this.labelDateTime.Text = "label2";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(389, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(200, 23);
            this.submit.TabIndex = 10;
            this.submit.Text = "Pošalji";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(252, 255);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(44, 16);
            this.testlabel.TabIndex = 11;
            this.testlabel.Text = "label2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 555);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.kojiKasneListBox);
            this.tabPage1.Controls.Add(this.satiRadnikaLabel);
            this.tabPage1.Controls.Add(this.radnaVremenaRadnikListBox);
            this.tabPage1.Controls.Add(this.firmeListBox);
            this.tabPage1.Controls.Add(this.radniciListBox);
            this.tabPage1.Controls.Add(this.testlabel);
            this.tabPage1.Controls.Add(this.firmaIdLabel);
            this.tabPage1.Controls.Add(this.submit);
            this.tabPage1.Controls.Add(this.radnikIdLabel);
            this.tabPage1.Controls.Add(this.userTimePicker);
            this.tabPage1.Controls.Add(this.userIdTextBox);
            this.tabPage1.Controls.Add(this.odlazakRadio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dolazakRadio);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Evidencija";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.testLabel2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.krajPicker2);
            this.tabPage2.Controls.Add(this.krajPicker1);
            this.tabPage2.Controls.Add(this.pocetakPicker2);
            this.tabPage2.Controls.Add(this.pocetakPicker1);
            this.tabPage2.Controls.Add(this.dodajFirmuButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.nazivFirmeTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodavanje firme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // testLabel2
            // 
            this.testLabel2.AutoSize = true;
            this.testLabel2.Location = new System.Drawing.Point(406, 109);
            this.testLabel2.Name = "testLabel2";
            this.testLabel2.Size = new System.Drawing.Size(44, 16);
            this.testLabel2.TabIndex = 17;
            this.testLabel2.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kraj 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kraj 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Početak 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Početak 1:";
            // 
            // krajPicker2
            // 
            this.krajPicker2.Location = new System.Drawing.Point(338, 284);
            this.krajPicker2.Name = "krajPicker2";
            this.krajPicker2.Size = new System.Drawing.Size(200, 22);
            this.krajPicker2.TabIndex = 12;
            // 
            // krajPicker1
            // 
            this.krajPicker1.Location = new System.Drawing.Point(338, 256);
            this.krajPicker1.Name = "krajPicker1";
            this.krajPicker1.Size = new System.Drawing.Size(200, 22);
            this.krajPicker1.TabIndex = 11;
            // 
            // pocetakPicker2
            // 
            this.pocetakPicker2.Location = new System.Drawing.Point(338, 228);
            this.pocetakPicker2.Name = "pocetakPicker2";
            this.pocetakPicker2.Size = new System.Drawing.Size(200, 22);
            this.pocetakPicker2.TabIndex = 10;
            // 
            // pocetakPicker1
            // 
            this.pocetakPicker1.Location = new System.Drawing.Point(338, 200);
            this.pocetakPicker1.Name = "pocetakPicker1";
            this.pocetakPicker1.Size = new System.Drawing.Size(200, 22);
            this.pocetakPicker1.TabIndex = 9;
            // 
            // dodajFirmuButton
            // 
            this.dodajFirmuButton.Location = new System.Drawing.Point(338, 346);
            this.dodajFirmuButton.Name = "dodajFirmuButton";
            this.dodajFirmuButton.Size = new System.Drawing.Size(200, 29);
            this.dodajFirmuButton.TabIndex = 2;
            this.dodajFirmuButton.Text = "Dodaj";
            this.dodajFirmuButton.UseVisualStyleBackColor = true;
            this.dodajFirmuButton.Click += new System.EventHandler(this.dodajFirmuButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv firme:";
            // 
            // nazivFirmeTextBox
            // 
            this.nazivFirmeTextBox.Location = new System.Drawing.Point(338, 158);
            this.nazivFirmeTextBox.Name = "nazivFirmeTextBox";
            this.nazivFirmeTextBox.Size = new System.Drawing.Size(200, 22);
            this.nazivFirmeTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.radnikDodan);
            this.tabPage3.Controls.Add(this.dodajKorisnika);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.prezimeTextBox);
            this.tabPage3.Controls.Add(this.imeTextBox);
            this.tabPage3.Controls.Add(this.odabranaFirmaLabel);
            this.tabPage3.Controls.Add(this.firmeListBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(826, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dodavanje radnika";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radnikDodan
            // 
            this.radnikDodan.AutoSize = true;
            this.radnikDodan.Location = new System.Drawing.Point(480, 59);
            this.radnikDodan.Name = "radnikDodan";
            this.radnikDodan.Size = new System.Drawing.Size(44, 16);
            this.radnikDodan.TabIndex = 8;
            this.radnikDodan.Text = "label7";
            // 
            // dodajKorisnika
            // 
            this.dodajKorisnika.Location = new System.Drawing.Point(420, 134);
            this.dodajKorisnika.Name = "dodajKorisnika";
            this.dodajKorisnika.Size = new System.Drawing.Size(168, 23);
            this.dodajKorisnika.TabIndex = 7;
            this.dodajKorisnika.Text = "Dodaj korisnika";
            this.dodajKorisnika.UseVisualStyleBackColor = true;
            this.dodajKorisnika.Click += new System.EventHandler(this.dodajKorisnika_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prezime:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(420, 106);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(168, 22);
            this.prezimeTextBox.TabIndex = 4;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(420, 78);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(168, 22);
            this.imeTextBox.TabIndex = 3;
            // 
            // odabranaFirmaLabel
            // 
            this.odabranaFirmaLabel.AutoSize = true;
            this.odabranaFirmaLabel.Location = new System.Drawing.Point(6, 151);
            this.odabranaFirmaLabel.Name = "odabranaFirmaLabel";
            this.odabranaFirmaLabel.Size = new System.Drawing.Size(44, 16);
            this.odabranaFirmaLabel.TabIndex = 2;
            this.odabranaFirmaLabel.Text = "label7";
            // 
            // firmeListBox2
            // 
            this.firmeListBox2.FormattingEnabled = true;
            this.firmeListBox2.ItemHeight = 16;
            this.firmeListBox2.Location = new System.Drawing.Point(6, 6);
            this.firmeListBox2.Name = "firmeListBox2";
            this.firmeListBox2.Size = new System.Drawing.Size(194, 132);
            this.firmeListBox2.TabIndex = 1;
            this.firmeListBox2.SelectedIndexChanged += new System.EventHandler(this.firmeListBox2_SelectedIndexChanged);
            // 
            // radnaVremenaRadnikListBox
            // 
            this.radnaVremenaRadnikListBox.FormattingEnabled = true;
            this.radnaVremenaRadnikListBox.ItemHeight = 16;
            this.radnaVremenaRadnikListBox.Location = new System.Drawing.Point(389, 236);
            this.radnaVremenaRadnikListBox.Name = "radnaVremenaRadnikListBox";
            this.radnaVremenaRadnikListBox.Size = new System.Drawing.Size(285, 276);
            this.radnaVremenaRadnikListBox.TabIndex = 12;
            this.radnaVremenaRadnikListBox.SelectedIndexChanged += new System.EventHandler(this.radnaVremenaRadnikListBox_SelectedIndexChanged);
            // 
            // satiRadnikaLabel
            // 
            this.satiRadnikaLabel.AutoSize = true;
            this.satiRadnikaLabel.Location = new System.Drawing.Point(630, 39);
            this.satiRadnikaLabel.Name = "satiRadnikaLabel";
            this.satiRadnikaLabel.Size = new System.Drawing.Size(44, 16);
            this.satiRadnikaLabel.TabIndex = 13;
            this.satiRadnikaLabel.Text = "label9";
            // 
            // kojiKasneListBox
            // 
            this.kojiKasneListBox.FormattingEnabled = true;
            this.kojiKasneListBox.ItemHeight = 16;
            this.kojiKasneListBox.Location = new System.Drawing.Point(695, 236);
            this.kojiKasneListBox.Name = "kojiKasneListBox";
            this.kojiKasneListBox.Size = new System.Drawing.Size(285, 276);
            this.kojiKasneListBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Koji imaju manje od 40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 625);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox firmeListBox;
        private System.Windows.Forms.ListBox radniciListBox;
        private System.Windows.Forms.Label firmaIdLabel;
        private System.Windows.Forms.Label radnikIdLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dolazakRadio;
        private System.Windows.Forms.RadioButton odlazakRadio;
        private System.Windows.Forms.DateTimePicker userTimePicker;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivFirmeTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button dodajFirmuButton;
        private System.Windows.Forms.DateTimePicker pocetakPicker1;
        private System.Windows.Forms.DateTimePicker krajPicker2;
        private System.Windows.Forms.DateTimePicker krajPicker1;
        private System.Windows.Forms.DateTimePicker pocetakPicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label testLabel2;
        private System.Windows.Forms.ListBox firmeListBox2;
        private System.Windows.Forms.Label odabranaFirmaLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Button dodajKorisnika;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label radnikDodan;
        private System.Windows.Forms.ListBox radnaVremenaRadnikListBox;
        private System.Windows.Forms.Label satiRadnikaLabel;
        private System.Windows.Forms.ListBox kojiKasneListBox;
        private System.Windows.Forms.Label label9;
    }
}

