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
    /// Logique d'interaction pour VueAjouter.xaml
    /// </summary>
    public partial class VueAjouter : Window
    {
        // Représente la fenêtre parente
        private MainWindow fenetreParent;

        // Constructeur prend en paramètre la fenêtre principale de l'application
        public VueAjouter(MainWindow fenetrePrincipale)
        {
            InitializeComponent();
            fenetreParent = fenetrePrincipale;   
        }

        // Événement lorsque l'on clique sur le bouton valider
        private void ClickValider(object sender, RoutedEventArgs e)
        {
            Projet p = new Projet(textBoxNom.Text, textBoxDescription.Text);
            fenetreParent.AjouterProjet(p);
            Close();
        }

        // Événement lorsque l'on clique sur le bouton annuler
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
