using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementClient
{
    public class Abonnement
    {
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private int _prix;

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set { _dateDebut = value; }
        }

        public DateTime DateFin
        {
            get { return _dateFin; }
            set { _dateFin = value; }
        }

        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Abonnement(DateTime dateDebut, DateTime dateFin, int prix)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            Prix = prix;
        }

        //to string
        public override string ToString()
        {
            return $"Date de début: {DateDebut}\nDate de fin: {DateFin}\nPrix: {Prix}";
        }
    }
}
