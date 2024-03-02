using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Chrono
    {
        // Représente la valeur du chrono
        private TimeSpan valeur;
        // getter de l'attribut
        public TimeSpan Valeur
        {
            get { return valeur; }
        }

        // Représente la date en heure à laquelle est déclenché le chrono
        private DateTime dateDebut;

        // Représente la date en heure à laquelle est arrêté le chrono
        private DateTime dateFin;

        // Constructeur de la classe
        public Chrono()
        {
        }

        // Méthode permettant de démarrer le chrono
        public void DemarrageChrono()
        {
            dateDebut = DateTime.Now;
        }

        // Méthode permettant d'arrêter le chrono
        public void ArretChrono()
        {
            dateFin = DateTime.Now;
            CalculValeur();
        }

        // Méthode permettant de calculer la valeur du chrono
        public void CalculValeur()
        {
            valeur = dateFin.Subtract(dateDebut);
        }

        // Méthode permettant de remettre à zéro la valeur du chrono
        public void RemiseAZero()
        {
            valeur = TimeSpan.Zero;
        }
    }
}
