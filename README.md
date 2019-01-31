# dotnet.CodingDojo

## Intégration de la couche Connectors

L'intégralité du code du Dojo est disponible sur Github, si vous avez un compte vous pouvez forker le projet ou récupérer l'archive : [Github du dojo](https://github.com/wihary/Capgemini.Ams.Dojo.Comic)
> Récupérer la branche 'develop'

1. Etudier la structure du projet et la manière de référencer des projets entre eux
2. Comprendre les différentes mécaniques de dépendances (csproj, sln etc...)

------

## Ajouter des fonctionnalités métiers

En l'etat l'API permet simplement de requeter une ou plusieurs source externes pour recuperer une liste de Comics via leur debut de titre

L'idee du DOJO est d'aller plus loin et d'ajouter de nouvelles fonctionnalités comme par exemple  :

* Recuperer une ou plusieurs serie de comics (exemple : Avengers (2012 - 2015) ou Star Wars (2015 - Present))
* Recuperer l'ID ou le titre des comics qui font partie de cette serie
* Pouvoir recuperer les informations detaillees d'un comics
* Lier la recuperation des auteurs a un comics

------

## Aller plus loin avec notre API

### Comment paramétrer le serveur Web

Le Core embarque un serveur Web par defaut nommé Kestrel. Son implémentation partage plusieurs composants communs avec ceux de NodeJS. Cependant bon nombre ont été réécrit par la communauté pour bénéficier de meilleurs performances

Il existe plusieurs possibilités pour paramétrer le serveur depuis une application Core, nous allons principalement en aborder 2 :

* Via du code C# directement dans l'initialisation de l'application
* Par fichier de configuration avec l'appsettings.json

> Récupérer la branche 'dojo/kestrel' pour voir comment le paramétrage du serveur est implémenté

> [Documentation : comment paramétrer le serveur Kestrel](https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-2.2)
> [Documentation : HTTPS et redirection](https://docs.microsoft.com/fr-fr/aspnet/core/security/enforcing-ssl?view=aspnetcore-2.2&tabs=visual-studio)


### Implémenter swagger pour la description d'interface

Swagger (ou OpenAPI) est un outil de génération de pages d’aide et de documentation pour les API web. Ses avantages sont, entre autres, la documentation interactive, la génération de SDK client et la découvertibilité des API.

En Core l'implementation de swagger est porté par le projet opensource [Swashbuckle.AspNetCote](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

> Récupérer la branche 'dojo/swagger' pour voir comment implémenter Swagger

Pour tester la documentation swagger de l'API :

1. Démarrer l'API soit par ligne de commande soit en debug
2. Naviguer vers http://localhost:5000/swagger

> [Documentation : comment swagger avec Swashbuckle](https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2)

### Ajouter du cache dans vos API

Lorsqu'une API permet de servir des données statiques ou qui sont peu amenées à évoluer, il peut être très interessant d'implémenter un système de cache. Le core porpose nativement plusieurs type d'implémentations :

* Client side cache en utilisant le header 'cache-control'
* Serveur In-Memory cache

> [Documentation : Generalites sur la gestion du cache des reponses](https://docs.microsoft.com/fr-fr/aspnet/core/performance/caching/response?view=aspnetcore-2.2)

### Comment gérer les Cross Origin Resource Sharing (CORs)

Il n'est pas rare de devoir gérer des exceptions de sécurité notamment pour l'accès CORs. Le core permet de les gérer via deux paramétrages trsè simple :

* Parametrage d'un middleware et déclaration de policy
* Ajout d'attribut directement dans les controllers ou endpoints

> [Documentation : Generalites sur la gestion du cache des reponses](https://docs.microsoft.com/fr-fr/aspnet/core/security/cors?view=aspnetcore-2.2)

### Implémenter un logger

------

## Aller (encore) plus loin avec notre API

### Paramétrer dynamiquement une application .net core

Le principe est de découvrir les possibilités proposées par le Core pour paramétrer une application à la volée, c'est à dire sans nécessairement devoir la redémarrer. Ce type de fonction est vraiment appréciable pour gérer les applications sans interruption de service.

Pour experimenter rapidement dans le cadre du sojo vous pouvez suivre la démarche suivante:

1. Récuperer la branche 'dojo/advanced-features'
2. Démarre l'API en debug ou via command line
3. Ouvrir le fichier appsettings.json qui se trouve dans le projet Comic.Api
4. Suivre les instructions en commentaire dans le fichier

> [Documentation : comment configurer une application core](https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/configuration/?view=aspnetcore-2.2)

### A la découverte de l'injection de dépendance avancée

Le composant 'Comic.Connectors' fait appels à des fonctionnalités avancées du moteur d'injection de dépendance par défaut proposé par le Core.
Le code du composant est disponible donc n'hésitez pas à le parcourir il se trouve dans la branche 'dojo/full-featured'
> [Documentation : injection de dépendance](https://docs.microsoft.com/fr-fr/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2)

------

## Lien utiles

* [Parcourir les sources du Dotnet Core](https://source.dot.net/)
* [Guide général pour démarrer en Dotnet Core](https://docs.microsoft.com/fr-fr/dotnet/core/)
* [Documentation ASP.Net Core](https://docs.microsoft.com/fr-fr/aspnet/core/?view=aspnetcore-2.2)
* [Github du dojo](https://github.com/wihary/Capgemini.Ams.Dojo.Comic)
* [Github de la fondation .Net](https://github.com/dotnet)