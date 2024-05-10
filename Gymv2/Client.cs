using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbonnementClient;

namespace ClientGestion
{
    public class Client 
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string photoPath;
        private Abonnement abonnement;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string PhotoPath
        {
            get { return photoPath; }
            set { photoPath = value; }
        }

        public Abonnement Abonnement
        {
            get { return abonnement; }
            set { abonnement = value; }
        }
    }
}
