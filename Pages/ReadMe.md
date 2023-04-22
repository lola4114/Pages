
### Ceci est un r�capitulatif de notre solution


#### Dans ce projet, nous allons voir quatre types de Pages en .Net MAUI et les diff�rentes formes de navigation d'une page � une autre

Pour les types de Pages, nous avons:
>1. ContentPage
>2. NavigationPage: peut contenir un ContentPage
>3. FlyoutPage : peut contenir les deux pr�c�dents
>4. TabbedPage : peut contenir tous les autres types de pages

>a. ContentPage est la plus simple de toutes les pages. Elle ne peut contenir un et un seul �l�ment. Pour y ajouter plusieurs �l�ments, on 
	utilise des layouts ou des conteneurs qu'on verra dans la suite du cours. Il faut savoir qu'ici, les �l�ments dont nous parlons sont appel�s 
	des contr�les (Controls)

>b. NavigationPage fournit une exp�rience de navigation hi�rarchique qui permet de naviguer entre les pages comme on le d�sire. Il utilise une pile LIFO (Last-In First-Out)

>c. FlyoutPage est une page qui g�re deux pages d'information reli�es. une partie flyout qui pr�sente les �l�ments et l'autre partie d�tail qui pr�sente les d�tails des �l�ments dans la partie fyout.
Ainsi, chaque �l�ment s�lectionn� dans la partie flyout aura sa page d�tail correspondante

>d. TabbedPage contient une collection de pages enfants et une seule est visible � la fois. Le titre de chaque page enfant s'affiche dans un menu,en haut ou en bas de page.

**Navigation entre les pages**
	Dans cet exercice, nous allons faire la navigation � travers le fichier App.xaml. Le fichier AppShell.xaml a �t� supprim� et ne nous sera pas d'utiliser dans ce projet.
	La classe **Navigation** nous permet de faire la navigation entre les pages avec les quatre m�thodes suivantes:

		PushAsync: permet d'ajouter les pages � une pile de navigation. Elle a deux constructeurs: l'un prend la page � ajouter � la pile et l'autre prend la page ainsi qu'un bool�en qui d�finit si cette page sera anim�e ou pas.
		PopAsync: supprime la premi�re page de la pile

On a aussi les m�thodes modal pour la navigation:
		
		PopModalAsync et PushModalAsync: Une page modale encourage les utilisateurs � effectuer une t�che autonome qui ne peut pas �tre quitt�e tant que la t�che n'est pas termin�e ou annul�e.

## **_Vous pouvez vous rendre ici https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.navigationpage.popasync?view=net-maui-7.0 pour la documentation_**

#### **Etant donn� que nous n'utilisons pas le AppShell, la page d'accueil de notre application doit �tre instanci�e comme MainPage dans le App.Xaml