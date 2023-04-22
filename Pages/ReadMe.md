
### Ceci est un récapitulatif de notre solution


#### Dans ce projet, nous allons voir quatre types de Pages en .Net MAUI et les différentes formes de navigation d'une page à une autre

Pour les types de Pages, nous avons:
>1. ContentPage
>2. NavigationPage: peut contenir un ContentPage
>3. FlyoutPage : peut contenir les deux précédents
>4. TabbedPage : peut contenir tous les autres types de pages

>a. ContentPage est la plus simple de toutes les pages. Elle ne peut contenir un et un seul élément. Pour y ajouter plusieurs éléments, on 
	utilise des layouts ou des conteneurs qu'on verra dans la suite du cours. Il faut savoir qu'ici, les éléments dont nous parlons sont appelés 
	des contrôles (Controls)

>b. NavigationPage fournit une expérience de navigation hiérarchique qui permet de naviguer entre les pages comme on le désire. Il utilise une pile LIFO (Last-In First-Out)

>c. FlyoutPage est une page qui gère deux pages d'information reliées. une partie flyout qui présente les éléments et l'autre partie détail qui présente les détails des éléments dans la partie fyout.
Ainsi, chaque élément sélectionné dans la partie flyout aura sa page détail correspondante

>d. TabbedPage contient une collection de pages enfants et une seule est visible à la fois. Le titre de chaque page enfant s'affiche dans un menu,en haut ou en bas de page.

**Navigation entre les pages**
	Dans cet exercice, nous allons faire la navigation à travers le fichier App.xaml. Le fichier AppShell.xaml a été supprimé et ne nous sera pas d'utiliser dans ce projet.
	La classe **Navigation** nous permet de faire la navigation entre les pages avec les quatre méthodes suivantes:

		PushAsync: permet d'ajouter les pages à une pile de navigation. Elle a deux constructeurs: l'un prend la page à ajouter à la pile et l'autre prend la page ainsi qu'un booléen qui définit si cette page sera animée ou pas.
		PopAsync: supprime la première page de la pile

On a aussi les méthodes modal pour la navigation:
		
		PopModalAsync et PushModalAsync: Une page modale encourage les utilisateurs à effectuer une tâche autonome qui ne peut pas être quittée tant que la tâche n'est pas terminée ou annulée.

## **_Vous pouvez vous rendre ici https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.navigationpage.popasync?view=net-maui-7.0 pour la documentation_**

#### **Etant donné que nous n'utilisons pas le AppShell, la page d'accueil de notre application doit être instanciée comme MainPage dans le App.Xaml