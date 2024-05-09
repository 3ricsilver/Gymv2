using Login;
using System.IO;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gymv2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginUtilisateur Utilisateur { get; } = new LoginUtilisateur();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Utilisateur;
        }



        private void btnAfficherUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            //je sais que ce n'est pas sécurisé de faire ca mais je ne sais pas comment faire autrement
            //MessageBox.Show($"Utilisateur: {Utilisateur.Login}\nMot de passe: {Utilisateur.MotDePasse}");
            MessageBox.Show($"Utilisateur: {Utilisateur.Login}\nMot de passe: {txtPassWord.Password.ToString()}");
        }

        /*        private void btnLogin_Click(object sender, EventArgs e)
                {
                    string username = Utilisateur.Login;
                    //string password = Utilisateur.MotDePasse.ToString();
                    string password = txtPassWord.Password.ToString();

                    if (username == "cisco" && password == "cisco")//to do rajouter le mot de passe quand ca marchera
                    {
                        MessageBox.Show("Connexion réussie !");
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                    }
                }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Utilisateur.Login;
            string password = txtPassWord.Password.ToString();

            string filePath = "DossierTopSecretPasTouche.txt";

            try
            {
                // Vérifie si le fichier existe
                if (File.Exists(filePath))
                {
                    // Lit toutes les lignes du fichier et le stocke dans un index
                    string[] lines = File.ReadAllLines(filePath);

                    // Parcourt chaque ligne pour trouver les informations d'identification
                    foreach (string line in lines)
                    {
                        // Sépare la ligne en username et password car j'ai mit un espacement entre les deux
                        string[] parts = line.Split(' ');

                        // Vérifie si les informations d'identification correspondent
                        if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                        {
                            MessageBox.Show("Connexion réussie !");
                            return;
                        }
                    }
                }

                // Si les informations d'identification ne correspondent pas
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture du fichier texte : {ex.Message}");
            }
        }



        private void CreateTextFile(object sender, RoutedEventArgs e)
        {
            string username = Utilisateur.Login;
            string password = txtPassWord.Password.ToString();

            string filePath = "DossierTopSecretPasTouche.txt";

            try
            {
                bool fileExists = File.Exists(filePath);

                // Utilise le StreamWriter en mode append si le fichier existe, sinon le crée
                using (StreamWriter writer = new StreamWriter(filePath, fileExists))
                {
                    if (fileExists)
                    {
                        // Si le fichier existe, place le curseur à la fin du fichier
                        writer.BaseStream.Seek(0, SeekOrigin.End);
                    }
                    else
                    {
                        // On le crée
                        writer.WriteLine("Format");
                        writer.WriteLine("Username: Password:");
                    }

                    //si username et password ne sont pas vide
                    if(username != "" && password != "")
                    {
                        // Écrit les données de l'utilisateur
                        writer.WriteLine($"{username} {password}");
                    }
                    writer.Close();
                }

                MessageBox.Show("Données ajoutées au fichier texte avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'écriture dans le fichier texte : {ex.Message}");
            }

        }




        private void Test(object sender, RoutedEventArgs e)
        {

            
           MessageBox.Show($"Kecin: {txtPassWord.Password.ToString()}\n ");

        }



    }
}