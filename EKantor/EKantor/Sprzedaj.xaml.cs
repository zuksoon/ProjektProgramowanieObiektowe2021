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
    /// Logika interakcji dla klasy Sprzedaj.xaml
    /// </summary>
    public partial class Sprzedaj : Window
    {
        float CenaSprzedazyEuro;
        float CenaSprzedazyDolara;
        float CenaSprzedazyFunta;
        string[] Ceny;
        string[] Zasoby;

        public Sprzedaj()
        {
            InitializeComponent();
            Ceny = System.IO.File.ReadAllLines("Cenowy.txt");
            Zasoby = System.IO.File.ReadAllLines("Zasoby.txt");

            CenaSprzedazyEuro = float.Parse(Ceny[1]);
            CenaSprzedazyDolara = float.Parse(Ceny[5]);
            CenaSprzedazyFunta = float.Parse(Ceny[9]);

            TextBoxWolneSrodki.Text = Zasoby[0].ToString();
            TextBoxIloscEuro.Text = Zasoby[1].ToString();
            TextBoxIloscDolar.Text = Zasoby[2].ToString();
            TextBoxIloscFunt.Text = Zasoby[3].ToString();
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        // obsługa wyboru waluty
        private void RBEuro_Checked(object sender, RoutedEventArgs e)
        {
            if (RBEuro.IsChecked == true)
            {
                RBDolar.IsChecked = false;
                RBFunt.IsChecked = false;
                TextBoxIloscEuro.Visibility = Visibility.Visible;
                TextBoxIleSprzedacEuro.Visibility = Visibility.Visible;
                TextBoxCenaEuro.Visibility = Visibility.Visible;

                TextBoxIloscDolar.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacDolar.Visibility = Visibility.Hidden;
                TextBoxCenaDolar.Visibility = Visibility.Hidden;
                TextBoxIloscFunt.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacFunt.Visibility = Visibility.Hidden;
                TextBoxCenaFunt.Visibility = Visibility.Hidden;
            }
        }

        private void RBDolar_Checked(object sender, RoutedEventArgs e)
        {
            if (RBDolar.IsChecked == true)
            {
                RBEuro.IsChecked = false;
                RBFunt.IsChecked = false;
                TextBoxIloscDolar.Visibility = Visibility.Visible;
                TextBoxIleSprzedacDolar.Visibility = Visibility.Visible;
                TextBoxCenaDolar.Visibility = Visibility.Visible;

                TextBoxIloscEuro.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacEuro.Visibility = Visibility.Hidden;
                TextBoxCenaEuro.Visibility = Visibility.Hidden;
                TextBoxIloscFunt.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacFunt.Visibility = Visibility.Hidden;
                TextBoxCenaFunt.Visibility = Visibility.Hidden;
            }
        }

        private void RBFunt_Checked(object sender, RoutedEventArgs e)
        {
            if (RBFunt.IsChecked == true)
            {
                RBEuro.IsChecked = false;
                RBDolar.IsChecked = false;
                TextBoxIloscFunt.Visibility = Visibility.Visible;
                TextBoxIleSprzedacFunt.Visibility = Visibility.Visible;
                TextBoxCenaFunt.Visibility = Visibility.Visible;

                TextBoxIloscEuro.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacEuro.Visibility = Visibility.Hidden;
                TextBoxCenaEuro.Visibility = Visibility.Hidden;
                TextBoxIloscDolar.Visibility = Visibility.Hidden;
                TextBoxIleSprzedacDolar.Visibility = Visibility.Hidden;
                TextBoxCenaDolar.Visibility = Visibility.Hidden;
            }
        }


        // obsługa sprzedarzy
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (RBEuro.IsChecked == true)
            {
                try
                {
                    /// wykonanie 2 poniższych linni dla sprawdzenia poprawności wartości
                    float.Parse(TextBoxCenaEuro.Text);
                    float.Parse(TextBoxIloscEuro.Text);

                    Zasoby[0] = (float.Parse(Zasoby[0]) + float.Parse(TextBoxCenaEuro.Text)).ToString();
                    Zasoby[1] = (float.Parse(Zasoby[1]) - float.Parse(TextBoxIloscEuro.Text)).ToString();

                    StreamWriter swZ = File.CreateText("Zasoby.txt");
                    swZ.WriteLine(Zasoby[0]);
                    swZ.WriteLine(Zasoby[1]);
                    swZ.WriteLine(Zasoby[2]);
                    swZ.WriteLine(Zasoby[3]);
                    swZ.Close();

                    this.DialogResult = true;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wprowadzono niepoprawne dane i nie można wykonać operacji, nalezy wprowadzić cyfrę!");
                }
            }
        }


        // obsługa zmian TextBoxów 
        private void TextBoxIloscEuro_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(float.Parse(TextBoxIloscEuro.Text) != float.Parse(Zasoby[1]))
            {
                MessageBox.Show("Masz tyle ile zakupiłeś! Zostaw tego Boxa w spokoju...");
                TextBoxIloscEuro.Text = Zasoby[1].ToString();
            }
        }

        private void TextBoxIloscDolar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (float.Parse(TextBoxIloscEuro.Text) != float.Parse(Zasoby[1]))
            {
                MessageBox.Show("Masz tyle ile zakupiłeś! Zostaw tego Boxa w spokoju...");
                TextBoxIloscDolar.Text = Zasoby[1].ToString();
            }
        }

        private void TextBoxIloscFunt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (float.Parse(TextBoxIloscEuro.Text) != float.Parse(Zasoby[1]))
            {
                MessageBox.Show("Masz tyle ile zakupiłeś! Zostaw tego Boxa w spokoju...");
                TextBoxIloscFunt.Text = Zasoby[1].ToString();
            }
        }

        private void TextBoxCenaEuro_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxCenaDolar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxCenaFunt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
