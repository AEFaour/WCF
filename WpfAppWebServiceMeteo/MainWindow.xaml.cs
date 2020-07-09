using System;
using System.Collections.Generic;
using System.IO;
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
using System.Configuration;
using WpfAppWebServiceMeteo.Model;
using WpfAppWebServiceMeteo.ServiceReference1;
using WpfAppWebServiceMeteo.ViewModel;

namespace WpfAppWebServiceMeteo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionMeteo gestionMeteo = new GestionMeteo();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = gestionMeteo;


        }

    }
}
