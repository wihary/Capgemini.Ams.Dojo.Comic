# Capgemini.Ams.Dojo.Comic

## Présentation de l'architecture cible du DOJO Dotnet

![Schéma de l'architecture](https://github.com/wihary/Capgemini.Ams.Dojo.Comic/raw/develop-dojo/images/archi-dojo-dotnet.png "")

------

## Part I : Initialisation du DOJO

Dans cette première partie, nous allons créer un premier projet .net Core, le faire fonctionner et explorer sa structure. Ensuite on initialisera l'arborescence du projet, ce qui va nous permettre de parler des références de projets et de l'organisaiton d'une solution.

### Objectifs

* Créer un projet Dotnet Core basé sur le template 'webApi'
* Faire fonctionner le template
* Comprendre la structure d'un projet Dotnet Core
* Construire l'arborescence de la solution globale

### Déroulement

1. Créer un projet

    * Créer un dossier 'Capgemini.Ams.Dojo.Comic' puis un autre à l'intérieur nommé 'src'
    * Ouvrir une console (powershell ou cmd) dans le dossier 'src'
    * Ecrire la commande suivante
    > dotnet new webapi -n Capgemini.Ams.Dojo.Donet.Api
    * Démarer le projet avec la commande suivante
    > dotnet run --project .\Capgemini.Ams.Dojo.Donet.Api\Capgemini.Ams.Dojo.Donet.Api.csproj

2. Explorer l'API

    * Dans le terminal, vous devriez voir une URL qui correpond à celle sur laquelle votre application devrait répondre
    * Dans votre navigateur préfér saisir l'url suivante :
    > [URL]/api/values
    * L'application devrait vous répondre en JSON !
    > ["value1","value2"]

3. Comprendre la structure du projet

