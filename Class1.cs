using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Paquet
{
	private int[,] tabPaquet = new int[52, 2]; // plutot utiliser List<xxxx>, l'ideal serait une liste de tableau
	public Paquet()
	{
		//
		// TODO: Add constructor logic here
		//
		initPaquet(); // initialise le paquet
	}
	public void initPaquet()
	{
		// A changer lorsque tabPaquet sera une List (en utilisant la méthode add)
		for (int couleur=0; couleur<3; couleur++)
		{
			for (int i=1; i<14; i++)
			{
				tabPaquet[(i - 1) * (couleur + 1), 0] = i;
				tabPaquet[(i - 1) * (couleur + 1), 1] = couleur;
			}
		}
	}
	public int[] piocheCarte(int num)
	{
		// il faudrait aussi supprimer la carte pioché
		return  new int[] { tabPaquet[num, 0], tabPaquet[num, 1]}; // renvoie la premiere carte sans la supprimer
	}
	public int[] piocheCarteAlea()
	{
		// retourne une carte du paquet aléatoirement, et la supprime
		// cette méthode peut appeler piocheCarte(num), ou non (a voir le plus simple et le plus clair)
		return piocheCarte(0);
	}
}

public class Joueur
{
	//private int[] cartesEnMain = new int[2];
	private int monnaie = 5000;
	private int monnaieManche = 0;

	public void init() // mettre les bons parametre
	{
		//TODO
	}

	public int play()
	{
		//renvoie la mise que le joueur vas payer a cet instant. -1 pour se coucher
		return -1;
	}
}

public class plateau
{
	private int[] tabMises = {0, 0, 0 }; // mettre le nombre de joueur a la place de 3
	private int pot = 0;
    private List<int[]> cartesPlateau = new List<int[]>();
	private Joueur[] listJoueur = new Joueur[3]; // 3 joueurs pour l'instant
	private int currentPlayer = 0;

	public void newGame()
	{
        pot = 0;
        List<int[]> cartesPlateau = new List<int[]>();
        int[] tabMises = { 0, 0, 0 };
    }

	public void JoueurActuelleJoue()
	{
		int mise = listJoueur[currentPlayer].play(); // ajouter des parametre pertinent
		
	}
}


public class PokerTextuel
{
	public void run()
	{
        Console.WriteLine("Debut fonction run");
        test();
	}
	public void test()
	{
		Console.WriteLine("Debut fonction test");
        // fonction pour faire des tests
        Paquet paquet = new Paquet();
		int[] carte = paquet.piocheCarte(0);
		Console.WriteLine("carte:"+carte[0]+" " + carte[1]);
        Console.ReadLine();
    }
}