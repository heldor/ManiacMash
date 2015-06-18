using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class nappi : MonoBehaviour {
	public Button pun;
	public Button sin;
	public Button kelt;
	private int puna = 1;
	private int kelta = 2;
	private int sini = 3;
	private int random;

	// Use this for initialization
	void Start () {
		pun.interactable = false;
		kelt.interactable = false;
		sin.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		for(int i = 0; i<50; i++){
			StartCoroutine(Hidastus());
			random = Random.Range (1, 4);
			Debug.Log ("rand: " + random);
			if(random == 1){
				sin.interactable = false;
				kelt.interactable = false;
				pun.interactable = true;
			} else if(random == 2){
				pun.interactable = false;
				sin.interactable = false;
				kelt.interactable = true;
			} else {
				kelt.interactable = false;
				pun.interactable = false;
				sin.interactable = true;
			}
			
		}
	}

	IEnumerator Hidastus() {
		print (Time.time);
		yield return new WaitForSeconds (900000);
	}
}
