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
        private decimal _prix;

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

        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
    }
}
