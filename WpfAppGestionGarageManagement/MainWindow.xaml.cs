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
using WpfAppGestionGarageManagement.ServiceReference1;

namespace WpfAppGestionGarageManagement
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static List<Voiture> ListVoitures()
        {
            Service1Client cli = new Service1Client();
            var res = cli.ListVoitures();
            cli.Close();
            return res.ToList();
        }
        private void DisV_Click(object sender, RoutedEventArgs e)
        {
            var _voitures = ListVoitures();
            LBGarage.ItemsSource = _voitures;
        }
    }
}
