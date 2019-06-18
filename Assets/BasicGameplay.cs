using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BasicGameplay : MonoBehaviour 
{
	[SerializeField]
	Text player1ScoreText = null;
	[SerializeField]
	Text player2ScoreText = null;
	[SerializeField]
	Text initialDealCardsText = null;

	public int Player1ScoreCount = 0;
	public int player2ScoreCount = 0;
	public int totalCardsInDeck = 52;
	public static string [] player1CardsInHands = null;
	public static string [] player2CardsInHands = null;
	public int maxCardsInHands = 6;
	string [] deck = new string[13] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

	public int [] deckCount = new int[13] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
	public string [] initialDealCards = new string[4];



	// Use this for initialization
	void Start () 
	{
		Deal ();
	}

	public int getPlayer1CardsLength()
	{
		player1CardsInHands = new string[maxCardsInHands];
		return player1CardsInHands.Length;
	}

	public void Deal ()
	{
		player1ScoreText.text = "";
		player2ScoreText.text = "";
		initialDealCardsText.text = "";

		player1CardsInHands = new string[maxCardsInHands];
		player2CardsInHands = new string[maxCardsInHands];
		string dealtCard = "";
		bool player1Dealt = false;
		bool player2Dealt = false;
		bool gamestartDealt = false;

		/*for (int i = 0; i < maxCardsInHands; i++) 
		{
			

			player1Dealt = false;
			player2Dealt = false;
			while (!player1Dealt && !player2Dealt) 
			{
				
				if (!player1Dealt) {
					int randomNum = Random.Range (0, 13);
					if (!(deckCount [randomNum] >= 4)) {
						player1Dealt = true;
						deckCount [randomNum] += 1;
						dealtCard = deck [randomNum];
						Debug.Log ("Card is " + dealtCard + " and has appeared " + deckCount [randomNum] + " times"); 				
						player1CardsInHands [i] = dealtCard;
					}
				}
				if (!player2Dealt) {
					int randomNum = Random.Range (0, 13);
					if (!(deckCount [randomNum] >= 4)) {
						player2Dealt = true;
						deckCount [randomNum] += 1;
						dealtCard = deck [randomNum];
						Debug.Log ("Card is " + dealtCard + " and has appeared " + deckCount [randomNum] + " times"); 				
						player2CardsInHands [i] = dealtCard;
					}
				}
			}
			string player1 = player1CardsInHands [i];
			player1ScoreText.text += "," + player1;
			string player2 = player2CardsInHands [i];
			player2ScoreText.text += "," + player2;
		}

		for (int i = 0; i < 4; i++) {
			gamestartDealt = false;
			if (!gamestartDealt) {
				int randomNum = Random.Range (0, 13);
				if (!(deckCount [randomNum] >= 4)) {
					gamestartDealt = true;
					deckCount [randomNum] += 1;
					dealtCard = deck [randomNum];
					Debug.Log ("Card is " + dealtCard + " and has appeared " + deckCount [randomNum] + " times"); 				
					initialDealCards [i] = dealtCard;
				}
			}
			string temp = initialDealCards [i];
			if (i == 4) {
				initialDealCardsText.text += temp;
			}
			else
				initialDealCardsText.text += temp + ",";
		}*/
	}
}
