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

namespace visor_de_fuentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fuenteComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fuenteComboBox.SelectedItem != null)
            {
                string fuente = (string)(fuenteComboBox.SelectedItem as ComboBoxItem).Content;
                leyendaTexblock.FontFamily = new FontFamily(familyName: fuente);
            }
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            leyendaTexblock.FontStyle = FontStyles.Italic;
        }
        private void negritasCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            leyendaTexblock.FontWeight = FontWeights.Bold;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendaTexblock.FontStyle = FontStyles.Normal;
        }

        private void negritasCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            leyendaTexblock.FontWeight = FontWeights.Normal;
        }

        private void smallRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (smallRadioButton.IsChecked == true)
            {
                leyendaTexblock.FontSize = 12;
            }
            else if (mediumRadioButton.IsChecked == true)
            {
                leyendaTexblock.FontSize = 18;
            }
            else
            {
                leyendaTexblock.FontSize = 24;
            }
        }
    }
}
