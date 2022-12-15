# Projet Architecture logiciel

Application Orienteering

# I- Sujet

## Application 

L’application à pour objectif de créer des courses d’orientation, d’être utilisée afin de réussir une course d’orientation, et de donner un classement final.

## Objectifs de l'application

- Créer une course d’orientation : L’administrateur, effectue le parcours. A chaque point de balise, celui scan le QRcode de celle-ci. Pour chaque nouvelle balise enregistrée, l’application doit enregistrer les coordonnées GPS de celle-ci et l’enregistrer dans l’ordre.  Une fois la dernière balise enregistrée, le système possède les coordonnées de l’ordre de chaque balise pour réaliser la course.

- Dérouler une course : Les utilisateurs accède à une course via un QRcode fourni par l’organisateur. La course se charge sur l’application et l’utilisateur peut commencer sa course. Sur une map un point GPS est pointé, celui indique le lieu où se trouve la balise à trouver. Une fois arrivé à la balise l’utilisateur scan le QRcode : 
-- Si celui-ci est celui de la balise à trouver, l’application indique par un message à l’utilisateur qu’il a trouvé la bonne balise et affiche le point GPS de la balise suivante.
-- Si ce n’est pas la bonne l’application indique l’erreur à l’utilisateur et celle le point GPS de la balise à trouver.

A la fin d’une course l’application indique à l’utilisateur qu’il a fini et lui indique le temps de sa course. Le système enregistre les informations de la course afin d’établir un classement final.

- Un peu de connaissances : L’application devra permettre de créer une question à poser à l’utilisateur à chaque balise. La réponse à ces questions se fera de manière numérique. La concaténation des réponses doit permettre de débloquer les coordonnées GPS de la dernière balise. Si l’utilisateur se trompe dans une ou plusieurs réponses, les coordonnées de la dernière balise ne sont pas débloquées et l’utilisateur est envoyé au point d’arrivée.



## Spécification techniques

L'application devra être exécutée sur des smartphones Android ou IOS.


## Contraintes techniques

- Hébergement : L’hébergement se fera dans un culster Kubernetes avec AKS. L’API sera conteneurisée. Elle devra être développée en microservices. L’API sera développée en .Net core.
- L’application mobile sera disponible depuis les stores.

## CI/CD

Vous pouvez implétementer un système DevOps de votre choix (Azuredevops, Gitlab, Jenkins, ...) afin de créer une intégration continue.
Vous devez intégrer les tests unitaires dans l'intégration continue.
L'intégration continue devra gérer le process complet du Git au déploiement docker.

## Base de données

Base de données : La base de données sera sous Azure (sqlserver).
Vous êtes obligé d'utiliser un ORM: EntityFramework.
Vous pouvez (fortement conseillé) utiliser les migrations.

## Web API

Vous devrez réaliser la doc des APIs avec SwaggerUI [aide](https://swagger.io/swagger-ui/)

[aide 2](https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio)

## Authentification

Vous devez implétementer une authentification OAuth2/OpenID dans vos API.
Une authentification tiers est acceptée.


# Groupes et fonctionnement

Le projet est a développé en groupe de 2/3/4 personnes.
Tous les groupes seront définis en cours, sous la supervision de l'enseignant. Les groupes s'enregistrent avec un nom de groupe ainsi que les noms de leurs membres.

Toute inscription est définitive.  Les étudiants ne sont pas autorisés, par la suite, à changer de groupe.

Au sein d'un groupe, les étudiants se répartiront les tâches pour le projet, de façon équitable.  Il est explicitement exigé que chaque membre consacre au moins 50% de son travail à du développement technique. Du code de test est acceptable, tant qu'il ne constitue pas l'intégralité de la réalisation technique du membre du groupe.

Les étudiants sont encouragés (mais pas obligés) à mettre en place un système de contrôle des sources de type Git ou équivalent, afin d'affecter et partager efficacement les fichiers de codes et autres composants numériques du projet (fichiers sources, descripteurs de déploiement, documents de recherche, cas d'utilisation, suites de tests, etc.).

# Soutenance et rendu

La soutenance aura lieux le jeudi 27 janvier 2023.
Les horaires de passage sont définis pour chaque groupe.
Toute absence à la soutenance entrainera un 0 (ZERO) pour le membre du groupe.

Les rendus doivent figurer sur un seul compte par groupe.
Le rendu s'effectu via un repos GIT ou SVN. L'adresse du rendu est envoyé par mail.
Le mail de rendu est vincent.leclerc@ynov.com
Les fichiers rendus doivent contenir
  - L'arborescence du projet, immédiatement exploitable après création des bases de données et exécution des migrations.
  - Un AUTHORS.TXT listant les membres du groupe (prénom, nom), à raison d'un par ligne.  Il liste ensuite les responsabilités effectives de chacun dans le groupe.
Le sujet du mail doit contenir votre section ainsi que le nom du projet.
Les fichiers rendus peuvent aussi comprendre: 
  - Des documents de recherche créés pour le projet et fournissant plus de détails pour l'enseignant.
Pour tout autre type de fichier, veuillez demander à l'enseignant si son inclusion est appropriée.
La soutenance dure 20 minutes durant lesquelles les membres présentent leur travail. Un échange de questions peut se faire entre le professeur et les membres du groupe.

Les groupes sont les suivants:
- 

Les horaires de passage des groupes sont les suivants:
- 14h15 => 
- 14h45 => 
- 15h15 => 
- 15h45 => 


Pour ceux dont le groupe n'est pas dans la liste, contactez-moi très rapidement à vincent.leclerc@ynov.com