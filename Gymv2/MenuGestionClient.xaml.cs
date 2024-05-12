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
using System.ComponentModel;

namespace Gymv2
{
    /// <summary>
    /// Logique d'interaction pour MenuGestionClient.xaml
    /// </summary>
    public partial class MenuGestionClient : Window
    {
        public Gym Gym { get; set; } = new Gym();

        public MenuGestionClient()
        {
            InitializeComponent();

            // Ajoutez quelques clients à la liste
            Gym.AjouterClient(new Client { Nom = "Nom1", Prenom = "Prenom1", DateNaissance = DateTime.Now.AddYears(-30) });
            Gym.AjouterClient(new Client { Nom = "Nom2", Prenom = "Prenom2", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "\"C:\\Users\\eric3\\Downloads\\@julmre_-profile(1).jpeg\"" });

            // Définissez le contexte de données du DataContext de la fenêtre sur cette instance de Gym
            DataContext = this;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            Gym.AjouterClient(client);
        }
    }




}
