# Capgemini.Ams.Dojo.Comic

- [Capgemini.Ams.Dojo.Comic](#capgeminiamsdojocomic)
  - [Présentation de l'architecture cible du DOJO Dotnet](#pr%C3%A9sentation-de-larchitecture-cible-du-dojo-dotnet)
  - [Part I : Initialisation du DOJO](#part-i--initialisation-du-dojo)
    - [Objectifs](#objectifs)
    - [Déroulement](#d%C3%A9roulement)
  - [Part II : Creation d'un contrôleur](#part-ii--creation-dun-contr%C3%B4leur)
    - [Objectifs](#objectifs-1)
    - [Déroulement](#d%C3%A9roulement-1)
  - [Part III : Communiquer avec une API externe](#part-iii--communiquer-avec-une-api-externe)
    - [Objectifs](#objectifs-2)
    - [Déroulement](#d%C3%A9roulement-2)

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

<strong>1. Créer un projet</strong>

  * Créer un dossier 'Capgemini.Ams.Dojo.Comic' puis un autre à l'intérieur nommé 'src'
  * Ouvrir une console (powershell ou cmd) dans le dossier 'src'
  * Écrire la commande suivante
  > dotnet new webapi -n Capgemini.Ams.Dojo.Dotnet.Comic.Api
  * Démarrer le projet avec la commande suivante
  > dotnet run --project .\Capgemini.Ams.Dojo.Dotnet.Comic.Api\Capgemini.Ams.Dojo.Dotnet.Comic.Api.csproj

<strong>2. Explorer l'API</strong>

  * Dans le terminal, vous devriez voir une URL qui correspond à celle sur laquelle votre application devrait répondre
  * Dans votre navigateur préféré saisir l'url suivante :
  > [URL]/api/values
  * L'application devrait vous répondre en JSON !
  > ["value1","value2"]

<strong>3. Comprendre la structure du projet</strong>

  * Program.cs
    * C'est le point d'entrée de l'application, il contient donc la method 'Main' qui peut prendre des arguments passe en ligne de commande.
    * La méthode Main permet notamment d'initialiser le serveur web, qui portera l'application
  * Startup.cs
    * La classe permet de décrire le comportement de l'application Dotnet Core
    * `ConfigureServices()` : est la méthode utilisée pour déclarer les services disponibles dans l'application. Nous aurons l'occasion de revenir sur cette partie dans une autre partie
    * `Configure()` : Permet de décrire le 'pipeline d'exécution des requêtes' que va utiliser votre application

> ## Request Execution Pipeline (ou Middleware Pipeline)
> Le pipeline est tout simplement le cycle de traitement d'une requête, suivi du cycle de traitement de la réponse. Un middleware est en réalité un bout de code qui embarque une logique de traitement sur la requête et/ou la réponse. <br><br>
> ![Schema du middleware pipeline](https://www.thomaslevesque.com/files/2018/03/request-delegate-pipeline.png "")
> <br>
> Dans le template par défaut, et donc le projet que l'on vient de créer, le pipeline est le suivant :
> * `UseDeveloperExceptionPage()`
> * `UseHttpsRedirection()`
> * `UseMvc()`
>
> Le nom des différents middlewares est plutôt clair et permet de comprendre ce qu'ils vont faire. On aura l'occasion de revenir sur la redirection HTTPS plus loin dans ce Dojo.

<strong>4. Construire la structure du projet</strong>

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

------

## Part II : Creation d'un contrôleur

Dans cette seconde partie nous allons aborder la création d'un contrôleur qui traitera spécifiquement les requêtes liés aux comics. Nous allons donc devoir declarer un nouveau point d'entre pour l'API, construire une logique metier et le modèle de données exposé a nos clients.

### Objectifs

* Créer le modèle objet et la logique metier
* Creation d'une classe contrôleur, definition des actions
* Injecter la logique metier dans l'API pour l'utiliser via les contrôleur
* Tester la nouvelle interface

### Déroulement

<strong>1. Création du modèle de données</strong>

* Pour les besoins du Dojo nous allons nous concentrer sur 3 objets (libre à vous d'en ajouter !)
    * `ComicBook` : Objet qui contient les informations d'un Comic (aussi nommé Issue)
    * `Serie` : Objet qui contient le détail d'une série, une série fait généralement référence vers plusieurs Comic Books
    * `Author` : Objet qui contient la description d'un auteur, généralement un auteur à travaillé sur plusieurs série et plusieurs comic books.

> ## Exemple de classe en C#
> ```csharp
> namespace Capgemini.Ams.Dojo.Dotnet.Comic.Model
>{
>    using System;
>
>    public class ComicBook
>    {
>        /// <summary>
>        ///     Id du comicBook utilise par la source donnees
>        /// </summary>
>        public int Id { get; set; }
>
>        public int SerieId { get; set; }
>
>        public string SerieName { get; set; }
>
>        public string Title { get; set; }
>
>        public DateTime ParutionDate { get; set; }
>
>        public int IssueNumber { get; set; }
>    }
>}
> ```
> <strong>Remarques :</strong>
>
> * Une classe appartient à un Namespace, il permet d'organisation des éléments de code afin de les regrouper par thématique, composants etc...
> * Le mot clé `using` est utilisé pour insérer des références dans votre fichier de code
> * Il est possible de spécifier des commentaires qui seront utilisés pour générer une doc XML, le formalisme est présenté sur la propriété `Id`
> <br><br>

Vous êtes libre d'ajouter les propriétés que vous souhaitez exposer à votre clients. Vous aurez de toute façon l'occasion d'en ajouter par la suite.

<strong>2. Implémentation de la logique métier et des routes de l'API</strong>

Dans un premier temps nous allons simplement créer un seul controleur avec une action, vous serez ensuite autonome pour en créer d'avantage sur ce modèle.

Les controleurs sont déclarés, par convention, dans le dossier Controllers, dans l'absolue, ce n'est pas obligatoire. Un controlleur en ASPnet Core est une simple classe décoré de l'attribut `[Controller]` ou `[ApiController]`. Les méthodes de cette classe, ou action, seront les points d'entrées exposés par votre API.

* Pour les besoins du Dojo nous allons commencer par créer le controlleur pour la ressource `ComicBook`:
> ## Exemple de controleur en AspNet Core
> ```csharp
>namespace Capgemini.Ams.Dojo.Dotnet.Comic.Api.Controllers
>{
>    using Microsoft.AspNetCore.Mvc;
>
>    [Route("api/[controller]")]
>    [ApiController]
>    public class ComicBookController : ControllerBase
>    {
>        /// <summary>
>        ///     Endpoint utilise pour recuperer un comicBook
>        ///     Signature : /api/comicbook
>        /// </summary>
>        /// <returns>returns une collection de <see cref="Model.ComicBook"/></returns>
>        [HttpGet]
>        public IActionResult GetComicBook()
>        {
>            return this.Ok();
>        }
>    }
>}
> ```
> <strong>Remarques :</strong>
>
> * Plus d'informations sur [les attributs des controlleurs](https://docs.microsoft.com/fr-fr/aspnet/core/web-api/?view=aspnetcore-2.2).
> * La mécanique est la même pour ajouter des actions avec des verbes différents comme `[HttpPost]`, `[HttpPut]`, `[HttpDelete]` etc...
> * Observer le retour de la méthode `GetComicBook()` il s'agit d'un helper qui permet de gérer simplement le type de retour que vous souhaitez faire. Il en existe d'autres comme `NotFound()`, `BadRequest()` etc... ([plus d'infos](https://docs.microsoft.com/fr-fr/aspnet/core/web-api/?view=aspnetcore-2.2))
> <br><br>

<strong>3. Injecter la logique métier dans les contrôleurs</strong>

Le Dotnet Core embarque nativement un moteur d'injection de dépendances qui propose une mécanique d'implémentation assez rapide a appréhender.
>Pour mieux comprendre les principaux architecturaux autour du dotnet core, je vous invite à lire cet article
> * [Principes de l’architecture](https://docs.microsoft.com/fr-fr/dotnet/standard/modern-web-apps-azure-architecture/architectural-principles)

* Pour commencer, nous allons créer une classe dans le projet `Comic.Business` qui va porter la logique métier de traitement derrière la ressource `ComicBook`
  * Ajouter une nouvelle dans le projet `Capgemini.Ams.Dojo.Dotnet.Comic.Business`, nommer par exemple `ComicBookLogic`. Elle va contenir une méthode toute simple qui retourne une instance d'un objet `ComicBook`, ce qui peut donner quelque chose comme :
  ```csharp
  namespace Capgemini.Ams.Dojo.Dotnet.Comic.Business
  {
      using System;
      using Capgemini.Ams.Dojo.Dotnet.Comic.Model;

      public class ComicBookLogic
      {
          public ComicBook GetComicBook() => new ComicBook
          {
              Id = 42,
              Title = "This is a ComicBook title",
              ParutionDate = DateTime.Now
          };
      }
  }
  ```
* Il faut ensuite déclarer cette classe comme étant un composant disponible dans le moteur d'injection :
  * La définition ve être portée par [une méthode d'extension](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods), définit dans le projet `Capgemini.Ams.Dojo.Dotnet.Comic.Business`
    >  ```csharp
    >namespace Capgemini.Ams.Dojo.Dotnet.Comic.Business
    >{
    >    using Microsoft.Extensions.DependencyInjection;
    >
    >    /// <summary>
    >    ///     Classe d'extension qui sert a decrire l'ensemble des services mis a disposition par la couche business
    >    ///     Au runtime ces services deviennent disponibles par Injection de Dependances
    >    /// </summary>
    >    public static class BusinessServiceExtension
    >    {
    >        /// <summary>
    >        ///     Methode d'extension qui definit les services mis a disposition par la couche Comic.Business
    >        ///
    >        ///     Actuellement la couche metier contient une seule classe et embarque la declaration des connecteurs
    >        /// </summary>
    >        /// <param name="services">Collection contenant la description de l'ensemble des services disponible pour l'application</param>
    >        /// <returns>retourne la collection des services <see cref="IServiceCollection"/></returns>
    >        public static IServiceCollection AddBusiness(this IServiceCollection services)
    >            => services.AddTransient<ComicBookLogic>();
    >    }
    >}
    >```
    > <strong>Remarques :</strong>
    > * Chacune des classe déclarée dans le moteur peut l'être de plusieurs manière suivant vos besoins : [DI avec AspNet Core](https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2)
  * Le moteur d'injection se configure dans le fameux `startup.cs`, on va donc utiliser notre méthode d'extension pour intégrer la définition que l'on vient d'écrire dans le moteur, ce qui donne ceci :
    ```csharp
    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddBusiness(); // Ajout de la définition d'injection des classes métiers
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
    }
    ```
* Pour finir, il faut récupérer la classe injectée dans le controlleur :
  * Les composants injectés sont récupérés à l'instanciation du controlleur c'est à dire depuis le constructeur directement. On ajoute donc, dans `ComicBookController`, le code suivant :
  ```csharp
  private readonly ComicBookLogic comicBookLogic;

  /// <summary>
  ///     ctor of <see cref="ComicBookController"/>
  /// </summary>
  /// <param name="comicBookLogic">Injection de Dependance : Couche metier qui supervise les actions pour les comics</param>
  public ComicBookController(ComicBookLogic comicBookLogic)
      => this.comicBookLogic = comicBookLogic;
  ```
  * La logique métier peut maintenant être appelée dans notre controller, le code à jour de la méthode donne donc :
  ```csharp
  /// <summary>
  ///     Endpoint utilise pour recuperer un comicBook
  ///     Signature : /api/comicbook
  /// </summary>
  /// <returns>returns une collection de <see cref="Model.ComicBook"/></returns>
  [HttpGet]
  public IActionResult GetComicBook()
  {
      return this.Ok(this.comicBookLogic.GetComicBook());
  }
  ```

<strong>4. Tester la nouvelle API</strong>
* Démarrer l'API en debug par exemple puis dans votre navigateur préféré, essayer d'atteindre : https://localhost:5001/api/comicbook
* Si tout se déroule correctement l'API doit renvoyer un objet JSON :
  ```json
  {"id":42,"serieId":0,"serieName":null,"title":"This is a ComicBook title","parutionDate":"2019-03-16T08:54:33.7210113+01:00","issueNumber":0}
  ```

------

## Part III : Communiquer avec une API externe

Dans cette troisième partie nous allons voir comment nous connecter a une API externe comme celle proposée par MARVEL. L'objectif est de pouvoir renvoyer a notre utilisateur des donnees provenant de cette API.

### Objectifs

* Communiquer avec une API en utilisant le composant HTTPClient
* Transformer un objet d'une source externe vers notre modèle business
* Transmettre nos arguments de recherche depuis le contrôleur jusqu'a l'API externe
* Tester les nouveaux appels

### Déroulement