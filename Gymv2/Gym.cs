using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbonnementClient;
using ClientGestion;
using System.ComponentModel;


namespace GymClient
{
    public class Gym
    {
        private List<Client> _gymClients;

        public List<Client> Clients
        {
            get { return _gymClients; }
            set { _gymClients = value; }
        }

        public Gym()
        {
            _gymClients = new List<Client>();
        }

        public Gym(List<Client> clients)
        {
            Clients = clients;
        }

        public void AjouterClient(Client client)
        {
            _gymClients.Add(client);
        }

        public void SupprimerClient(int index)
        {
            if (index >= 0 && index < _gymClients.Count)
            {
                _gymClients.RemoveAt(index);
            }
        }
    }
}
