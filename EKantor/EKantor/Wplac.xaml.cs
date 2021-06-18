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
    /// Logika interakcji dla klasy Wplac.xaml
    /// </summary>
    /// 
    public partial class Wplac : Window
    {
        string[] zasoby = System.IO.File.ReadAllLines("Zasoby.txt");
        float kwotaDpWplaty = 0f;

        public Wplac()
        {
            InitializeComponent();
            TextBoxWolneSrodki.Text = zasoby[0].ToString();
        }

        private void TextBoxWolneSrodki_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnOK_Click(object sender, RoutedEventArgs e) 
        {
            try
            {
                kwotaDpWplaty = float.Parse(TextBoxIleWplacic.Text);
                zasoby[0] = (float.Parse(zasoby[0]) + kwotaDpWplaty).ToString();
                StreamWriter sw = File.CreateText("Zasoby.txt");
                sw.WriteLine(zasoby[0]);
                sw.WriteLine(zasoby[1]);
                sw.WriteLine(zasoby[2]);
                sw.WriteLine(zasoby[3]);
                sw.Close();
                this.DialogResult = true;
                this.Close();
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
