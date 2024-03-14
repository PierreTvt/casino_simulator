using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Paquet
{
	private List<int[]> listCartes = new List<int[]>(); // plutot utiliser List<xxxx>, l'ideal serait une liste de tableau
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
		Console.WriteLine("La taille du paquet est de :" + listCartes.Count);
		for(int couleur = 0; couleur< 4; couleur++)//création des cartes couleurs
		{
			for(int valeur = 1; valeur <= 13; valeur++)//création des valeurs 
			{
				listCartes.Add(new int[] {valeur,couleur });//Ajoute dans la liste une carte
			}
		}
	}
	public void Affiche_cartes()
	{
		//Console.WriteLine("1ère carte : " + listCartes[0][1]);
		//1er crochet corrspond à la carte sélectionnée et le 2ème à la valeur ou couleur (0 ou 1)
		for (int carte = 0; carte < listCartes.Count; carte++)
		{
			Console.WriteLine(carte + "carte : valeur=" + listCartes[carte][0] + "couleur=" + listCartes[carte][1]);
		}
		//Affiche les valeurs et les couleurs des 52 cartes
	}
	
	public int[] piocheCarteAlea()
	{
		// retourne une carte du paquet aléatoirement, et la supprime
		// cette méthode peut appeler piocheCarte(num), ou non (a voir le plus simple et le plus clair)
		Random aleatoire = new Random();
		int[] carte = new int[2];
		int nb_alea = aleatoire.Next(51);
		carte = listCartes[nb_alea];
		listCartes.RemoveAt(nb_alea);
		return carte;
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
        int[] carte_alea = new int[2];
		carte_alea = paquet.piocheCarteAlea();
		Console.WriteLine("carte aléatoire : valeur =" + carte_alea[0] + "couleur =" + carte_alea[1]);
		paquet.Affiche_cartes();
        Console.ReadLine();
    }
}