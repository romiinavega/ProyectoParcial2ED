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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Formulario.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (articulo.SelectedIndex)
            {
                case 0: 
                   Formulario.Children.Add(new Pizza());
                    break;

                case 1:
                    Formulario.Children.Add(new Hamburguesa());
                    break;

                case 2: 
                    Formulario.Children.Add(new Sushi());
                    break;
                case 3: 
                   Formulario.Children.Add(new Carnes());

                    break;

                case 4: 
                    Formulario.Children.Add(new Ensaladas());
        
                    break;

                case 5:
                   Formulario.Children.Add(new Bebida());

                    break;


            }
        }

    }
}

