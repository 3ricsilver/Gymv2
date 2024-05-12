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
using AbonnementClient;
using ClientGestion;
using GymClient;
using Microsoft.Win32;

namespace Gymv2
{
    /// <summary>
    /// Logique d'interaction pour Ajouter.xaml
    /// </summary>
    public partial class Ajouter : Window
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string photoPath;
        private DateTime dateDebut;
        private DateTime dateFin;
        private int prix;

        public Client ClientAjoute { get; private set; }

        public Ajouter()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            nom = NomTextBox.Text;
            prenom = PrenomTextBox.Text;
            dateNaissance = DateNaissanceDatePicker.SelectedDate ?? DateTime.MinValue;
            photoPath = PhotoPathTextBox.Text;
            dateDebut = DateDebutDatePicker.SelectedDate ?? DateTime.MinValue;
            dateFin = DateFinDatePicker.SelectedDate ?? DateTime.MinValue;
            prix = int.Parse(PrixTextBox.Text);



            Client client = new Client(nom, prenom, dateNaissance, photoPath, new Abonnement(dateDebut, dateFin, prix));

            ClientAjoute = client;
            MessageBox.Show(ClientAjoute.ToString());

            // Close the window
            this.Close();
        }

        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                // pour que ca affiche bien dans le format image qu'o
                PhotoPathTextBox.Text = "\"" + openFileDialog.FileName.Replace("\\", "\\\\") + "\"";

            }
        }
    }
}
