using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Paquet
{
	int[,] tabPaquet = new int[52, 2]; // plutot utiliser List<xxxx>, l'ideal serait une liste de tableau
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