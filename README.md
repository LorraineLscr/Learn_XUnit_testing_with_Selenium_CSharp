<h1 align="center">Hi 👋, I'm Lorraine</h1>
<h2 align="center">Performing Selenium automation tests using xUnit Framework</h2>

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://www.linkedin.com/in/lorraine-lescour-09599b239/" target="blank"><img align="center" src="https://raw.githubusercontent.com/rahuldkjain/github-profile-readme-generator/master/src/images/icons/Social/linked-in-alt.svg" alt="https://www.linkedin.com/in/lorraine-lescour-09599b239/" height="30" width="40" /></a>
</p>

<h3 align="left">Languages and Tools:</h3>
  <div align="left">
  <a href="https://www.selenium.dev" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/detain/svg-logos/780f25886640cef088af994181646db2f6b1a3f8/svg/selenium-logo.svg" alt="selenium" width="40" height="40"/> </a> 
    <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" width="52" alt="csharp logo"  />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" height="40" width="52" alt="visualstudio logo"  />

  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-original.svg" height="40" width="52" alt="dot-net logo"  />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" width="52" alt="dotnetcore logo"  />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/chrome/chrome-original.svg" height="40" width="52" alt="chrome logo"  />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/firefox/firefox-original.svg" height="40" width="52" alt="firefox logo"  />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/safari/safari-original.svg" height="40" width="52" alt="safari logo"  />
</div>

###

<h4>Pour démarrer un Projet : </h4>
Commencer par ouvrir un nouveau projet dans Fichier. <br>
Rechercher le modèle « Projet de test xUnit » en C# <br>
Donner un nom de projet et choisir le framework .NET 6.0 <br>
Ouvrir l’explorateur de tests dans Affichage. <br>

<h4>Prérequis : </h4>
Clic droit sur Dépendances  dans Explorateur de solutions <br>
Cliquer sur Gérer les packages NuGet <br>
Cliquer sur Parcourir <br>
Rechercher Webdriver <br>
Cocher « inclure la version préliminaire » <br>
Sélectionner « Selenium.Webdriver » .NET bindings for the Selenium webdriver API <br>
Enfin cliquer sur installer. <br>

<h4>Packages NuGet supplémentaires : </h4>
WebdriverManager : Il est responsible du téléchargement de la bonne version des pilotes. <br>
xUnit.SkippableFact : Faites en sorte que vos méthodes de test xUnit s'autodéterminent pour signaler un résultat "sauté". Utile pour les cas tels que les résultats "non pris en charge sur cette plate-forme" ou d'autres entrées environnementales. <br>
AutoFixture : AutoFixture permet aux développeurs de réaliser plus facilement un développement piloté par les tests en automatisant la configuration des montages de test non pertinents, permettant au développeur de test de se concentrer sur l'essentiel de chaque cas de test. <br>

<h4>Commencer à coder le projet : </h4>
Nommer les class de tests  <br>
Puis décrire le contexte comme nom de fonction <br>

<h4>Nous pouvons exécuter les tests dans le terminal : </h4>
dotnet test : exécute tous les tests <br>
dotnet test --filter FullyQualifiedName~nomdelaclasse : exécute une seule class de test <br>

<h4>Attributs et descriptions :</h4>

<table>
<tr>
<td>[Fact]</td>
<td>L'attribut est utilisé par l'exécuteur de test xUnit.net pour identifier un test unitaire "normal" - une méthode de test qui ne prend aucun argument de méthode.</td>
</tr>
<tr>
<td>Assert.Throws une exception d'enregistrement</td>
<td>Permet de vérifier les conditions et de les affirmer même lorsque l’exception est générique. De plus, il ne se limite pas à la seule première ligne de la méthode de test.</td>
</tr>
<tr>
<td>Constructor</td>
<td>Endroit pratique pour placer le code de configuration de contexte réutilisable là où vous souhaitez partager le code sans partager les instances d'objet (ce qui signifie que vous obtenez une copie propre du ou des objets de contexte pour chaque test exécuté).</td>
</tr>
<tr>
<td>IDisposable.Dispose</td>
<td>Pour le nettoyage de contexte, ajoutez l' IDisposableinterface à votre classe de test et placez le code de nettoyage dans la Dispose()méthode.</td>
</tr>
<tr>
<td>[Trait]</td>
<td>Utilisé pour définir des métadonnées arbitraires sur un test.  L'attribut Trait reçoit deux arguments. Le premier est le nom réel de la catégorie et le second argument est la sous-section de la catégorie. </td>
</tr>
<tr>
<td>[Theory]</td>
<td>Représente une suite de tests qui exécutent le même code, mais qui ont des arguments d’entrée différents.  Utilisé lorsqu’il existe une exigence pour des tests paramétrés. Dans de tels cas, [Theory] doit être utilisé à la place de l'attribut [Fact]</td>
</tr>
<tr>
<td>[InlineData]</td>
<td>Cet attribut est utilisé avec l'attribut [Theory] pour fournir un sous-ensemble de données sur lequel des tests paramétrés seront exécutés.</td>
</tr>
<tr>
<td>[ClassData]</td>
<td>Cet attribut est utilisé lorsque les paramètres passés aux tests [Theory] ne sont pas des constantes.<br>
[Theory] <br>
[ClassData(typeof(some-data))]<br>
</td>
</tr>
<tr>
<td>[MemberData]</td>
<td>Cet attribut peut être utilisé pour récupérer des données pour [Theory] à partir d'une méthode statique. <br>
L'approche la plus courante consiste à charger les données à partir de la propriété d'une classe de test, c'est-à-dire en utilisant IEnumerable< object[ ] >
</td>
</tr>
</table>

<h4> Documentation : </h4> 
<div align="left">
  <img src="https://raw.githubusercontent.com/maurodesouza/profile-readme-generator/master/src/assets/icons/social/youtube/default.svg" width="52" height="40" alt="youtube logo"  /> https://www.youtube.com/watch?v=gOC_lCz2zXs <br>
</div>
<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg" height="40" width="52" alt="github logo"  /> https://github.com/xunit/samples.xunit
</div> 
<div align="left">
<img alt="Logo Test Lambda" src="https://www.lambdatest.com/resources/images/logos/logo.svg" width="147" height="26">
https://www.lambdatest.com/blog/xunit-testing-tutorial/ <br>
</div>



