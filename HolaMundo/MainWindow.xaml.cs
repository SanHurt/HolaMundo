using System;
using System.Windows;
using System.Windows.Media;

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string TEXTO_POR_DEFECTO = "¡Hola mundo!";
        const string CADENA_VACIA = "";
        string textBlockHolaPorDefecto =  null;
        public MainWindow()
        {
            InitializeComponent();
            textBlockHolaPorDefecto = TEXTO_POR_DEFECTO;
        }

        private void eventoBotonSaludar(object sender, RoutedEventArgs e)
        {
            String nombre = textBoxNombre.Text;
            textBlockHola.Text = "¡Hola " + nombre + "!";
            textBlockHola.Foreground = Brushes.BlueViolet;
        }
        public void eventoBotonLimpiar(object sender, RoutedEventArgs e)
        {
            if (textBlockHola.Text != textBlockHolaPorDefecto || (textBoxNombre.Text != CADENA_VACIA))
            {
                textBlockHola.Text = textBlockHolaPorDefecto;
                textBoxNombre.Text = " ";
                textBlockHola.Foreground = Brushes.Red;
            }
        }
    }
}
