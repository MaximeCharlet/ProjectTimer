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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Métier;
using System.Runtime.Serialization;
using System.IO;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    [DataContract]
    public partial class MainWindow : Window
    {

        // Attribut permettant de stocker tous les projets
        [DataMember]
        private List<Projet> listeProjet;

        // Constructeur de la mainwindow
        public MainWindow()
        {
            InitializeComponent();
            listeProjet = new List<Projet>();
            // Création du dossier où la sauvegarde va se trouver
            // chemin du dossier
            string cheminDossier = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ProjectTimer";
            // Si le dossier n'existe pas
            if (!Directory.Exists(cheminDossier))
            {
                // Alors on le créé
                Directory.CreateDirectory(cheminDossier);
            }
            Charger();
        }

        // Méthode permettant d'ajouter un projet à la liste des projets
        public void AjouterProjet(Projet p)
        {
            listeProjet.Add(p);
            AjoutListBox(p);
        }

        // Méthode permettant l'ajout dans la listBox
        public void AjoutListBox(Projet p)
        {
            listBoxProjets.Items.Add(p.Nom);
        }

        // Méthode permettant de supprimer un projet à la liste des projets
        public void SupprimerProjet(Projet p)
        {
            listeProjet.Remove(p);
            SuppressionListBox(p);
        }

        // Méthode permettant la suppression dans la listBox
        public void SuppressionListBox(Projet p)
        {
            listBoxProjets.Items.Remove(p.Nom);
            ViderAffichage();
        }

        // Méthode permettant de vider l'affichage après une suppression
        public void ViderAffichage()
        {
            textBoxDescription.Text = "";
            textBoxDateDébut.Text = "";
            textBoxDateFin.Text = "";
            textBoxEtat.Text = "";
            textBoxDurée.Text = "";
        }

        // Méthode permettant d'ajouter le temps du chrono au bon projet
        public void AjoutTemps(Projet p)
        {
            // On parcourt tous les projets que l'on a dans notre liste
            foreach (Projet proj in listeProjet)
            {
                if(proj.Nom == p.Nom)
                {
                    proj.Duree += p.Duree;
                    ActualisationAffichage();
                }
            }
        }

        // Méthode permettant d'appliquer la modification d'un projet
        public void Modification(Projet p)
        {
            // On parcourt tous les projets que l'on a dans notre liste
            foreach (Projet proj in listeProjet)
            {
                if (proj.Nom == p.Nom)
                {
                    proj.Description = p.Description;
                    proj.Etat = p.Etat;
                    if(proj.Etat == "terminé")
                    {
                        proj.FinirProjet();
                    }
                    ActualisationAffichage();
                }
            }
        }

        // Méthode permettant d'actualiser l'affichage
        public void ActualisationAffichage()
        {
            foreach (Projet p in listeProjet)
            {
                // Si un projet correspond à celui selectionné dans la listbox
                if (listBoxProjets.SelectedItem.ToString() == p.Nom)
                {
                    // Alors on affiche ces informations
                    textBoxDescription.Text = p.Description;
                    textBoxDateDébut.Text = p.DebutProjet.ToString("d");
                    textBoxDurée.Text = p.Duree.ToString(@"hh\:mm\:ss");
                    textBoxEtat.Text = p.Etat;
                    if (p.Etat == "terminé")
                    {
                        textBoxDateFin.Text = p.FinProjet.ToString("d");
                    }
                }
            }
        }

        // Méthode permettant la sauvegarde des projets
        public void Sauvegarder()
        {
            try
            {
                // Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                // Il s'agit de l'endroit où les fichiers d'une application doivent se trouver
                // voici le chemin C:\Users\<nom_utilisateur>\AppData\Roaming
                string chemin = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ProjectTimer\\";
                string nomFichier = chemin + "sauvegardeProjectTimer.xml";
                DataContractSerializer ser = new DataContractSerializer(typeof(List<Projet>));
                FileStream fichier = new FileStream(nomFichier, FileMode.Create);
                ser.WriteObject(fichier, listeProjet);
                fichier.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Il y a eu une erreur lors de la sauvegarde.", "Sauvegarde" , MessageBoxButton.OK ,MessageBoxImage.Error);
            }
        }

        // Méthode permettant le chargement des projets
        public void Charger()
        {
            // Gestion d'une exception si aucune sauvegarde n'est présente
            try
            {
                // Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                // Il s'agit de l'endroit où les fichiers d'une application doivent se trouver
                // voici le chemin C:\Users\<nom_utilisateur>\AppData\Roaming
                string chemin = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ProjectTimer\\";
                string nomFichier =  chemin + "sauvegardeProjectTimer.xml";
                FileStream fichier = new FileStream(nomFichier, FileMode.Open);
                DataContractSerializer ser = new DataContractSerializer(typeof(List<Projet>));
                listeProjet = ser.ReadObject(fichier) as List<Projet>;
                foreach (Projet proj in listeProjet)
                {
                    AjoutListBox(proj);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Aucune sauvegarde n'est présente sur cet ordinateur.", "Chargement", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Évènement lorsque l'on clique sur le bouton ajouter
        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            VueAjouter vue = new VueAjouter(this);
            vue.Show();
        }

        // Évènement lorsque l'on clique sur le bouton supprimer
        private void ClickSupprimer(object sender, RoutedEventArgs e)
        {
            Projet p = new Projet();
            // Gestion d'une exception si l'utilisateur ne sélectionne pas de projet à supprimer
            try
            {
                string Nom = listBoxProjets.SelectedItem.ToString();
                // On envoie la copie exacte du projet pour la suppression pour éviter les bugs
                foreach (Projet proj in listeProjet)
                {
                    if (Nom == proj.Nom)
                    {
                        p = proj;
                    }
                }
                VueSupprimer vue = new VueSupprimer(this, p);
                vue.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez sélectionner un projet à supprimer.", "Suppression", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Évènement lorsque l'on clique sur le bouton modifier
        private void ClickModifier(object sender, RoutedEventArgs e)
        {
            Projet p = new Projet();
            // Gestion d'une exception si l'utilisateur ne sélectionne pas de projet à modifier
            try
            {
                p.Nom = listBoxProjets.SelectedItem.ToString();
                // On récupère la description et l'état du projet
                foreach(Projet proj in listeProjet)
                {
                    if(proj.Nom == p.Nom)
                    {
                        p.Description = proj.Description;
                        p.Etat = proj.Etat;
                    }
                }
                VueModifier vue = new VueModifier(this, p);
                vue.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez sélectionner un projet à modifier.", "Modification", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Évènement lorsque l'on clique sur le bouton chrono
        private void ClickChrono(object sender, RoutedEventArgs e)
        {
            Projet p = new Projet();
            // Gestion d'une exception si l'utilisateur ne sélectionne pas de projet pour afficher son chronomètre
            try
            {
                p.Nom = listBoxProjets.SelectedItem.ToString();
                VueChrono vue = new VueChrono(this, p);
                vue.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Veuillez sélectionner un projet pour afficher son chronomètre.", "Chronomètre", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // Évènement lorsque l'on clique sur le bouton exporter
        private void ClickExporter(object sender, RoutedEventArgs e)
        {
            // Création de la fenêtre de sauvegarde
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            // Définit le dossier par défault de destination
            dlg.InitialDirectory = "Desktop";
            // Nom du fichier par défault
            dlg.FileName = "Exportation_ProjectTimer";
            // Extension par défault
            dlg.DefaultExt = ".xml";
            // Filtre les fichiers par leurs extensions
            dlg.Filter = "Xml documents (.xml)|*.xml";

            // Affiche la fenêtre
            Nullable<bool> result = dlg.ShowDialog();
            
            if(result == true)
            {
                // On récupère le nom du fichier ainsi que le chemin choisit
                string nomFichier = dlg.FileName;
                // Puis on effectue la sauvegarde
                DataContractSerializer ser = new DataContractSerializer(typeof(List<Projet>));
                FileStream fichier = new FileStream(nomFichier, FileMode.Create);
                ser.WriteObject(fichier, listeProjet);
                fichier.Close();
            }
        }

        // Évènement lorsque l'on sélectionne un élément dans la listBox
        private void OnSelectItem(object sender, SelectionChangedEventArgs e)
        {
            // On parcourt tous les projets que l'on a dans notre liste
            foreach (Projet p in listeProjet)
            {
                // On essaye "d'attraper" l'exception lorsque l'on supprime un projet
                try
                {
                    // Si un projet correspond à celui selectionné dans la listbox
                    if (listBoxProjets.SelectedItem.ToString() == p.Nom)
                    {
                        // Alors on affiche ces informations
                        textBoxDescription.Text = p.Description;
                        textBoxDateDébut.Text = p.DebutProjet.ToString("d");
                        textBoxDurée.Text = p.Duree.ToString(@"hh\:mm\:ss");
                        textBoxEtat.Text = p.Etat;
                        if (p.Etat == "terminé")
                        {
                            textBoxDateFin.Text = p.FinProjet.ToString("d");
                        }
                        else
                        {
                            textBoxDateFin.Text = "";
                        }
                    }
                }
                // On "attrape" l'exception et on applique ça correction
                // Pour celà on affiche toutes les cases vides
                catch (Exception)
                {
                    textBoxDescription.Text = "";
                    textBoxDateDébut.Text = "";
                    textBoxDurée.Text = "";
                    textBoxEtat.Text = "";
                    textBoxDateFin.Text = "";
                }
            }
        }

        // Évènement lorsque l'application se ferme
        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Sauvegarder();
        }
    }
}
