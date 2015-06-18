using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class punapainallus : MonoBehaviour {
	public Text pisteet;
	// Use this for initialization
	void Start () {
		pisteet.text = "Points: " + GamePlay.pisteetInt;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Painettu(){


	}
}
