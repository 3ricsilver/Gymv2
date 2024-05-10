using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe de base pour les données contenant une référence à une image en gros l'héritage que le prof demande et histoire d'avoir 3 classes
namespace ImageBase
{
    internal class Image
    {
        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
    }
}
