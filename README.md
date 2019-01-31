# Capgemini.Ams.Dojo.Comic

## Présentation de l'architecture cible du DOJO Dotnet

![Schéma de l'architecture](https://github.com/wihary/Capgemini.Ams.Dojo.Comic/raw/develop-dojo/images/archi-dojo-dotnet.png "")

------

## Part I : Initialisation du DOJO

Dans cette première partie, nous allons créer un premier projet .net Core, le faire fonctionner et explorer sa structure. Ensuite on initialisera l'arborescence du projet, ce qui va nous permettre de parler des références de projets et de l'organisation d'une solution.

### Objectifs

* Créer un projet Dotnet Core basé sur le template 'webApi'
* Faire fonctionner le template
* Comprendre la structure d'un projet Dotnet Core
* Construire l'arborescence de la solution globale

### Déroulement

1. Créer un projet

    * Créer un dossier 'Capgemini.Ams.Dojo.Comic' puis un autre à l'intérieur nommé 'src'
    * Ouvrir une console (powershell ou cmd) dans le dossier 'src'
    * Écrire la commande suivante
    > dotnet new webapi -n Capgemini.Ams.Dojo.Donet.Comic.Api
    * Démarrer le projet avec la commande suivante
    > dotnet run --project .\Capgemini.Ams.Dojo.Donet.Comic.Api\Capgemini.Ams.Dojo.Donet.Comic.Api.csproj

2. Explorer l'API

    * Dans le terminal, vous devriez voir une URL qui correspond à celle sur laquelle votre application devrait répondre
    * Dans votre navigateur préféré saisir l'url suivante :
    > [URL]/api/values
    * L'application devrait vous répondre en JSON !
    > ["value1","value2"]

3. Comprendre la structure du projet

    * Program.cs
      * C'est le point d'entrée de l'application, il contient donc la method 'Main' qui peut prendre des arguments passe en ligne de commande. 
      * La méthode Main permet notamment d'initialiser le serveur web, qui portera l'application
    * Startup.cs
      * La classe permet de décrire le comportement de l'application Dotnet Core
      *  `ConfigureServices()` : est la méthode utilisée pour déclarer les services disponibles dans l'application. Nous aurons l'occasion de revenir sur cette partie dans une autre partie
      * `Configure()` : Permet de décrire le 'pipeline d'exécution des requêtes' que va utiliser votre application

> ## Request Execution Pipeline (ou Middleware Pipeline)
> Le pipeline est tout simplement le cycle de traitement d'une requête, suivi du cycle de traitement de la réponse. Un middleware est en réalité un bout de code qui embarque une logique de traitement sur la requête et/ou la réponse. <br>
> 
> ![Schema du middleware pipeline](https://www.thomaslevesque.com/files/2018/03/request-delegate-pipeline.png "")
> 
> Dans le template par défaut, et donc le projet que l'on vient de créer, le pipeline est le suivant :
> * `UseDeveloperExceptionPage()`
> * `UseHttpsRedirection()`
> * `UseMvc()`
> 
> Le nom des différents middlewares est plutôt clair et permet de comprendre ce qu'ils vont faire. On aura l'occasion de revenir sur la redirection HTTPS plus loin dans ce Dojo.

4. Construire la structure du projet

La cible désormais est de préparer notre solution pour accueillir l'architecture de l'API cible. Vous savez créer des projets, mais pas encore les lier entre eux.

> ## Reference de projet
> Pour qu'un projet en référence un autre il faut lui indiquer en utilisant le fichier `*.csproj`
> 
> C'est l'équivalent d'un `package.json` par exemple ou d'un `pom.xml` etc...
> Voici comment déclarer une référence de projet : 
> ``` xml
>  <ItemGroup>
>    <ProjectReference Include="..\Capgemini.Ams.Dojo.Comic.Model\Capgemini.Ams.Dojo.Comic.Model.csproj"/>
>  </ItemGroup>
> ``` 
> 
> ## Fichier Solution
> Dans l'univers .Net on peut créer des solutions, il s'agit d’un ensemble de projet. C'est particulièrement utile pour compiler un ensemble de projet en une seule instruction par exemple.
> 
> Ces fichiers sont les `*.sln`
> 
> En dotnet Core on peut utiliser la CLI (Command Line Interface) pour générer et manipuler ces fichiers solutions, exemple :
> * Créer une fichier solution brut : `dotnet new sln`
> * Ajouter un projet dans une solution : `dotnet sln add`
> * Retirer un projet d'une solution : `dotnet sln remove`
> <br><br>

Pour vous aider un peu voici la cible que l'on cherche a atteindre :

![Schéma du middleware pipeline](https://github.com/wihary/Capgemini.Ams.Dojo.Comic/raw/develop-dojo/images/part1-arborescence.PNG "")

> ## Bonus : Debugger avec VSCode
> Comme tout IDE, VSCode permet de debugger une application CSharp (positionner des points d'arrêt, inspecter des variables, exécuter du code à la volée etc...)
>
>Pour démarrer le Debug avec Vscode appuyer sur F5 ou via le menu debug situe à gauche de l'interface ([plus d'information](https://code.visualstudio.com/docs/editor/debugging))

