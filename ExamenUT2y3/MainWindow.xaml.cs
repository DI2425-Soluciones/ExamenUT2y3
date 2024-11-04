using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenUT2y3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int vecesAceptar;
        private int vecesCancelar;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        // Manejador para contar las veces que se pulsa ACEPTAR o CANCELAR.
        private void ContadorButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
 
            if (b.Content.Equals("Aceptar"))
            {   // También se puede hacer con "Tag".
                vecesAceptar++;
                MessageBox.Show("El botón ACEPTAR se ha pulsado " + (vecesAceptar == 1 ? "una vez" : $"{vecesAceptar} veces"));
            }
            else
            {
                vecesCancelar++;
                MessageBox.Show("El botón CANCELAR se ha pulsado " + (vecesCancelar == 1 ? "una vez" : $"{vecesCancelar} veces"));
            }
        }

        private void ActualizarButton_Click(object sender, RoutedEventArgs e)
        {
            actualizaTextBlock.Text = textoTextBox.Text;
            textoTextBox.Text = "Escribe aquí...";
            actualizarButton.IsEnabled = false;
        }

        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Para evitar excepción en tiempo de diseño.
            if (actualizarButton != null)
                actualizarButton.IsEnabled = true;
        }
    }
}