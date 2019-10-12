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

namespace Proyecto_2parcial
{
    /// <summary>
    /// Lógica de interacción para Sushi.xaml
    /// </summary>
    public partial class Sushi : UserControl
    {
        public Sushi()
        {
            InitializeComponent();
            restriccion.Visibility = Visibility.Hidden;
        }

        private void infoingrediente1_TextChanged(object sender, TextChangedEventArgs e)
        {
            restriccion.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (infoingrediente1.Text == string.Empty || infoingrediente2.Text == string.Empty || infoingrediente3.Text == string.Empty || infonota.Text == string.Empty || infoqueso.Text == string.Empty || infotamaño.Text == string.Empty)
            {
                restriccion.Visibility = Visibility.Visible;
            }

            else
            {
                sushi.Children.Clear();

            }
        }

        private void infoingrediente2_TextChanged(object sender, TextChangedEventArgs e)
        {
            restriccion.Visibility = Visibility.Hidden;
        }

        private void infoingrediente3_TextChanged(object sender, TextChangedEventArgs e)
        {
            restriccion.Visibility = Visibility.Hidden;
        }

        private void infonota_TextChanged(object sender, TextChangedEventArgs e)
        {
            restriccion.Visibility = Visibility.Hidden;
        }

        private void infoqueso_TextChanged(object sender, TextChangedEventArgs e)
        {
            restriccion.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sushi.Children.Clear();
        }
    }
}
