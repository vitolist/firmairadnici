using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

/*

Enkapsulacija je jedan od četiri osnovna koncepta objektno 
orijentiranog programiranja (OOP), zajedno s nasljeđivanjem, polimorfizmom i apstrakcijom.
Enkapsulacija se odnosi na skrivanje unutarnjih detalja objekta i ograničavanje pristupa tim detaljima izvana.
Ovaj koncept omogućuje promjenu implementacije objekta bez utjecaja na ostatak programa koji koristi taj objekt.

public class Osoba
{
    private string ime;  // privatni član
    private int godine;   // privatni član

    // Javni getteri i setteri omogućuju pristup privatnim članovima
    public string Ime
    {
        get { return ime; }
        set { ime = value; }
    }

    public int Godine
    {
        get { return godine; }
        set { godine = value; }
    }
}

// Primjer korištenja gettera i settera
Osoba osoba = new Osoba();
osoba.Ime = "Ana";      // postavljanje vrijednosti putem settera
string imeOsobe = osoba.Ime;  // čitanje vrijednosti putem gettera


*/

namespace firmairadnici
{
    public partial class Form1 : Form
    {
        SQLDB db;
        public List<Dictionary<string, object>> firmeDict;
        public List<Firma> firme;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            dateTimeFormat();



            db = new SQLDB();
            firme = new List<Firma>();

            popuniFirme();
            ispisFirmi();
        }

        public void dateTimeFormat()
        {
            userTimePicker.Format = DateTimePickerFormat.Custom;
            userTimePicker.CustomFormat = "yyyy.dd.MM. HH:mm";
            userTimePicker.ShowUpDown = true;
            userTimePicker.Value = DateTime.Today;

            pocetakPicker1.Format = DateTimePickerFormat.Custom;
            pocetakPicker1.CustomFormat = "HH:mm";
            pocetakPicker1.ShowUpDown = true;
            pocetakPicker1.Value = DateTime.Today;

            pocetakPicker2.Format = DateTimePickerFormat.Custom;
            pocetakPicker2.CustomFormat = "HH:mm";
            pocetakPicker2.ShowUpDown = true;
            pocetakPicker2.Value = DateTime.Today;

            krajPicker1.Format = DateTimePickerFormat.Custom;
            krajPicker1.CustomFormat = "HH:mm";
            krajPicker1.ShowUpDown = true;
            krajPicker1.Value = DateTime.Today;

            krajPicker2.Format = DateTimePickerFormat.Custom;
            krajPicker2.CustomFormat = "HH:mm";
            krajPicker2.ShowUpDown = true;
            krajPicker2.Value = DateTime.Today;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Update every 1000 milliseconds (1 second)
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
            labelDateTime.Text = DateTime.Now.ToString();
        }

        public Firma firmaByID(int id)
        {
            foreach (var firma in firme)
            {
                if (firma.DohvatiId() == id)
                {
                    return firma;
                }
            }

            return null;
        }


        public class SQLDB
        {
            private static SQLDB instance;
            private MySqlConnection connection;

            public SQLDB()
            {
                string conn_string = @"Server=localhost;Port=3306;Database=firmairadnici;User ID=vito;Password=micko;Convert Zero Datetime=True";

                connection = new MySqlConnection(conn_string);
                try
                {
                    connection.Open();
                    Console.WriteLine("Connected to MySQL Server");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            public static SQLDB Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new SQLDB();
                    }
                    return instance;
                }
            }

            public List<Dictionary<string, object>> Select(string sql)
            {
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dictionary<string, object> row = new Dictionary<string, object>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string columnName = reader.GetName(i);
                        object value = reader.GetValue(i);
                        row[columnName] = value;
                    }

