using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAplliEchec
{
    public class Niveau
    {
        private string nomNiveau;

        //Constructeur
        public Niveau(string nomNiveau)
        {
            this.nomNiveau = nomNiveau;
        }
        //GETTERS/SETTERS
        public string NomNiveau { get => nomNiveau; set => nomNiveau = value; }

        // Affiche tous les inscrits à la compétition


        
    }
}
