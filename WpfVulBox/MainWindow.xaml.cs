using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfVulBox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtVan.Text = "1";
            txtTot.Text = "10";
            txtSprong.Text = "2";
        }

        private void btnVulListBox_Click(object sender, RoutedEventArgs e)
        {

            int van, tot, sprong;

            try //risicovolle code
            {

                van = int.Parse(txtVan.Text);
                tot = int.Parse(txtTot.Text);
                sprong = int.Parse(txtSprong.Text);
                tbkFeedBack.Visibility = Visibility.Hidden;
                VulSelectorMetGetallen(van, tot, sprong, lstGetallenlijst);

            }
            catch (Exception ex)
            {

                tbkFeedBack.Text = "Geef geldige getallen in.\n" + ex.Message;
                tbkFeedBack.Background = Brushes.Black;
                tbkFeedBack.Visibility = Visibility.Visible;

            }

        }

        void VulSelectorMetGetallen(int start, int einde, int sprong, Selector lijst)
        {

            lijst.Items.Clear();

            if (start < einde)
            {

                for (int i = start; i <= einde; i += Math.Abs(sprong))
                {
                    lijst.Items.Add(i);
                }
            }
            else
            {
                for (int i = start; i >= einde; i -= Math.Abs(sprong))
                {
                    lijst.Items.Add(i);
                }
            }

        }

        private void btnVulComboBox_Click(object sender, RoutedEventArgs e)
        {


            int van, tot, sprong;

            try //risicovolle code
            {

                van = int.Parse(txtVan.Text);
                tot = int.Parse(txtTot.Text);
                sprong = int.Parse(txtSprong.Text);
                tbkFeedBack.Visibility = Visibility.Hidden;
                VulSelectorMetGetallen(van, tot, sprong, cmbGetallenLijst);


            }
            catch (Exception ex)
            {

                tbkFeedBack.Text = "Geef geldige getallen in.\n" + ex.Message;
                tbkFeedBack.Background = Brushes.Black;
                tbkFeedBack.Visibility = Visibility.Visible;

            }
        }
    }
}
