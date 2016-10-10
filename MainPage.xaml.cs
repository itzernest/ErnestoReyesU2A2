using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculadora_Propinas
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float iva = 0;
            int p = 100;
            float iva2 = 0;
            float r = 0;
            float r1 = 0;
            
            iva = float.Parse(Cuenta.Text) * Convert.ToSingle(Propina.SelectionBoxItem);
            iva2 = iva / p;
            r = iva2 + float.Parse(Cuenta.Text);
            r1 = r / Convert.ToSingle(Comensales.SelectionBoxItem);
            Resultado.Text = r1.ToString();
              
        }

      }
}
