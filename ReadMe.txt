JiraCreationSite v.1.3

*UNE VERSION DU README PLUS COMPL�TE ET CLAIRE EST SUR CONFLUENCE
*ELLE CONTIENT AUSSI LA PROC�DURE POUR MODIFIER LE CODE
*https://confluence.montreal.ca/display/DTWC/Jira+Creation+Site


Quand on compile le projet. Le fichier d'executable se trouve dans:
...\JiraCreationSite\TestJiraRESTApi\bin\Release

Fonctionalit�s:

Permet de cr�er la t�che pour un nouveau Site ainsi que toute ses sous-t�ches automatiquement.
Les propri�t�s qui sont actuellement sp�cifiables:
	-Id du site
	-Status
	-Adresse
	-Occupation (Ex.: Biblio, Ar�na, etc...)
	-Responsable
	-Rapporteur
	-Composantes
	-�tiquettes

L'application valide les informations entr�es pour qu'elles ne soit pas incorrectes. 
Par contre, elle ne d�tecte pas les erreurs de frappes comme les fautes.

Veuillez v�rifier le site sur Jira suivant sa cr�ation sur l'application et v�rifiez
que toutes les informations sont entr�es correctement.