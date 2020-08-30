using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica de interacción para StockWindow.xaml
    /// </summary>
    public partial class StockWindow : Window
    {
        public class Stock
        {
            public string Tipo { get; set; }
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Importe { get; set; }
        }

        public List<Stock> stocks;
        public StockWindow()
        {
            InitializeComponent();
            stocks = new List<Stock>();

            this.txtNombreTienda.Text = $"Stock tienda: {clsGlobal.currentEstablecimiento.Nombre}";

            List<Arbol> arboles = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Arboles;
            List<Flor> flores = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Flores;
            List<Decoracion> decoraciones = clsGlobal.globalDatabase.Establecimientos.Where(e => e.ID == clsGlobal.currentEstablecimiento.ID).FirstOrDefault().Decoraciones;

            double impTotal = 0.0;
            int cdadTotal = 0;
            foreach (var item in arboles)
            {
                Stock stock = new Stock();
                stock.Tipo = "Arbol";
                stock.Nombre = $"{item.Nombre} ({item.Altura})";
                stock.Cantidad = item.Cantidad;
                stock.Precio = item.Precio;
                stock.Importe = item.Cantidad * item.Precio;
                impTotal += stock.Importe;
                cdadTotal += stock.Cantidad;

                stocks.Add(stock);
            }

            foreach (var item in flores)
            {
                Stock stock = new Stock();
                stock.Tipo = "Flor";
                stock.Nombre = $"{item.Nombre} ({item.Color})";
                stock.Cantidad = item.Cantidad;
                stock.Precio = item.Precio;
                stock.Importe = item.Cantidad * item.Precio;
                impTotal += stock.Importe;
                cdadTotal += stock.Cantidad;

                stocks.Add(stock);
            }

            foreach (var item in decoraciones)
            {
                Stock stock = new Stock();
                stock.Tipo = "Decoración";
                stock.Nombre = $"{item.Nombre} ({item.Material})";
                stock.Cantidad = item.Cantidad;
                stock.Precio = item.Precio;
                stock.Importe = item.Cantidad * item.Precio;
                impTotal += stock.Importe;
                cdadTotal += stock.Cantidad;

                stocks.Add(stock);
            }
            stocks.Add(new Stock { Tipo = "Total", Nombre = "Total", Importe = impTotal, Cantidad = cdadTotal });
            
            ListCollectionView lista = new ListCollectionView(stocks);
            lista.GroupDescriptions.Add(new PropertyGroupDescription("Tipo"));

            this.dgStocks.ItemsSource = null;
            this.dgStocks.ItemsSource = lista;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
