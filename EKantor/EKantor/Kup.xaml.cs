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

namespace EKantor
{
    /// <summary>
    /// Logika interakcji dla klasy Kup.xaml
    /// </summary>
    public partial class Kup : Window
    {

        public Kup()
        {
            string[] Ceny = System.IO.File.ReadAllLines("Cenowy.txt");
            string[] Zasoby = System.IO.File.ReadAllLines("Zasoby.txt");

            float CenaZakupuEuro = float.Parse(Ceny[2]);
            float CenaZakupuDolara = float.Parse(Ceny[6]);
            float CenaZakupuFunta = float.Parse(Ceny[10]); 
            InitializeComponent();
            TextBoxWolneSrodki.Text = Zasoby[0].ToString();
        }

        private void btnAnuluj_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
