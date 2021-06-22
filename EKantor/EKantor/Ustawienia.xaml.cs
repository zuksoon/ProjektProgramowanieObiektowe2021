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
    /// Logika interakcji dla klasy Ustawienia.xaml
    /// </summary>
    public partial class Ustawienia : Window
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void CheckBoxNaPewnoReset_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxNaPewnoReset.IsChecked == true)
            {
                btnResetuj.Visibility = Visibility.Visible;
            }
        }

        private void CheckBoxNaPewnoReset_Unchecked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxNaPewnoReset.IsChecked == false)
            {
                btnResetuj.Visibility = Visibility.Hidden;
            }
        }

        private void btnPowrot_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnResetuj_Click(object sender, RoutedEventArgs e)
        {
            string[] ResetCeny = System.IO.File.ReadAllLines("CenowyDefault.txt");
            string[] ResetZasoby = System.IO.File.ReadAllLines("ZasobyDefault.txt");

            ///resetowanie Zasobów
            StreamWriter swZ = File.CreateText("Zasoby.txt");
            swZ.WriteLine(ResetZasoby[0]);
            swZ.WriteLine(ResetZasoby[1]);
            swZ.WriteLine(ResetZasoby[2]);
            swZ.WriteLine(ResetZasoby[3]);
            swZ.Close();

            ///resetowanie Ceny
            StreamWriter swC = File.CreateText("Zasoby.txt");
            swC.WriteLine(ResetCeny[0]);
            swC.WriteLine(ResetCeny[1]);
            swC.WriteLine(ResetCeny[2]);
            swC.WriteLine(ResetCeny[3]);
            swC.WriteLine(ResetCeny[4]);
            swC.WriteLine(ResetCeny[5]);
            swC.WriteLine(ResetCeny[6]);
            swC.WriteLine(ResetCeny[7]);
            swC.WriteLine(ResetCeny[8]);
            swC.WriteLine(ResetCeny[9]);
            swC.WriteLine(ResetCeny[10]);
            swC.WriteLine(ResetCeny[11]);
            swC.Close();

            MessageBox.Show("Wszystkie ceny oraz zasoby zostały przywrócone do początkowych.");
        }
    }
}
