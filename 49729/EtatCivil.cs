using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49729
{
    class EtatCivil
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
        }
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
        }
        private string statut_martial;
        public string Statut_martial
        {
            get { return statut_martial; }
        }
        private int nb_enfants;
        public int Nb_enfants
        {
            get { return nb_enfants; }
        }


        public EtatCivil(string nom, string prenom, string statut_martial, int nb_enfants)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.statut_martial = statut_martial;
            this.nb_enfants = nb_enfants;
        }



    }
}
