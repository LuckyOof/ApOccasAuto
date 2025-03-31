using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAplliEchec
{
    public class Club
    {
        private int numClub;
        private string nomClub;
        private string villeClub;
        private List<Joueur> lesJoueurs;

        public Club(int numClub, string nomClub, string villeClub, List<Joueur> lesJoueurs)
        {
            this.numClub = numClub;
            this.nomClub = nomClub;
            this.villeClub = villeClub;
            List<Joueur> joueurs = new List<Joueur>();
        }

        public int NumClub { get => numClub; set => numClub = value; }
        public string NomClub { get => nomClub; set => nomClub = value; }
        public string VilleClub { get => villeClub; set => villeClub = value; }
        public List<Joueur> joueurs { get => lesJoueurs; set => joueurs = value; }
    }

}

