using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbonnementClient;

namespace ClientGestion
{
    public class Client : INotifyPropertyChanged
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string photoPath;
        private Abonnement abonnement;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)//pour etre biensur que ca update
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                OnPropertyChanged(nameof(Prenom));
            }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set
            {
                dateNaissance = value;
                OnPropertyChanged(nameof(DateNaissance));
            }
        }

        public string PhotoPath
        {
            get { return photoPath; }
            set
            {
                photoPath = value;
                OnPropertyChanged(nameof(PhotoPath));
            }
        }

        public Abonnement Abonnement
        {
            get { return abonnement; }
            set
            {
                abonnement = value;
                OnPropertyChanged(nameof(Abonnement));
            }
        }
        //constructeur
        public Client(string nom, string prenom, DateTime dateNaissance, string photoPath, Abonnement abonnement)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            PhotoPath = photoPath;
            Abonnement = abonnement;
        }
        public Client()
        {
            Nom = "";
            Prenom = "";
            DateNaissance = DateTime.MinValue;
            PhotoPath = "";
            Abonnement = new Abonnement(DateTime.MinValue, DateTime.MinValue, 0);
        }
        //tostring
        public override string ToString()
        {
            return $"Nom: {Nom}\nPrenom: {Prenom}\nDate de naissance: {DateNaissance}\nPhotoPath: {PhotoPath}\nAbonnement: {Abonnement}";
        }
    }
}