                    rows.Add(row);
                }

                reader.Close();

                return rows;
            }

            public void Insert(string sql)
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            public void Delete(string sql)
            {
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }

        public class Radnik
        {
            private int id;
            private string ime;
            private string prezime;
            private List<RadnoVrijeme> radnaVremena;

            public Radnik(int id, string ime, string prezime)
            {
                this.id = id;
                this.ime = ime;
                this.prezime = prezime;
                this.radnaVremena = new List<RadnoVrijeme>();
            }

            public string DohvatiIme()
            {
                return ime;
            }

            public string DohvatiPrezime()
            {
                return prezime;
            }

            public int DohvatiId()
            {
                return id;
            }


            public void DodajRadnoVrijeme(RadnoVrijeme radnoVrijeme)
            {
                radnaVremena.Add(radnoVrijeme);
            }

            public List<RadnoVrijeme> DohvatiRadnoVrijeme()
            {
                return radnaVremena;
            }

            public int DohvatiUkupnoSatiUTjednu()
            {
                int ukupnoSati = 0;
                int i = 1;
                foreach (RadnoVrijeme radnoVrijeme in radnaVremena)
                {
                    if (radnoVrijeme.DohvatiDolazak() == true && i < radnaVremena.Count)
                    {
                        ukupnoSati -= radnoVrijeme.DohvatiDatum().Hour;
                    }
                    else if (radnoVrijeme.DohvatiDolazak() == false)
                    {
                        ukupnoSati += radnoVrijeme.DohvatiDatum().Hour;
                    }
                    i++;
                }
                return ukupnoSati;
            }

            public void IspisiInformacije()
            {
                Console.WriteLine($"Ime: {ime}");
                Console.WriteLine($"Prezime: {prezime}");
                Console.WriteLine($"Ukupno sati u tjednu: {DohvatiUkupnoSatiUTjednu()} sati");
            }

            public override string ToString()
            {
                return id + " " + ime + " " + prezime;
            }
        }
        public class Firma
        {
            private int id;
            private string naziv;
            public List<Radnik> radnici;
            private int radnoVrijemeFirme;

            public Firma(int id, string naziv)
            {
                this.id = id;
                this.naziv = naziv;
                //this.radnoVrijemeFirme = radnoVrijemeFirme;
                this.radnici = new List<Radnik>();
            }

            public void DodajRadnika(Radnik radnik)
            {
                radnici.Add(radnik);
            }

            public void ObrisiRadnikaPoID(int id)
            {
                Radnik radnikZaBrisanje = radnici.Find(r => r.DohvatiId() == id);
                if (radnikZaBrisanje != null)
                {
                    radnici.Remove(radnikZaBrisanje);
                    Console.WriteLine($"Radnik s ID-om {id} je obrisan.");
                }
                else
                {
                    Console.WriteLine($"Radnik s ID-om {id} nije pronađen.");
                }
            }

            //public List<Radnik> DohvatiZaposlenikeSaNedovoljnoSati()
            //{
            //    List<Radnik> nedovoljnoSatiRadnici = new List<Radnik>();
            //    foreach (var radnik in radnici)
            //    {
            //        if (radnik.DohvatiUkupnoSatiUTjednu() < radnoVrijemeFirme)
            //        {
            //            nedovoljnoSatiRadnici.Add(radnik);
            //        }
            //    }
            //    return nedovoljnoSatiRadnici;
            //}

            public void IspisiSveRadnike()
            {
                Console.WriteLine($"Radnici firme {naziv} (ID: {id}):");
                foreach (var radnik in radnici)
                {
                    radnik.IspisiInformacije();
                    Console.WriteLine();
                }
            }

            public string DohvatiNaziv()
            {
                return naziv;
            }

            public List<Radnik> DohvatiRadnike()
            {
                return radnici;
            }

            public int DohvatiId()
            {
                return id;
            }

            public void ispisiPodatke()
            {
                Console.WriteLine($"ID: {id} => {naziv}");
            }

            public override string ToString()
            {
                return naziv;
            }
        }

        public class RadnoVrijeme
        {
            private DateTime datum;
            private bool dolazak;

            public RadnoVrijeme(DateTime datum, bool dolazak)
            {
                this.datum = datum;
                this.dolazak = dolazak;
            }

            public DateTime DohvatiDatum()
            {
                return datum;
            }

            public bool DohvatiDolazak()
            {
                return dolazak;
            }

            public override string ToString()
            {
                return datum.ToString() + " " + (dolazak ? "DOLAZAK" : "ODLAZAK");
            }
        }

        public void popuniRadnikeListBox()
        {
            firmaIdLabel.Text = $"Firma naziv: {firmeListBox.SelectedItem}";
            radniciListBox.Items.Clear();

            if (firmeListBox.SelectedItem is Firma selectedFirma)
            {
                foreach (Radnik radnik in selectedFirma.radnici)
                {
                    radniciListBox.Items.Add(radnik);
                }
            }
        }

        public void oniKojiKasne()
        {
            kojiKasneListBox.Items.Clear();
            if (firmeListBox.SelectedItem is Firma selectedFirma)
            {
                foreach (Radnik radnik in selectedFirma.DohvatiRadnike())
                {
                    int radnikSati = radnik.DohvatiUkupnoSatiUTjednu();
                    if (radnikSati < 40)
                    {
                        kojiKasneListBox.Items.Add(radnik + ": " + radnikSati);
                    }
                }
            }
        }

        private void firmeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniRadnikeListBox();
            oniKojiKasne();
        }

        public void popuniFirme()
        {
            firmeDict = db.Select("select * from firme");
            firme.Clear();
            foreach (var firma in firmeDict)
            {
                int firma_id = Convert.ToInt32(firma["id"]);
                Firma firmaObj = new Firma(firma_id, Convert.ToString(firma["naziv"]));

                foreach (var radnik in db.Select($"select * from radnici where firma_id={firma_id}"))
                {
                    int id = Convert.ToInt32(radnik["id"]);
                    string ime = Convert.ToString(radnik["ime"]);
                    string prezime = Convert.ToString(radnik["prezime"]);

                    Radnik novi_radnik = new Radnik(id, ime, prezime);

                    List<Dictionary<string, object>> radni_sati = db.Select("select * from radno_vrijeme where radnik_id = " + id.ToString());
                    foreach (Dictionary<string, object> vrijeme in radni_sati)
                    {
                        novi_radnik.DodajRadnoVrijeme(new RadnoVrijeme(Convert.ToDateTime(vrijeme["vrijeme"]), Convert.ToBoolean(vrijeme["dolazak"])));
                    }


                    firmaObj.DodajRadnika(novi_radnik);
                }
                firme.Add(firmaObj);
            }

            firmeListBox.Items.Clear();
            firmeListBox2.Items.Clear();
            foreach (var firma in firme)
            {
                firmeListBox.Items.Add(firma);
                firmeListBox2.Items.Add(firma);
            }
        }

        public void ispisFirmi()
        {
            foreach (var firma in firme)
            {
                firma.ispisiPodatke();
                firma.IspisiSveRadnike();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //int broj_dolazaka, broj_odlazaka;
            //foreach (var row in db.Select("SELECT SUM(CASE WHEN dolazak = 1 THEN 1 ELSE 0 END) AS broj_dolazaka, " +
            //    "SUM(CASE WHEN dolazak = 0 THEN 1 ELSE 0 END) AS broj_odlazaka " +
            //    "FROM radno_vrijeme;"))
            //{
            //    //Console.WriteLine($"Broj dolazaka za usera {}" + dictionary["broj_dolazaka"]);
            //    //Console.WriteLine(dictionary["broj_odlazaka"]);
            //    broj_dolazaka = Convert.ToInt32(row["broj_dolazaka"]);
            //    broj_odlazaka = Convert.ToInt32(row["broj_odlazaka"]);
            //}
            if (radniciListBox.SelectedItem is Radnik selectedRadnik)
            {
                testlabel.Text = (userTimePicker.Value - new DateTime(1970, 1, 1)).TotalSeconds.ToString();

                string user_id = userIdTextBox.Text;
                string vrijeme = userTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                int dolazak = dolazakRadio.Checked ? 1 : 0;

                Console.WriteLine(vrijeme);

                if (user_id != "")
                {
                    db.Insert($"insert into radno_vrijeme (radnik_id, vrijeme, dolazak) " +
                        $"values ({user_id}, '{vrijeme}', {dolazak})");
                }

                int temp = firmeListBox.SelectedIndex;
                int temp2 = radniciListBox.SelectedIndex;
                popuniFirme();
                firmeListBox.SelectedIndex = temp;
                radniciListBox.SelectedIndex = temp2;



            }
        }

        public void popuniSateListBox()
        {
            radnikIdLabel.Text = $"Radnik: {radniciListBox.SelectedItem}";
            if (radniciListBox.SelectedItem is Radnik selectedRadnik)
            {
                userIdTextBox.Text = selectedRadnik.DohvatiId().ToString();

                radnaVremenaRadnikListBox.Items.Clear();
                foreach (RadnoVrijeme vrijeme in selectedRadnik.DohvatiRadnoVrijeme())
                {
                    radnaVremenaRadnikListBox.Items.Add(vrijeme);
                }
                satiRadnikaLabel.Text = $"Radni sati radnika ({selectedRadnik}): " + selectedRadnik.DohvatiUkupnoSatiUTjednu().ToString();
            }
        }

        private void radniciListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniSateListBox();
        }

        private void dodajFirmuButton_Click(object sender, EventArgs e)
        {

            string naziv = nazivFirmeTextBox.Text;

            string pocetak1 = pocetakPicker1.Value.ToString("HH:mm:ss");
            string pocetak2 = pocetakPicker2.Value.ToString("HH:mm:ss");
            string kraj1 = krajPicker1.Value.ToString("HH:mm:ss");
            string kraj2 = krajPicker2.Value.ToString("HH:mm:ss");

            db.Insert($"insert into firme (naziv, pocetak1, pocetak2, kraj1, kraj2) " +
                $"values ('{naziv}', '{pocetak1}', '{pocetak2}', '{kraj1}', '{kraj2}')");

            testLabel2.Text = "UPISANO";

            popuniFirme();
        }

        private void firmeListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabranaFirmaLabel.Text = $"Firma naziv: {firmeListBox2.SelectedItem}";
        }

        private void dodajKorisnika_Click(object sender, EventArgs e)
        {
            if (firmeListBox2.SelectedIndex != -1)
            {
                if (imeTextBox.Text != "" && prezimeTextBox.Text != "")
                {
                    if (firmeListBox2.SelectedItem is Firma selectedFirma)
                    {
                        db.Insert($"insert into radnici (ime, prezime, firma_id) " +
                        $"values ('{imeTextBox.Text}', '{prezimeTextBox.Text}', '{selectedFirma.DohvatiId()}')");
                        radnikDodan.Text = "Radnik dodan";
                    }
                }
            }
            else
            {
                radnikDodan.Text = "Odaberi firmu!";
            }
        }

        private void radnaVremenaRadnikListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
