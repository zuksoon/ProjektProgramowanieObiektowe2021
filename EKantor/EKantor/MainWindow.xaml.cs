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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace EKantor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btmUstawienia_Click(object sender, RoutedEventArgs e)
        {
            Ustawienia ustawienia = new Ustawienia();
            ustawienia.Show();
            this.Close();
        }

        private void btnMojeKonto_Click(object sender, RoutedEventArgs e)
        {
            MojeKonto mojeKonto = new MojeKonto();
            mojeKonto.Show();
            this.Close();
        }

        private void btnZamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
