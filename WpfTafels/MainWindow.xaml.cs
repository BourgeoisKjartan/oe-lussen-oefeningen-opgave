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

namespace WpfTafels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //vul cmbKiesTafel met de getallen van 1 - 10
            for (int i = 1; i <= 10; i++)
            {
                cmbKiesTafel.Items.Add(i);
            }
        }

        private void btnTafel5_Click(object sender, RoutedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de tafel van 5

            ToonTafel(5);

        }

        void ToonTafel(int tafel, bool maakLeeg = true)
        {
            int vermenigvuldiger = 1;
            if (maakLeeg) lstTafels.Items.Clear();

            while (vermenigvuldiger <= 10)
            {
                string vermenigvuldiging;
                int product;
                product = vermenigvuldiger * tafel;
                vermenigvuldiging = $"{vermenigvuldiger} X {tafel} = {product}";
                lstTafels.Items.Add(vermenigvuldiging);
                vermenigvuldiger++;
            }
        }


        private void cmbKiesTafel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de gekozen tafel
            int tafel = (int)cmbKiesTafel.SelectedItem;
            ToonTafel(tafel);
        }

        private void btnAlleTafels_Click(object sender, RoutedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de tafels van 1 ==> 10
            //Onder elke tafel komt een lijn
            lstTafels.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                ToonTafel(i, false);
                if (i < 10)
                {
                    lstTafels.Items.Add("--------------------");
                }

            }

        }
    }
}
