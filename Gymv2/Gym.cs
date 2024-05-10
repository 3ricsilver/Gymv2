using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbonnementClient;
using ClientGestion;

namespace GymClient
{
    public class Gym
    {
        public List<Client> _gymClients;

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

        public void SupprimerClient(Client client)
        {
            _gymClients.Remove(client);
        }

        public void ModifierClient(Client client)
        {
            Client clientAModifier = _gymClients.Find(c => c.Nom == client.Nom && c.Prenom == client.Prenom);
            clientAModifier = client;
        }
    }
}
