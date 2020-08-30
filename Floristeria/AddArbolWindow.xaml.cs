using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Floristeria
{
    /// <summary>
    /// Lógica de interacción para AddArbolWindow.xaml
    /// </summary>
    public partial class AddArbolWindow : Window
    {
        public Arbol arbol;
        public AddArbolWindow()
        {
            InitializeComponent();
            arbol = new Arbol();
            DataContext = arbol;
        }
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(arbol.Nombre))
            {
                MessageBox.Show("El nombre no puede estar en blanco.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (arbol.Altura <= 0)
            {
                MessageBox.Show("Altura debe ser mayor que 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (arbol.Cantidad <= 0)
            {
                MessageBox.Show("Cantidad debe ser mayor que 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (arbol.Precio <= 0)
            {
                MessageBox.Show("Precio debe ser mayor que 1.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            clsGlobal.globalDatabase.Establecimientos.Where(estab => estab.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Arboles.Add(arbol);
            this.Close();
        }

    }
}
