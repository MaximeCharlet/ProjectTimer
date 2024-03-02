using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Métier;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour VueChrono.xaml
    /// </summary>
    public partial class VueChrono : Window
    {
        // Représente la fenêtre parente
        private MainWindow fenetreParent;

        // Représente un projet
        private Projet p;

        // Constructeur
        public VueChrono(MainWindow fenetrePrincipale, Projet projet)
        {
            InitializeComponent();
            fenetreParent = fenetrePrincipale;
            p = projet;
            // On récupère le nom du projet pour lancer son chrono
            textBoxNom.Text = p.Nom;
        }

        // Évènement lorsque l'on clique sur le bouton démarrer
        private void ClickDémarrer(object sender, RoutedEventArgs e)
        {
            p.MonChrono.DemarrageChrono();
            textBoxEtatChrono.Text = "Chronomètre démarré";
        }

        // Évènement lorsque l'on clique sur le bouton arrêter
        private void ClickArrêter(object sender, RoutedEventArgs e)
        {
            p.MonChrono.ArretChrono();
            textBoxEtatChrono.Text = "Chronomètre arrêté";
            p.ActualisationDuree(p.MonChrono.Valeur);
            p.MonChrono.RemiseAZero();
            fenetreParent.AjoutTemps(p);
        }

        // Évènement lorsque l'on clique sur le bouton quitter
        private void ClickQuitter(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
