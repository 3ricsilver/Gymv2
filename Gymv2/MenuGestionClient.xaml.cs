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
using System.Windows.Media.Animation;

namespace Gymv2
{
    /// <summary>
    /// Logique d'interaction pour MenuGestionClient.xaml
    /// </summary>
    public partial class MenuGestionClient : Window
    {
        public Gym Gym { get; set; } = new Gym();
        public Client ClientAjoute { get; private set; }

        public MenuGestionClient()
        {
            InitializeComponent();
            Gym.AjouterClient(new Client { Nom = "erio", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\Downloads\\@julmre_-profile(1).jpeg" });
            Gym.AjouterClient(new Client { Nom = "fugo", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\OneDrive\\Images\\LASM-4144.jpg" });

            Gym.AjouterClient(new Client { Nom = "eric", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\Downloads\\@julmre_-profile(1).jpeg" });
            Gym.AjouterClient(new Client { Nom = "figo", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\OneDrive\\Images\\LASM-4144.jpg" });


            // Définissez le contexte de données du DataContext de la fenêtre sur cette instance de Gym
            DataContext = this;
        }

        private void Sup_Click(object sender, RoutedEventArgs e)
        {
            // Créer une boîte de dialogue pour demander le nombre à supprimer
            int nombreASupprimer = 0;
            bool isNumeric = false;
            while (!isNumeric)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Entrez le nombre de clients à supprimer :", "Supprimer des clients", "0");
                if (input == "")
                {
                    return; // Sortir de la méthode si l'utilisateur a appuyé sur Annuler
                }

                isNumeric = int.TryParse(input, out nombreASupprimer);
                if (!isNumeric)
                {
                    MessageBox.Show("Veuillez entrer un nombre valide.");
                }
                // Vérifier si l'utilisateur a appuyé sur Annuler

            }

            // Supprimer les clients
            Gym.SupprimerClient(nombreASupprimer);
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Ajouter MenuAjouter = new Ajouter();
            MenuAjouter.ShowDialog(); // Utilisation de ShowDialog pour attendre que la fenêtre Ajouter se ferme
                                      // Récupérer le client ajouté depuis l'interface Ajouter
            Gym.AjouterClient(MenuAjouter.ClientAjoute);
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            //affiche tous les clients
            foreach (Client client in Gym.Clients)
            {
                MessageBox.Show(client.Nom + " " + client.Prenom + " " + client.DateNaissance + " " + client.PhotoPath);
            }
        }
    }




}
