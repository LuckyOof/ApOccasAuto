using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioOccas
{
    public class Concessionnaire
    {
        private string adresse;
        private int codepostal;
        private int identifiant;
        private string nomCon;
        private string prenomCon;
        private string ville;

        public Concessionnaire(string adresse, int cp, int id, string nom, string prenom, string ville)
        {
            this.adresse = adresse;
            this.codepostal = cp;
            this.identifiant = id;
            this.nomCon = nom;
            this.prenomCon = prenom;
            this.ville = ville;
        }

        public string Adresse { get => adresse; set => adresse = value; }
        public int Cp { get => codepostal; set => codepostal = value; }
        public int Id { get => identifiant; set => identifiant = value; }
        public string Nom { get => nomCon; set => nomCon = value; }
        public string Prenom { get => prenomCon; set => prenomCon = value; }
        public string Ville { get => ville; set => ville = value; }
    }
}
