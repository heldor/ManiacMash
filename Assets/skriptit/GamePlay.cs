using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class GamePlay : MonoBehaviour {
	List<string> playerInput;
	List<string> compInput;
	private int puna = 1;
	private int kelta = 2;
	private int sini = 3;
	private int random;
	public Button pun;
	public Button sin;
	public Button kelt;
	public int playerInputCount = 0;
	private int lastRandom = 0;
	public Text pisteet;
	public static int pisteetInt = 0;

	// Use this for initialization
	void Start () {
		playerInput = new List<string>();
		compInput = new List<string>();
	}

	public void redPressed(){
		playerInputCount++;
		playerInput.Add ("red");
		CheckLists ();
	}
	public void bluePressed(){
		playerInputCount++;
		playerInput.Add ("blue");
		CheckLists ();
	}
	public void yellowPressed(){
		playerInputCount++;
		playerInput.Add ("yellow");
		CheckLists ();
	}

	public void CheckLists(){
		if (playerInput.Count <= compInput.Count){
			if (playerInput [playerInputCount-1].Equals (compInput [playerInputCount-1])) {
				pisteetInt++;
				Debug.Log("points: " + pisteetInt);
				pisteet.text = "Points: " + pisteetInt;
			} 
			else 
			{
				pun.interactable = false;
				kelt.interactable = false;
				sin.interactable = false;
				Application.LoadLevel ("gameOver");
			}
		}
		else
		{
			pun.interactable = false;
			kelt.interactable = false;
			sin.interactable = false;
			Application.LoadLevel ("gameOver");
		}
	}

	public float lastChange        = 0f;
	public float interval          = 2.0f;   // Sec
	public float minInterval       = 0.1f;   // Sec
	public float speedOfTimeChange = 0.005f; // Speed of change 1 second per 1 second. 0.005f = 1ms/1s

	void Update () {
		// Oikeastaan ajoitettu kutsu tuolle vaihdolle olisi fiksumpi. Voi tulla pientä epätarkkuutta näin.
		if (Time.time - lastChange > interval) {
			//Debug.Log ("Time from last change was " + (Time.time - lastChange));
			lastChange = Time.time;
			doChange();
		}
		alterChangeSpeed ();
	}

	void alterChangeSpeed()  {
		// Decrease interval
		interval -= speedOfTimeChange*Time.deltaTime;

		if (interval < minInterval)
			interval = minInterval;

	}

	void doChange() {
		random = Random.Range (1, 4);
		while (random == lastRandom) {
			random = Random.Range (1, 4);
		}
		if (random == 1) {
			kelt.image.color = Color.yellow;
			sin.image.color = Color.blue;
			compInput.Add ("red");
			pun.image.color = Color.black;
		} else if (random == 2) {
			pun.image.color = Color.red;
			sin.image.color = Color.blue;
			compInput.Add ("yellow");
			kelt.image.color = Color.black;
		} else {
			pun.image.color = Color.red;
			kelt.image.color = Color.yellow;
			compInput.Add ("blue");
			sin.image.color = Color.black;
		}
		lastRandom = random;
	}
}
