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
    /// Logika interakcji dla klasy Wyplac.xaml
    /// </summary>
    public partial class Wyplac : Window
    {

        string[] zasoby = System.IO.File.ReadAllLines("Zasoby.txt");
        float kwotaDpWyplaty = 0f;

        public Wyplac()
        {
            InitializeComponent();
            TextBoxWolneSrodki.Text = zasoby[0].ToString();
        }


        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kwotaDpWyplaty = float.Parse(TextBoxIleWyplacic.Text);
                if (kwotaDpWyplaty > float.Parse(zasoby[0]))
                {
                    MessageBox.Show("Nie można wypłacić więcej pieniędzy, niż się posiada wolnych zasobów !");
                }
                else
                {
                    zasoby[0] = (float.Parse(zasoby[0]) - kwotaDpWyplaty).ToString();
                    StreamWriter sw = File.CreateText("Zasoby.txt");
                    sw.WriteLine(zasoby[0]);
                    sw.WriteLine(zasoby[1]);
                    sw.WriteLine(zasoby[2]);
                    sw.WriteLine(zasoby[3]);
                    sw.Close();
                    this.DialogResult = true;
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadź poprawną kwotę");
            }
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}

