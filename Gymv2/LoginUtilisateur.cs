using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class LoginUtilisateur : INotifyPropertyChanged
    {
        private string _utilisateur;
        private SecureString _motDePasse;

        public string Login
        {
            get { return _utilisateur; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Le login ne peut pas être vide");
                }
                else
                {
                    _utilisateur = value;
                    OnPropertyChanged(nameof(Login));
                }
            }
        }
        public SecureString MotDePasse
        {
            get { return _motDePasse; }
            set
            {
                if (_motDePasse != value)
                {
                    throw new Exception("Le mot de passe ne peut pas être vide");
                }
                else
                {
                    _motDePasse = value;
                }
            }
        }
        public LoginUtilisateur()
        {
            _utilisateur = string.Empty;
            _motDePasse = new SecureString();
        }
        public LoginUtilisateur(string utilisateur, SecureString motDePasse)
        {
            _utilisateur = utilisateur;
            _motDePasse = motDePasse;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
