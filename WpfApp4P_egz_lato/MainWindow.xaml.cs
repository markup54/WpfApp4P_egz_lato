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

namespace WpfApp4P_egz_lato
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

        private void Sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if(list.IsChecked == true)
            {
                obrazekimg.Source = new BitmapImage(new Uri(@"obrazki/list.png",UriKind.Relative));
                cenatxt.Text = "Cena: 1,5 zł";
            }
            else
            {
                if(pocztowka.IsChecked == true) {
                    obrazekimg.Source = new BitmapImage(new Uri(@"obrazki/pocztowka.png", UriKind.Relative));
                    cenatxt.Text = "Cena: 1 zł";
                }
                else
                    if(paczka.IsChecked == true)
                {
                    obrazekimg.Source = new BitmapImage(new Uri(@"obrazki/paczka.png", UriKind.Relative));
                    cenatxt.Text = "Cena: 10 zł";
                }
            }
        }

        private void Zatwierdz_Button_Click(object sender, RoutedEventArgs e)
        {
            if (kodtxtbox.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else
            {
                int wynik;
                if(int.TryParse(kodtxtbox.Text,out wynik))
                {
                    if(wynik>=0 && wynik <= 99999)
                    {
                        MessageBox.Show("Dane przesyłki zostały wprowadzone");
                    }
                }
                else
                {
                    MessageBox.Show("Kod pocztowy powinien się skłądać z samych cyfr");
                }
            }
            
        }
    }
}
