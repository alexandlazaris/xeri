using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCardGameObjects : MonoBehaviour {

	public GameObject [] prefabCards = null;
	public GameObject [] player1Cards = null;
	public GameObject [] player2Cards = null;
	public List<GameObject> [] initialCards = new List<GameObject>[4];
	public Transform [] player1CardTransforms = null;
	public Transform [] player2CardTransforms = null;
	public Transform initialCardTransforms = null;//up to adding initial 4 starting cards, cannot add them it seems ... 
	public List<string> deckNames = new List<string>(); 
	public int maxCardsInHands = 6;

	void Start () {
		CreateCards ();
	}

	void CreateCards() 
	{
		player1Cards = new GameObject[maxCardsInHands]; 
		player2Cards = new GameObject[maxCardsInHands]; 

		string currentGameObjectName = "";
		bool matchFound = false;
		for (int i = 0; i < player1Cards.Length; i++) {
			matchFound = false;
			while (!matchFound) {
				int randomNum = Random.Range (0, prefabCards.Length);
				currentGameObjectName = prefabCards [randomNum].name;
				if (!deckNames.Contains (currentGameObjectName)) {
					deckNames.Add (currentGameObjectName);
					player1Cards [i] = prefabCards [randomNum];
					Instantiate (prefabCards [randomNum]);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().SetParent (player1CardTransforms [i].transform);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localPosition = new Vector3 (0, 0, 0);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localScale = new Vector3 (100, 100, 10);
					matchFound = true;
				} else {
					Debug.Log ("Current card: '" + currentGameObjectName + "' is already found"); 
				}
			}
		}

		for (int i = 0; i < player2Cards.Length; i++) {
			matchFound = false;
			while (!matchFound) {
				int randomNum = Random.Range (0, prefabCards.Length);
				currentGameObjectName = prefabCards [randomNum].name;
				if (!deckNames.Contains (currentGameObjectName)) {
					deckNames.Add (currentGameObjectName);
					player2Cards [i] = prefabCards [randomNum];
					Instantiate (prefabCards [randomNum]);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().SetParent (player2CardTransforms [i].transform);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localPosition = new Vector3 (0, 0, 0);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localScale = new Vector3 (100, 100, 10);
					matchFound = true;
				} else {
					Debug.Log ("Current card: '" + currentGameObjectName + "' is already found"); 
				}
			}
		}

		for (int i = 0; i < initialCards.Length; i++) {
			matchFound = false;
			while (!matchFound) {
				int randomNum = Random.Range (0, prefabCards.Length);
				currentGameObjectName = prefabCards [randomNum].name;
				if (!deckNames.Contains (currentGameObjectName)) {
					deckNames.Add (currentGameObjectName);
					initialCards [i].Add(prefabCards [randomNum]);//look up how to add gameobjects to Lists in Unity
					Instantiate (prefabCards [randomNum]);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().SetParent (initialCardTransforms.transform);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localPosition = new Vector3 (0, 0, ((i + 1) * Time.deltaTime));
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localRotation = new Quaternion(0, 0, 0, 0);
					GameObject.Find (currentGameObjectName + "(Clone)").GetComponent<Transform> ().gameObject.transform.localScale = new Vector3 (100, 100, 10);
					matchFound = true;
				} else {
					Debug.Log ("Current card: '" + currentGameObjectName + "' is already found"); 
				}
			}
		}
	}
}
