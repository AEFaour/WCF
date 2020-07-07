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

namespace WpfAppWebServiceMeteo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            ChargerInfoMeteo();
        }

        private void ChargerInfoMeteo()
        {
            // pour récupérer une info à partir du app.config, on utilise la configuarationMangager
            string _nomfic = ConfigurationManager.AppSettings["fic"];
            StreamReader stream = new StreamReader(_nomfic, Encoding.Default);
            string contenu = stream.ReadToEnd();
            string[] lignes = contenu.Split('\n');
            //foreach (var ligne in lignes)
            //{
            //    string[] _cellules = ligne.Split('=');
            //    cbbMeteo.Items.Add(_cellules[0]);


            //}
            for (int i = 0; i < lignes.Length; i++)
            {
                string[] _cellules = lignes[i].Split('=');
                cbbMeteo.Items.Add(_cellules[0]);
            }

        }

        private void ChoixMeteo_Select(object sender, SelectionChangedEventArgs e)
        {
            int ChoixSelect = cbbMeteo.SelectedIndex + 1;
            Service1Client service1Client = new Service1Client();
            string _dateVal;
            string _descVal;
            string _res = service1Client.Get_Value(ChoixSelect, out _dateVal, out _descVal);

            textDataVal.Text = _dateVal;
            textDescVal.Text = _descVal;
            textValRes.Text = _res;
        }
    }
}
