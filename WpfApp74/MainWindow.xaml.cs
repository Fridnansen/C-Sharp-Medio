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

namespace WpfApp74
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Console.WriteLine("Le has dado al Boton");

            MessageBox.Show("Le has dado al boton 2");


        }

       /* private void Panel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le has dado al Panel");
        }*/

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            MessageBox.Show("Le has dado al Panel");

        }
    }
}
