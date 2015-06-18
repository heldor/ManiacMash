using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {
	public string nimi;
	// Use this for initialization
	public void lataa () {
		Application.LoadLevel(nimi);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
