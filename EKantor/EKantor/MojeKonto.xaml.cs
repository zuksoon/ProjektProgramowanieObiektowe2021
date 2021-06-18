using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace EKantor
{
    /// <summary>
    /// Logika interakcji dla klasy MojeKonto.xaml
    /// </summary>
    public partial class MojeKonto : Window
    {
        public MojeKonto()
        {
            InitializeComponent();
            // pobranie całego tekstu zrzucanie całości do tablicy lines oraz zasoby, potem zamyka plik
            string[] lines = System.IO.File.ReadAllLines("Cenowy.txt");
            string[] zasoby = System.IO.File.ReadAllLines("Zasoby.txt");
            //Ustawianie Walut
            Euro euro = new Euro();
            euro.nazwaWaluty = lines[0];
            euro.cenaZakupu = float.Parse(lines[1]);
            euro.cenaSprzedazy = float.Parse(lines[2]);
            euro.staraCenaSprzedazy = float.Parse(lines[3]);

            Dolar dolar = new Dolar();
            dolar.nazwaWaluty = lines[4];
            dolar.cenaZakupu = float.Parse(lines[5]);
            dolar.cenaSprzedazy = float.Parse(lines[6]);
            dolar.staraCenaSprzedazy = float.Parse(lines[7]);

            Funt funt = new Funt();
            funt.nazwaWaluty = lines[8];
            funt.cenaZakupu = float.Parse(lines[9]);
            funt.cenaSprzedazy = float.Parse(lines[10]);
            funt.staraCenaSprzedazy = float.Parse(lines[11]);

            //Ustawianie TextBoxów wartości walut;
            TextBoxEuroCenaKupna.Text = euro.cenaZakupu.ToString();
            TextBoxEuroCenaSprzedazy.Text = euro.cenaSprzedazy.ToString();
            TextBoxEuroRoznica.Text = (euro.cenaSprzedazy - euro.staraCenaSprzedazy).ToString();

            TextBoxDolarCenaKupna.Text = dolar.cenaZakupu.ToString();
            TextBoxDolarCenaSprzedazy.Text = dolar.cenaSprzedazy.ToString();
            TextBoxDolarRoznica.Text = (dolar.cenaSprzedazy - dolar.staraCenaSprzedazy).ToString();

            TextBoxFuntCenaKupna.Text = funt.cenaZakupu.ToString();
            TextBoxFuntCenaSprzedazy.Text = funt.cenaSprzedazy.ToString();
            TextBoxFuntRoznica.Text = (funt.cenaSprzedazy - funt.staraCenaSprzedazy).ToString();

            //ustawienie TextBoxów zasobów użytkownika // nie mogę odwołać sie do np. euro cena sprzedarzy błąd typu.
            float lacznaIlosc = float.Parse(zasoby[0]) + (float.Parse(zasoby[1]) * euro.cenaSprzedazy) + (float.Parse(zasoby[2]) * dolar.cenaSprzedazy) + (float.Parse(zasoby[3]) * funt.cenaSprzedazy);
            TextBoxIloscWolnychSrodkow.Text = (zasoby[0] + "zł ");
            TextBoxIloscSrodkowLacznie.Text = ( lacznaIlosc + "zł ");
            TextBoxEuroPosiadanaIlosc.Text = zasoby[1];
            TextBoxDolarPosiadanaIlosc.Text = zasoby[2];
            TextBoxFuntPosiadanaIlosc.Text = zasoby[3];
        }

        private void btnPowrotMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnWplac_Click(object sender, RoutedEventArgs e)
        {
            Wplac wplac = new Wplac();
            wplac.ShowDialog();
            if(wplac.DialogResult == false)
            {
                MessageBox.Show("Wpłata została anulowana");
            }
            else
            {
                MessageBox.Show("Wpłata środków przebiegła pomyślnie");
                //na około ale nie znalałem funkcji odświeżenia okna
                MojeKonto newWindow = new MojeKonto();
                newWindow.Show();
                this.Close();
            }
        }

        private void btnWyplac_Click(object sender, RoutedEventArgs e)
        {
            Wyplac wyplac = new Wyplac();
            wyplac.ShowDialog();
            if (wyplac.DialogResult == false)
            {
                MessageBox.Show("Operacja wypłaty została anulowana");
            }
            else
            {
                MessageBox.Show("Wypłata środków przebiegła pomyślnie");
                //na około ale nie znalałem metody odświeżenia okna
                MojeKonto newWindow = new MojeKonto();
                newWindow.Show();
                this.Close();
            }
        }

        private void btnNastepnyDzien_Click(object sender, RoutedEventArgs e)
        {
            //////// Euro
            Random rndEuro = new Random();
            Random rndEuroSecondRandom = new Random();
            int euroPlusMinus = 1;
            if(rndEuro.NextDouble() * rndEuroSecondRandom.NextDouble() > 0.5)
            {
                euroPlusMinus = 1 ;
            }
            else
            {
                euroPlusMinus = -1;
            }
            double mnoznikEuroDouble = rndEuro.NextDouble();
            float mnoznikEuro = (float)mnoznikEuroDouble % 0.05f;
            ///////// Dolar
            Random rndDolar = new Random();
            Random rndDolarSecondRandom = new Random();
            int dolarPlusMinus = 1;
            if (rndDolar.NextDouble() * rndDolarSecondRandom.NextDouble() > 0.5)
            {
                dolarPlusMinus = 1;
            }
            else
            {
                dolarPlusMinus = -1;
            }
            double mnoznikDolarDouble = rndEuro.NextDouble();
            float mnoznikDolar = (float)mnoznikEuroDouble % 0.05f;
            ///////// Funt
            Random rndFunt = new Random();
            Random rndFuntSecondRandom = new Random();
            int funtPlusMinus = 1;
            if (rndFunt.NextDouble() * rndFuntSecondRandom.NextDouble() > 0.3)
            {
                euroPlusMinus = 1;
            }
            else
            {
                euroPlusMinus = -1;
            }
            double mnoznikFuntDouble = rndEuro.NextDouble();
            float mnoznikFunt = (float)mnoznikEuroDouble % 0.05f;

            //////// koniec losowań zmiennych 

            //////// pobranie danych z pliku i ich edycja
            
            string[] infoWaluty = System.IO.File.ReadAllLines("Cenowy.txt"); 
            StreamWriter sw = File.CreateText("Cenowy.txt");
            

            ///// stworzenie buforu dla nowych "starych" cen
            string buforEuro = infoWaluty[2];
            string buforDolar = infoWaluty[6];
            string buforFunt = infoWaluty[10];

            sw.WriteLine("Euro");
            sw.WriteLine(((float.Parse(infoWaluty[1]) * ( mnoznikEuro * (float)euroPlusMinus)) + float.Parse(infoWaluty[1])).ToString());
            sw.WriteLine(((float.Parse(infoWaluty[2]) * (mnoznikEuro * (float)euroPlusMinus)) + float.Parse(infoWaluty[2])).ToString());
            sw.WriteLine(buforEuro);

            sw.WriteLine("Dolar");
            sw.WriteLine(((float.Parse(infoWaluty[5]) * (mnoznikDolar * (float)dolarPlusMinus)) + float.Parse(infoWaluty[5])).ToString());
            sw.WriteLine(((float.Parse(infoWaluty[6]) * (mnoznikDolar * (float)dolarPlusMinus)) + float.Parse(infoWaluty[6])).ToString());
            sw.WriteLine(buforDolar);

            sw.WriteLine("Funt");
            sw.WriteLine(((float.Parse(infoWaluty[9]) * (mnoznikFunt * (float)funtPlusMinus)) + float.Parse(infoWaluty[9])).ToString());
            sw.WriteLine(((float.Parse(infoWaluty[10]) * (mnoznikFunt * (float)funtPlusMinus)) + float.Parse(infoWaluty[10])).ToString());
            sw.WriteLine(buforFunt);

            sw.Close();

            /////// reset okna 
            MojeKonto newWindow = new MojeKonto();
            newWindow.Show();
            this.Close();

        }

        private void btnKup_Click(object sender, RoutedEventArgs e)
        {
            Kup kup = new Kup();
            kup.ShowDialog();
            if (kup.DialogResult == false)
            {
                MessageBox.Show("Zakup waluty został anulowany.");
            }
            else
            {
                MessageBox.Show("Zakup waluty przebiegł pomyślnie.");
                //na około ale nie znalałem funkcji odświeżenia okna
                MojeKonto newWindow = new MojeKonto();
                newWindow.Show();
                this.Close();
            }
        }
    }
}
