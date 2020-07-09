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
using WpfAppMeteoClient.Helper;
using WpfAppMeteoClient.Model;
using WpfAppMeteoClient.ServiceReference1;
using WpfAppMeteoClient.VieModel;

namespace WpfAppMeteoClient
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Meteo meteos = new Meteo();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = meteos;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mesure mesure = (Mesure)cbbMesure.SelectedItem;
            //MessageBox.Show("Vous avez selectioné : " + mesure.Id);

            ResultatMeteo resultatMeteo = AccesWS.GetInfoMeteo(mesure.Id);
            textDataVal.Text = resultatMeteo.Datereleve;
            textValRes.Text = resultatMeteo.ValeurReleve;
            textDescVal.Text = resultatMeteo.DescriptifReleve;

            //Service1Client client = new Service1Client();
            //client.Get_Value(mesure.Id, out resultatMeteo.Datereleve, out resultatMeteo.DescriptifReleve);
        }

    }
}
