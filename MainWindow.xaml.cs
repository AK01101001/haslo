
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

namespace haslo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string haslo = "";
            string specjalneS = "!@#$%^&*()_+-=";

            if (int.TryParse(dlugosc.Text, out int x))
            {
                if (md.IsChecked == true)
                {
                    haslo += (char)new Random().Next(65, 90);//duze litery
                    x--;
                }
                if (cyfry.IsChecked == true)
                {
                    haslo += (char)new Random().Next(48, 57);//cyfry
                    x--;
                }
                if (specjalne.IsChecked == true)
                {
                    haslo += specjalneS[new Random().Next(specjalneS.Length)];
                    x--;
                }
                for (int i = 0; i < x; i++)
                {
                    haslo += (char)new Random().Next(97, 122);//male litery
                }
                MessageBox.Show(haslo);
            }

        }
    }
}
