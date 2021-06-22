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
    /// Logika interakcji dla klasy Kup.xaml
    /// </summary>
    public partial class Kup : Window
    {
        float CenaZakupuEuro;
        float CenaZakupuDolara;
        float CenaZakupuFunta;
        string[] Ceny;
        string[] Zasoby;

        public Kup()
        {
            InitializeComponent();
            Ceny = System.IO.File.ReadAllLines("Cenowy.txt");
            Zasoby = System.IO.File.ReadAllLines("Zasoby.txt");

            CenaZakupuEuro = float.Parse(Ceny[2]);
            CenaZakupuDolara = float.Parse(Ceny[6]);
            CenaZakupuFunta = float.Parse(Ceny[10]); 
            TextBoxWolneSrodki.Text = Zasoby[0].ToString();
            TextBoxIloscEuro.Text = "0";
            TextBoxIloscDolar.Text = "0";
            TextBoxIloscFunt.Text = "0";
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RBEuro.IsChecked == true)
                {
                    try
                    {
                        /// wykonanie 2 poniższych linni dla sprawdzenia poprawności wartości
                        float.Parse(TextBoxCenaEuro.Text);
                        float.Parse(TextBoxIloscEuro.Text);

                        Zasoby[0] = (float.Parse(Zasoby[0]) - float.Parse(TextBoxCenaEuro.Text)).ToString();
                        Zasoby[1] = (float.Parse(Zasoby[1]) + float.Parse(TextBoxIloscEuro.Text)).ToString();

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
                if (RBDolar.IsChecked == true)
                {
                    try
                    {
                        /// wykonanie 2 poniższych linni dla sprawdzenia poprawności wartości
                        float.Parse(TextBoxCenaDolar.Text);
                        float.Parse(TextBoxIloscDolar.Text);

                        Zasoby[0] = (float.Parse(Zasoby[0]) - float.Parse(TextBoxCenaDolar.Text)).ToString();
                        Zasoby[2] = (float.Parse(Zasoby[2]) + float.Parse(TextBoxIloscDolar.Text)).ToString();

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
                if (RBFunt.IsChecked == true)
                {
                    try
                    {
                        /// wykonanie 2 poniższych linni dla sprawdzenia poprawności wartości
                        float.Parse(TextBoxCenaFunt.Text);
                        float.Parse(TextBoxIloscFunt.Text);

                        Zasoby[0] = (float.Parse(Zasoby[0]) - float.Parse(TextBoxCenaFunt.Text)).ToString();
                        Zasoby[3] = (float.Parse(Zasoby[3]) + float.Parse(TextBoxIloscFunt.Text)).ToString();

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
                if (RBEuro.IsChecked == false && RBDolar.IsChecked == false && RBFunt.IsChecked == false)
                {
                    MessageBox.Show(" Wybierz którą walutę chcesz kupić, a następnie wpisz ile chcesz danej waluty lub ile chcesz zapłacić.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadzono niepoprawne informacje, nalezy wprowadzić cyfrę!");
            }
            //this.Close();
        }

        private void RBEuro_Checked(object sender, RoutedEventArgs e)
        {
            if (RBEuro.IsChecked == true)
            {
                RBDolar.IsChecked = false;
                RBFunt.IsChecked = false;
                TextBoxIloscEuro.Visibility = Visibility.Visible;
                TextBoxCenaEuro.Visibility = Visibility.Visible;

                TextBoxIloscDolar.Visibility = Visibility.Hidden;
                TextBoxCenaDolar.Visibility = Visibility.Hidden;
                TextBoxIloscFunt.Visibility = Visibility.Hidden;
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
                TextBoxCenaDolar.Visibility = Visibility.Visible;

                TextBoxIloscEuro.Visibility = Visibility.Hidden;
                TextBoxCenaEuro.Visibility = Visibility.Hidden;
                TextBoxIloscFunt.Visibility = Visibility.Hidden;
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
                TextBoxCenaFunt.Visibility = Visibility.Visible;

                TextBoxIloscEuro.Visibility = Visibility.Hidden;
                TextBoxCenaEuro.Visibility = Visibility.Hidden;
                TextBoxIloscDolar.Visibility = Visibility.Hidden;
                TextBoxCenaDolar.Visibility = Visibility.Hidden;
            }
        }

        private void TextBoxIloscEuro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = (float.Parse(TextBoxIloscEuro.Text) * CenaZakupuEuro);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxCenaEuro.Text = (float.Parse(TextBoxIloscEuro.Text) * CenaZakupuEuro).ToString();
                }
                if (sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                    TextBoxIloscEuro.Text = "0";
                    TextBoxCenaEuro.Text = "0";
                }
            }
            catch (Exception)
            {
                TextBoxCenaEuro.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne informacje, nalezy wprowadzić cyfrę!");
            }
        }

        private void TextBoxCenaEuro_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = float.Parse(TextBoxCenaEuro.Text);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxIloscEuro.Text = (float.Parse(TextBoxCenaEuro.Text) / CenaZakupuEuro).ToString();
                }
                if(sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                }
            }
            catch (Exception)
            {
                TextBoxIloscEuro.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne informacje, nalezy wprowadzić cyfrę!");
            }
        }

        private void TextBoxIloscDolar_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = (float.Parse(TextBoxIloscDolar.Text) * CenaZakupuDolara);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxCenaDolar.Text = (float.Parse(TextBoxIloscDolar.Text) * CenaZakupuDolara).ToString();
                }
                if (sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                    TextBoxIloscDolar.Text = "0";
                    TextBoxCenaDolar.Text = "0";
                }
            }
            catch (Exception)
            {
                TextBoxCenaDolar.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne informacje, nalezy wprowadzić cyfrę!");
            }
        }

        private void TextBoxCenaDolar_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = float.Parse(TextBoxCenaEuro.Text);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxIloscEuro.Text = (float.Parse(TextBoxCenaEuro.Text) / CenaZakupuEuro).ToString();
                }
                if (sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                }
            }
            catch (Exception)
            {
                TextBoxIloscDolar.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne dane, nalezy wprowadzić cyfrę!");
            }
        }

        private void TextBoxIloscFunt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = (float.Parse(TextBoxIloscFunt.Text) * CenaZakupuFunta);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxCenaFunt.Text = (float.Parse(TextBoxIloscFunt.Text) * CenaZakupuFunta).ToString();
                }
                if (sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                    TextBoxIloscFunt.Text = "0";
                    TextBoxCenaFunt.Text = "0";
                }
            }
            catch (Exception)
            {
                TextBoxCenaFunt.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne informacje, nalezy wprowadzić cyfrę!");
            }
        }

        private void TextBoxCenaFunt_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                float sprIlosc = float.Parse(TextBoxCenaEuro.Text);
                if (sprIlosc <= float.Parse(Zasoby[0]))
                {
                    TextBoxIloscEuro.Text = (float.Parse(TextBoxCenaEuro.Text) / CenaZakupuEuro).ToString();
                }
                if (sprIlosc > float.Parse(Zasoby[0]))
                {
                    MessageBox.Show("Cena okazała się większa niż twój portfel jest w stanie udzwignąć.");
                }
            }
            catch (Exception)
            {
                TextBoxIloscFunt.Text = "";
                MessageBox.Show("Wprowadzono niepoprawne dane, nalezy wprowadzić cyfrę!");
            }
        }
    }
}
