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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nuevoWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Grid miGrid;
        TextBox miTextBox;
        Button miBoton;
        public MainWindow()
        {
            InitializeComponent();

            miGrid = new Grid();
            miTextBox = new TextBox();
            miBoton = new Button();

            miTextBox.Width = 200;
            miTextBox.Height = 50;
            miBoton.Width = 100;
            miBoton.Height = 50;
            miBoton.Margin = new Thickness(0, 120, 0, 0);
            miBoton.Click += button_Click;


            miGrid.Children.Add(miTextBox);
            miGrid.Children.Add(miBoton);

            this.AddChild(miGrid);

            this.ResizeMode = ResizeMode.NoResize;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string cajaDeTexto = miTextBox.Text;
            this.Title = cajaDeTexto;
        }
    }
}
