using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Floristeria
{
    /// <summary>
    /// Lógica de interacción para SelectTiendaWindow.xaml
    /// </summary>
    public partial class SelectTiendaWindow : Window
    {
        public class ListaTiendas
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public SelectTiendaWindow()
        {
            InitializeComponent();
            List<ListaTiendas> listaTiendas = clsGlobal.globalDatabase.Establecimientos.Select(s => new ListaTiendas { ID = s.ID, Name = s.Nombre }).ToList<ListaTiendas>();
            listBox1.ItemsSource = listaTiendas;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar una tienda.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            clsGlobal.currentEstablecimiento = clsGlobal.globalDatabase.Establecimientos.Where(c => c.ID == (listBox1.SelectedItem as ListaTiendas).ID).FirstOrDefault();
            this.Close();
        }

    }
}
