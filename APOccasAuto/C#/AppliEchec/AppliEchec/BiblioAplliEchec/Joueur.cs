using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiblioAplliEchec
{
    public class Joueur
    {
        private int numJoueur;
        private string nomJoueur;
        private DateTime dateLicence;
        private Niveau niveauJoueur;
        private Club clubJoueur;

        public Joueur(int numJoueur, string nomJoueur, DateTime dateLicence, Niveau niveauJoueur, Club clubJoueur)
        {
            this.numJoueur = numJoueur;
            this.nomJoueur = nomJoueur;
            this.dateLicence = dateLicence;
            this.niveauJoueur = niveauJoueur;
            this.clubJoueur = clubJoueur;
        }

        public int NumJoueur { get => numJoueur; set => numJoueur = value; }
        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }
        public DateTime DateLicence { get => dateLicence; set => dateLicence = value; }
        public Niveau NiveauJoueur { get => niveauJoueur; set => niveauJoueur = value; }
        public Club ClubJoueur { get => clubJoueur; set => clubJoueur = value; }
    }
}
