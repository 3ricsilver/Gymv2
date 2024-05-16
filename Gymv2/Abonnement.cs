using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementClient
{
    public class Abonnement : INotifyPropertyChanged
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private int _prix;

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set
            {
                if (_dateDebut != value)
                {
                    _dateDebut = value;
                    OnPropertyChanged(nameof(DateDebut));
                }
            }
        }

        public DateTime DateFin
        {
            get { return _dateFin; }
            set
            {
                if (_dateFin != value)
                {
                    _dateFin = value;
                    OnPropertyChanged(nameof(DateFin));
                }
            }
        }

        public int Prix
        {
            get { return _prix; }
            set
            {
                if (_prix != value)
                {
                    _prix = value;
                    OnPropertyChanged(nameof(Prix));
                }
            }
        }

        public Abonnement(DateTime dateDebut, DateTime dateFin, int prix)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            Prix = prix;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public override string ToString()
        {
            return $"Date de début: {DateDebut}\nDate de fin: {DateFin}\nPrix: {Prix}";
        }
    }
}
