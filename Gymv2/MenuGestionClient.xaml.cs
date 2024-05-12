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
            //test
            Gym.AjouterClient(new Client { Nom = "erio", Prenom = "tru", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\Downloads\\@julmre_-profile(1).jpeg" });
            Gym.AjouterClient(new Client { Nom = "fugo", Prenom = "ong", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\OneDrive\\Images\\LASM-4144.jpg" });

            Gym.AjouterClient(new Client { Nom = "eric", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\Downloads\\@julmre_-profile(1).jpeg" });
            Gym.AjouterClient(new Client { Nom = "figo", Prenom = "helpme", DateNaissance = DateTime.Now.AddYears(-25), PhotoPath = "C:\\Users\\eric3\\OneDrive\\Images\\LASM-4144.jpg" });


            DataContext = this;
        }

        private void Sup_Click(object sender, RoutedEventArgs e)
        {
            int nombreASupprimer = 0;
            bool isNumeric = false;
            while (!isNumeric)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Entrez le nombre de clients à supprimer :", "Supprimer des clients", "0");
                if (input == "")
                {
                    return;
                }

                isNumeric = int.TryParse(input, out nombreASupprimer);
                if (!isNumeric)
                {
                    MessageBox.Show("Veuillez entrer un nombre valide.");
                }

            }

            // Supprimer les clients
            Gym.SupprimerClient(nombreASupprimer);
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            Ajouter MenuAjouter = new Ajouter();
            MenuAjouter.ShowDialog();
            Gym.AjouterClient(MenuAjouter.ClientAjoute);
            MessageBox.Show(MenuAjouter.ClientAjoute.Nom + " " + MenuAjouter.ClientAjoute.Prenom + " " + MenuAjouter.ClientAjoute.DateNaissance + " " + MenuAjouter.ClientAjoute.PhotoPath);//debug
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            //affiche tous les clients
            foreach (Client client in Gym.Clients)
            {
                MessageBox.Show(client.Nom + " " + client.Prenom + " " + client.DateNaissance + " " + client.PhotoPath);//debug
            }
        }
    }




}
