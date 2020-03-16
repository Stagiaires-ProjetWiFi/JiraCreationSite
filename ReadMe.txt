JiraCreationSite v.1.3

*UNE VERSION DU README PLUS COMPLÊTE ET CLAIRE EST SUR CONFLUENCE
*ELLE CONTIENT AUSSI LA PROCÉDURE POUR MODIFIER LE CODE
*https://confluence.montreal.ca/display/DTWC/Jira+Creation+Site


Quand on compile le projet. Le fichier d'executable se trouve dans:
...\JiraCreationSite\TestJiraRESTApi\bin\Release

Fonctionalités:

Permet de créer la tâche pour un nouveau Site ainsi que toute ses sous-tâches automatiquement.
Les propriétés qui sont actuellement spécifiables:
	-Id du site
	-Status
	-Adresse
	-Occupation (Ex.: Biblio, Aréna, etc...)
	-Responsable
	-Rapporteur
	-Composantes
	-Étiquettes

L'application valide les informations entrées pour qu'elles ne soit pas incorrectes. 
Par contre, elle ne détecte pas les erreurs de frappes comme les fautes.

Veuillez vérifier le site sur Jira suivant sa création sur l'application et vérifiez
que toutes les informations sont entrées correctement.