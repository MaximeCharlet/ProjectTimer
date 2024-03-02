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
    /// Logique d'interaction pour VueSupprimer.xaml
    /// </summary>
    public partial class VueSupprimer : Window
    {
        // Représente la fenêtre parente
        private MainWindow fenetreParent;

        // Représente un projet
        private Projet p;

        // Constructeur
        public VueSupprimer(MainWindow fenetrePrincipale, Projet projet)
        {
            InitializeComponent();
            fenetreParent = fenetrePrincipale;
            p = projet;
            // On récupère le nom du projet à supprimer
            textBoxNom.Text = p.Nom;
        }

        // Évènement lorsque l'on clique sur valider
        private void ClickValider(object sender, RoutedEventArgs e)
        {
            fenetreParent.SupprimerProjet(p);
            Close();
        }

        // Évènement lorsque l'on clique sur annuler
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
