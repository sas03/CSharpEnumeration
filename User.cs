using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Color Couleur { get; set; }
        public User(string nom, string prenom, Color couleur)
        {
            Nom = nom;
            Prenom = prenom;
            Couleur = couleur;
        }
    }
}
