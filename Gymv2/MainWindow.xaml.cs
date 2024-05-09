using Login;
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
        /*        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e) //cause des crashs
                {
                    Utilisateur.MotDePasse = new SecureString();
                    foreach (char c in txtPassword.Password)
                    {
                        Utilisateur.MotDePasse.AppendChar(c);
                    }

                }*/

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Utilisateur.MotDePasse = new SecureString();
            foreach (char c in txtPassword.Password)
            {
                Utilisateur.MotDePasse.AppendChar(c);
            }
  
        }

        private void btnAfficherUtilisateur_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Utilisateur: {Utilisateur.Login}\nMot de passe: {Utilisateur.MotDePasse}");
        }
    }
}