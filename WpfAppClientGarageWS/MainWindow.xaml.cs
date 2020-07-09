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
using WpfAppClientGarageWS.ServiceReference1;
using WpfAppClientGarageWS.ViewModel;

namespace WpfAppClientGarageWS
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionVoiture GestionVoiture = new GestionVoiture();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = GestionVoiture;
        }

        private void AjoutVoiture_Click(object sender, RoutedEventArgs e)
        {
            Voiture v = new Voiture();

            v.Marque = txtMarq.Text;
            v.Nom = txtNom.Text;
            v.Matricule = txtMat.Text;
            v.Chassis = int.Parse(txtChassis.Text);

            int i = GestionVoiture.AjoutVoiture(v);

            if (i > 0)
            {
                txtChassis.Text = ""; txtMarq.Text = ""; txtNom.Text = ""; txtMat.Text = "";
            }
        }
    }
}
