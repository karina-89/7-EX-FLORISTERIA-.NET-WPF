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

namespace Floristeria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            clsGlobal.globalDatabase = clsGlobal.LoadFromXMLDatabase();
            UpdateData();
        }

        private void UpdateData()
        {
            if (clsGlobal.currentEstablecimiento == null)
            {
                this.txtNombreTienda.Text = string.Empty;
                this.stackInfo.Visibility = Visibility.Hidden;
                return;
            }

            this.txtNombreTienda.Text = clsGlobal.currentEstablecimiento.Nombre;

            List<Arbol> arboles = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Arboles;
            List<Flor> flores = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Flores;
            List<Decoracion> decoraciones = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Decoraciones;

            this.dgArboles.ItemsSource = null;
            this.dgFlores.ItemsSource = null;
            this.dgDecoraciones.ItemsSource = null;
            this.dgArboles.ItemsSource = arboles;
            this.dgFlores.ItemsSource = flores;
            this.dgDecoraciones.ItemsSource = decoraciones;
            this.stackInfo.Visibility = Visibility.Visible;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            clsGlobal.SaveToXMLDatabase(clsGlobal.globalDatabase);
        }

        private void mnuNuevaTienda_Click(object sender, RoutedEventArgs e)
        {
            NuevaTiendaWindow nuevaTienda = new NuevaTiendaWindow();
            nuevaTienda.Owner = this;
            nuevaTienda.ShowDialog();
            UpdateData();
        }

        private void mnuAbrirTienda_Click(object sender, RoutedEventArgs e)
        {
            SelectTiendaWindow selectTiendaWindow = new SelectTiendaWindow();
            selectTiendaWindow.Owner = this;
            selectTiendaWindow.ShowDialog();
            UpdateData();
        }

        private void mnuAddArbol_Click(object sender, RoutedEventArgs e)
        {
            if (clsGlobal.currentEstablecimiento == null)
            {
                MessageBox.Show("Debes seleccionar una tienda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AddArbolWindow addArbolWindow = new AddArbolWindow();
            addArbolWindow.Owner = this;
            addArbolWindow.ShowDialog();
            UpdateData();
        }

        private void mnuAddFlor_Click(object sender, RoutedEventArgs e)
        {
            if (clsGlobal.currentEstablecimiento == null)
            {
                MessageBox.Show("Debes seleccionar una tienda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AddFlorWindow addFlorWindow = new AddFlorWindow();
            addFlorWindow.Owner = this;
            addFlorWindow.ShowDialog();
            UpdateData();
        }

        private void mnuAddDecoracion_Click(object sender, RoutedEventArgs e)
        {
            if (clsGlobal.currentEstablecimiento == null)
            {
                MessageBox.Show("Debes seleccionar una tienda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AddDecoracionWindow addDecoracionWindow = new AddDecoracionWindow();
            addDecoracionWindow.Owner = this;
            addDecoracionWindow.ShowDialog();
            UpdateData();
        }

        private void mnuStocks_Click(object sender, RoutedEventArgs e)
        {
            if (clsGlobal.currentEstablecimiento == null)
            {
                MessageBox.Show("Debes seleccionar una tienda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            StockWindow stockWindow = new StockWindow();
            stockWindow.Owner = this;
            stockWindow.ShowDialog();
            UpdateData();
        }
    }

}
