using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAplliEchec
{
    public class Competition
    {
        private string nomCompet;
        private DateTime dateCompet;
        private Niveau niveauCompet;
        private Club clubOrganisateur;
        private Joueur joueur;
        private List<Joueur> lesInscrits;

        

        // Constructeur
        public Competition(string nom, DateTime dateC, Niveau niv, Club org, List<Joueur> lesInscrits)
        {
            this.nomCompet = nom;
            this.dateCompet = dateC;
            this.niveauCompet = niv;
            this.clubOrganisateur = org;
            List<Joueur> inscrits = new List<Joueur>();
        }
        // GETTERS/SETTERS
        public string NomCompet { get => nomCompet; set => nomCompet = value; }
        public DateTime DateCompet { get => dateCompet; set => dateCompet = value; }
        public Niveau NiveauCompet { get => niveauCompet; set => niveauCompet = value; }
        public Club ClubOrganisateur { get => clubOrganisateur; set => clubOrganisateur = value; }
        public List<Joueur> inscrits { get => inscrits; set => inscrits = value; }

        public string AfficherParticipants()
        {
            string result = "Nb participants : \n";
            foreach (Joueur inscrits in lesInscrits)
            {
                result += nomCompet + "Le" + dateCompet.Day +"\n";
                result += inscrits.NomJoueur + " \n";
            }
            return result;
        }

        public bool ExisteJoueur(Joueur unJoueur)
        {
            if (inscrits.Contains(unJoueur))
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }

        public bool AjouterJoueur(Joueur unJoueur)
        {
            inscrits.Add(unJoueur);
            return ExisteJoueur(unJoueur);
        }

        public int CompterParticipants()
        { 
            return inscrits.Count(); 
        }

        public int compterJoueurs(Club unClub)
        {
            return clubOrganisateur.joueurs.Count();
        }

        public int CompterJoueurs(string nom)
        {
            int i = 0;
            foreach (Joueur joueur in inscrits)
            {
                if (clubOrganisateur.NomClub.Contains(nom))
                { 
                    i++; 
                }
            }
            return i;
        }
        public int CompterJoueurs(int uneAnnee)
        {
            int i = 0;
            foreach(Joueur joueur in inscrits)
            {
               if (joueur.DateLicence.Year == uneAnnee)
                {
                    i++;
                }
            }
            return i;
        }
    }
}

