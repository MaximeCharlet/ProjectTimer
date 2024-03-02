using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    [DataContract]
    public class Projet
    {
        [DataMember]
        // Représente le nom du projet
        private string nom;
        // Property nom
        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
            }
        }

        [DataMember]
        // Représente une description courte du projet
        private string description;
        // Property description
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }

        [DataMember]
        // Représente la date de début du projet
        private DateTime debutProjet;
        // getter de l'attribut
        public DateTime DebutProjet
        {
            get { return debutProjet; }
        }

        [DataMember]
        // Représente la date de fin du projet
        private DateTime finProjet;
        // getter de l'attribut
        public DateTime FinProjet
        {
            get { return finProjet; }
        }

        [DataMember]
        // Représente la durée du projet
        private TimeSpan duree;
        // Property duree
        public TimeSpan Duree
        {
            get { return duree; }
            set
            {
                duree = value;
            }
        }

        [DataMember]
        // Représente l'état du projet
        private string etat;
        // Property etat
        public string Etat
        {
            get { return etat; }
            set
            {
                etat = value;
            }
        }

        // Représente le chrono de ce projet
        private Chrono monChrono;
        // Getter de l'attribut
        public Chrono MonChrono
        {
            get { return monChrono; }
        }

        // Constructeur de la classe
        public Projet(string n, string desc)
        {
            nom = n;
            description = desc;
            debutProjet = DateTime.Today;
            duree = TimeSpan.Zero;
            etat = "en cours";
            monChrono = new Chrono();
        }

        // Constructeur vide
        public Projet()
        {
            duree = TimeSpan.Zero;
            monChrono = new Chrono();
        }

        // Méthode permettant d'actualiser la duree du projet grâce à la valeur du chrono
        public void ActualisationDuree(TimeSpan time)
        {
            // la méthode add créé un nouveau TimeSpan
            duree = duree.Add(time);
        }

        // Méthode permettant de finir un projet
        public void FinirProjet()
        {
            finProjet = DateTime.Today;
        }
    }
}
