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
using System.Windows.Shapes;

using ClientGestion;
using GymClient;
using AbonnementClient;

namespace Gymv2
{
    /// <summary>
    /// Logique d'interaction pour MenuGestionClient.xaml
    /// </summary>
    public partial class MenuGestionClient : Window
    {
        private Gym gym;
        public MenuGestionClient()
        {
            InitializeComponent();
            gym = new Gym();

            DataContext = gym;// Définir le DataContext sur l'instance de Gym pour que les contrôles de liaison de données fonctionnent
        }


        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();

            // test
            client.Nom = "John";
            client.Prenom = "Doe";
            client.DateNaissance = new DateTime(1990, 1, 1);
            client.PhotoPath = "chemin/vers/photo.jpg";
            client.Abonnement = new Abonnement();

            gym.AjouterClient(client);
        }


        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            //a faire
        }
    }


}
