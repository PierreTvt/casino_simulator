
// instanciation de la classe game, puis lancement de cette classe
using System; // a retirer possiblement apres tout les tests consoles

//using var game = new testJeuxCross2.Game1();
//game.Run();

//test en console:
Console.WriteLine("debut programme Programm.cs");
PokerTextuel gameText = new PokerTextuel();
gameText.run();

// probleme possible avec obj\project.assets.json
// il faut utiliser dotnet restore (demande a Pierre si besoin)

// pour que l'execution fonctionne, j'ai selectionn� testJeuxCross2 a cot� du triangle vert

/* /!\ IMPORTANT /!\ (Pierre THEVENOT)
 * Pour executer le programme avec une sortie console, j'ai du changer une ligne du fichier testJeuxCross2.csproj
 * J'ai chang� (uniquement !) la 3eme ligne (commencant par <OutputType>...)
 * J'ai mis (sans les doubles guillemets):
"    <OutputType>Exe</OutputType>"
 * avant, la ligne �tait (tr�s exactement, mais sans les doubles guillemets):
"    <OutputType>WinExe</OutputType>"
 * Quand les tests en consoles seront termin�, 
 * il FAUDRA pour le bon fonctionnement du programme remettre la lignes comme avant.
*/
