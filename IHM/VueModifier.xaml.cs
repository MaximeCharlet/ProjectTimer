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
    /// Logique d'interaction pour VueModifier.xaml
    /// </summary>
    public partial class VueModifier : Window
    {
        // Représente la fenêtre parente
        private MainWindow fenetreParent;

        // Représente un projet
        private Projet p;

        // Constructeur
        public VueModifier(MainWindow fenetrePrincipale, Projet projet)
        {
            InitializeComponent();
            fenetreParent = fenetrePrincipale;
            p = projet;
            // On récupère le nom du projet à modifier, la description et l'état
            textBoxNom.Text = p.Nom;
            textBoxDescription.Text = p.Description;
            if (p.Etat == "terminé")
            {
                comboBoxEtat.SelectedIndex = comboBoxEtat.SelectedIndex + 1;
            }
        }

        // Évènement lorsque l'on clique sur le bouton valider
        private void ClickValider(object sender, RoutedEventArgs e)
        {
            p.Description = textBoxDescription.Text;
            p.Etat = comboBoxEtat.SelectionBoxItem.ToString();
            fenetreParent.Modification(p);
            Close();
        }

        // Évènement lorsque l'on clique sur le bouton annuler
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
