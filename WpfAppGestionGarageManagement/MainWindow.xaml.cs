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
using WpfAppGestionGarageManagement.ViewModel;

namespace WpfAppGestionGarageManagement
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionVoiture gestionVoiture = new GestionVoiture();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = gestionVoiture;
        }


        private void AjoutVoiture_Click(object sender, RoutedEventArgs e)
        {
            Voiture v = new Voiture();
            v.Nom = txtNom.Text;
            v.Marque = txtMarque.Text;
            v.Matricule = txtMatricule.Text;
            v.NumeroChassis = int.Parse(txtNumeroChassis.Text);

            int i = GestionVoiture.ajoutVoiture(v);
            if (i > 0)
            {
                txtNumeroChassis.Text = ""; txtMarque.Text = ""; txtNom.Text = ""; txtMatricule.Text = "";
            }

        }
    }
}
