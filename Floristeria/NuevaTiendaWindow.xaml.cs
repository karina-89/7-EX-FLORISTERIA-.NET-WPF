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

namespace Floristeria
{
    /// <summary>
    /// Lógica de interacción para NuevaTienda.xaml
    /// </summary>
    public partial class NuevaTiendaWindow : Window
    {
        public NuevaTiendaWindow()
        {
            InitializeComponent();
        }

        private void btnCrearTienda_Click(object sender, RoutedEventArgs e)
        {
            Establecimiento establecimiento = new Establecimiento();
            establecimiento.Nombre = nombreTienda.Text;
            clsGlobal.globalDatabase.Establecimientos.Add(establecimiento);
            clsGlobal.currentEstablecimiento = establecimiento;

            this.Close();
        }
    }
}
