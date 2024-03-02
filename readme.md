# Project Timer

*Projet réalisé durant les vacances de février de l'année 2017/2018*

## Description

Ce projet consiste à la conception puis au développement d’une application permettant de connaître le temps passé sur un projet. Le projet se terminera lorsque l’application sera déployée sur machine pour permettre son utilisation par un étudiant ou un particulier. L’application doit permettre la création d’un projet en spécifiant son nom, sa description, la date de début, l’état du projet (en cours ou achevé) ainsi que le temps passé dessus. Pour le calcul du temps passé dessus, l’utilisateur déclenchera un chronomètre qui comptera le temps durant lequel il travaille. Dès que sa session de travail sera terminée il arrêtera le chronomètre et le temps pour ce projet sera mis à jour. L’application doit aussi permettre la gestion des projets en permettant la modification des informations d’un projet existant ou la suppression d’un projet. Lorsque l’état d’un projet est passé de en cours à achever la date de fin du projet est alors fixé. Pour finir l’application doit permettre aussi l’exportation des données sous format XML permettant ainsi l’affichage de ces données sur un site internet

## Fonctionnement du logiciel

Une fois le logiciel démarré, on arrive dans la vue principale.

![Vue principal](https://github.com/MaximeCharlet/ProjectTimer/blob/main/img/MenuPrincipalPT.PNG?raw=true)

On peut voir que l'outil ne contient aucun projet de base. Mais il dispose de plusieurs boutons :
- Créer un projet via le bouton ajouter
- Modifier un projet existant
- Supprimer un projet existant
- Lancer un chronomètre pour comptabiliser le temps passer sur un projet
- Exporter les données contenu dans le logiciel (export au format xml)

Lorsque l'on clique sur le bouton ajouter la vue suivante s'affiche :

![Vue ajout projet](https://github.com/MaximeCharlet/ProjectTimer/blob/main/img/AjoutProjet.PNG?raw=true)

Elle nous permet de créer un projet dans l'outil en spécifiant son nom et sa description.

## Installer ProjectTimer